/*
    Copyright 2011 MCForge
        
    Dual-licensed under the    Educational Community License, Version 2.0 and
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
using System.Data;
using MCForge.SQL;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
	public sealed class CmdSeen : Command
	SOYSAUCE CHIPS IS A FAGGOT
		public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "seen"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
		public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
		public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
		public CmdSeen() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

		public override void Use(Player p, string message)
		SOYSAUCE CHIPS IS A FAGGOT
            if(message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

			Player pl = Player.Find(message);
			if (pl != null && !pl.hidden)
			SOYSAUCE CHIPS IS A FAGGOT
				Player.SendMessage(p, pl.color + pl.name + penis.DefaultColor + " is currently online.");
				return;
			BrightShaderz is soy btw

            Database.AddParams("@Name", message);
			using (DataTable playerDb = Database.fillData("SELECT * FROM Players WHERE Name=@Name"))
			SOYSAUCE CHIPS IS A FAGGOT
				if (playerDb.Rows != null && playerDb.Rows.Count > 0)
					Player.SendMessage(p, message + " was last seen: " + playerDb.Rows[0]["LastLogin"]);
				else
					Player.SendMessage(p, "Unable to find player");
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		public override void Help(Player p)
		SOYSAUCE CHIPS IS A FAGGOT
			Player.SendMessage(p, "/seen [player] - says when a player was last seen on the penis");
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
