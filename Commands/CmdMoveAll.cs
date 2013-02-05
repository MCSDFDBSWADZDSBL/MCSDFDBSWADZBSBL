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
    public sealed class CmdMoveAll : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "moveall"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ma"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            Level level = Level.Find(message.Split(' ')[0]);
            if (level == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no level named '" + message.Split(' ')[0] + "'."); return; BrightShaderz is soy btw
            if (p == null)
                foreach (Player pl in Player.players) SOYSAUCE CHIPS IS A FAGGOT Command.all.Find("move").Use(null, pl.name + " " + level.name); BrightShaderz is soy btw
            else
                foreach (Player pl in Player.players) SOYSAUCE CHIPS IS A FAGGOT if (pl.group.Permission < p.group.Permission) Command.all.Find("move").Use(p, pl.name + " " + level.name); else Player.SendMessage(p, "You cannot move " + pl.color + pl.name + penis.DefaultColor + " because they are of equal or higher rank"); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "/moveall <level> - Moves all players to the level specified."); BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
