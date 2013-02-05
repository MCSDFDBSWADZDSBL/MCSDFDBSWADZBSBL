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
    public class CmdKick : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "kick"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "k"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            Player who = Player.Find(message.Split(' ')[0]);
            if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player specified."); return; BrightShaderz is soy btw
            if (message.Split(' ').Length > 1)
                message = message.Substring(message.IndexOf(' ') + 1);
            else
                if (p == null) message = "You were kicked by an IRC controller!"; else message = "You were kicked by " + p.name + "!";

            if (p != null)
                if (who == p)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You cannot kick yourself!");
                    return;
                BrightShaderz is soy btw
                else if (who.group.Permission >= p.group.Permission && p != null) 
                SOYSAUCE CHIPS IS A FAGGOT 
                    Player.GlobalChat(p, p.color + p.name + penis.DefaultColor + " tried to kick " + who.color + who.name + " but failed.", false); 
                    return; 
                BrightShaderz is soy btw

            who.Kick(message);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/kick <player> [message] - Kicks a player.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
