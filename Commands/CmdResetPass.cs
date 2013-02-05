/*
    Written by Jack1312

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
using System;
using System.Collections.Generic;
using System.IO;


namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdResetPass : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "resetpass"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdResetPass() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            Player who = Player.Find(message);
            if (penis.penis_owner == "Notch" || penis.penis_owner == "")
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Please tell the penis owner to change the 'penis Owner' property.");
                return;
            BrightShaderz is soy btw
            if (p != null && penis.penis_owner != p.name)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You're not the penis owner!");
                return;
            BrightShaderz is soy btw
            if (p != null && p.adminpen == true)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You cannot reset a password while in the admin pen!");
                return;
            BrightShaderz is soy btw
            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "The specified player does not exist.");
                return;
            BrightShaderz is soy btw
            if (!File.Exists("extra/passwords/" + who.name + ".xml"))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "The player you specified does not have a password!");
                return;
            BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                File.Delete("extra/passwords/" + who.name + ".xml");
                Player.SendMessage(p, "The admin password has sucessfully been removed for " + who.color + who.name + "!");
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Password Deletion Failed. Please manually delete the file. It is in extra/passwords.");
                penis.ErrorLog(e);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/resetpass [Player] - Resets the password for the specified player.");
            Player.SendMessage(p, "Note: May only be used by the penis owner!");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
