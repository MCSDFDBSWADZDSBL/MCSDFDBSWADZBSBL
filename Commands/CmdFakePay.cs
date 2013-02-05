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
    public sealed class CmdFakePay : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "fakepay"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "fpay"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/fakepay <name> <amount> - Sends a fake give change message.");
        BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
			
			var split = message.Split(' ');
			
            Player who = Player.Find(split[0]);
			if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, penis.DefaultColor + "Player not found!");
                return;
            BrightShaderz is soy btw
			
			int amount = 0;
			try
			SOYSAUCE CHIPS IS A FAGGOT
	            amount = int.Parse(split[1]);
			BrightShaderz is soy btw
			catch/* (Exception ex)*/
			SOYSAUCE CHIPS IS A FAGGOT
				Player.SendMessage(p, "How much do you want to fakepay them?");
				return;
			BrightShaderz is soy btw
			
            if (amount < 0)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, penis.DefaultColor + "You can't fakepay a negative amount.");
                return;
            BrightShaderz is soy btw
			
            if (amount >= 16777215)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Whoa, that's too much money. Try less than 16777215.");
                return;
            BrightShaderz is soy btw

            Player.GlobalMessage(who.color + who.prefix + who.name + penis.DefaultColor + " was given " + amount + " " + penis.moneys);

        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw

