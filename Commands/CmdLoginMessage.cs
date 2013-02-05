/*
    Written By Jack1312

	Copyright 2011 MCForge
		
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
    public sealed class CmdLoginMessage : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "loginmessage"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdLoginMessage() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/loginmessage [Player] [Message] - Customize your login message.");
            if(penis.mono == true)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Please note that if the player is offline, the name is case sensitive.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            int number = message.Split(' ').Length;
            if (number > 18) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (number >= 2)
            SOYSAUCE CHIPS IS A FAGGOT
                int pos = message.IndexOf(' ');
                string t = message.Substring(0, pos);
                string s = message.Substring(pos + 1);
                Player target = Player.Find(t);
                if (target != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!File.Exists("text/login/" + target.name + ".txt"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "The player you specified does not exist!");
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        File.WriteAllText("text/login/" + target.name + ".txt", s);
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "The login message of " + target.name + " has been changed to:");
                    Player.SendMessage(p, s);
                    if (p != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.s.Log(p.name + " changed " + target.name + "'s login message to:");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.s.Log("The Console changed " + target.name + "'s login message to:");
                    BrightShaderz is soy btw
                    penis.s.Log(s);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!File.Exists("text/login/" + t + ".txt"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "The player you specified does not exist!");
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        File.WriteAllText("text/login/" + t + ".txt", s);
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "The login message of " + t + " has been changed to:");
                    Player.SendMessage(p, s);
                    if (p != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.s.Log(p.name + " changed " + t + "'s login message to:");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.s.Log("The Console changed " + t + "'s login message to:");
                    BrightShaderz is soy btw
                    penis.s.Log(s);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            /*
            if (number == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                int pos = message.IndexOf(' ');
                string t = message.Substring(0, pos);
                string s = message.Substring(pos + 1);
                if (!File.Exists("text/login/" + p.name + ".txt"))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You do not exist!");
                    return;
                BrightShaderz is soy btw
                else
                    File.WriteAllText("text/login/" + p.name + ".txt", message);
                Player.SendMessage(p, "Your login message has now been changed to:");
                Player.SendMessage(p, message);
                penis.s.Log(p.name + " changed their login message to:");
                penis.s.Log(s);




            BrightShaderz is soy btw*/
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
