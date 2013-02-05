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
using System.Collections.Generic;
using System.Text;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    class CmdAfk : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "afk"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message != "list")
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.joker)
                SOYSAUCE CHIPS IS A FAGGOT
                    message = "";
                BrightShaderz is soy btw
                if (!penis.afkset.Contains(p.name))
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.afkset.Add(p.name);
                    if (p.muted)
                    SOYSAUCE CHIPS IS A FAGGOT
                        message = "";
                    BrightShaderz is soy btw
                    Player.GlobalMessage("-" + p.color + p.name + penis.DefaultColor + "- is AFK " + message);
                    IRCBot.Say(p.name + " is AFK " + message);
                    return;

                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.afkset.Remove(p.name);
                    Player.GlobalMessage("-" + p.color + p.name + penis.DefaultColor + "- is no longer AFK");
                    IRCBot.Say(p.name + " is no longer AFK");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (string s in penis.afkset) Player.SendMessage(p, s);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/afk <reason> - mark yourself as AFK. Use again to mark yourself as back");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
