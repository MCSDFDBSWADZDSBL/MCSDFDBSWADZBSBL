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
    public class CmdUnban : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "unban"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            bool totalUnban = false;
            if (message[0] == '@')
            SOYSAUCE CHIPS IS A FAGGOT
                totalUnban = true;
                message = message.Remove(0, 1).Trim();
            BrightShaderz is soy btw

            Player who = Player.Find(message);

            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                if (Group.findPlayerGroup(message) != Group.findPerm(LevelPermission.Banned))
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (penis.TempBan tban in penis.tempBans)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (tban.name.ToLower() == message.ToLower())
                        SOYSAUCE CHIPS IS A FAGGOT
                            penis.tempBans.Remove(tban);
                            Player.GlobalMessage(message + " has had their temporary ban lifted.");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "Player is not banned.");
                    return;
                BrightShaderz is soy btw
                Player.GlobalMessage(message + " &8(banned)" + penis.DefaultColor + " is now " + Group.standard.color + Group.standard.name + penis.DefaultColor + "!");
                Group.findPerm(LevelPermission.Banned).playerList.Remove(message);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (Group.findPlayerGroup(message) != Group.findPerm(LevelPermission.Banned))
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (penis.TempBan tban in penis.tempBans)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (tban.name == who.name)
                        SOYSAUCE CHIPS IS A FAGGOT
                            penis.tempBans.Remove(tban);
                            Player.GlobalMessage(who.color + who.prefix + who.name + penis.DefaultColor + "has had their temporary ban lifted.");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "Player is not banned.");
                    return;
                BrightShaderz is soy btw
                Player.GlobalChat(who, who.color + who.prefix + who.name + penis.DefaultColor + " is now " + Group.standard.color + Group.standard.name + penis.DefaultColor + "!", false);
                who.group = Group.standard; who.color = who.group.color; Player.GlobalDie(who, false);
                Player.GlobalSpawn(who, who.pos[0], who.pos[1], who.pos[2], who.rot[0], who.rot[1], false);
                Group.findPerm(LevelPermission.Banned).playerList.Remove(message);
            BrightShaderz is soy btw

            Group.findPerm(LevelPermission.Banned).playerList.Save(); 
            if (totalUnban)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("unbanip").Use(p, "@" + message);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/unban <player> - Unbans a player.  This includes temporary bans.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
