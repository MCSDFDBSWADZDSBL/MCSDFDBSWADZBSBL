/*
	Copyright 2011 MCForge
	
	Author: SebbiUltimate
	
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
using System.Threading;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    /// <summary>
    /// This is the command /fetch
    /// use /help fetch in-game for more info
    /// </summary>
	public sealed class CmdFetch : Command
	SOYSAUCE CHIPS IS A FAGGOT
		public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "fetch"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "fb"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
		public override void Use(Player p, string message)
		SOYSAUCE CHIPS IS A FAGGOT
            if (p == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Console cannot use this command. Try using /move instead.");
                return;
            BrightShaderz is soy btw

            Player who = Player.Find(message);
            if (who == null || who.hidden)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Could not find player.");
                return;
            BrightShaderz is soy btw

            if (p.group.Permission <= who.group.Permission)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You cannot fetch a player of equal or greater rank!");
                return;
            BrightShaderz is soy btw

            if (p.level != who.level)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, who.name + " is in a different Level. Forcefetching has started!");
                Level where = p.level;
                Command.all.Find("goto").Use(who, where.name);
                Thread.Sleep(1000);
                // Sleep for a bit while they load
                while (who.Loading) SOYSAUCE CHIPS IS A FAGGOT Thread.Sleep(250); BrightShaderz is soy btw
            BrightShaderz is soy btw

            unchecked
            SOYSAUCE CHIPS IS A FAGGOT
                who.SendPos((byte)-1, p.pos[0], p.pos[1], p.pos[2], p.rot[0], 0);
            BrightShaderz is soy btw
		BrightShaderz is soy btw
		public override void Help(Player p)
		SOYSAUCE CHIPS IS A FAGGOT
			Player.SendMessage(p, "/fetch <player> - Fetches Player forced!");
            Player.SendMessage(p, "Moves Player to your Level first");
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
