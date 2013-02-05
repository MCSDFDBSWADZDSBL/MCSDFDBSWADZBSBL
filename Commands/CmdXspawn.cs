/*
	Copyright 2011 MCForge
	
	Written by jordanneil23
		
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

namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
	public class CmdXspawn : Command
	SOYSAUCE CHIPS IS A FAGGOT
    	public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "xspawn"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
		public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            Player player = Player.Find(message.Split(' ')[0]);
            if (player == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Error: " + player.color + player.name + penis.DefaultColor + " was not found");
                return;
            BrightShaderz is soy btw
            if (player == p)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Error: Seriously? Just use /spawn!");
                return;
            BrightShaderz is soy btw
            if (player.group.Permission > p.group.Permission)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Cannot move someone of greater rank");
                return;
            BrightShaderz is soy btw
            Command.all.Find("spawn").Use(player, "");
            Player.SendMessage(p, "Succesfully spawned " + player.color + player.name + penis.DefaultColor + ".");
            Player.GlobalMessage(player.color + player.name + penis.DefaultColor + " was respawned by " + p.color + p.name + penis.DefaultColor + ".");
        BrightShaderz is soy btw
		public override void Help(Player p)
		SOYSAUCE CHIPS IS A FAGGOT
			Player.SendMessage(p, "/xspawn - Spawn another player.");
            Player.SendMessage(p, "WARNING: It says who used it!");
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
