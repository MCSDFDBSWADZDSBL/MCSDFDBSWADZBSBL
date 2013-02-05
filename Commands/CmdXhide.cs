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
using System.IO;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdXhide : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "xhide"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "This command can only be used in-game!"); return; BrightShaderz is soy btw
            if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (p.possess != "")
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Stop your current possession first.");
                return;
            BrightShaderz is soy btw
            p.hidden = !p.hidden;
            if (p.hidden)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalDie(p, true);
                Player.GlobalChat(p, "&c- " + p.color + p.prefix + p.name + penis.DefaultColor + " " + (File.Exists("text/logout/" + p.name + ".txt") ? File.ReadAllText("text/logout/" + p.name + ".txt") : "Disconnected."), false);
                penis.IRC.Say(p.name + " left the game (Disconnected.)");

            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalSpawn(p, p.pos[0], p.pos[1], p.pos[2], p.rot[0], p.rot[1], false, "");
                Player.GlobalChat(p, "&a+ " + p.color + p.prefix + p.name + penis.DefaultColor + " " + (File.Exists("text/login/" + p.name + ".txt") ? File.ReadAllText("text/login/" + p.name + ".txt") : "joined the game."), false);
                penis.IRC.Say(p.name + " joined the game");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/xhide - like /hide, only it doesn't send a message to ops.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw

