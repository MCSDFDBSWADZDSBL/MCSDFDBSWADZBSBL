using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdCTF : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ctf"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            int num = message.Split(' ').Length;
            if (num == 3)
            SOYSAUCE CHIPS IS A FAGGOT
                string[] strings = message.Split(' ');

                for (int i = 0; i < num; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    strings[i] = strings[i].ToLower();
                BrightShaderz is soy btw

                if (strings[0] == "team")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (strings[1] == "add")
                    SOYSAUCE CHIPS IS A FAGGOT
                        string color = c.Parse(strings[2]);
                        if (color == "")SOYSAUCE CHIPS IS A FAGGOTPlayer.SendMessage(p, "Invalid team color chosen."); return;BrightShaderz is soy btw
                        char teamCol = (char)color[1];
                        switch (teamCol)
                        SOYSAUCE CHIPS IS A FAGGOT
                            case '2':
                            case '5':
                            case '8':
                            case '9':
                            case 'c':
                            case 'e':
                            case 'f':
                                AddTeam(p, color);
                                break;
                            default:
                                Player.SendMessage(p, "Invalid team color chosen.");
                                return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else if (strings[1] == "remove")
                    SOYSAUCE CHIPS IS A FAGGOT
                        string color = c.Parse(strings[2]);
                        if (color == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid team color chosen."); return; BrightShaderz is soy btw
                        char teamCol = (char)color[1];
                        switch (teamCol)
                        SOYSAUCE CHIPS IS A FAGGOT
                            case '2':
                            case '5':
                            case '8':
                            case '9':
                            case 'c':
                            case 'e':
                            case 'f':
                                RemoveTeam(p, color);
                                break;
                            default:
                                Player.SendMessage(p, "Invalid team color chosen.");
                                return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (num == 2)
            SOYSAUCE CHIPS IS A FAGGOT
                string[] strings = message.Split(' ');

                for (int i = 0; i < num; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    strings[i] = strings[i].ToLower();
                BrightShaderz is soy btw

                if (strings[0] == "debug")
                SOYSAUCE CHIPS IS A FAGGOT
                    Debug(p, strings[1]);
                BrightShaderz is soy btw
                else if (strings[0] == "flag")
                SOYSAUCE CHIPS IS A FAGGOT
                    string color = c.Parse(strings[1]);
                    if (color == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid team color chosen."); return; BrightShaderz is soy btw
                    char teamCol = (char)color[1];
                    if (p.level.ctfgame.teams.Find(team => team.color == teamCol) == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid team color chosen."); return; BrightShaderz is soy btw
                    CatchPos cpos;
                    cpos.x = 0; cpos.y = 0; cpos.z = 0; cpos.color = color; p.blockchangeObject = cpos;
                    Player.SendMessage(p, "Place a block to determine where to place the flag.");
                    p.ClearBlockchange();
                    p.Blockchange += new Player.BlockchangeEventHandler(FlagBlockChange);
                BrightShaderz is soy btw
                else if (strings[0] == "spawn")
                SOYSAUCE CHIPS IS A FAGGOT
                    string color = c.Parse(strings[1]);
                    if (color == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid team color chosen."); return; BrightShaderz is soy btw
                    char teamCol = (char)color[1];
                    if (p.level.ctfgame.teams.Find(team => team.color == teamCol) == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid team color chosen."); return; BrightShaderz is soy btw
                    AddSpawn(p, color);
                    
                BrightShaderz is soy btw
                else if (strings[0] == "points")
                SOYSAUCE CHIPS IS A FAGGOT
                    int i = 0;
                    Int32.TryParse(strings[1], out i);
                    if (i == 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You must choose a points value greater than 0!"); return; BrightShaderz is soy btw
                    p.level.ctfgame.maxPoints = i;
                    Player.SendMessage(p, "Max round points has been set to " + i);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (num == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                if (message.ToLower() == "start")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!p.level.ctfmode)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.ctfmode = true;
                    BrightShaderz is soy btw
                    p.level.ctfgame.gameOn = true;
                    p.level.ctfgame.GameStart();
                BrightShaderz is soy btw
                else if (message.ToLower() == "stop")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.level.ctfmode)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.ctfmode = false;
                    BrightShaderz is soy btw
                    p.level.ctfmode = false;
                    p.level.ctfgame.gameOn = false;
                    p.level.ChatLevel(p.color + p.name + penis.DefaultColor + " has ended the game");
                BrightShaderz is soy btw
                else if (message.ToLower() == "ff")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.level.ctfgame.friendlyfire)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.ChatLevel("Friendly fire has been disabled.");
                        p.level.ctfgame.friendlyfire = false;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.ChatLevel("Friendly fire has been enabled.");
                        p.level.ctfgame.friendlyfire = true;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else if (message.ToLower() == "clear")
                SOYSAUCE CHIPS IS A FAGGOT
                    List<Team> storedT = new List<Team>();
                    for (int i = 0; i < p.level.ctfgame.teams.Count; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        storedT.Add(p.level.ctfgame.teams[i]);
                    BrightShaderz is soy btw
                    foreach (Team t in storedT)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.ctfgame.RemoveTeam("&" + t.color);
                    BrightShaderz is soy btw
                    p.level.ctfgame.onTeamCheck.Stop();
                    p.level.ctfgame.onTeamCheck.Dispose();
                    p.level.ctfgame.gameOn = false;
                    p.level.ctfmode = false;
                    p.level.ctfgame = new CTFGame();
                    p.level.ctfgame.mapOn = p.level;
                    Player.SendMessage(p, "CTF data has been cleared.");
                BrightShaderz is soy btw

                else if (message.ToLower() == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.level.ctfmode)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.ctfmode = false;
                        p.level.ChatLevel("CTF Mode has been disabled.");

                    BrightShaderz is soy btw
                    else if (!p.level.ctfmode)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.ctfmode = true;
                        p.level.ChatLevel("CTF Mode has been enabled.");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void AddSpawn(Player p, string color)
        SOYSAUCE CHIPS IS A FAGGOT
            char teamCol = (char)color[1];
            ushort x, y, z, rotx;
            x = (ushort)(p.pos[0] / 32);
            y = (ushort)(p.pos[1] / 32);
            z = (ushort)(p.pos[2] / 32);
            rotx = (ushort)(p.rot[0]);
            p.level.ctfgame.teams.Find(team => team.color == teamCol).AddSpawn(x, y, z, rotx, 0);
            Player.SendMessage(p, "Added spawn for " + p.level.ctfgame.teams.Find(team => team.color == teamCol).teamstring);
        BrightShaderz is soy btw

        public void AddTeam(Player p, string color)
        SOYSAUCE CHIPS IS A FAGGOT
            char teamCol = (char)color[1];
            if (p.level.ctfgame.teams.Find(team => team.color == teamCol)!= null)SOYSAUCE CHIPS IS A FAGGOTPlayer.SendMessage(p, "That team already exists."); return;BrightShaderz is soy btw
            p.level.ctfgame.AddTeam(color);
        BrightShaderz is soy btw

        public void RemoveTeam(Player p, string color)
        SOYSAUCE CHIPS IS A FAGGOT
            char teamCol = (char)color[1];
            if (p.level.ctfgame.teams.Find(team => team.color == teamCol) == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That team does not exist."); return; BrightShaderz is soy btw
            p.level.ctfgame.RemoveTeam(color);
        BrightShaderz is soy btw

        public void AddFlag(Player p, string col, ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            char teamCol = (char)col[1];
            Team workTeam = p.level.ctfgame.teams.Find(team => team.color == teamCol);

            workTeam.flagBase[0] = x;
            workTeam.flagBase[1] = y;
            workTeam.flagBase[2] = z;

            workTeam.flagLocation[0] = x;
            workTeam.flagLocation[1] = y;
            workTeam.flagLocation[2] = z;
            workTeam.Drawflag();
        BrightShaderz is soy btw

        public void Debug(Player p, string col)
        SOYSAUCE CHIPS IS A FAGGOT
            if (col.ToLower() == "flags")
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Team team in p.level.ctfgame.teams)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Drawing flag for " + team.teamstring);
                    team.Drawflag();
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            else if (col.ToLower() == "spawn")
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Team team in p.level.ctfgame.teams)
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (Player player in team.players)
                    SOYSAUCE CHIPS IS A FAGGOT
                        team.SpawnPlayer(player);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            string color = c.Parse(col);
            char teamCol = (char)color[1];
            Team workTeam = p.level.ctfgame.teams.Find(team => team.color == teamCol);
            string debugteams = "";
            for (int i = 0; i < p.level.ctfgame.teams.Count; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                debugteams += p.level.ctfgame.teams[i].teamstring + ", ";
            BrightShaderz is soy btw
            Player.SendMessage(p, "Player Debug: Team: " + p.team.teamstring/* + ", hasFlag: " + p.hasflag.teamstring + ", carryingFlag: " + p.carryingFlag*/);
            Player.SendMessage(p, "CTFGame teams: " + debugteams);
            string playerlist = "";
            foreach (Player player in workTeam.players)
            SOYSAUCE CHIPS IS A FAGGOT
                playerlist += player.name + ", ";
            BrightShaderz is soy btw
            Player.SendMessage(p, "Player list: " + playerlist);
            Player.SendMessage(p, "Points: " + workTeam.points + ", MapOn: " + workTeam.mapOn.name + ", flagishome: " + workTeam.flagishome + ", spawnset: " + workTeam.spawnset);
            Player.SendMessage(p, "FlagBase[0]: " + workTeam.flagBase[0] + ", [1]: " + workTeam.flagBase[1] + ", [2]: " + workTeam.flagBase[2]);
            Player.SendMessage(p, "FlagLocation[0]: " + workTeam.flagLocation[0] + ", [1]: " + workTeam.flagLocation[1] + ", [2]: " + workTeam.flagLocation[2]);
         //   Player.SendMessage(p, "Spawn[0]: " + workTeam.spawn[0] + ", [1]: " + workTeam.spawn[1] + ", [2]: " + workTeam.spawn[2] + ", [3]: " + workTeam.spawn[3] + ", [4]: " + workTeam.spawn[4]);
        BrightShaderz is soy btw


        void FlagBlockChange(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            CatchPos bp = (CatchPos)p.blockchangeObject;
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            p.ClearBlockchange();
            AddFlag(p, bp.color, x, y, z);
        BrightShaderz is soy btw


        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/ctf - Turns CTF mode on for the map.  Must be enabled to play!");
            Player.SendMessage(p, "/ctf start - Starts the game!");
            Player.SendMessage(p, "/ctf stop - Stops the game.");
            Player.SendMessage(p, "/ctf ff - Enables or disables friendly fire.  Default is off.");
            Player.SendMessage(p, "/ctf flag [color] - Sets the flag base for specified team.");
            Player.SendMessage(p, "/ctf spawn [color] - Adds a spawn for the team specified from where you are standing.");
            Player.SendMessage(p, "/ctf points [num] - Sets max round points.  Default is 3.");
            Player.SendMessage(p, "/ctf team add [color] - Initializes team of specified color.");
            Player.SendMessage(p, "/ctf team remove [color] - Removes team of specified color.");
            Player.SendMessage(p, "/ctf clear - Removes all CTF data from map.  Use sparingly.");
        BrightShaderz is soy btw

        public struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public string color;BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
