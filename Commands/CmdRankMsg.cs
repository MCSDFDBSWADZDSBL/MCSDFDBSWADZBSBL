/*
    Written by Jack1312
  
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
    public sealed class CmdRankMsg : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "rankmsg"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "rm"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdRankMsg() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string[] command = message.ToLower().Split(' ');
            string msg1 = String.Empty;
            string msg2 = String.Empty;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                msg1 = command[0];
                msg2 = command[1];
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            if (msg1 == "")
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw
            if (msg2 == "")
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("rankmsg").Use(p, p.group.name + " " + msg1);
                return;
            BrightShaderz is soy btw
            Group findgroup = Group.Find(msg1);
            if (findgroup == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Could not find group specified!");
                return;
            BrightShaderz is soy btw
            foreach (Player pl in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                if (pl.group.name == findgroup.name)
                SOYSAUCE CHIPS IS A FAGGOT
                    pl.SendMessage(p.color + p.name + ": " + penis.DefaultColor + (message.Replace(msg1, "").Trim()));
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/rankmsg [Rank] [Message] - Sends a message to the specified rank.");
            Player.SendMessage(p, "Note: If no message is given, player's rank is taken.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
