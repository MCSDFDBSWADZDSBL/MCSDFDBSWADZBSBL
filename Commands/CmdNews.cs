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
using System.IO;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdNews : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "news"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string newsFile = "text/news.txt";
            if (!File.Exists(newsFile) || (File.Exists(newsFile) && File.ReadAllLines(newsFile).Length == -1))
            SOYSAUCE CHIPS IS A FAGGOT
                using (var SW = new StreamWriter(newsFile))
                SOYSAUCE CHIPS IS A FAGGOT
                    SW.WriteLine("News have not been created. Put News in '" + newsFile + "'.");
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            string[] strArray = File.ReadAllLines(newsFile);
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (string t in strArray)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, t);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                string[] split = message.Split(' ');
                if (split[0] == "all") SOYSAUCE CHIPS IS A FAGGOT if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You must be at least " + Group.findPermInt(CommandOtherPerms.GetPerm(this)).name + " to send this to all players."); return; BrightShaderz is soy btw for (int k = 0; k < strArray.Length; k++) SOYSAUCE CHIPS IS A FAGGOT Player.GlobalMessage(strArray[k]); BrightShaderz is soy btw return; BrightShaderz is soy btw
                Player player = Player.Find(split[0]);
                if (player == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player \"" + split[0] + "\"!"); return; BrightShaderz is soy btw
                foreach (string t in strArray)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(player, t);
                BrightShaderz is soy btw
                Player.SendMessage(p, "The News were successfully sent to " + player.name + ".");
               
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/news - Shows penis news.");
            Player.SendMessage(p, "/news <player> - Sends the News to <player>.");
            Player.SendMessage(p, "/news all - Sends the News to everyone.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
