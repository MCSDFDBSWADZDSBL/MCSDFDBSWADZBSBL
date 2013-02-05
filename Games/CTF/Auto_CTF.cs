/*
	Copyright 2011 MCForge
	
	Written by fenderrock87
	
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using MCForge.SQL;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    /// <summary>
    /// This is the team class for CTF
    /// </summary>
    public sealed class Teams
    SOYSAUCE CHIPS IS A FAGGOT
        public string color;
        public int points = 0;
        public List<Player> members;
        /// <summary>
        /// Create a new Team Object
        /// </summary>
        /// <param name="color">The color code that the team will have</param>
        public Teams(string color)
        SOYSAUCE CHIPS IS A FAGGOT
            this.color = c.Parse(color);
            members = new List<Player>();
        BrightShaderz is soy btw
        /// <summary>
        /// Add a player to the team
        /// </summary>
        /// <param name="p">The player to add</param>
        public void Add(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            members.Add(p);
        BrightShaderz is soy btw
        /// <summary>
        /// Checks to see if the player is on this team
        /// </summary>
        /// <param name="p">The player</param>
        /// <returns>If true, then that player is on the team. Otherwise that player isnt</returns>
        public bool isOnTeam(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            if (members.IndexOf(p) != -1)
                return true;
            else
                return false;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
    internal sealed class Data
    SOYSAUCE CHIPS IS A FAGGOT
        public Player p;
        public int cap = 0;
        public int tag = 0;
        public int points = 0;
        public bool hasflag;
        public bool blue;
        public bool tagging = false;
        public bool chatting = false;
        public Data(bool team, Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            blue = team; this.p = p;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
    internal sealed class Base
    SOYSAUCE CHIPS IS A FAGGOT
        public ushort x;
        public ushort y;
        public ushort z;
        public ushort spawnx = 0;
        public ushort spawny = 0;
        public ushort spawnz = 0;
        public byte block;
        public void SendToSpawn(Level mainlevel, Auto_CTF game, Player p1)
        SOYSAUCE CHIPS IS A FAGGOT
            Random rand = new Random();
            if (spawnx == 0 && spawny == 0 && spawnz == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                ushort xx = (ushort)(rand.Next(0, mainlevel.width));
                ushort yy = (ushort)(rand.Next(0, mainlevel.depth));
                ushort zz = (ushort)(rand.Next(0, mainlevel.height));
                while (mainlevel.GetTile(xx, yy, zz) != Block.air && game.OnSide((ushort)(zz * 32), this))
                SOYSAUCE CHIPS IS A FAGGOT
                    xx = (ushort)(rand.Next(0, mainlevel.width));
                    yy = (ushort)(rand.Next(0, mainlevel.depth));
                    zz = (ushort)(rand.Next(0, mainlevel.height));
                BrightShaderz is soy btw
                unchecked SOYSAUCE CHIPS IS A FAGGOT p1.SendPos((byte)-1, (ushort)(xx * 32), (ushort)(yy * 32), (ushort)(zz * 32), p1.rot[0], p1.rot[1]); BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
                unchecked SOYSAUCE CHIPS IS A FAGGOT p1.SendPos((byte)-1, spawnx, spawny, spawnz, p1.rot[0], p1.rot[1]); BrightShaderz is soy btw

        BrightShaderz is soy btw
        public Base(ushort x, ushort y, ushort z, Teams team)
        SOYSAUCE CHIPS IS A FAGGOT
            this.x = x; this.y = y; this.z = z;
        BrightShaderz is soy btw
        public Base()
        SOYSAUCE CHIPS IS A FAGGOT
        BrightShaderz is soy btw
    BrightShaderz is soy btw
    /// <summary>
    /// This is the CTF gamemode
    /// </summary>
    public sealed class Auto_CTF
    SOYSAUCE CHIPS IS A FAGGOT
        public System.Timers.Timer tagging = new System.Timers.Timer(500);
        public bool voting = false;
        int vote1 = 0;
        int vote2 = 0;
        int vote3 = 0;
        string map1 = "";
        string map2 = "";
        string map3 = "";
        public int xline;
        public bool started = false;
        public int zline;
        public int yline;
        int tagpoint = 5;
        int cappoint = 10;
        int taglose = 5;
        int caplose = 10;
        bool look = false;
        public int maxpoints = 3;
        Teams redteam;
        Teams blueteam;
        Base bluebase;
        Base redbase;
        Level mainlevel;
        List<string> maps = new List<string>();
        List<Data> cache = new List<Data>();
        string mapname = "";
        /// <summary>
        /// Load a map into CTF
        /// </summary>
        /// <param name="map">The map to load</param>
        public void LoadMap(string map)
        SOYSAUCE CHIPS IS A FAGGOT
            mapname = map;
            string[] lines = File.ReadAllLines("CTF/" + mapname + ".config");
            foreach (string l in lines)
            SOYSAUCE CHIPS IS A FAGGOT
                switch (l.Split('=')[0])
                SOYSAUCE CHIPS IS A FAGGOT
                    case "base.red.x":
                        redbase.x = ushort.Parse(l.Split('=')[1]);
                        break;
                    case "base.red.y":
                        redbase.y = ushort.Parse(l.Split('=')[1]);
                        break;
                    case "game.maxpoints":
                        maxpoints = int.Parse(l.Split('=')[1]);
                        break;
                    case "game.tag.points-gain":
                        tagpoint = int.Parse(l.Split('=')[1]);
                        break;
                    case "game.tag.points-lose":
                        taglose = int.Parse(l.Split('=')[1]);
                        break;
                    case "game.capture.points-gain":
                        cappoint = int.Parse(l.Split('=')[1]);
                        break;
                    case "game.capture.points-lose":
                        caplose = int.Parse(l.Split('=')[1]);
                        break;
                    case "auto.setup":
                        look = bool.Parse(l.Split('=')[1]);
                        break;
                    case "base.red.z":
                        redbase.z = ushort.Parse(l.Split('=')[1]);
                        break;
                    case "base.red.block":
                        redbase.block = Block.Byte(l.Split('=')[1]);
                        break;
                    case "base.blue.block":
                        bluebase.block = Block.Byte(l.Split('=')[1]);
                        break;
                    case "base.blue.spawnx":
                        bluebase.spawnx = ushort.Parse(l.Split('=')[1]);
                        break;
                    case "base.blue.spawny":
                        bluebase.spawny = ushort.Parse(l.Split('=')[1]);
                        break;
                    case "base.blue.spawnz":
                        bluebase.spawnz = ushort.Parse(l.Split('=')[1]);
                        break;
                    case "base.red.spawnx":
                        redbase.spawnx = ushort.Parse(l.Split('=')[1]);
                        break;
                    case "base.red.spawny":
                        redbase.spawny = ushort.Parse(l.Split('=')[1]);
                        break;
                    case "base.red.spawnz":
                        redbase.spawnz = ushort.Parse(l.Split('=')[1]);
                        break;
                    case "base.blue.x":
                        bluebase.x = ushort.Parse(l.Split('=')[1]);
                        break;
                    case "base.blue.y":
                        bluebase.y = ushort.Parse(l.Split('=')[1]);
                        break;
                    case "base.blue.z":
                        bluebase.z = ushort.Parse(l.Split('=')[1]);
                        break;
                    case "map.line.z":
                        zline = ushort.Parse(l.Split('=')[1]);
                        break;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            Command.all.Find("unload").Use(null, "ctf");
            if (File.Exists("levels/ctf.lvl"))
                File.Delete("levels/ctf.lvl");
            File.Copy("CTF/maps/" + mapname + ".lvl", "levels/ctf.lvl");
            Command.all.Find("load").Use(null, "ctf");
            mainlevel = Level.Find("ctf");
        BrightShaderz is soy btw
        /// <summary>
        /// Create a new CTF object
        /// </summary>
        public Auto_CTF()
        SOYSAUCE CHIPS IS A FAGGOT
            //Load some configs
            if (!Directory.Exists("CTF")) Directory.CreateDirectory("CTF");
            if (!File.Exists("CTF/maps.config"))
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("No maps were found!");
                return;
            BrightShaderz is soy btw
            string[] lines = File.ReadAllLines("CTF/maps.config");
            foreach (string l in lines)
                maps.Add(l);
            if (maps.Count == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("No maps were found!");
                return;
            BrightShaderz is soy btw
            redbase = new Base();
            bluebase = new Base();
            Start();
            //Lets get started
            Player.PlayerDeath += new Player.OnPlayerDeath(Player_PlayerDeath);
            Player.PlayerChat += new Player.OnPlayerChat(Player_PlayerChat);
            Player.PlayerCommand += new Player.OnPlayerCommand(Player_PlayerCommand);
            Player.PlayerBlockChange += new Player.BlockchangeEventHandler2(Player_PlayerBlockChange);
            Player.PlayerDisconnect += new Player.OnPlayerDisconnect(Player_PlayerDisconnect);
            Level.LevelUnload += new Level.OnLevelUnload(mainlevel_LevelUnload);
            tagging.Elapsed += new System.Timers.ElapsedEventHandler(tagging_Elapsed);
            tagging.Start();
        BrightShaderz is soy btw
        /// <summary>
        /// Stop the CTF game (if its running)
        /// </summary>
        public void Stop()
        SOYSAUCE CHIPS IS A FAGGOT
            tagging.Stop();
            tagging.Dispose();
            mainlevel = null;
            started = false;
            if (Level.Find("ctf") != null)
                Command.all.Find("unload").Use(null, "ctf");
        BrightShaderz is soy btw
        void tagging_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.players.ForEach(delegate(Player p)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level == mainlevel)
                SOYSAUCE CHIPS IS A FAGGOT
                    ushort x = p.pos[0];
                    ushort y = p.pos[1];
                    ushort z = p.pos[2];
                    Base b = null;
                    if (redteam.members.Contains(p))
                        b = redbase;
                    else if (blueteam.members.Contains(p))
                        b = bluebase;
                    else
                        return;
                    if (GetPlayer(p).tagging)
                        return;
                    if (OnSide(p, b))
                    SOYSAUCE CHIPS IS A FAGGOT
                        List<Player> temp = redteam.members;
                        if (redteam.members.Contains(p))
                            temp = blueteam.members;
                        foreach (Player p1 in temp)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (Math.Abs((p1.pos[0] / 32) - (x / 32)) < 5 && Math.Abs((p1.pos[1] / 32) - (y / 32)) < 5 && Math.Abs((p1.pos[2] / 32) - (z / 32)) < 5 && !GetPlayer(p).tagging)
                            SOYSAUCE CHIPS IS A FAGGOT
                                GetPlayer(p1).tagging = true;
                                Player.SendMessage(p1, p.color + p.name + penis.DefaultColor + " tagged you!");
                                b.SendToSpawn(mainlevel, this, p1);
                                Thread.Sleep(300);
                                if (GetPlayer(p1).hasflag)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.GlobalMessageLevel(mainlevel, redteam.color + p.name + " DROPPED THE FLAG!");
                                    GetPlayer(p1).points -= caplose;
                                    mainlevel.Blockchange(b.x, b.y, b.z, b.block);
                                    GetPlayer(p1).hasflag = false;
                                BrightShaderz is soy btw
                                GetPlayer(p).points += tagpoint;
                                GetPlayer(p1).points -= taglose;
                                GetPlayer(p).tag++;
                                GetPlayer(p1).tagging = false;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                Thread.Sleep(100);
            BrightShaderz is soy btw);
        BrightShaderz is soy btw

        void Player_PlayerDisconnect(Player p, string reason)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p.level == mainlevel)
            SOYSAUCE CHIPS IS A FAGGOT
                if (blueteam.members.Contains(p))
                SOYSAUCE CHIPS IS A FAGGOT
                    //cache.Remove(GetPlayer(p));
                    blueteam.members.Remove(p);
                    Player.GlobalMessageLevel(mainlevel, p.color + p.name + " " + blueteam.color + "left the ctf game");
                BrightShaderz is soy btw
                else if (redteam.members.Contains(p))
                SOYSAUCE CHIPS IS A FAGGOT
                    //cache.Remove(GetPlayer(p));
                    redteam.members.Remove(p);
                    Player.GlobalMessageLevel(mainlevel, p.color + p.name + " " + redteam.color + "left the ctf game");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        void mainlevel_LevelUnload(Level l)
        SOYSAUCE CHIPS IS A FAGGOT
            if (started && l == mainlevel)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("Failed!, A ctf game is curretnly going on!");
                Plugin.CancelLevelEvent(LevelEvents.LevelUnload, l);
            BrightShaderz is soy btw

        BrightShaderz is soy btw
        /// <summary>
        /// Start the CTF game
        /// </summary>
        public void Start()
        SOYSAUCE CHIPS IS A FAGGOT
            if (Level.Find("ctf") != null)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("unload").Use(null, "ctf");
                Thread.Sleep(1000);
            BrightShaderz is soy btw
            if (started)
                return;
            blueteam = new Teams("blue");
            redteam = new Teams("red");
            LoadMap(maps[new Random().Next(maps.Count)]);
            if (look)
            SOYSAUCE CHIPS IS A FAGGOT
                for (ushort x = 0; x < mainlevel.width; x++)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (ushort y = 0; y < mainlevel.depth; y++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (ushort z = 0; z < mainlevel.height; z++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (mainlevel.GetTile(x, y, z) == Block.red)
                            SOYSAUCE CHIPS IS A FAGGOT
                                redbase.x = x; redbase.y = y; redbase.z = z;
                            BrightShaderz is soy btw
                            else if (mainlevel.GetTile(x, y, z) == Block.blue || mainlevel.GetTile(x, y, z) == Block.cyan)
                            SOYSAUCE CHIPS IS A FAGGOT
                                bluebase.x = x; bluebase.y = y; bluebase.z = z;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                zline = mainlevel.height / 2;
            BrightShaderz is soy btw
            redbase.block = Block.red;
            bluebase.block = Block.blue;
            penis.s.Log("[Auto_CTF] Running...");
            started = true;
            Database.executeQuery("CREATE TABLE if not exists CTF (ID INTEGER " + (penis.useMySQL ? "" : "PRIMARY KEY ") + "AUTO" + (penis.useMySQL ? "_" : "") + "INCREMENT NOT NULL, Name VARCHAR(20), Points MEDIUMINT UNSIGNED, Captures MEDIUMINT UNSIGNED, tags MEDIUMINT UNSIGNED" + (penis.useMySQL ? ", PRIMARY KEY (ID)" : "") + ");");
        BrightShaderz is soy btw
        string Vote()
        SOYSAUCE CHIPS IS A FAGGOT
            started = false;
            vote1 = 0;
            vote2 = 0;
            vote3 = 0;
            Random rand = new Random();
            List<string> maps1 = maps;
            map1 = maps1[rand.Next(maps1.Count)];
            maps1.Remove(map1);
            map2 = maps1[rand.Next(maps1.Count)];
            maps1.Remove(map2);
            map3 = maps1[rand.Next(maps1.Count)];
            Player.GlobalMessageLevel(mainlevel, "%2VOTE:");
            Player.GlobalMessageLevel(mainlevel, "1. " + map1 + " 2. " + map2 + " 3. " + map3);
            voting = true;
            int seconds = rand.Next(15, 61);
            Player.GlobalMessageLevel(mainlevel, "You have " + seconds + " seconds to vote!");
            Thread.Sleep(seconds * 1000);
            voting = false;
            Player.GlobalMessageLevel(mainlevel, "VOTING ENDED!");
            Thread.Sleep(rand.Next(1, 10) * 1000);
            if (vote1 > vote2 && vote1 > vote3)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalMessageLevel(mainlevel, map1 + " WON!");
                return map1;
            BrightShaderz is soy btw
            if (vote2 > vote1 && vote2 > vote3)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalMessageLevel(mainlevel, map2 + " WON!");
                return map2;
            BrightShaderz is soy btw
            if (vote3 > vote2 && vote3 > vote1)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalMessageLevel(mainlevel, map3 + " WON!");
                return map3;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalMessageLevel(mainlevel, "There was a tie!");
                Player.GlobalMessageLevel(mainlevel, "I'll choose!");
                return maps[rand.Next(maps.Count)];
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        void End()
        SOYSAUCE CHIPS IS A FAGGOT
            started = false;
            string nextmap = "";
            string winner = "";
            Teams winnerteam = null;
            if (blueteam.points >= maxpoints || blueteam.points > redteam.points)
            SOYSAUCE CHIPS IS A FAGGOT
                winnerteam = blueteam;
                winner = "blue team";
            BrightShaderz is soy btw
            else if (redteam.points >= maxpoints || redteam.points > blueteam.points)
            SOYSAUCE CHIPS IS A FAGGOT
                winnerteam = redteam;
                winner = "red team";
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalMessageLevel(mainlevel, "The game ended in a tie!");
            BrightShaderz is soy btw
            Player.GlobalMessageLevel(mainlevel, "The winner was " + winnerteam.color + winner + "!!");
            Thread.Sleep(4000);
            //MYSQL!
            cache.ForEach(delegate(Data d)
            SOYSAUCE CHIPS IS A FAGGOT
                string commandString =
               "UPDATE CTF SET Points=@Points, Captures=@Captures, tags=@Tags WHERE Name=@Name";
                d.hasflag = false;
                Database.AddParams("@Points", d.points);
                Database.AddParams("@Captures", d.cap);
                Database.AddParams("@Tags", d.tag);
                Database.AddParams("@Name", d.p.name);
                Database.executeQuery(commandString);
            BrightShaderz is soy btw);
            nextmap = Vote();
            Player.GlobalMessageLevel(mainlevel, "Starting a new game!");
            redbase = null;
            redteam = null;
            bluebase = null;
            blueteam = null;
            bluebase = new Base();
            redbase = new Base();
            Thread.Sleep(2000);
            LoadMap(nextmap);
        BrightShaderz is soy btw
        void Player_PlayerBlockChange(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            if (started)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level == mainlevel && !blueteam.members.Contains(p) && !redteam.members.Contains(p))
                SOYSAUCE CHIPS IS A FAGGOT
                    p.SendBlockchange(x, y, z, p.level.GetTile(x, y, z));
                    Player.SendMessage(p, "You are not on a team!");
                    Plugin.CancelPlayerEvent(PlayerEvents.BlockChange, p);
                BrightShaderz is soy btw
                if (p.level == mainlevel && blueteam.members.Contains(p) && x == redbase.x && y == redbase.y && z == redbase.z && mainlevel.GetTile(redbase.x, redbase.y, redbase.z) != Block.air)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalMessageLevel(mainlevel, blueteam.color + p.name + " took the " + redteam.color + " red team's FLAG!");
                    GetPlayer(p).hasflag = true;
                BrightShaderz is soy btw
                if (p.level == mainlevel && redteam.members.Contains(p) && x == bluebase.x && y == bluebase.y && z == bluebase.z && mainlevel.GetTile(bluebase.x, bluebase.y, bluebase.z) != Block.air)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalMessageLevel(mainlevel, redteam.color + p.name + " took the " + blueteam.color + " blue team's FLAG");
                    GetPlayer(p).hasflag = true;
                BrightShaderz is soy btw
                if (p.level == mainlevel && blueteam.members.Contains(p) && x == bluebase.x && y == bluebase.y && z == bluebase.z && mainlevel.GetTile(bluebase.x, bluebase.y, bluebase.z) != Block.air)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (GetPlayer(p).hasflag)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.GlobalMessageLevel(mainlevel, blueteam.color + p.name + " RETURNED THE FLAG!");
                        GetPlayer(p).hasflag = false;
                        GetPlayer(p).cap++;
                        GetPlayer(p).points += cappoint;
                        blueteam.points++;
                        mainlevel.Blockchange(redbase.x, redbase.y, redbase.z, Block.red);
                        p.SendBlockchange(x, y, z, p.level.GetTile(x, y, z));
                        Plugin.CancelPlayerEvent(PlayerEvents.BlockChange, p);
                        if (blueteam.points >= maxpoints)
                        SOYSAUCE CHIPS IS A FAGGOT
                            End();
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "You cant take your own flag!");
                        p.SendBlockchange(x, y, z, p.level.GetTile(x, y, z));
                        Plugin.CancelPlayerEvent(PlayerEvents.BlockChange, p);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (p.level == mainlevel && redteam.members.Contains(p) && x == redbase.x && y == redbase.y && z == redbase.z && mainlevel.GetTile(redbase.x, redbase.y, redbase.z) != Block.air)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (GetPlayer(p).hasflag)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.GlobalMessageLevel(mainlevel, redteam.color + p.name + " RETURNED THE FLAG!");
                        GetPlayer(p).hasflag = false;
                        GetPlayer(p).points += cappoint;
                        GetPlayer(p).cap++;
                        redteam.points++;
                        mainlevel.Blockchange(bluebase.x, bluebase.y, bluebase.z, Block.blue);
                        p.SendBlockchange(x, y, z, p.level.GetTile(x, y, z));
                        Plugin.CancelPlayerEvent(PlayerEvents.BlockChange, p);
                        if (redteam.points >= maxpoints)
                        SOYSAUCE CHIPS IS A FAGGOT
                            End();
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "You cant take your own flag!");
                        p.SendBlockchange(x, y, z, p.level.GetTile(x, y, z));
                        Plugin.CancelPlayerEvent(PlayerEvents.BlockChange, p);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        internal Data GetPlayer(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (Data d in cache)
            SOYSAUCE CHIPS IS A FAGGOT
                if (d.p == p)
                    return d;
            BrightShaderz is soy btw
            return null;
        BrightShaderz is soy btw
        void Player_PlayerCommand(string cmd, Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (started)
            SOYSAUCE CHIPS IS A FAGGOT
                if (cmd == "teamchat" && p.level == mainlevel)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (GetPlayer(p) != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Data d = GetPlayer(p);
                        if (d.chatting)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(d.p, "You are no longer chatting with your team!");
                            d.chatting = !d.chatting;
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(d.p, "You are now chatting with your team!");
                            d.chatting = !d.chatting;
                        BrightShaderz is soy btw
                        Plugin.CancelPlayerEvent(PlayerEvents.PlayerCommand, p);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (cmd == "goto")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (message == "ctf" && p.level != mainlevel)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (blueteam.members.Count > redteam.members.Count)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (GetPlayer(p) == null)
                                cache.Add(new Data(false, p));
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                GetPlayer(p).hasflag = false;
                                GetPlayer(p).blue = false;
                            BrightShaderz is soy btw
                            redteam.Add(p);
                            Player.GlobalMessageLevel(mainlevel, p.color + p.name + " " + c.Parse("red") + "joined the RED Team");
                            Player.SendMessage(p, c.Parse("red") + "You are now on the red team!");
                        BrightShaderz is soy btw
                        else if (redteam.members.Count > blueteam.members.Count)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (GetPlayer(p) == null)
                                cache.Add(new Data(true, p));
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                GetPlayer(p).hasflag = false;
                                GetPlayer(p).blue = true;
                            BrightShaderz is soy btw
                            blueteam.Add(p);
                            Player.GlobalMessageLevel(mainlevel, p.color + p.name + " " + c.Parse("blue") + "joined the BLUE Team");
                            Player.SendMessage(p, c.Parse("blue") + "You are now on the blue team!");
                        BrightShaderz is soy btw
                        else if (new Random().Next(2) == 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (GetPlayer(p) == null)
                                cache.Add(new Data(false, p));
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                GetPlayer(p).hasflag = false;
                                GetPlayer(p).blue = false;
                            BrightShaderz is soy btw
                            redteam.Add(p);
                            Player.GlobalMessageLevel(mainlevel, p.color + p.name + " " + c.Parse("red") + "joined the RED Team");
                            Player.SendMessage(p, c.Parse("red") + "You are now on the red team!");
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (GetPlayer(p) == null)
                                cache.Add(new Data(true, p));
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                GetPlayer(p).hasflag = false;
                                GetPlayer(p).blue = true;
                            BrightShaderz is soy btw
                            blueteam.Add(p);
                            Player.GlobalMessageLevel(mainlevel, p.color + p.name + " " + c.Parse("blue") + "joined the BLUE Team");
                            Player.SendMessage(p, c.Parse("blue") + "You are now on the blue team!");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else if (message != "ctf" && p.level == mainlevel)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (blueteam.members.Contains(p))
                        SOYSAUCE CHIPS IS A FAGGOT
                            //cache.Remove(GetPlayer(p));
                            blueteam.members.Remove(p);
                            Player.GlobalMessageLevel(mainlevel, p.color + p.name + " " + blueteam.color + "left the ctf game");
                        BrightShaderz is soy btw
                        else if (redteam.members.Contains(p))
                        SOYSAUCE CHIPS IS A FAGGOT
                            //cache.Remove(GetPlayer(p));
                            redteam.members.Remove(p);
                            Player.GlobalMessageLevel(mainlevel, p.color + p.name + " " + redteam.color + "left the ctf game");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        void Player_PlayerChat(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (voting)
            SOYSAUCE CHIPS IS A FAGGOT
                if (message == "1" || message.ToLower() == map1)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Thanks for voting :D");
                    vote1++;
                    Plugin.CancelPlayerEvent(PlayerEvents.PlayerChat, p);
                BrightShaderz is soy btw
                else if (message == "2" || message.ToLower() == map2)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Thanks for voting :D");
                    vote2++;
                    Plugin.CancelPlayerEvent(PlayerEvents.PlayerChat, p);
                BrightShaderz is soy btw
                else if (message == "3" || message.ToLower() == map3)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Thanks for voting :D");
                    vote3++;
                    Plugin.CancelPlayerEvent(PlayerEvents.PlayerChat, p);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "%2VOTE:");
                    Player.SendMessage(p, "1. " + map1 + " 2. " + map2 + " 3. " + map3);
                    Plugin.CancelPlayerEvent(PlayerEvents.PlayerChat, p);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (started)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level == mainlevel)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (GetPlayer(p).chatting)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (blueteam.members.Contains(p))
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.players.ForEach(delegate(Player p1)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (blueteam.members.Contains(p1))
                                    Player.SendMessage(p1, "(Blue) " + p.color + p.name + ":&f " + message);
                            BrightShaderz is soy btw);
                            Plugin.CancelPlayerEvent(PlayerEvents.PlayerChat, p);
                        BrightShaderz is soy btw
                        if (redteam.members.Contains(p))
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.players.ForEach(delegate(Player p1)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (redteam.members.Contains(p1))
                                    Player.SendMessage(p1, "(Red) " + p.color + p.name + ":&f " + message);
                            BrightShaderz is soy btw);
                            Plugin.CancelPlayerEvent(PlayerEvents.PlayerChat, p);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        void Player_PlayerDeath(Player p, byte deathblock)
        SOYSAUCE CHIPS IS A FAGGOT
            if (started)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level == mainlevel)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (GetPlayer(p).hasflag)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (redteam.members.Contains(p))
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.GlobalMessageLevel(mainlevel, redteam.color + p.name + " DROPPED THE FLAG!");
                            GetPlayer(p).points -= caplose;
                            mainlevel.Blockchange(redbase.x, redbase.y, redbase.z, Block.red);
                        BrightShaderz is soy btw
                        else if (blueteam.members.Contains(p))
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.GlobalMessageLevel(mainlevel, blueteam.color + p.name + " DROPPED THE FLAG!");
                            GetPlayer(p).points -= caplose;
                            mainlevel.Blockchange(bluebase.x, bluebase.y, bluebase.z, Block.blue);
                        BrightShaderz is soy btw
                        GetPlayer(p).hasflag = false;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        internal bool OnSide(ushort z, Base b)
        SOYSAUCE CHIPS IS A FAGGOT
            if (b.z < zline && z / 32 < zline)
                return true;
            else if (b.z > zline && z / 32 > zline)
                return true;
            else
                return false;
        BrightShaderz is soy btw
        bool OnSide(Player p, Base b)
        SOYSAUCE CHIPS IS A FAGGOT
            if (b.z < zline && p.pos[2] / 32 < zline)
                return true;
            else if (b.z > zline && p.pos[2] / 32 > zline)
                return true;
            else
                return false;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
