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
using System.IO;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdCopyLVL : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "copylvl"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdCopyLVL() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string msg1 = String.Empty;
            string msg2 = String.Empty;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                msg1 = message.Split(' ')[0];
                msg2 = message.Split(' ')[1];
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
              
            if (!p.group.CanExecute(Command.all.Find("newlvl")))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You cannot use this command, unless you can use /newlvl!");
                return;
            BrightShaderz is soy btw
            int number = message.Split(' ').Length;
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw
            if (number < 2)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You did not specify the level it would be copied to as!");
                return;
            BrightShaderz is soy btw
            try SOYSAUCE CHIPS IS A FAGGOT
                File.Copy("levels/" + msg1 + ".lvl", "levels/" + msg2 + ".lvl");
                File.Copy("levels/level properties/" + msg1 + ".properties", "levels/level properties/" + msg1 + ".properties", false);

            BrightShaderz is soy btw catch (System.IO.FileNotFoundException) SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, msg2 + " does not exist!");
                return;

            BrightShaderz is soy btw catch (System.IO.IOException) SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "The level, &c" + msg2 + " &e already exists!");
                return;

            BrightShaderz is soy btw catch (System.ArgumentException) SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "One or both level names are either invalid, or corrupt.");
                return;

            BrightShaderz is soy btw
            Player.SendMessage(p, "The level, &c" + msg1 + " &ehas been copied to &c" + msg2 + "!");
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/copylvl [Level] [Copied Level] - Makes a copy of [Level] called [Copied Level].");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
