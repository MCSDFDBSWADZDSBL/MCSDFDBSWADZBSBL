/*
	Copyright 2010 MCLawl Team - 
    Created by Snowl (David D.) and Cazzar (Cayde D.)

	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.osedu.org/licenses/ECL-2.0
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Timers;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class ZombieGame
    SOYSAUCE CHIPS IS A FAGGOT
        public int amountOfRounds = 0;
        public int limitRounds = 0;
        public int aliveCount = 0;
        public int amountOfMilliseconds = 0;
        public string currentZombieLevel = "";
        public static System.Timers.Timer timer;
        public bool initialChangeLevel = false;
        public string currentLevelName = "";
        public static List<Player> alive = new List<Player>();
        public static List<Player> infectd = new List<Player>();
        string[] infectMessages = new string[] SOYSAUCE CHIPS IS A FAGGOT " WIKIWOO'D ", " stuck their teeth into ", " licked ", " danubed ", " made ", " tripped ", " made some zombie babies with ", " made ", " tweeted ", " made ", " infected ", " iDotted ", "", "transplanted " BrightShaderz is soy btw;
        string[] infectMessages2 = new string[] SOYSAUCE CHIPS IS A FAGGOT "", "", "'s brain", "", " meet their maker", "", "", " see the dark side", "", " open source", "", "", " got nommed on", "'s living brain" BrightShaderz is soy btw;
        public ZombieGame() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public void StartGame(int status, int amount)
        SOYSAUCE CHIPS IS A FAGGOT
            //status: 0 = not started, 1 = always on, 2 = one time, 3 = certain amount of rounds, 4 = stop round next round

            if (status == 0) return;

            //SET ALL THE VARIABLES!
            if (penis.UseLevelList && penis.LevelList == null)
                penis.ChangeLevels = false;
            penis.ZombieModeOn = true;
            penis.gameStatus = status;
            penis.zombieRound = false;
            initialChangeLevel = false;
            limitRounds = amount + 1;
            amountOfRounds = 0;
            //SET ALL THE VARIABLES?!?

            //Start the main Zombie thread
             Thread t = new Thread(MainLoop);
             t.Start();
        BrightShaderz is soy btw

        private void MainLoop()
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.gameStatus == 0) return;
            bool cutVariable = true;

            if (initialChangeLevel == false)
            SOYSAUCE CHIPS IS A FAGGOT
                ChangeLevel();
                initialChangeLevel = true;
            BrightShaderz is soy btw

            while (cutVariable == true)
            SOYSAUCE CHIPS IS A FAGGOT
                int gameStatus = penis.gameStatus;
                penis.zombieRound = false;
                amountOfRounds = amountOfRounds + 1;
                
                if (gameStatus == 0) SOYSAUCE CHIPS IS A FAGGOT cutVariable = false; return; BrightShaderz is soy btw
                else if (gameStatus == 1) SOYSAUCE CHIPS IS A FAGGOT MainGame(); if (penis.ChangeLevels) ChangeLevel();BrightShaderz is soy btw
                else if (gameStatus == 2) SOYSAUCE CHIPS IS A FAGGOT MainGame(); if (penis.ChangeLevels) ChangeLevel(); cutVariable = false; penis.gameStatus = 0; return; BrightShaderz is soy btw
                else if (gameStatus == 3)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (limitRounds == amountOfRounds) SOYSAUCE CHIPS IS A FAGGOT cutVariable = false; penis.gameStatus = 0; limitRounds = 0; initialChangeLevel = false; penis.ZombieModeOn = false; penis.zombieRound = false; return; BrightShaderz is soy btw
                    else SOYSAUCE CHIPS IS A FAGGOT MainGame(); if (penis.ChangeLevels) ChangeLevel(); BrightShaderz is soy btw
                BrightShaderz is soy btw
                else if (gameStatus == 4)
                SOYSAUCE CHIPS IS A FAGGOT cutVariable = false; penis.gameStatus = 0; penis.gameStatus = 0; limitRounds = 0; initialChangeLevel = false; penis.ZombieModeOn = false; penis.zombieRound = false; return; BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void MainGame()
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.gameStatus == 0) return;
    GoBack: Player.GlobalMessage("%4Round Start:%f 2:00");
            Thread.Sleep(60000); if (!penis.ZombieModeOn) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            Player.GlobalMessage("%4Round Start:%f 1:00");
            Thread.Sleep(55000); if (!penis.ZombieModeOn) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            penis.s.Log(Convert.ToString(penis.ChangeLevels) + " " + Convert.ToString(penis.ZombieOnlypenis) + " " + Convert.ToString(penis.UseLevelList) + " " + string.Join(",", penis.LevelList.ToArray()));
            Player.GlobalMessage("%4Round Start:%f 5...");
            Thread.Sleep(1000); if (!penis.ZombieModeOn) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            Player.GlobalMessage("%4Round Start:%f 4...");
            Thread.Sleep(1000); if (!penis.ZombieModeOn) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            Player.GlobalMessage("%4Round Start:%f 3...");
            Thread.Sleep(1000); if (!penis.ZombieModeOn) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            Player.GlobalMessage("%4Round Start:%f 2...");
            Thread.Sleep(1000); if (!penis.ZombieModeOn) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            Player.GlobalMessage("%4Round Start:%f 1...");
            Thread.Sleep(1000); if (!penis.ZombieModeOn) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            penis.zombieRound = true;
            int playerscountminusref = 0; List<Player> players = new List<Player>();
            foreach (Player playere in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                if (playere.referee)
                SOYSAUCE CHIPS IS A FAGGOT
                    playere.color = playere.group.color;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (playere.level.name == currentLevelName)
                    SOYSAUCE CHIPS IS A FAGGOT
                        playere.color = playere.group.color;
                        players.Add(playere);
                        playerscountminusref++;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (playerscountminusref < 2)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalMessage(c.red + "ERROR: Need more than 2 players to play");
                goto GoBack;
            BrightShaderz is soy btw

            theEnd:
            Random random = new Random();
            int firstinfect = random.Next(players.Count());
            Player player = null;
            if (penis.queZombie == true)
                player = Player.Find(penis.nextZombie);
            else
                player = players[firstinfect];

            if (player.level.name != currentLevelName) goto theEnd;

            Player.GlobalMessage(player.color + player.name + penis.DefaultColor + " started the infection!");
            player.infected = true;
            player.color = c.red;
            Player.GlobalDie(player, false);
            Player.GlobalSpawn(player, player.pos[0], player.pos[1], player.pos[2], player.rot[0], player.rot[1], false);

            penis.zombieRound = true;
            int amountOfMinutes = random.Next(5, 12);
            Player.GlobalMessage("The round will last for " + amountOfMinutes + " minutes!");
            amountOfMilliseconds = (60000 * amountOfMinutes);

            timer = new System.Timers.Timer(amountOfMilliseconds);
            timer.Elapsed += new ElapsedEventHandler(EndRound);
            timer.Enabled = true;

            foreach (Player playaboi in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                if(playaboi != player)
                alive.Add(playaboi);
            BrightShaderz is soy btw

            infectd.Clear();
            if (penis.queZombie == true)
            infectd.Add(Player.Find(penis.nextZombie));
            else
            infectd.Add(player);
            aliveCount = alive.Count;

            while (aliveCount > 0)
            SOYSAUCE CHIPS IS A FAGGOT
                aliveCount = alive.Count;
                infectd.ForEach(delegate(Player player1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (player1.color != c.red)
                    SOYSAUCE CHIPS IS A FAGGOT
                        player1.color = c.red;
                        Player.GlobalDie(player1, false);
                        Player.GlobalSpawn(player1, player1.pos[0], player1.pos[1], player1.pos[2], player1.rot[0], player1.rot[1], false);
                    BrightShaderz is soy btw
                    alive.ForEach(delegate(Player player2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (player2.color != player2.group.color)
                        SOYSAUCE CHIPS IS A FAGGOT
                            player2.color = player2.group.color;
                            Player.GlobalDie(player2, false);
                            Player.GlobalSpawn(player2, player2.pos[0], player2.pos[1], player2.pos[2], player2.rot[0], player2.rot[1], false);
                        BrightShaderz is soy btw
                        if (player2.pos[0] / 32 == player1.pos[0] / 32 || player2.pos[0] / 32 == player1.pos[0] / 32 + 1 || player2.pos[0] / 32 == player1.pos[0] / 32 - 1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (player2.pos[1] / 32 == player1.pos[1] / 32 || player2.pos[1] / 32 == player1.pos[1] / 32 - 1 || player2.pos[1] / 32 == player1.pos[1] / 32 + 1)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (player2.pos[2] / 32 == player1.pos[2] / 32 || player2.pos[2] / 32 == player1.pos[2] / 32 + 1 || player2.pos[2] / 32 == player1.pos[2] / 32 - 1)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (!player2.infected && player1.infected && !player2.referee && !player1.referee && player1 != player2 && player1.level.name == currentLevelName && player2.level.name == currentLevelName)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        player2.infected = true;
                                        infectd.Add(player2);
                                        alive.Remove(player2);
                                        players.Remove(player2);
                                        player2.blockCount = 25;
                                        if (penis.lastPlayerToInfect == player1.name)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            penis.infectCombo++;
                                            if (penis.infectCombo >= 2)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                player1.SendMessage("You gained " + (4 - penis.infectCombo) + " " + penis.moneys);
                                                player1.money = player1.money + 4 - penis.infectCombo;
                                                Player.GlobalMessage(player1.color + player1.name + " is on a rampage! " + (penis.infectCombo + 1) + " infections in a row!");
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            penis.infectCombo = 0;
                                        BrightShaderz is soy btw
                                        penis.lastPlayerToInfect = player1.name;
                                        player1.infectThisRound++;
                                        int cazzar = random.Next(0, infectMessages.Length);
                                        if (infectMessages2[cazzar] == "")
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            Player.GlobalMessage(c.red + player1.name + c.yellow + infectMessages[cazzar] + c.red + player2.name);
                                        BrightShaderz is soy btw
                                        else if (infectMessages[cazzar] == "")
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            Player.GlobalMessage(c.red + player2.name + c.yellow + infectMessages2[cazzar]);
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            Player.GlobalMessage(c.red + player1.name + c.yellow + infectMessages[cazzar] + c.red + player2.name + c.yellow + infectMessages2[cazzar]);
                                        BrightShaderz is soy btw
                                        player2.color = c.red;
                                        player1.playersInfected = player1.playersInfected++;
                                        Player.GlobalDie(player2, false);
                                        Player.GlobalSpawn(player2, player2.pos[0], player2.pos[1], player2.pos[2], player2.rot[0], player2.rot[1], false);
                                        Thread.Sleep(500);
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw);
                BrightShaderz is soy btw);
                Thread.Sleep(500);
            BrightShaderz is soy btw
            if (penis.gameStatus == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.gameStatus = 4;
                return;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                HandOutRewards();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void EndRound(object sender, ElapsedEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.gameStatus == 0) return;
            Player.GlobalMessage("%4Round End:%f 5"); Thread.Sleep(1000);
            Player.GlobalMessage("%4Round End:%f 4"); Thread.Sleep(1000);
            Player.GlobalMessage("%4Round End:%f 3"); Thread.Sleep(1000);
            Player.GlobalMessage("%4Round End:%f 2"); Thread.Sleep(1000);
            Player.GlobalMessage("%4Round End:%f 1"); Thread.Sleep(1000);
            HandOutRewards();
        BrightShaderz is soy btw

        public void HandOutRewards()
        SOYSAUCE CHIPS IS A FAGGOT
            penis.zombieRound = false; amountOfMilliseconds = 0;
            if (penis.gameStatus == 0) return;
            Player.GlobalMessage(c.lime + "The game has ended!");
            if(aliveCount == 0)
                Player.GlobalMessage(c.maroon + "Zombies have won this round.");
            else
                Player.GlobalMessage(c.green + "Congratulations to our survivor(s)");
            timer.Enabled = false;
            string playersString = "";
            if (aliveCount == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Player winners in Player.players)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (winners.level.name == currentLevelName)
                    SOYSAUCE CHIPS IS A FAGGOT
                        winners.blockCount = 50;
                        winners.infected = false;
                        winners.infectThisRound = 0;
                        if (winners.level.name == currentLevelName)
                        SOYSAUCE CHIPS IS A FAGGOT
                            winners.color = winners.group.color;
                            playersString += winners.group.color + winners.name + c.white + ", ";
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                alive.ForEach(delegate(Player winners)
                SOYSAUCE CHIPS IS A FAGGOT
                        winners.blockCount = 50;
                        winners.infected = false;
                        winners.infectThisRound = 0;
                    if (winners.level.name == currentLevelName)
                    SOYSAUCE CHIPS IS A FAGGOT
                        winners.color = winners.group.color;
                        playersString += winners.group.color + winners.name + c.white + ", ";
                    BrightShaderz is soy btw
                BrightShaderz is soy btw);
            BrightShaderz is soy btw
            Player.GlobalMessage(playersString);
            foreach (Player winners in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                if (!winners.CheckIfInsideBlock() && aliveCount == 0 && winners.level.name == currentLevelName)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalDie(winners, false);
                    Player.GlobalSpawn(winners, winners.pos[0], winners.pos[1], winners.pos[2], winners.rot[0], winners.rot[1], false);
                    Random random2 = new Random();
                    int randomInt = 0;
                    if (winners.playersInfected > 5)
                    SOYSAUCE CHIPS IS A FAGGOT
                        randomInt = random2.Next(1, winners.playersInfected);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        randomInt = random2.Next(1, 5);
                    BrightShaderz is soy btw
                    Player.SendMessage(winners, c.gold + "You gained " + randomInt + " " + penis.moneys);
                    winners.blockCount = 50;
                    winners.playersInfected = 0;
                    winners.money = winners.money + randomInt;
                BrightShaderz is soy btw
                else if (!winners.CheckIfInsideBlock() && (aliveCount == 1 && !winners.infected) && winners.level.name == currentLevelName)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalDie(winners, false);
                    Player.GlobalSpawn(winners, winners.pos[0], winners.pos[1], winners.pos[2], winners.rot[0], winners.rot[1], false);
                    Random random2 = new Random();
                    int randomInt = 0;
                    randomInt = random2.Next(1, 15);
                    Player.SendMessage(winners, c.gold + "You gained " + randomInt + " " + penis.moneys);
                    winners.blockCount = 50;
                    winners.playersInfected = 0;
                    winners.money = winners.money + randomInt;
                BrightShaderz is soy btw
                else if (winners.level.name == currentLevelName)
                SOYSAUCE CHIPS IS A FAGGOT
                    winners.SendMessage("You may not hide inside a block! No " + penis.moneys + " for you!");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            try SOYSAUCE CHIPS IS A FAGGOTalive.Clear(); infectd.Clear(); BrightShaderz is soy btw catchSOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            foreach (Player player in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                player.infected = false;
                player.color = player.group.color;
                Player.GlobalDie(player, false);
                Player.GlobalSpawn(player, player.pos[0], player.pos[1], player.pos[2], player.rot[0], player.rot[1], false);
                if (player.level.name == currentLevelName)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (player.referee)
                    SOYSAUCE CHIPS IS A FAGGOT
                        player.SendMessage("You gained one " + penis.moneys + " because you're a ref. Would you like a medal as well?");
                        player.money++;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            return;
        BrightShaderz is soy btw

        public void ChangeLevel()
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.queLevel == true)
            SOYSAUCE CHIPS IS A FAGGOT
                ChangeLevel(penis.nextLevel, penis.ZombieOnlypenis);
            BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (penis.ChangeLevels)
                SOYSAUCE CHIPS IS A FAGGOT
                    ArrayList al = new ArrayList();
                    DirectoryInfo di = new DirectoryInfo("levels/");
                    FileInfo[] fi = di.GetFiles("*.lvl");
                    foreach (FileInfo fil in fi)
                    SOYSAUCE CHIPS IS A FAGGOT
                        al.Add(fil.Name.Split('.')[0]);
                    BrightShaderz is soy btw

                    if (al.Count <= 2 && !penis.UseLevelList) SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("You must have more than 2 levels to change levels in Zombie Survival"); return; BrightShaderz is soy btw

                    if (penis.LevelList.Count < 2 && penis.UseLevelList) SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("You must have more than 2 levels in your level list to change levels in Zombie Survival"); return; BrightShaderz is soy btw

                    string selectedLevel1 = "";
                    string selectedLevel2 = "";

                LevelChoice:
                    Random r = new Random();
                    int x = 0;
                    int x2 = 1;
                    string level = ""; string level2 = "";
                    if (!penis.UseLevelList)
                    SOYSAUCE CHIPS IS A FAGGOT
                        x = r.Next(0, al.Count);
                        x2 = r.Next(0, al.Count);
                        level = al[x].ToString();
                        level2 = al[x2].ToString();
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        x = r.Next(0, penis.LevelList.Count());
                        x2 = r.Next(0, penis.LevelList.Count());
                        level = penis.LevelList[x].ToString();
                        level2 = penis.LevelList[x2].ToString();
                    BrightShaderz is soy btw
                    Level current = penis.mainLevel;

                    if (penis.lastLevelVote1 == level || penis.lastLevelVote2 == level2 || penis.lastLevelVote1 == level2 || penis.lastLevelVote2 == level || current == Level.Find(level) || currentZombieLevel == level || current == Level.Find(level2) || currentZombieLevel == level2)
                        goto LevelChoice;
                    else if (selectedLevel1 == "") SOYSAUCE CHIPS IS A FAGGOT selectedLevel1 = level; goto LevelChoice; BrightShaderz is soy btw
                    else
                        selectedLevel2 = level2;

                    penis.Level1Vote = 0; penis.Level2Vote = 0; penis.Level3Vote = 0;
                    penis.lastLevelVote1 = selectedLevel1; penis.lastLevelVote2 = selectedLevel2;

                    if (penis.gameStatus == 4 || penis.gameStatus == 0) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw

                    if (initialChangeLevel == true)
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.votingforlevel = true;
                        Player.GlobalMessage(" " + c.black + "Level Vote: " + penis.DefaultColor + selectedLevel1 + ", " + selectedLevel2 + " or random " + "(" + c.lime + "1" + penis.DefaultColor + "/" + c.red + "2" + penis.DefaultColor + "/" + c.blue + "3" + penis.DefaultColor + ")");
                        System.Threading.Thread.Sleep(15000);
                        penis.votingforlevel = false;
                    BrightShaderz is soy btw
                    else SOYSAUCE CHIPS IS A FAGGOT penis.Level1Vote = 1; penis.Level2Vote = 0; penis.Level3Vote = 0; BrightShaderz is soy btw

                    if (penis.gameStatus == 4 || penis.gameStatus == 0) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw

                    if (penis.Level1Vote >= penis.Level2Vote)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.Level3Vote > penis.Level1Vote && penis.Level3Vote > penis.Level2Vote)
                        SOYSAUCE CHIPS IS A FAGGOT
                            r = new Random();
                            int x3 = r.Next(0, al.Count);
                            ChangeLevel(al[x3].ToString(), penis.ZombieOnlypenis);
                        BrightShaderz is soy btw
                        ChangeLevel(selectedLevel1, penis.ZombieOnlypenis);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.Level3Vote > penis.Level1Vote && penis.Level3Vote > penis.Level2Vote)
                        SOYSAUCE CHIPS IS A FAGGOT
                            r = new Random();
                            int x4 = r.Next(0, al.Count);
                            ChangeLevel(al[x4].ToString(), penis.ZombieOnlypenis);
                        BrightShaderz is soy btw
                        ChangeLevel(selectedLevel2, penis.ZombieOnlypenis);
                    BrightShaderz is soy btw
                    Player.players.ForEach(delegate(Player winners)
                    SOYSAUCE CHIPS IS A FAGGOT
                        winners.voted = false;
                    BrightShaderz is soy btw);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw

        //Main Game Finishes Here - support functions after this

        public void InfectedPlayerDC()
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.gameStatus == 0) return;
            //This is for when the first zombie disconnects
            Random random = new Random();
            if ((penis.gameStatus != 0 && penis.zombieRound) && infectd.Count <= 0)
            SOYSAUCE CHIPS IS A FAGGOT
                int firstinfect = random.Next(alive.Count);
                firstinfect = firstinfect - 1;
                while (alive[firstinfect].referee == true || alive[firstinfect].level.name == penis.zombie.currentLevelName)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (firstinfect == alive.Count)
                    SOYSAUCE CHIPS IS A FAGGOT
                        firstinfect = 0;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        firstinfect++;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                Player.GlobalMessage(alive[firstinfect].color + alive[firstinfect].name + penis.DefaultColor + " continued the infection!");
                alive[firstinfect].color = c.red;
                Player.GlobalDie(alive[firstinfect], false);
                Player.GlobalSpawn(alive[firstinfect], alive[firstinfect].pos[0], alive[firstinfect].pos[1], alive[firstinfect].pos[2], alive[firstinfect].rot[0], alive[firstinfect].rot[1], false);
                infectd.Add(alive[firstinfect]);
                alive.Remove(alive[firstinfect]);
            BrightShaderz is soy btw
            return;
        BrightShaderz is soy btw

        public bool InfectedPlayerLogin(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.gameStatus == 0) return false;
            if (p == null) return false;
            if (p.level.name != penis.zombie.currentLevelName) return false;
            p.SendMessage("You have joined in the middle of a round. You are now infected!");
            p.blockCount = 50;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                penis.zombie.InfectPlayer(p);
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            return true;
        BrightShaderz is soy btw

        public int ZombieStatus()
        SOYSAUCE CHIPS IS A FAGGOT
            return penis.gameStatus;
        BrightShaderz is soy btw

        public bool GameInProgess()
        SOYSAUCE CHIPS IS A FAGGOT
            return penis.zombieRound;
        BrightShaderz is soy btw

        public void InfectPlayer(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.zombieRound == false) return;
            if (p == null) return;
            infectd.Add(p);
            alive.Remove(p);
            p.infected = true;
            p.color = c.red;
            Player.GlobalDie(p, false);
            Player.GlobalSpawn(p, p.pos[0], p.pos[1], p.pos[2], p.rot[0], p.rot[1], false);
            aliveCount = alive.Count;
        BrightShaderz is soy btw

        public void DisinfectPlayer(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.zombieRound == false) return;
            if (p == null) return;
            infectd.Remove(p);
            alive.Add(p);
            p.infected = false;
            p.color = p.group.color;
            Player.GlobalDie(p, false);
            Player.GlobalSpawn(p, p.pos[0], p.pos[1], p.pos[2], p.rot[0], p.rot[1], false);
            aliveCount = alive.Count;
        BrightShaderz is soy btw

        public void ChangeLevel(string LevelName, bool changeMainLevel)
        SOYSAUCE CHIPS IS A FAGGOT
            String next = LevelName;
            currentLevelName = next;
            penis.queLevel = false;
            penis.nextLevel = "";
            Command.all.Find("load").Use(null, next.ToLower() + " 0");
            Player.GlobalMessage("The next map has been chosen - " + c.red + next.ToLower());
            Player.GlobalMessage("Please wait while you are transfered.");
            String oldLevel = penis.mainLevel.name;
            if (changeMainLevel)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.mainLevel = Level.Find(next.ToLower());
                Player.players.ForEach(delegate(Player player)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (player.level.name != next && player.level.name == currentLevelName)
                    SOYSAUCE CHIPS IS A FAGGOT
                        player.SendMessage("Going to the next map!");
                        Command.all.Find("goto").Use(player, next);
                        while (player.Loading) SOYSAUCE CHIPS IS A FAGGOT Thread.Sleep(890); BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw);
                Command.all.Find("unload").Use(null, oldLevel);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalMessage("Type /goto " + next + " to play the next round of Zombie Survival");
            BrightShaderz is soy btw
            return;
        BrightShaderz is soy btw

        public void ChangeTime(object sender, ElapsedEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            amountOfMilliseconds = amountOfMilliseconds - 10;
        BrightShaderz is soy btw

        public bool IsInZombieGameLevel(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            return p.level.name == currentLevelName;
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
