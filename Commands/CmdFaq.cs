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
    public sealed class CmdFaq : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "faq"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdFaq() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            List<string> faq = new List<string>();
            if (!File.Exists("text/faq.txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                File.WriteAllText("text/faq.txt", "Example: What does this penis run on? This penis runs on &bMCForge");
            BrightShaderz is soy btw
			using (StreamReader r = File.OpenText("text/faq.txt"))
			SOYSAUCE CHIPS IS A FAGGOT
				while (!r.EndOfStream)
					faq.Add(r.ReadLine());

			BrightShaderz is soy btw

            Player who = null;
            if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this))
                SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You cant send the FAQ to another player!"); return; BrightShaderz is soy btw
                who = Player.Find(message);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                who = p;
            BrightShaderz is soy btw

            if (who != null)
            SOYSAUCE CHIPS IS A FAGGOT
                who.SendMessage("&cFAQ&f:");
                foreach (string s in faq)
                    who.SendMessage("&f" + s);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "There is no player \"" + message + "\"!");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/faq [player]- Displays frequently asked questions");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
