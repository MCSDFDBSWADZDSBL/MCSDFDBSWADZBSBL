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
    public sealed class CmdMoney : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "money"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            bool emptyMessage = message == "" || message == null || message == string.Empty;
            if (p != null && emptyMessage)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You currently have %f" + p.money + " %3" + penis.moneys);
            BrightShaderz is soy btw
            else if (message.Split().Length == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                Player who = Player.Find(message);
                if (who == null)
                SOYSAUCE CHIPS IS A FAGGOT //player is offline
                    Economy.EcoStats ecos = Economy.RetrieveEcoStats(message);
                    Player.SendMessage(p, ecos.playerName + "(%foffline" + penis.DefaultColor + ") currently has %f" + ecos.money + " %3" + penis.moneys);
                    return;
                BrightShaderz is soy btw
                //you can see everyone's stats with /eco stats [player]
                /*if (who.group.Permission >= p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "%cCannot see the money of someone of equal or greater rank.");
                    return;
                BrightShaderz is soy btw*/
                Player.SendMessage(p, who.color + who.name + penis.DefaultColor + " currently has %f" + who.money + " %3" + penis.moneys);
            BrightShaderz is soy btw
            else if (p == null && emptyMessage)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "%Console can't have %3" + penis.moneys);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "%cInvalid parameters!");
                Help(p);
            BrightShaderz is soy btw

        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "%f/money <player>" + penis.DefaultColor + " - Shows how much %3" + penis.moneys + penis.DefaultColor + " <player> has");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
