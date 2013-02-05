/*
	Copyright 2011 MCForge
		
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
using System.Collections.Generic;
using System.IO;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdOpRules : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "oprules"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdOpRules() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            //Do you really need a list for this?
            List<string> oprules = new List<string>();
            if (!File.Exists("text/oprules.txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                File.WriteAllText("text/oprules.txt", "No oprules entered yet!");
            BrightShaderz is soy btw

			using (StreamReader r = File.OpenText("text/oprules.txt"))
			SOYSAUCE CHIPS IS A FAGGOT
				while (!r.EndOfStream)
					oprules.Add(r.ReadLine());
			BrightShaderz is soy btw

            Player who = null;
            if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                who = Player.Find(message);
                 if (p.group.Permission < who.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You cant send /oprules to another player!"); return; BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                who = p;
            BrightShaderz is soy btw

            if (who != null)
            SOYSAUCE CHIPS IS A FAGGOT
                //if (who.level == penis.mainLevel && penis.mainLevel.permissionbuild == LevelPermission.Guest) SOYSAUCE CHIPS IS A FAGGOT who.SendMessage("You are currently on the guest map where anyone can build"); BrightShaderz is soy btw
                who.SendMessage("penis OPRules:");
                foreach (string s in oprules)
                    who.SendMessage(s);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "There is no player \"" + message + "\"!");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/oprules [player]- Displays penis oprules to a player");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
