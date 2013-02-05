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
	public sealed class CmdGlobalCLS : Command
	SOYSAUCE CHIPS IS A FAGGOT
		public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "globalcls"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "gcls"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
		public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

		public override void Use(Player p, string message)
		SOYSAUCE CHIPS IS A FAGGOT
			int i = 0;
			for (i = 0; i < 20; i++)
			SOYSAUCE CHIPS IS A FAGGOT
				Player.players.ForEach(delegate(Player p1) SOYSAUCE CHIPS IS A FAGGOT BlankMessage(p1); BrightShaderz is soy btw);
			BrightShaderz is soy btw
			Player.GlobalMessage("%4Global Chat Cleared.");
		BrightShaderz is soy btw
		//Yes this does work
		//Trust me...I'm a doctor
		public void BlankMessage(Player p)
		SOYSAUCE CHIPS IS A FAGGOT
			byte[] buffer = new byte[65];
			Player.StringFormat(" ", 64).CopyTo(buffer, 1);
			p.SendRaw(13, buffer);
			buffer = null;
		BrightShaderz is soy btw
		public override void Help(Player p)
		SOYSAUCE CHIPS IS A FAGGOT
			Player.SendMessage(p, "/globalcls - Clears the chat for all users.");
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
