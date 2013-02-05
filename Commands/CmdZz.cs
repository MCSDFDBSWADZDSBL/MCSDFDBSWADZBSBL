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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
	public sealed class CmdZz : Command
	SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "zz"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
		public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw
		public override void Use(Player p, string message)
		SOYSAUCE CHIPS IS A FAGGOT
            if ((p.group.CanExecute(Command.all.Find("cuboid"))) && (p.group.CanExecute(Command.all.Find("static"))))
            SOYSAUCE CHIPS IS A FAGGOT
                if ((!p.staticCommands == true) && (!p.megaBoid == true))
                SOYSAUCE CHIPS IS A FAGGOT
                    Command.all.Find("static").Use(p, "");
                    Command.all.Find("cuboid").Use(p, message);
                    Player.SendMessage(p, p.color + p.name + penis.DefaultColor + " to stop this, use /zz again");
                BrightShaderz is soy btw
                else 
                SOYSAUCE CHIPS IS A FAGGOT
                    p.ClearBlockchange();
                    p.staticCommands = false;
                    Player.SendMessage(p, "/zz has ended.");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Sorry, your rank cannot use one of the commands this uses!"); BrightShaderz is soy btw
               
		BrightShaderz is soy btw
		public override void Help(Player p)
		SOYSAUCE CHIPS IS A FAGGOT
			Player.SendMessage(p, "/zz - Like cuboid but in static mode automatically.");
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
