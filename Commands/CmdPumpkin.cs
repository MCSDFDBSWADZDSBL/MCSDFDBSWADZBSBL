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
//Thanks to the /nyan creators...
using System.IO;
using System.Net;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdPumpkin : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pumpkin"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "This command can only be used in-game!"); return; BrightShaderz is soy btw
            if (!Directory.Exists("extra/copy"))
                Directory.CreateDirectory("extra/copy");

            if (!File.Exists("extra/copy/pumpkin.copy"))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Pumpkin copy doesn't exist. Downloading...");
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    using (WebClient WEB = new WebClient())
                        WEB.DownloadFile("http://www.mcforge.net/uploads/copy/pumpkin.copy", "extra/copy/pumpkin.copy");
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Sorry, downloading failed. Please try again later.");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            Command.all.Find("retrieve").Use(p, "pumpkin");
            Command.all.Find("paste").Use(p, "");
            ushort[] loc = p.getLoc(false);
            ushort loc0 = (ushort)(loc[0] + 3);
            ushort loc2 = (ushort)(loc[2] - 8);
            Command.all.Find("click").Use(p, loc0 + " " + loc[1] + " " + loc2);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/pumpkin - places a pumpkin at your location!");
            Player.SendMessage(p, "&4Warning! &cThis will go through other blocks, and replace them!");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
