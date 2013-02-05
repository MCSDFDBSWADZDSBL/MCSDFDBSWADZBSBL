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

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdAwardMod : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "awardmod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "" || message.IndexOf(' ') == -1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            bool add = true;
            if (message.Split(' ')[0].ToLower() == "add")
            SOYSAUCE CHIPS IS A FAGGOT
                message = message.Substring(message.IndexOf(' ') + 1);
            BrightShaderz is soy btw
            else if (message.Split(' ')[0].ToLower() == "del")
            SOYSAUCE CHIPS IS A FAGGOT
                add = false;
                message = message.Substring(message.IndexOf(' ') + 1);
            BrightShaderz is soy btw

            if (add)
            SOYSAUCE CHIPS IS A FAGGOT
                if (message.IndexOf(":") == -1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "&cMissing a colon!"); Help(p); return; BrightShaderz is soy btw
                string awardName = message.Split(':')[0].Trim();
                string description = message.Split(':')[1].Trim();

                if (!Awards.addAward(awardName, description))
                    Player.SendMessage(p, "This award already exists!");
                else
                    Player.GlobalChat(p, "Award added: &6" + awardName + " : " + description, false);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (!Awards.removeAward(message))
                    Player.SendMessage(p, "This award doesn't exists!");
                else
                    Player.GlobalChat(p, "Award removed: &6" + message, false);
            BrightShaderz is soy btw

            Awards.Save();
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/awardmod <add/del> [award name] : [description]");
            Player.SendMessage(p, "Adds or deletes a reward with the name [award name]");
            Player.SendMessage(p, "&b/awardmod add Bomb joy : Bomb lots of people" + penis.DefaultColor + " is an example");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
