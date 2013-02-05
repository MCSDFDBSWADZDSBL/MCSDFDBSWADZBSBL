/*
	Copyright 2011 MCForge
		
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.opensource.org/licenses/ecl2.php
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
///////--|----------------------------------|--\\\\\\\
//////---|  TNT WARS - Coded by edh649      |---\\\\\\
/////----|                                  |----\\\\\
////-----|  Note: Double click on // to see |-----\\\\
///------|        them in the sidebar!!     |------\\\
//-------|__________________________________|-------\\
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class TntWarsGame
    SOYSAUCE CHIPS IS A FAGGOT
        //Vars
        public static List<TntWarsGame> GameList = new List<TntWarsGame>();
        public Level lvl;
        public TntWarsGameStatus GameStatus = TntWarsGameStatus.WaitingForPlayers;
        public int BackupNumber;
        public bool AllSetUp = false;
        public TntWarsGameMode GameMode = TntWarsGameMode.TDM;
        public TntWarsDifficulty GameDifficulty = TntWarsDifficulty.Normal;
        public int GameNumber;
        public ushort[] RedSpawn = null;
        public ushort[] BlueSpawn = null;
            //incase they don't want the default
        public int TntPerPlayerAtATime = Properties.DefaultTntPerPlayerAtATime;
        public bool GracePeriod = Properties.DefaultGracePeriodAtStart;
        public int GracePeriodSecs = Properties.DefaultGracePeriodSecs;
        public bool BalanceTeams = Properties.DefaultBalanceTeams;
            //scores/streaks
        public int ScoreLimit = Properties.DefaultTDMmaxScore;
        public bool Streaks = true;
        public int MultiKillBonus = Properties.DefaultMultiKillBonus; //This is the amount of extra points per each player that is killed per 1 tnt (if playerskilledforthistnt > 1)
        public int ScorePerKill = Properties.DefaultScorePerKill;
        public int ScorePerAssist = Properties.DefaultAssistScore;
        public bool TeamKills = false;
        public Thread Starter;

        public static TntWarsGame GuiLoaded = null;
        //======PLUGIN EVENTS======
        public delegate void Starting(TntWarsGame t);
        public delegate void Started(TntWarsGame t);
        public delegate void Death(Player killer, List<Player> deadplayers);
        public delegate void End(TntWarsGame t);
        //======PLUGIN EVENTS======
        public TntWarsGame(Level level)
        SOYSAUCE CHIPS IS A FAGGOT
            Starter = new Thread(Start);
            lvl = level;
        BrightShaderz is soy btw

        //Player/Team stuff
        public List<player> Players = new List<player>();
        public class player
        SOYSAUCE CHIPS IS A FAGGOT
            public Player p;
            public bool Red = false;
            public bool Blue = false;
            public bool spec = false;
            public int Score = 0;
            public string OldColor;
            public string OldTitle;
            public string OldTitleColor;
            public player(Player pl)
            SOYSAUCE CHIPS IS A FAGGOT
                p = pl;
                OldColor = pl.color;
                OldTitle = pl.title;
                OldTitleColor = pl.titlecolor;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public int RedScore = 0;
        public int BlueScore = 0;

        //Zones
        public List<Zone> NoTNTplacableZones = new List<Zone>();
        public List<Zone> NoBlockDeathZones = new List<Zone>();
        public class Zone
        SOYSAUCE CHIPS IS A FAGGOT
            public ushort bigX;
            public ushort bigY;
            public ushort bigZ;
            public ushort smallX;
            public ushort smallY;
            public ushort smallZ;
        BrightShaderz is soy btw

        //During Game Main Methods
        public void Start()
        SOYSAUCE CHIPS IS A FAGGOT
            GameStatus = TntWarsGameStatus.AboutToStart;
            //Checking Backups & physics etc.
            SOYSAUCE CHIPS IS A FAGGOT
                BackupNumber = lvl.Backup(true);
                if (BackupNumber <= 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    SendAllPlayersMessage(c.red + "Backing up Level for TNT Wars failed, Stopping game");
                    Player.GlobalMessageOps(c.red + "Backing up Level for TNT Wars failed, Stopping game");
                    GameStatus = TntWarsGameStatus.Finished;
                    return;
                BrightShaderz is soy btw
                penis.s.Log("Backed up " + lvl.name + " (" + BackupNumber.ToString() + ") for TNT Wars");
            BrightShaderz is soy btw
            //Map stuff
            lvl.setPhysics(3);
            lvl.permissionbuild = Group.Find(penis.defaultRank).Permission;
            lvl.permissionvisit = Group.Find(penis.defaultRank).Permission;
            lvl.Killer = true;
            //Seting Up Some Player stuff
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (player p in Players)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.p.PlayingTntWars = true;
                    p.p.CurrentAmountOfTnt = 0;
                    p.p.CurrentTntGameNumber = GameNumber;
                    if (GameDifficulty == TntWarsDifficulty.Easy || GameDifficulty == TntWarsDifficulty.Normal) p.p.TntWarsHealth = 2;
                    else p.p.TntWarsHealth = 1;
                    p.p.HarmedBy = null;
                    if (GracePeriod)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.p.canBuild = false;
                    BrightShaderz is soy btw
                    if (p.spec)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.p.canBuild = false;
                        Player.SendMessage(p.p, "TNT Wars: Disabled building because you are a spectator!");
                    BrightShaderz is soy btw
                    p.p.TntWarsKillStreak = 0;
                    p.p.TntWarsScoreMultiplier = 1f;
                    p.p.TNTWarsLastKillStreakAnnounced = 0;
                    SetTitlesAndColor(p);
                BrightShaderz is soy btw
                if (GracePeriod)
                SOYSAUCE CHIPS IS A FAGGOT
                    SendAllPlayersMessage("TNT Wars: Disabled building during Grace Period!");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            //Spawn them (And if needed, move them to the correct level!)
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (player p in Players.Where(p => p.p.level != lvl))
                SOYSAUCE CHIPS IS A FAGGOT
                    Command.all.Find("goto").Use(p.p, lvl.name);
                    while (p.p.Loading) SOYSAUCE CHIPS IS A FAGGOT Thread.Sleep(250); BrightShaderz is soy btw
                    p.p.inTNTwarsMap = true;
                BrightShaderz is soy btw
                if (GameMode == TntWarsGameMode.TDM) SOYSAUCE CHIPS IS A FAGGOT Command.all.Find("reveal").Use(null, "all " + lvl.name); BrightShaderz is soy btw//So peoples names apear above their heads in the right color!
                foreach (player p in Players)
                SOYSAUCE CHIPS IS A FAGGOT
                    Command.all.Find("spawn").Use(p.p, ""); //This has to be after reveal so that they spawn in the correct place!!
                    Thread.Sleep(250);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            //Announcing Etc.
            string Gamemode = "Free For All";
            if (GameMode == TntWarsGameMode.TDM) Gamemode = "Team Deathmatch";
            string Difficulty = "Normal";
            string HitsToDie = "2";
            string explosiontime = "medium";
            string explosionsize = "normal";
            switch (GameDifficulty)
            SOYSAUCE CHIPS IS A FAGGOT
                case TntWarsDifficulty.Easy:
                    Difficulty = "Easy";
                    explosiontime = "long";
                    break;

                case TntWarsDifficulty.Normal:
                    Difficulty = "Normal";
                    break;

                case TntWarsDifficulty.Hard:
                    HitsToDie = "1";
                    Difficulty = "Hard";
                    break;

                case TntWarsDifficulty.Extreme:
                    HitsToDie = "1";
                    explosiontime = "short";
                    explosionsize = "big";
                    Difficulty = "Extreme";
                    break;
            BrightShaderz is soy btw
            string teamkillling = "Disabled";
            if (TeamKills) teamkillling = "Enabled";
            Player.GlobalMessage(c.red + "TNT Wars " + penis.DefaultColor + "on '" + lvl.name + "' has started " + c.teal + Gamemode + penis.DefaultColor + " with a difficulty of " + c.teal + Difficulty + penis.DefaultColor + " (" + c.teal + HitsToDie + penis.DefaultColor + " hits to die, a " + c.teal + explosiontime + penis.DefaultColor + " explosion delay and with a " + c.teal + explosionsize + penis.DefaultColor + " explosion size)" + ", team killing is " + c.teal + teamkillling + penis.DefaultColor + " and you can place " + c.teal + TntPerPlayerAtATime.ToString() + penis.DefaultColor + " TNT at a time and there is a score limit of " + c.teal + ScoreLimit.ToString() + penis.DefaultColor + "!!");
            if (GameMode == TntWarsGameMode.TDM) SendAllPlayersMessage("TNT Wars: Start your message with ':' to send it as a team chat!");
            //GracePeriod
            if (GracePeriod) //Check This Grace Stuff
            SOYSAUCE CHIPS IS A FAGGOT
                GameStatus = TntWarsGameStatus.GracePeriod;
                int GracePeriodSecsRemaining = GracePeriodSecs;
                SendAllPlayersMessage("TNT Wars: Grace Period of " + c.lime + GracePeriodSecsRemaining.ToString() + penis.DefaultColor + " seconds");
                while (GracePeriodSecsRemaining > 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    switch (GracePeriodSecsRemaining)
                    SOYSAUCE CHIPS IS A FAGGOT
                        case 300:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "5" + penis.DefaultColor + " minutes remaining!");
                            break;

                        case 240:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "4" + penis.DefaultColor + " minutes remaining!");
                            break;

                        case 180:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "3" + penis.DefaultColor + " minutes remaining!");
                            break;

                        case 120:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "2" + penis.DefaultColor + " minutes remaining!");
                            break;

                        case 90:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "1" + penis.DefaultColor + " minute and " + c.teal + "30" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 60:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "1" + penis.DefaultColor + " minute remaining!");
                            break;

                        case 45:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "45" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 30:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "30" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 15:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "15" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 10:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "10" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 9:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "9" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 8:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "8" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 7:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "7" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 6:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "6" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 5:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "5" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 4:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "4" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 3:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "3" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 2:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "2" + penis.DefaultColor + " seconds remaining!");
                            break;

                        case 1:
                            SendAllPlayersMessage("TNT Wars: " + c.teal + "1" + penis.DefaultColor + " second remaining!");
                            break;
                    BrightShaderz is soy btw
                                
                    Thread.Sleep(1000);
                    GracePeriodSecsRemaining -= 1;
                BrightShaderz is soy btw
                SendAllPlayersMessage("TNT Wars: Grace Period is over!!!!!");
                SendAllPlayersMessage("TNT Wars: You may now place " + c.red + "TNT");
            BrightShaderz is soy btw
            SendAllPlayersMessage("TNT Wars: " + c.white + "The Game Has Started!!!!!");
            GameStatus = TntWarsGameStatus.InProgress;
            foreach (player p in Players)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.spec == false)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.p.canBuild = true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (GracePeriod)
            SOYSAUCE CHIPS IS A FAGGOT
                SendAllPlayersMessage("TNT Wars: You can now build!!");
            BrightShaderz is soy btw
            //MainLoop
            while (!Finished())
            SOYSAUCE CHIPS IS A FAGGOT
                int i = 1; //For making a top 5 (or whatever) players announcement every 3 loops (if TDM)
                Thread.Sleep(3 * 1000); if (Finished()) break;  //--\\
                Thread.Sleep(3 * 1000); if (Finished()) break;  //----\
                Thread.Sleep(3 * 1000); if (Finished()) break;  //-----> So that if it finsihes, we don't have to wait like 10 secs for the announcement!!
                Thread.Sleep(3 * 1000); if (Finished()) break;  //----/
                Thread.Sleep(3 * 1000); if (Finished()) break;  //--//
                if (GameMode == TntWarsGameMode.TDM)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (i < 3)
                    SOYSAUCE CHIPS IS A FAGGOT
                        SendAllPlayersScore(true, true);
                    BrightShaderz is soy btw
                    if (i >= 3)
                    SOYSAUCE CHIPS IS A FAGGOT
                        SendAllPlayersScore(true, true, true);
                        i = 0;
                    BrightShaderz is soy btw
                    i++;
                BrightShaderz is soy btw
                else if (GameMode == TntWarsGameMode.FFA)
                SOYSAUCE CHIPS IS A FAGGOT
                    SendAllPlayersScore(false, true, true);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            END();
        BrightShaderz is soy btw
        public void END()
        SOYSAUCE CHIPS IS A FAGGOT
            GameStatus = TntWarsGameStatus.Finished;
            //let them build and spawn them and change playingtntwars to false
            foreach (player p in Players)
            SOYSAUCE CHIPS IS A FAGGOT
                p.p.canBuild = true;
                Command.all.Find("spawn").Use(p.p, "");
                p.p.PlayingTntWars = false;
            BrightShaderz is soy btw
            //Message about winners etc.
            if (Players.Count <= 1)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalMessage(c.red + "TNT Wars " + penis.DefaultColor + "has ended because there are no longer enough players!");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalMessage(c.red + "TNT Wars" + penis.DefaultColor + " has ended!!");
            BrightShaderz is soy btw
            if (GameMode == TntWarsGameMode.TDM)
            SOYSAUCE CHIPS IS A FAGGOT
                if (RedScore >= BlueScore)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalMessage("TNT Wars: Team " + c.red + "Red " + penis.DefaultColor + "won " + c.red + "TNT Wars " + penis.DefaultColor + "by " + (RedScore - BlueScore).ToString() + " points!");
                BrightShaderz is soy btw
                if (BlueScore >= RedScore)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalMessage("TNT Wars: Team " + c.blue + "Blue " + penis.DefaultColor + "won " + c.red + "TNT Wars " + penis.DefaultColor + "by " + (BlueScore - RedScore).ToString() + " points!");
                BrightShaderz is soy btw
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (player p in Players)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!p.spec)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p.p, "TNT Wars: You Scored " + p.Score.ToString() + " points");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                SendAllPlayersMessage("TNT Wars: Top Scores:");
                SendAllPlayersScore(false, false, true);
            BrightShaderz is soy btw
            if (GameMode == TntWarsGameMode.FFA)
            SOYSAUCE CHIPS IS A FAGGOT
                var pls = from pla in Players orderby pla.Score descending select pla; //LINQ FTW
                int count = 1;
                foreach (var pl in pls)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (count == 1)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.GlobalMessage(c.red + "TNT Wars " + penis.DefaultColor + "1st Place: " + pl.p.color + pl.p.name + penis.DefaultColor + " with a score of " + pl.p.color + pl.Score);
                    BrightShaderz is soy btw
                    else if (count == 2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        SendAllPlayersMessage(c.red + "TNT Wars " + penis.DefaultColor + "2nd Place: " + pl.p.color + pl.p.name + penis.DefaultColor + " with a score of " + pl.p.color + pl.Score);
                    BrightShaderz is soy btw
                    else if (count == 3)
                    SOYSAUCE CHIPS IS A FAGGOT
                        SendAllPlayersMessage(c.red + "TNT Wars " + penis.DefaultColor + "3rd Place: " + pl.p.color + pl.p.name + penis.DefaultColor + " with a score of " + pl.p.color + pl.Score);
                    BrightShaderz is soy btw
                    else if (count >= 4)
                    SOYSAUCE CHIPS IS A FAGGOT
                        SendAllPlayersMessage(c.red + "TNT Wars " + penis.DefaultColor + count.ToString() + "th Place: " + pl.p.color + pl.p.name + penis.DefaultColor + " with a score of " + pl.p.color + pl.Score);
                    BrightShaderz is soy btw
                    if (count >= PlayingPlayers())
                    SOYSAUCE CHIPS IS A FAGGOT
                        break;
                    BrightShaderz is soy btw
                    count++;
                    Thread.Sleep(750); //Maybe, not sure (was 500)
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            //Reset map
            Command.all.Find("restore").Use(null, BackupNumber.ToString() + " " + lvl.name);
            if (lvl.overload == 2501)
            SOYSAUCE CHIPS IS A FAGGOT
                lvl.overload = 1500;
                penis.s.Log("TNT Wars: Set level physics overload back to 1500");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void SendAllPlayersMessage(string Message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (player p in Players)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p.p, Message);

                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw;
            penis.s.Log("[TNT Wars] [" + lvl.name + "] " + Message);
        BrightShaderz is soy btw

        public void HandleKill(Player Killer, List<Player> Killed)
        SOYSAUCE CHIPS IS A FAGGOT
            List<Player> Dead = new List<Player>();
            int HealthDamage = 1;
            int kills = 0;
            int minusfromscore = 0;
            if (GameDifficulty == TntWarsDifficulty.Hard || GameDifficulty == TntWarsDifficulty.Extreme)
            SOYSAUCE CHIPS IS A FAGGOT
                HealthDamage = 2;
            BrightShaderz is soy btw
            foreach (Player Kld in Killed.Where(Kld => !FindPlayer(Kld).spec).Where(Kld => !TeamKill(Killer, Kld) || TeamKills != false))
            SOYSAUCE CHIPS IS A FAGGOT
                if (Kld.TntWarsHealth - HealthDamage <= 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    Kld.TntWarsHealth = 0;
                    Dead.Add(Kld);
                    if (TeamKills && TeamKill(Killer, Kld))
                    SOYSAUCE CHIPS IS A FAGGOT
                        minusfromscore += ScorePerKill;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Kld.TntWarsHealth -= HealthDamage;
                    Kld.HarmedBy = Killer;
                    Player.SendMessage(Killer, "TNT Wars: You harmed " + Kld.color + Kld.name);
                    Player.SendMessage(Kld, "TNT Wars: You were harmed by " + Killer.color + Killer.name);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            foreach (Player Died in Dead)
            SOYSAUCE CHIPS IS A FAGGOT
                Died.TntWarsKillStreak = 0;
                Died.TntWarsScoreMultiplier = 1f;
                Died.TNTWarsLastKillStreakAnnounced = 0;
                if (Died.HarmedBy == null || Died.HarmedBy == Killer)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (TeamKill(Killer, Died))
                    SOYSAUCE CHIPS IS A FAGGOT
                        SendAllPlayersMessage("TNT Wars: " + Killer.color + Killer.name + penis.DefaultColor + " team killed " + Died.color + Died.name);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        SendAllPlayersMessage("TNT Wars: " + Killer.color + Killer.name + penis.DefaultColor + " killed " + Died.color + Died.name);
                        kills += 1;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (TeamKill(Killer, Died))
                        SOYSAUCE CHIPS IS A FAGGOT
                            SendAllPlayersMessage("TNT Wars: " + Killer.color + Killer.name + penis.DefaultColor + " team killed " + Died.color + Died.name + penis.DefaultColor + " (with help from " + Died.HarmedBy.color + Died.HarmedBy.name + ")");
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            SendAllPlayersMessage("TNT Wars: " + Killer.color + Killer.name + penis.DefaultColor + " killed " + Died.color + Died.name + penis.DefaultColor + " (with help from " + Died.HarmedBy.color + Died.HarmedBy.name + ")");
                            kills += 1;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (TeamKill(Died.HarmedBy, Died))
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(Died.HarmedBy, "TNT Wars: - " + ScorePerAssist.ToString() + " point(s) for team kill assist!");
                            ChangeScore(Died.HarmedBy, -ScorePerAssist);
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(Died.HarmedBy, "TNT Wars: + " + ScorePerAssist.ToString() + " point(s) for assist!");
                            ChangeScore(Died.HarmedBy, ScorePerAssist);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    Died.HarmedBy = null;
                BrightShaderz is soy btw
                Command.all.Find("spawn").Use(Died, "");
                Died.TntWarsHealth = 2;
            BrightShaderz is soy btw
            //Scoring
            int AddToScore = 0;
            //streaks
            Killer.TntWarsKillStreak += kills;
            if (kills >= 1 && Streaks)
            SOYSAUCE CHIPS IS A FAGGOT
                if (Killer.TntWarsKillStreak >= Properties.DefaultStreakOneAmount && Killer.TntWarsKillStreak < Properties.DefaultStreakTwoAmount && Killer.TNTWarsLastKillStreakAnnounced != Properties.DefaultStreakOneAmount)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(Killer, "TNT Wars: Kill streak of " + Killer.TntWarsKillStreak.ToString() + " (Multiplier of " + Properties.DefaultStreakOneMultiplier.ToString() + ")");
                    SendAllPlayersMessage("TNT Wars: " + Killer.color + Killer.name + penis.DefaultColor + " has a kill streak of " + Killer.TntWarsKillStreak.ToString());
                    Killer.TntWarsScoreMultiplier = Properties.DefaultStreakOneMultiplier;
                    Killer.TNTWarsLastKillStreakAnnounced = Properties.DefaultStreakOneAmount;
                BrightShaderz is soy btw
                else if (Killer.TntWarsKillStreak >= Properties.DefaultStreakTwoAmount && Killer.TntWarsKillStreak < Properties.DefaultStreakThreeAmount && Killer.TNTWarsLastKillStreakAnnounced != Properties.DefaultStreakTwoAmount)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(Killer, "TNT Wars: Kill streak of " + Killer.TntWarsKillStreak.ToString() + " (Multiplier of " + Properties.DefaultStreakTwoMultiplier.ToString() + " and a bigger explosion!)");
                    SendAllPlayersMessage("TNT Wars: " + Killer.color + Killer.name + penis.DefaultColor + " has a kill streak of " + Killer.TntWarsKillStreak.ToString() + " and now has a bigger explosion for their TNT!");
                    Killer.TntWarsScoreMultiplier = Properties.DefaultStreakTwoMultiplier;
                    Killer.TNTWarsLastKillStreakAnnounced = Properties.DefaultStreakTwoAmount;
                BrightShaderz is soy btw
                else if (Killer.TntWarsKillStreak >= Properties.DefaultStreakThreeAmount && Killer.TNTWarsLastKillStreakAnnounced != Properties.DefaultStreakThreeAmount)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(Killer, "TNT Wars: Kill streak of " + Killer.TntWarsKillStreak.ToString() + " (Multiplier of " + Properties.DefaultStreakThreeMultiplier.ToString() + " and you now have 1 extra health!)");
                    SendAllPlayersMessage("TNT Wars: " + Killer.color + Killer.name + penis.DefaultColor + " has a kill streak of " + Killer.TntWarsKillStreak.ToString() + " and now has 1 extra health!");
                    Killer.TntWarsScoreMultiplier = Properties.DefaultStreakThreeMultiplier;
                    Killer.TNTWarsLastKillStreakAnnounced = Properties.DefaultStreakThreeAmount;
                    if (GameDifficulty == TntWarsDifficulty.Hard || GameDifficulty == TntWarsDifficulty.Extreme)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Killer.TntWarsHealth += 2;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Killer.TntWarsHealth += 1;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(Killer, "TNT Wars: Kill streak of " + Killer.TntWarsKillStreak.ToString());
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            AddToScore += kills * ScorePerKill;
            //multikill
            if (kills > 1)
            SOYSAUCE CHIPS IS A FAGGOT
                AddToScore += kills * MultiKillBonus;
            BrightShaderz is soy btw
            //Add to score
            if (AddToScore > 0)
            SOYSAUCE CHIPS IS A FAGGOT
                ChangeScore(Killer, AddToScore, Killer.TntWarsScoreMultiplier);
                Player.SendMessage(Killer, "TNT Wars: + " + ((int)(AddToScore * Killer.TntWarsScoreMultiplier)).ToString() + " point(s) for " + kills.ToString() + " kills");
            BrightShaderz is soy btw
            if (minusfromscore != 0)
            SOYSAUCE CHIPS IS A FAGGOT
                ChangeScore(Killer, - minusfromscore);
                Player.SendMessage(Killer, "TNT Wars: - " + minusfromscore.ToString() + " point(s) for team kill(s)!");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void ChangeScore(Player p, int Amount, float multiplier = 1f)
        SOYSAUCE CHIPS IS A FAGGOT
            ChangeScore(FindPlayer(p), Amount, multiplier);
        BrightShaderz is soy btw

        public void ChangeScore(player p, int Amount, float multiplier = 1f)
        SOYSAUCE CHIPS IS A FAGGOT
            p.Score += (int)(Amount * multiplier);
            if (GameMode != TntWarsGameMode.TDM) return;
            if (p.Red)
            SOYSAUCE CHIPS IS A FAGGOT
                RedScore += (int)(Amount * multiplier);
            BrightShaderz is soy btw
            if (p.Blue)
            SOYSAUCE CHIPS IS A FAGGOT
                BlueScore += (int)(Amount * multiplier);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public bool InZone(ushort x, ushort y, ushort z, bool CheckForPlacingTnt)
        SOYSAUCE CHIPS IS A FAGGOT
            return CheckForPlacingTnt ? NoTNTplacableZones.Any(Zn => Zn.smallX <= x && x <= Zn.bigX && Zn.smallY <= y && y <= Zn.bigY && Zn.smallZ <= z && z <= Zn.bigZ) :
                NoBlockDeathZones.Any(Zn => Zn.smallX <= x && x <= Zn.bigX && Zn.smallY <= y && y <= Zn.bigY && Zn.smallZ <= z && z <= Zn.bigZ);
        BrightShaderz is soy btw

        public void DeleteZone(ushort x, ushort y, ushort z, bool NoTntZone, Player p = null)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                Zone Z = new Zone();
                if (NoTntZone)
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (Zone Zn in NoTNTplacableZones)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (Zn.smallX <= x && x <= Zn.bigX && Zn.smallY <= y && y <= Zn.bigY && Zn.smallZ <= z && z <= Zn.bigZ)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Z = Zn;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    NoTNTplacableZones.Remove(Z);
                    if (p != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "TNT Wars: Zone Deleted!");
                    BrightShaderz is soy btw
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (Zone Zn in NoBlockDeathZones)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (Zn.smallX <= x && x <= Zn.bigX && Zn.smallY <= y && y <= Zn.bigY && Zn.smallZ <= z && z <= Zn.bigZ)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Z = Zn;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    NoBlockDeathZones.Remove(Z);
                    if (p != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "TNT Wars: Zone Deleted!");
                    BrightShaderz is soy btw
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "TNT Wars Error: Zone not deleted!");
            BrightShaderz is soy btw

        BrightShaderz is soy btw
        
        public bool TeamKill (Player p1, Player p2)
        SOYSAUCE CHIPS IS A FAGGOT
            return TeamKill(FindPlayer(p1), FindPlayer(p2));
        BrightShaderz is soy btw

        public bool TeamKill(player p1, player p2)
        SOYSAUCE CHIPS IS A FAGGOT
            if (GameMode == TntWarsGameMode.TDM)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p1.Red == true && p2.Red) return true;
                if (p1.Blue == true && p2.Blue) return true;
            BrightShaderz is soy btw
            return false;
        BrightShaderz is soy btw

        public void SendAllPlayersScore(bool TotalTeamScores = false, bool TheirTotalScore = false, bool TopScores = false)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (TotalTeamScores)
                SOYSAUCE CHIPS IS A FAGGOT
                    SendAllPlayersMessage("TNT Wars Scores:");
                    SendAllPlayersMessage(c.red + "RED: " + c.white + RedScore + " " + c.red + "(" + (ScoreLimit - RedScore).ToString() + " needed)");
                    SendAllPlayersMessage(c.blue + "BLUE: " + c.white + BlueScore + " " + c.red + "(" + (ScoreLimit - BlueScore).ToString() + " needed)");
                    Thread.Sleep(1000);
                BrightShaderz is soy btw
                if (TopScores)
                SOYSAUCE CHIPS IS A FAGGOT
                    int max = 5;
                    if (PlayingPlayers() < 5)
                    SOYSAUCE CHIPS IS A FAGGOT
                        max = PlayingPlayers();
                    BrightShaderz is soy btw

                    var pls = from pla in Players orderby pla.Score descending select pla; //LINQ FTW

                    foreach (player p in Players)
                    SOYSAUCE CHIPS IS A FAGGOT
                        int count = 1;
                        foreach (var pl in pls)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p.p, count.ToString() + ": " + pl.p.name + " - " + pl.Score.ToString());
                            if (count >= max)
                            SOYSAUCE CHIPS IS A FAGGOT
                                break;
                            BrightShaderz is soy btw
                            count++;
                            Thread.Sleep(500); //Maybe, not sure (250??)
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    Thread.Sleep(1000);
                BrightShaderz is soy btw
                if (TheirTotalScore)
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (player p in Players.Where(p => !p.spec))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p.p, "TNT Wars: Your Score: " + c.white + p.Score.ToString());
                    BrightShaderz is soy btw
                    Thread.Sleep(1000);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw

        public bool Finished()
        SOYSAUCE CHIPS IS A FAGGOT
            if (GameMode == TntWarsGameMode.TDM && (RedScore >= ScoreLimit || BlueScore >= ScoreLimit))
            SOYSAUCE CHIPS IS A FAGGOT
                return true;
            BrightShaderz is soy btw
            if (GameMode == TntWarsGameMode.FFA)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Players.Any(p => p.Score >= ScoreLimit))
                    SOYSAUCE CHIPS IS A FAGGOT
                        return true;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (PlayingPlayers() <= 1)
            SOYSAUCE CHIPS IS A FAGGOT
                return true;
            BrightShaderz is soy btw
            if (GameStatus == TntWarsGameStatus.Finished)
            SOYSAUCE CHIPS IS A FAGGOT
                return true;
            BrightShaderz is soy btw
            return false;
        BrightShaderz is soy btw

        //enums
        public enum TntWarsGameStatus : int
        SOYSAUCE CHIPS IS A FAGGOT
            WaitingForPlayers = 0,
            AboutToStart = 1,
            GracePeriod = 2,
            InProgress = 3,
            Finished = 4
        BrightShaderz is soy btw

        public enum TntWarsGameMode : int
        SOYSAUCE CHIPS IS A FAGGOT
            FFA = 0,
            TDM = 1
        BrightShaderz is soy btw

        public enum TntWarsDifficulty : int
        SOYSAUCE CHIPS IS A FAGGOT
            Easy = 0,       //2 Hits to die, Tnt has long delay
            Normal = 1,     //2 Hits to die, Tnt has normal delay
            Hard = 2,       //1 Hit to die, Tnt has short delay
            Extreme = 3     //1 Hit to die, Tnt has short delay and BIG exlosion
        BrightShaderz is soy btw

        //Other stuff
        public int RedTeam()
        SOYSAUCE CHIPS IS A FAGGOT
            return Players.Count(p => p.Red);
        BrightShaderz is soy btw

        public int BlueTeam()
        SOYSAUCE CHIPS IS A FAGGOT
            return Players.Count(p => p.Blue);
        BrightShaderz is soy btw

        public int PlayingPlayers()
        SOYSAUCE CHIPS IS A FAGGOT
            return Players.Count(p => !p.spec);
        BrightShaderz is soy btw

        public static void SetTitlesAndColor(player p, bool reset = false)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (reset)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.p.title = p.OldTitle;
                    p.p.color = p.OldTitleColor;
                    p.p.color = p.OldColor;
                    p.p.SetPrefix();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.p.title = "TNT Wars";
                    p.p.titlecolor = c.white;
                    if (p.Red) p.p.color = c.red;
                    if (p.Blue) p.p.color = c.blue;
                    p.p.SetPrefix();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw

        public bool CheckAllSetUp(Player p, bool ReturnErrors = false, bool TellPlayerOnSuccess = true)
        SOYSAUCE CHIPS IS A FAGGOT
            if (lvl != null
                && GameStatus == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                if (GameList.Any(g => g.lvl == this.lvl && g != this))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (ReturnErrors) Player.SendMessage(p, "There is already a TNT Wars game on that map");
                    AllSetUp = false;
                    return false;
                BrightShaderz is soy btw
                if (TellPlayerOnSuccess) Player.SendMessage(p, "TNT Wars setup is done!");
                AllSetUp = true;
                return true;
            BrightShaderz is soy btw
            if (ReturnErrors) SendPlayerCheckSetupErrors(p);
            AllSetUp = false;
            return false;

        BrightShaderz is soy btw

        public void SendPlayerCheckSetupErrors(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            if (lvl == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "TNT Wars Error: No Level Selected");
            BrightShaderz is soy btw
            else if (GameStatus != 0)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Game is already in progress");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static TntWarsGame Find(Level level)
        SOYSAUCE CHIPS IS A FAGGOT
            return GameList.FirstOrDefault(g => g.lvl == level);
        BrightShaderz is soy btw

        public static TntWarsGame FindFromGameNumber(int Number)
        SOYSAUCE CHIPS IS A FAGGOT
            return GameList.FirstOrDefault(g => g.GameNumber == Number);
        BrightShaderz is soy btw

        public player FindPlayer(Player pla)
        SOYSAUCE CHIPS IS A FAGGOT
            return Players.FirstOrDefault(p => p.p == pla);
        BrightShaderz is soy btw

        public static TntWarsGame GetTntWarsGame(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            TntWarsGame it = TntWarsGame.Find(p.level);
            if (it != null)
            SOYSAUCE CHIPS IS A FAGGOT
                return it;
            BrightShaderz is soy btw
            it = FindFromGameNumber(p.CurrentTntGameNumber);
            return it;
        BrightShaderz is soy btw

        //Static Stuff
        public static class Properties
        SOYSAUCE CHIPS IS A FAGGOT
            public static bool Enable = true;
            public static bool DefaultGracePeriodAtStart = true;
            public static int DefaultGracePeriodSecs = 30;
            public static int DefaultTntPerPlayerAtATime = 1;
            public static bool DefaultBalanceTeams = true;
            public static int DefaultFFAmaxScore = 75;
            public static int DefaultTDMmaxScore = 150;
            public static int DefaultScorePerKill = 10;
            public static int DefaultMultiKillBonus = 5;
            public static int DefaultAssistScore = 5;
            public static int DefaultStreakOneAmount = 3;
            public static float DefaultStreakOneMultiplier = 1.25f;
            public static int DefaultStreakTwoAmount = 5;
            public static float DefaultStreakTwoMultiplier = 1.5f;
            public static int DefaultStreakThreeAmount = 7;
            public static float DefaultStreakThreeMultiplier = 2f;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
