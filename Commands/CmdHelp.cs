/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCSong) Licensed under the
	Educational Community License, Version 2.0 (the "License"); you may
	not use this file except in compliance with the License. You may
	obtain a copy of the License at
	
	http://www.osedu.org/licenses/ECL-2.0
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the License is distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the License for the specific language governing
	permissions and limitations under the License.
*/
using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdHelp : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "help"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                message.ToLower();
                switch (message)
                SOYSAUCE CHIPS IS A FAGGOT
                    case "":
                        if (penis.oldHelp)
                        SOYSAUCE CHIPS IS A FAGGOT
                            goto case "old";
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Use &b/help ranks" + penis.DefaultColor + " for a list of ranks.");
                            Player.SendMessage(p, "Use &b/help colors" + penis.DefaultColor + " for a list of color codes.");
                            Player.SendMessage(p, "Use &b/help build" + penis.DefaultColor + " for a list of building commands.");
                            Player.SendMessage(p, "Use &b/help mod" + penis.DefaultColor + " for a list of moderation commands.");
                            Player.SendMessage(p, "Use &b/help information" + penis.DefaultColor + " for a list of information commands.");
                            Player.SendMessage(p, "Use &b/help homes" + penis.DefaultColor + " for a list of home commands.");
                            Player.SendMessage(p, "Use &b/help other" + penis.DefaultColor + " for a list of other commands.");
                            Player.SendMessage(p, "Use &b/help short" + penis.DefaultColor + " for a list of shortcuts.");
                            Player.SendMessage(p, "Use &b/help old" + penis.DefaultColor + " to view the Old help menu.");
                            Player.SendMessage(p, "Use &b/help [command] or /help [block] " + penis.DefaultColor + "to view more info.");
                        BrightShaderz is soy btw break;
                    case "ranks":
                        message = "";
                        foreach (Group grp in Group.GroupList)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (grp.name != "nobody")
                                Player.SendMessage(p, grp.color + grp.name + " - &bCommand limit: " + grp.maxBlocks + " - &cPermission: " + (int)grp.Permission);
                        BrightShaderz is soy btw
                        break;
                    case "colors":
                        Player.SendMessage(p, "&0%0 &f- &0Black");
                        Player.SendMessage(p, "&1%1 &f- &1Navy");
                        Player.SendMessage(p, "&2%2 &f- &2Green");
                        Player.SendMessage(p, "&3%3 &f- &3Teal");
                        Player.SendMessage(p, "&4%4 &f- &4Maroon");
                        Player.SendMessage(p, "&5%5 &f- &5Purple");
                        Player.SendMessage(p, "&6%6 &f- &6Gold");
                        Player.SendMessage(p, "&7%7 &f- &7Silver");
                        Player.SendMessage(p, "&8%8 &f- &8Gray");
                        Player.SendMessage(p, "&9%9 &f- &9Blue");
                        Player.SendMessage(p, "&a%a &f- &aLime");
                        Player.SendMessage(p, "&b%b &f- &bAqua");
                        Player.SendMessage(p, "&c%c &f- &cRed");
                        Player.SendMessage(p, "&d%d &f- &dPink");
                        Player.SendMessage(p, "&e%e &f- &eYellow");
                        Player.SendMessage(p, "&f%f - White");
                        break;
                    case "build":
                        message = "";
                        foreach (Command comm in Command.all.commands)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p == null || p.group.commands.All().Contains(comm))
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (comm.type.Contains("build")) message += ", " + getColor(comm.name) + comm.name;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        if (message == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No commands of this type are available to you."); break; BrightShaderz is soy btw
                        Player.SendMessage(p, "Building commands you may use:");
                        Player.SendMessage(p, message.Remove(0, 2) + ".");
                        break;
                    case "mod": case "moderation":
                        message = "";
                        foreach (Command comm in Command.all.commands)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p == null || p.group.commands.All().Contains(comm))
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (comm.type.Contains("mod")) message += ", " + getColor(comm.name) + comm.name;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        if (message == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No commands of this type are available to you."); break; BrightShaderz is soy btw
                        Player.SendMessage(p, "Moderation commands you may use:");
                        Player.SendMessage(p, message.Remove(0, 2) + ".");
                        break;
                    case "information":
                        message = "";
                        foreach (Command comm in Command.all.commands)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p == null || p.group.commands.All().Contains(comm))
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (comm.type.Contains("info")) message += ", " + getColor(comm.name) + comm.name;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        if (message == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No commands of this type are available to you."); break; BrightShaderz is soy btw
                        Player.SendMessage(p, "Information commands you may use:");
                        Player.SendMessage(p, message.Remove(0, 2) + ".");
                        break;
                    case "homes":
                        message = "";
                        foreach (Command comm in Command.all.commands)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p == null || p.group.commands.All().Contains(comm))
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (comm.type.Contains("home")) message += ", " + getColor(comm.name) + comm.name;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        if (message == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No commands of this type are available to you."); break; BrightShaderz is soy btw
                        Player.SendMessage(p, "Home commands you may use:");
                        Player.SendMessage(p, message.Remove(0, 2) + ".");
                        break;
                    case "other":
                        message = "";
                        foreach (Command comm in Command.all.commands)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p == null || p.group.commands.All().Contains(comm))
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (comm.type.Contains("other")) message += ", " + getColor(comm.name) + comm.name;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        if (message == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No commands of this type are available to you."); break; BrightShaderz is soy btw
                        Player.SendMessage(p, "Other commands you may use:");
                        Player.SendMessage(p, message.Remove(0, 2) + ".");
                        break;
                    case "short":
                        message = "";
                        foreach (Command comm in Command.all.commands)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p == null || p.group.commands.All().Contains(comm))
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (comm.shortcut != "") message += ", &b" + comm.shortcut + " " + penis.DefaultColor + "[" + comm.name + "]";
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        Player.SendMessage(p, "Available shortcuts:");
                        Player.SendMessage(p, message.Remove(0, 2) + ".");
                        break;
                    case "old":
                        string commandsFound = "";
                        foreach (Command comm in Command.all.commands)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p == null || p.group.commands.All().Contains(comm))
                            SOYSAUCE CHIPS IS A FAGGOT
                                try SOYSAUCE CHIPS IS A FAGGOT commandsFound += ", " + comm.name; BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        Player.SendMessage(p, "Available commands:");
                        Player.SendMessage(p, commandsFound.Remove(0, 2));
                        Player.SendMessage(p, "Type \"/help <command>\" for more help.");
                        Player.SendMessage(p, "Type \"/help shortcuts\" for shortcuts.");
                        break;
                    default:
                        Command cmd = Command.all.Find(message);
                        if (cmd != null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            cmd.Help(p);
                            string foundRank = Level.PermissionToName(GrpCommands.allowedCommands.Find(grpComm => grpComm.commandName == cmd.name).lowestRank);
                            Player.SendMessage(p, "Rank needed: " + getColor(cmd.name) + foundRank);
                            return;
                        BrightShaderz is soy btw
                        byte b = Block.Byte(message);
                        if (b != Block.Zero)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Block \"" + message + "\" appears as &b" + Block.Name(Block.Convert(b)));
                            string foundRank = Level.PermissionToName(Block.BlockList.Find(bs => bs.type == b).lowestRank);
                            Player.SendMessage(p, "Rank needed: " + foundRank);
                            return;
                        BrightShaderz is soy btw
                        Player.SendMessage(p, "Could not find command or block specified.");
                        break;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); Player.SendMessage(p, "An error occured"); BrightShaderz is soy btw
        BrightShaderz is soy btw

        private string getColor(string commName)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (GrpCommands.rankAllowance aV in GrpCommands.allowedCommands)
            SOYSAUCE CHIPS IS A FAGGOT
                if (aV.commandName == commName)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Group.findPerm(aV.lowestRank) != null)
                        return Group.findPerm(aV.lowestRank).color;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            return "&f";
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "...really? Wow. Just...wow.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
