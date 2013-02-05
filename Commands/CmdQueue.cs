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
using System.IO;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdQueue : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "queue"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "qz"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdQueue() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            int number = message.Split(' ').Length;
            if (number > 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (number == 2)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log(message);
                string t = message.Split(' ')[0];
                string s = message.Split(' ')[1];
                if (t == "zombie")
                SOYSAUCE CHIPS IS A FAGGOT
                    bool asdfasdf = false;
                    Player.players.ForEach(delegate(Player player)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (player.name == s)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.SendMessage(s + " was queued.");
                            penis.queZombie = true;
                            penis.nextZombie = s;
                            asdfasdf = true;
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw);
                    if (!asdfasdf)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.SendMessage(s + " is not online.");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else if (t == "level")
                SOYSAUCE CHIPS IS A FAGGOT
                    bool yes = false;
                    DirectoryInfo di = new DirectoryInfo("levels/");
                    FileInfo[] fi = di.GetFiles("*.lvl");
                    foreach (FileInfo file in fi)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (file.Name.Replace(".lvl", "").ToLower().Equals(s.ToLower()))
                        SOYSAUCE CHIPS IS A FAGGOT
                            yes = true;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    if (yes)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.SendMessage(s + " was queued.");
                        penis.queLevel = true;
                        penis.nextLevel = s.ToLower();
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.SendMessage("Level does not exist.");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.SendMessage("You did not enter a valid option.");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/queue zombie [name] - Next round [name] will be infected");
            Player.SendMessage(p, "/queue level [name] - Next round [name] will be the round loaded");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
