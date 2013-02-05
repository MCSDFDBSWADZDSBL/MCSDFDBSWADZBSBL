/*
Copyright 2011 MCForge
Dual-licensed under the Educational Community License, Version 2.0 and
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
    public sealed class CmdDelTempRank : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "deltemprank"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "dtr"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdDelTempRank() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string alltext = File.ReadAllText("text/tempranks.txt");
            if (!alltext.Contains(message))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "&cPlayer &a" + message + "&c Has not been assigned a temporary rank. Cannot unnasign.");
                return;
            BrightShaderz is soy btw
            string alltempranks = "";
           Player who = Player.Find(message);
           foreach (string line in File.ReadAllLines("text/tempranks.txt"))
           SOYSAUCE CHIPS IS A FAGGOT
               if (line.Contains(message))
               SOYSAUCE CHIPS IS A FAGGOT
                   string group = line.Split(' ')[2];
                   Group newgroup = Group.Find(group);
                   Command.all.Find("setrank").Use(null, who.name + " " + newgroup.name);
                   Player.SendMessage(p, "&eTemporary rank of &a" + message + "&e has been unassigned");
                   Player.SendMessage(who, "&eYour temporary rank has been unassigned");
               BrightShaderz is soy btw
               if (!line.Contains(message))
               SOYSAUCE CHIPS IS A FAGGOT
                   alltempranks = alltempranks + line + "\r\n";
               BrightShaderz is soy btw
           BrightShaderz is soy btw
           File.WriteAllText("text/tempranks.txt", alltempranks);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/deltemprank - Deletes someones temporary rank");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
