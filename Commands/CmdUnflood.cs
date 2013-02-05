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
using System;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdUnflood : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "unflood"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Help(Player p) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "/unflood [liquid] - Unfloods the map you are on of [liquid]"); BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "This command can only be used in-game!"); return; BrightShaderz is soy btw
            if (String.IsNullOrEmpty(message)) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message.ToLower() != "all" && Block.Byte(message) == Block.Zero) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no block \"" + message + "\"."); return; BrightShaderz is soy btw
            int phys = p.level.physics;
            Command.all.Find("physics").Use(p, "0");
            if (!p.level.Instant)
                Command.all.Find("map").Use(p, "instant");

            if (message.ToLower() == "all")
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("replaceall").Use(p, "lavafall air");
                Command.all.Find("replaceall").Use(p, "waterfall air");
                Command.all.Find("replaceall").Use(p, "lava_fast air");
                Command.all.Find("replaceall").Use(p, "active_lava air");
                Command.all.Find("replaceall").Use(p, "active_water air");
                Command.all.Find("replaceall").Use(p, "active_hot_lava air");
                Command.all.Find("replaceall").Use(p, "active_cold_water air");
                Command.all.Find("replaceall").Use(p, "fast_hot_lava air");
                Command.all.Find("replaceall").Use(p, "magma air");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("replaceall").Use(p, message + " air");
            BrightShaderz is soy btw

            if (p.level.Instant)
                Command.all.Find("map").Use(p, "instant");
            Command.all.Find("reveal").Use(p, "all");
            Command.all.Find("physics").Use(p, phys.ToString());
            Player.GlobalMessage("Unflooded!");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
