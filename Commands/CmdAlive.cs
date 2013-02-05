/*
	Copyright 2010 MCLawl Team - Written by Valek (Modified for use with MCForge)
 
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.osedu.org/licenses/ECL-2.0
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdAlive : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "alive"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "alive"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdAlive() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            Player who = null;
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT who = p; message = p.name; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT who = Player.Find(message); BrightShaderz is soy btw
            if (ZombieGame.alive.Count == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "No one is alive.");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Players who are " + c.green + "alive " + penis.DefaultColor + "are:");
                string playerstring = "";
                ZombieGame.alive.ForEach(delegate(Player player)
                SOYSAUCE CHIPS IS A FAGGOT
                    playerstring = playerstring + player.group.color + player.name + penis.DefaultColor + ", ";
                BrightShaderz is soy btw);
                Player.SendMessage(p, playerstring);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/alive - shows who is alive");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
