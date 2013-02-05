/*  Copyright 2011 MCForge
		
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
//--------------------------------------------------\\
//the whole of the game 'countdown' was made by edh649\\
//======================================================\\
using System;
using System.Net;
using System.Threading;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdCountdown : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "countdown"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "cd"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "game"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdCountdown() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (p == null)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("'null' or console tried to use /countdown. This command is limited to ingame, sorry!!");
                return;
            BrightShaderz is soy btw

            string[] command = message.ToLower().Split(' ');
            string par0 = String.Empty;
            string par1 = String.Empty;
            string par2 = String.Empty;
            string par3 = String.Empty;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                par0 = command[0];
                par1 = command[1];
                par2 = command[2];
                par3 = command[3];
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

            if (par0 == "help")
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("help").Use(p, "countdown");
                return;
            BrightShaderz is soy btw

            if (par0 == "goto")
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    Command.all.Find("goto").Use(p, "countdown");
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Countdown level not loaded");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            else if (par0 == "join")
            SOYSAUCE CHIPS IS A FAGGOT
                switch (CountdownGame.gamestatus)
                SOYSAUCE CHIPS IS A FAGGOT
                    case CountdownGameStatus.Disabled:
                        Player.SendMessage(p, "Sorry - Countdown isn't enabled yet");
                        return;
                    case CountdownGameStatus.Enabled:
                        if (!CountdownGame.players.Contains(p))
                        SOYSAUCE CHIPS IS A FAGGOT
                            CountdownGame.players.Add(p);
                            Player.SendMessage(p, "You've joined the Countdown game!!");
                            Player.GlobalMessage(p.name + " has joined Countdown!!");
                            if (p.level != CountdownGame.mapon)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "You can type '/countdown goto' to goto the countdown map!!");
                            BrightShaderz is soy btw
                            p.playerofcountdown = true;
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Sorry, you have already joined!!, to leave please type /countdown leave");
                            return;
                        BrightShaderz is soy btw
                        break;
                    case CountdownGameStatus.AboutToStart:
                        Player.SendMessage(p, "Sorry - The game is about to start");
                        return; ;
                    case CountdownGameStatus.InProgress:
                        Player.SendMessage(p, "Sorry - The game is already in progress.");
                        return;
                    case CountdownGameStatus.Finished:
                        Player.SendMessage(p, "Sorry - The game has finished. Get an op to reset it.");
                        return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            else if (par0 == "leave")
            SOYSAUCE CHIPS IS A FAGGOT
                if (CountdownGame.players.Contains(p))
                SOYSAUCE CHIPS IS A FAGGOT
                    switch (CountdownGame.gamestatus)
                    SOYSAUCE CHIPS IS A FAGGOT
                        case CountdownGameStatus.Disabled:
                            Player.SendMessage(p, "Sorry - Countdown isn't enabled yet");
                            return;
                        case CountdownGameStatus.Enabled:
                            CountdownGame.players.Remove(p);
                            CountdownGame.playersleftlist.Remove(p);
                            Player.SendMessage(p, "You've left the game.");
                            p.playerofcountdown = false;
                            break;
                        case CountdownGameStatus.AboutToStart:
                            Player.SendMessage(p, "Sorry - The game is about to start");
                            return; ;
                        case CountdownGameStatus.InProgress:
                            Player.SendMessage(p, "Sorry - you are in a game that is in progress, please wait till its finished or till you've died.");
                            return;
                        case CountdownGameStatus.Finished:
                            CountdownGame.players.Remove(p);
                            if (CountdownGame.playersleftlist.Contains(p))
                            SOYSAUCE CHIPS IS A FAGGOT
                                CountdownGame.playersleftlist.Remove(p);
                            BrightShaderz is soy btw
                            p.playerofcountdown = false;
                            Player.SendMessage(p, "You've left the game.");
                            break;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else if (!(CountdownGame.playersleftlist.Contains(p)) && CountdownGame.players.Contains(p))
                SOYSAUCE CHIPS IS A FAGGOT
                    CountdownGame.players.Remove(p);
                    Player.SendMessage(p, "You've left the game.");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You haven't joined the game yet!!");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            else if (par0 == "players")
            SOYSAUCE CHIPS IS A FAGGOT
                switch (CountdownGame.gamestatus)
                SOYSAUCE CHIPS IS A FAGGOT
                    case CountdownGameStatus.Disabled:
                        Player.SendMessage(p, "The game has not been enabled yet.");
                        return;

                    case CountdownGameStatus.Enabled:
                        Player.SendMessage(p, "Players who have joined:");
                        foreach (Player plya in CountdownGame.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, plya.color + plya.name);
                        BrightShaderz is soy btw
                        break;

                    case CountdownGameStatus.AboutToStart:
                        Player.SendMessage(p, "Players who are about to play:");
                        foreach (Player plya in CountdownGame.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, plya.color + plya.name);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        break;

                    case CountdownGameStatus.InProgress:
                        Player.SendMessage(p, "Players left playing:");
                        foreach (Player plya in CountdownGame.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (CountdownGame.playersleftlist.Contains(plya))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, plya.color + plya.name + penis.DefaultColor + " who is &aIN");
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, plya.color + plya.name + penis.DefaultColor + " who is &cOUT");
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        break;

                    case CountdownGameStatus.Finished:
                        Player.SendMessage(p, "Players who were playing:");
                        foreach (Player plya in CountdownGame.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, plya.color + plya.name);
                        BrightShaderz is soy btw
                        break;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            else if (par0 == "rules")
            SOYSAUCE CHIPS IS A FAGGOT
                if (String.IsNullOrEmpty(par1))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "The aim of the game is to stay alive the longest.");
                    Player.SendMessage(p, "Don't fall in the lava!!");
                    Player.SendMessage(p, "Blocks on the ground will disapear randomly, first going yellow, then orange, then red and finally disappering.");
                    Player.SendMessage(p, "The last person alive will win!!");
                BrightShaderz is soy btw

                else if (par1 == "send")
                SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 1))
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (par2 == "all")
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.GlobalMessage("Countdown Rules being sent to everyone by " + p.color + p.name + ":");
                            Player.GlobalMessage("The aim of the game is to stay alive the longest.");
                            Player.GlobalMessage("Don't fall in the lava!!");
                            Player.GlobalMessage("Blocks on the ground will disapear randomly, first going yellow, then orange, then red and finally disappering.");
                            Player.GlobalMessage("The last person alive will win!!");
                            Player.SendMessage(p, "Countdown rules sent to everyone");
                        BrightShaderz is soy btw
                        else if (par2 == "map")
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.GlobalMessageLevel(p.level, "Countdown Rules being sent to " + p.level.name + " by " + p.color + p.name + ":");
                            Player.GlobalMessageLevel(p.level, "The aim of the game is to stay alive the longest.");
                            Player.GlobalMessageLevel(p.level, "Don't fall in the lava!!");
                            Player.GlobalMessageLevel(p.level, "Blocks on the ground will disapear randomly, first going yellow, then orange, then red and finally disappering.");
                            Player.GlobalMessageLevel(p.level, "The last person alive will win!!");
                            Player.SendMessage(p, "Countdown rules sent to: " + p.level.name);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else if (!String.IsNullOrEmpty(par2))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player who = Player.Find(par2);
                        if (who == null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "That wasn't an online player.");
                            return;
                        BrightShaderz is soy btw
                        else if (who == p)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "You can't send rules to yourself, use '/countdown rules' to send it to your self!!");
                            return;
                        BrightShaderz is soy btw
                        else if (p.group.Permission < who.group.Permission)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "You can't send rules to someone of a higher rank than yourself!!");
                            return;
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(who, "Countdown rules sent to you by " + p.color + p.name);
                            Player.SendMessage(who, "The aim of the game is to stay alive the longest.");
                            Player.SendMessage(who, "Don't fall in the lava!!");
                            Player.SendMessage(who, "Blocks on the ground will disapear randomly, first going yellow, then orange, then red and finally disawhowhoering.");
                            Player.SendMessage(who, "The last person alive will win!!");
                            Player.SendMessage(p, "Countdown rules sent to: " + who.color + who.name);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, par1 + " wasn't a correct parameter.");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            else if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 2))
            SOYSAUCE CHIPS IS A FAGGOT
                if (par0 == "download")
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        using (WebClient WEB = new WebClient())
                        SOYSAUCE CHIPS IS A FAGGOT
                            WEB.DownloadFile("http://db.tt/R0x1MFS", "levels/countdown.lvl");
                            Player.SendMessage(p, "Downloaded map, now loading map and sending you to it.");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    catch
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Sorry, Downloading Failed. PLease try again later");
                        return;
                    BrightShaderz is soy btw
                    Command.all.Find("load").Use(p, "countdown");
                    Command.all.Find("goto").Use(p, "countdown");
                    Thread.Sleep(1000);
                    // Sleep for a bit while they load
                    while (p.Loading) SOYSAUCE CHIPS IS A FAGGOT Thread.Sleep(250); BrightShaderz is soy btw
                    p.level.permissionbuild = LevelPermission.Nobody;
                    p.level.motd = "Welcome to the Countdown map!!!! -hax";
                    ushort x = System.Convert.ToUInt16(8);
                    ushort y = System.Convert.ToUInt16(23);
                    ushort z = System.Convert.ToUInt16(17);
                    x *= 32; x += 16;
                    y *= 32; y += 32;
                    z *= 32; z += 16;
                    unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, x, y, z, p.rot[0], p.rot[1]); BrightShaderz is soy btw
                BrightShaderz is soy btw

                else if (par0 == "enable")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (CountdownGame.gamestatus == CountdownGameStatus.Disabled)
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            Command.all.Find("load").Use(null, "countdown");
                            CountdownGame.mapon = Level.Find("countdown");
                            CountdownGame.gamestatus = CountdownGameStatus.Enabled;
                            Player.GlobalMessage("Countdown has been enabled!!");
                        BrightShaderz is soy btw
                        catch
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Failed, have you downloaded the map yet??");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "A Game is either already enabled or is already progress");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                else if (par0 == "disable")
                SOYSAUCE CHIPS IS A FAGGOT

                    if (CountdownGame.gamestatus == CountdownGameStatus.AboutToStart || CountdownGame.gamestatus == CountdownGameStatus.InProgress)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Sorry, a game is currently in progress - please wait till its finished or use '/countdown cancel' to cancel the game");
                        return;
                    BrightShaderz is soy btw
                    else if (CountdownGame.gamestatus == CountdownGameStatus.Disabled)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Already disabled!!");
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        foreach (Player pl in CountdownGame.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(pl, "The countdown game was disabled.");
                        BrightShaderz is soy btw
                        CountdownGame.gamestatus = CountdownGameStatus.Disabled;
                        CountdownGame.playersleft = 0;
                        CountdownGame.playersleftlist.Clear();
                        CountdownGame.players.Clear();
                        CountdownGame.squaresleft.Clear();
                        CountdownGame.Reset(p, true);
                        Player.SendMessage(p, "Countdown Disabled");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                else if (par0 == "cancel")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (CountdownGame.gamestatus == CountdownGameStatus.AboutToStart || CountdownGame.gamestatus == CountdownGameStatus.InProgress)
                    SOYSAUCE CHIPS IS A FAGGOT
                        CountdownGame.cancel = true;
                        Thread.Sleep(1500);
                        Player.SendMessage(p, "Countdown has been canceled");
                        CountdownGame.gamestatus = CountdownGameStatus.Enabled;
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (CountdownGame.gamestatus == CountdownGameStatus.Disabled)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "The game is disabled!!");
                            return;
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            foreach (Player pl in CountdownGame.players)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(pl, "The countdown game was canceled");
                            BrightShaderz is soy btw
                            CountdownGame.gamestatus = CountdownGameStatus.Enabled;
                            CountdownGame.playersleft = 0;
                            CountdownGame.playersleftlist.Clear();
                            CountdownGame.players.Clear();
                            CountdownGame.squaresleft.Clear();
                            CountdownGame.Reset(null, true);
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                else if (par0 == "start" || par0 == "play")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (CountdownGame.gamestatus == CountdownGameStatus.Enabled)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (CountdownGame.players.Count >= 2)
                        SOYSAUCE CHIPS IS A FAGGOT
                            CountdownGame.playersleftlist = CountdownGame.players;
                            CountdownGame.playersleft = CountdownGame.players.Count;
                            switch (par1)
                            SOYSAUCE CHIPS IS A FAGGOT
                                case "slow":
                                    CountdownGame.speed = 800;
                                    CountdownGame.speedtype = "slow";
                                    break;

                                case "normal":
                                    CountdownGame.speed = 650;
                                    CountdownGame.speedtype = "normal";
                                    break;

                                case "fast":
                                    CountdownGame.speed = 500;
                                    CountdownGame.speedtype = "fast";
                                    break;

                                case "extreme":
                                    CountdownGame.speed = 300;
                                    CountdownGame.speedtype = "extreme";
                                    break;

                                case "ultimate":
                                    CountdownGame.speed = 150;
                                    CountdownGame.speedtype = "ultimate";
                                    break;

                                default:
                                    p.SendMessage("You didn't specify a speed, resorting to 'normal'");
                                    goto case "normal"; //More efficient
                            BrightShaderz is soy btw
                            if (par2 == null || par2.Trim() == "")
                            SOYSAUCE CHIPS IS A FAGGOT
                                CountdownGame.freezemode = false;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (par2 == "freeze" || par2 == "frozen")
                                SOYSAUCE CHIPS IS A FAGGOT
                                    CountdownGame.freezemode = true;
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    CountdownGame.freezemode = false;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            CountdownGame.GameStart(p);
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Sorry, there aren't enough players to play.");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Either a game is already in progress or it hasn't been enabled");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                else if (par0 == "reset")
                SOYSAUCE CHIPS IS A FAGGOT
                    switch (CountdownGame.gamestatus)
                    SOYSAUCE CHIPS IS A FAGGOT
                        case CountdownGameStatus.Disabled:
                            Player.SendMessage(p, "Please enable countdown first.");
                            return;
                        case CountdownGameStatus.AboutToStart:
                            Player.SendMessage(p, "Sorry - The game is about to start");
                            return;
                        case CountdownGameStatus.InProgress:
                            Player.SendMessage(p, "Sorry - The game is already in progress.");
                            return;
                        default:
                            Player.SendMessage(p, "Reseting");
                            if (par1 == "map")
                            SOYSAUCE CHIPS IS A FAGGOT
                                CountdownGame.Reset(p, false);
                            BrightShaderz is soy btw
                            else if (par1 == "all")
                            SOYSAUCE CHIPS IS A FAGGOT
                                CountdownGame.Reset(p, true);
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "Please specify whether it is 'map' or 'all'");
                                return;
                            BrightShaderz is soy btw
                            break;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                else if (par0 == "tutorial")
                SOYSAUCE CHIPS IS A FAGGOT
                    p.SendMessage("First, download the map using /countdown download");
                    p.SendMessage("Next, type /countdown enable to enable the game mode");
                    p.SendMessage("Next, type /countdown join to join the game and tell other players to join aswell");
                    p.SendMessage("When some people have joined, type /countdown start [speed] to start it");
                    p.SendMessage("[speed] can be 'ultimate', 'extreme', 'fast', 'normal' or 'slow'");
                    p.SendMessage("When you are done, type /countdown reset [map/all]");
                    p.SendMessage("use map to reset only the map and all to reset everything.");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                p.SendMessage("Sorry, you aren't a high enough rank or that wasn't a correct command addition.");
                return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            p.SendMessage("/cd - Command shortcut.");
            p.SendMessage("/countdown join - join the game");
            p.SendMessage("/countdown leave - leave the game");
            p.SendMessage("/countdown goto - goto the countdown map");
            p.SendMessage("/countdown players - view players currently playing");
            SOYSAUCE CHIPS IS A FAGGOT
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 1))
                SOYSAUCE CHIPS IS A FAGGOT
                    p.SendMessage("/countdown rules <send> <all/map/player> - the rules of countdown. with send: all to send to all, map to send to map and have a players name to send to a player");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.SendMessage("/countdown rules - view the rules of countdown");
                BrightShaderz is soy btw
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 2))
                SOYSAUCE CHIPS IS A FAGGOT
                    p.SendMessage("/countdown download - download the countdown map");
                    p.SendMessage("/countdown enable - enable the game");
                    p.SendMessage("/countdown disable - disable the game");
                    p.SendMessage("/countdown cancel - cancels a game");
                    p.SendMessage("/countdown start [speed] [mode] - start the game, speeds are 'slow', 'normal', 'fast', 'extreme' and 'ultimate', modes are 'normal' and 'freeze'");
                    p.SendMessage("/countdown reset [all/map] - reset the whole game (all) or only the map (map)");
                    p.SendMessage("/countdown tutorial - a tutorial on how to setup countdown");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
