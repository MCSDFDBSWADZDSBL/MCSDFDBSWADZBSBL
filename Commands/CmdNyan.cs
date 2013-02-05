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
// Created by Sinjai, for use only with MCForge
// Special thanks to Nerketur and Kris9006!
using System.IO;
using System.Net;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdNyan : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "nyan"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "This command can only be used in-game!"); return; BrightShaderz is soy btw
            if (!Directory.Exists("extra/copy"))
                Directory.CreateDirectory("extra/copy");

            if (!File.Exists("extra/copy/nyancat.copy"))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Nyan Cat copy doesn't exist. Downloading...");
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    using (WebClient WEB = new WebClient())
                        WEB.DownloadFile("http://mcforge.net/uploads/copy/nyancat.copy", "extra/copy/nyancat.copy");
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Sorry, downloading failed. Please try again later.");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            Command.all.Find("retrieve").Use(p, "nyancat");
            Command.all.Find("paste").Use(p, "");
            ushort[] loc = p.getLoc(false);
            Command.all.Find("click").Use(p, loc[0] + " " + loc[1] + " " + loc[2]);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/nyan - places a nyan cat at your location!");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
