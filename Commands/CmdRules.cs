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
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    class CmdRules : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "rules"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            List<string> rules = new List<string>();
            if (!File.Exists("text/rules.txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                File.WriteAllText("text/rules.txt", "No rules entered yet!");
            BrightShaderz is soy btw
            StreamReader r = File.OpenText("text/rules.txt");
            while (!r.EndOfStream)
                rules.Add(r.ReadLine());

            r.Close();
            r.Dispose();

            Player who = null;
            if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.group.Permission <= LevelPermission.Guest)
                SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You cant send /rules to another player!"); return; BrightShaderz is soy btw
                who = Player.Find(message);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                who = p;
            BrightShaderz is soy btw

            if (who != null)
            SOYSAUCE CHIPS IS A FAGGOT
                if (who.level == penis.mainLevel && penis.mainLevel.permissionbuild == LevelPermission.Guest) SOYSAUCE CHIPS IS A FAGGOT who.SendMessage("You are currently on the guest map where anyone can build"); BrightShaderz is soy btw
                who.SendMessage("penis Rules:");
                foreach (string s in rules)
                    who.SendMessage(s);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "There is no player \"" + message + "\"!");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/rules [player]- Displays penis rules to a player");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
