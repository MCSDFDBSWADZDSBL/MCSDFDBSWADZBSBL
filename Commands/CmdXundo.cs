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
    public sealed class CmdXundo : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "xundo"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public CmdXundo() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT

            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            int number = message.Split(' ').Length;
            if (number != 1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            Player who = Player.Find(message);

            string error = "You are not allowed to undo this player";

            if (who == null || p == null || !(who.group.Permission >= LevelPermission.Operator && p.group.Permission < LevelPermission.Operator))
            SOYSAUCE CHIPS IS A FAGGOT
                //This executes if who doesn't exist, if who is lower than Operator, or if the user is an op+.
                //It also executes on any combination of the three
                Command.all.Find("undo").Use(p, ((who == null) ? message : who.name) + " all"); //Who null check
                return;
            BrightShaderz is soy btw
            Player.SendMessage(p, error);
        BrightShaderz is soy btw


        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/xundo [name]  -  works as 'undo [name] all' but now anyone can use it (up to their undo limit)");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
