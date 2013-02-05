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
    public class CmdMe : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "me"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You"); return; BrightShaderz is soy btw

            if (p.muted) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You are currently muted and cannot use this command."); return; BrightShaderz is soy btw
            if (penis.chatmod && !p.voice) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Chat moderation is on, you cannot emote."); return; BrightShaderz is soy btw

            if (penis.worldChat)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalChat(p, p.color + "*" + p.name + " " + message, false);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalChatLevel(p, p.color + "*" + p.name + " " + message, false);
            BrightShaderz is soy btw
            IRCBot.Say("*" + p.name + " " + message);


        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "What do you need help with, m'boy?! Are you stuck down a well?!");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
