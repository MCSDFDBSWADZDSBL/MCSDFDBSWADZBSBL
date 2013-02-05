/*
 * Written By Jack1312

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
	permissions and limitations under the Licenses  
*/
using System.IO;

namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdAgree : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "agree"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdAgree() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.agreetorulesonentry == false)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "This command can only be used if agree-to-rules-on-entry is enabled!");
                return;
            BrightShaderz is soy btw
            if (p == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "This command can only be used in-game");
                return;
            BrightShaderz is soy btw
            //If someone is ranked before agreeing to the rules they are locked and cannot use any commands unless demoted back to guest
            /*if (p.group.Permission > LevelPermission.Guest)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Your rank is higher than guest and you have already agreed to the rules!");
                return;
            BrightShaderz is soy btw*/
            var agreed = File.ReadAllText("ranks/agreed.txt");
            /*
            if (File.Exists("logs/" + DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd") + ".txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                var checklogs = File.ReadAllText("logs/" + DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd") + ".txt");
                if (!checklogs.Contains(p.name.ToLower() + " used /rules"))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "&9You must read /rules before agreeing!");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw*/
            if (p.hasreadrules == false)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "&9You must read /rules before agreeing!");
                return;
            BrightShaderz is soy btw
            if ((agreed+" ").Contains(" " + p.name.ToLower() + " ")) //Edited to prevent inner names from working.
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You have already agreed to the rules!");
                return;
            BrightShaderz is soy btw
            p.agreed = true;
            Player.SendMessage(p, "Thank you for agreeing to follow the rules. You may now build and use commands!");
            string playerspath = "ranks/agreed.txt";
            if (File.Exists(playerspath))
            SOYSAUCE CHIPS IS A FAGGOT 
                //We don't want player "test" to have already agreed if "nate" and "stew" agrred.
                // the preveious one, though, would put "natesteve" which also allows test
                //There is a better way, namely regular expressions, but I'll worry about that later.
                File.AppendAllText(playerspath, " " + p.name.ToLower());  //Ensures every name is seperated by a space.
            BrightShaderz is soy btw
        
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/agree - Agree to the rules when entering the penis");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
