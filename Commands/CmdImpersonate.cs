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
    public sealed class CmdImpersonate : Command
	SOYSAUCE CHIPS IS A FAGGOT
		public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
		public override void Help(Player p) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "/impersonate <player> <message> - Sends a message as if it came from <player>"); BrightShaderz is soy btw
		public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "impersonate"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "imp"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
		public void SendIt(Player p, string message, Player player)
		SOYSAUCE CHIPS IS A FAGGOT
			if (message.Split(' ').Length > 1)
			SOYSAUCE CHIPS IS A FAGGOT
				if (player != null)
				SOYSAUCE CHIPS IS A FAGGOT
					message = message.Substring(message.IndexOf(' ') + 1);
					//Player.GlobalMessage(player.color + player.voicestring + player.color + player.prefix + player.name + ": &f" + message);
					Player.GlobalChat(player, message);
				BrightShaderz is soy btw
				else
				SOYSAUCE CHIPS IS A FAGGOT
					string playerName = message.Split(' ')[0];
					message = message.Substring(message.IndexOf(' ') + 1);
					Player.GlobalMessage(playerName + ": &f" + message);
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No message was given."); BrightShaderz is soy btw
		BrightShaderz is soy btw
		public override void Use(Player p, string message)
		SOYSAUCE CHIPS IS A FAGGOT
			if ((message == "")) SOYSAUCE CHIPS IS A FAGGOT this.Help(p); BrightShaderz is soy btw
			else
			SOYSAUCE CHIPS IS A FAGGOT
				Player player = Player.Find(message.Split(' ')[0]);
				if (player != null)
				SOYSAUCE CHIPS IS A FAGGOT
					if (p == null) SOYSAUCE CHIPS IS A FAGGOT this.SendIt(p, message, player); BrightShaderz is soy btw
					else
					SOYSAUCE CHIPS IS A FAGGOT
						if (player == p) SOYSAUCE CHIPS IS A FAGGOT this.SendIt(p, message, player); BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							if (p.group.Permission > player.group.Permission) SOYSAUCE CHIPS IS A FAGGOT this.SendIt(p, message, player); BrightShaderz is soy btw
							else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You cannot impersonate a player of equal or greater rank."); BrightShaderz is soy btw
						BrightShaderz is soy btw
					BrightShaderz is soy btw
				BrightShaderz is soy btw
				else
				SOYSAUCE CHIPS IS A FAGGOT
					if (p != null)
					SOYSAUCE CHIPS IS A FAGGOT
						if (p.group.Permission >= LevelPermission.Admin)
						SOYSAUCE CHIPS IS A FAGGOT
							if (Group.findPlayerGroup(message.Split(' ')[0]).Permission < p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT this.SendIt(p, message, null); BrightShaderz is soy btw
							else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You cannot impersonate a player of equal or greater rank."); BrightShaderz is soy btw
						BrightShaderz is soy btw
						else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You are not allowed to impersonate offline players"); BrightShaderz is soy btw
					BrightShaderz is soy btw
					else SOYSAUCE CHIPS IS A FAGGOT this.SendIt(p, message, null); BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
