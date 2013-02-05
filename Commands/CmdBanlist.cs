/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
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
    public sealed class CmdBanlist : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "banlist"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "bl"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdBanlist() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string endresult = "";
            foreach (string line in File.ReadAllLines("ranks/banned.txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                if (Ban.Isbanned(line))
                SOYSAUCE CHIPS IS A FAGGOT
                    endresult = endresult + "&a" + line + penis.DefaultColor + ", ";
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    endresult = endresult + "&c" + line + penis.DefaultColor + ", ";
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (endresult == "")
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "There are no players banned");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                endresult = endresult.Remove(endresult.Length - 2, 2);
                endresult = "&9Banned players: " + penis.DefaultColor + endresult + penis.DefaultColor + ".";
                Player.SendMessage(p, endresult);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/banlist - shows who's banned on penis");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
