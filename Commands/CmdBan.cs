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
    public class CmdBan : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ban"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

                bool stealth = false; bool totalBan = false;
                if (message[0] == '#')
                SOYSAUCE CHIPS IS A FAGGOT
                    message = message.Remove(0, 1).Trim();
                    stealth = true;
                    penis.s.Log("Stealth Ban Attempted");
                BrightShaderz is soy btw
                else if (message[0] == '@')
                SOYSAUCE CHIPS IS A FAGGOT
                    totalBan = true;
                    message = message.Remove(0, 1).Trim();
                BrightShaderz is soy btw

                Player who = Player.Find(message);

                if (who == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!Player.ValidName(message))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Invalid name \"" + message + "\".");
                        return;
                    BrightShaderz is soy btw

                    Group foundGroup = Group.findPlayerGroup(message);

                    if (foundGroup.Permission >= LevelPermission.Operator)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "You can't ban a " + foundGroup.name + "!");
                        return;
                    BrightShaderz is soy btw
                    if (foundGroup.Permission == LevelPermission.Banned)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, message + " is already banned.");
                        return;
                    BrightShaderz is soy btw

                    foundGroup.playerList.Remove(message);
                    foundGroup.playerList.Save();

                    Player.GlobalMessage(message + " &f(offline)" + penis.DefaultColor + " is now &8banned" + penis.DefaultColor + "!");
                    Group.findPerm(LevelPermission.Banned).playerList.Add(message);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!Player.ValidName(who.name))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Invalid name \"" + who.name + "\".");
                        return;
                    BrightShaderz is soy btw

                    if (who.group.Permission >= LevelPermission.Operator)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "You can't ban a " + who.group.name + "!");
                        return;
                    BrightShaderz is soy btw
                    if (who.group.Permission == LevelPermission.Banned)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, message + " is already banned.");
                        return;
                    BrightShaderz is soy btw

                    who.group.playerList.Remove(message);
                    who.group.playerList.Save();

                    if (stealth) Player.GlobalMessageOps(who.color + who.name + penis.DefaultColor + " is now STEALTH &8banned" + penis.DefaultColor + "!");
                    else Player.GlobalChat(who, who.color + who.name + penis.DefaultColor + " is now &8banned" + penis.DefaultColor + "!", false);

                    who.group = Group.findPerm(LevelPermission.Banned);
                    who.color = who.group.color;
                    Player.GlobalDie(who, false);
                    Player.GlobalSpawn(who, who.pos[0], who.pos[1], who.pos[2], who.rot[0], who.rot[1], false);
                    Group.findPerm(LevelPermission.Banned).playerList.Add(who.name);
                BrightShaderz is soy btw
                Group.findPerm(LevelPermission.Banned).playerList.Save();

                IRCBot.Say(message + " was banned.");
                penis.s.Log("BANNED: " + message.ToLower());

                if (totalBan == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    Command.all.Find("undo").Use(p, message + " 0");
                    Command.all.Find("banip").Use(p, "@ " + message);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/ban <player> - Bans a player without kicking him.");
            Player.SendMessage(p, "Add # before name to stealth ban.");
            Player.SendMessage(p, "Add @ before name to total ban.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
