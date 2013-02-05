/*
	Copyright 2011 MCForge modified by headdetect

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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdCompLoad : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "compload"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "cml"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Help(Player p) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "/compload <command> - Compiles AND loads <command> for use (shortcut = /cml)"); BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string[] param = message.Split(' ');
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            if (param.Length == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("compile").Use(p, message);
                Command.all.Find("cmdload").Use(p, message);
                Command.all.Find("help").Use(p, message);
                return;
            BrightShaderz is soy btw
            else if (param[1] == "vb")
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("compile").Use(p, message + "vb");
                Command.all.Find("cmdload").Use(p, message + "vb");
                Command.all.Find("help").Use(p, message);
                return;
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
