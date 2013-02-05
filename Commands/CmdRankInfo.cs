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
using System;
using System.IO;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdRankInfo : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "rankinfo"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ri"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdRankInfo() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string alltext = File.ReadAllText("text/rankinfo.txt");
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                Player.SendMessage(p, "&cYou need to enter a player!");
                return;
            BrightShaderz is soy btw
            Player who2 = Player.Find(message);
            if (who2 == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "&cPlayer &e" + message + " &cHas not been found!");
                return;
            BrightShaderz is soy btw
            if (!alltext.Contains(message))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "&cPlayer &a" + message + "&c has not been ranked yet!");
                return;
            BrightShaderz is soy btw
            


            foreach (string line3 in File.ReadAllLines("text/rankinfo.txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                if (!line3.Contains(message))
                    continue;
                string newrank = line3.Split(' ')[7];
                string oldrank = line3.Split(' ')[8];
                string assigner = line3.Split(' ')[1];
                Group newrankcolor = Group.Find(newrank);
                Group oldrankcolor = Group.Find(oldrank);
                int minutes = Convert.ToInt32(line3.Split(' ')[2]);
                int hours = Convert.ToInt32(line3.Split(' ')[3]);
                int days = Convert.ToInt32(line3.Split(' ')[4]);
                int months = Convert.ToInt32(line3.Split(' ')[5]);
                int years = Convert.ToInt32(line3.Split(' ')[6]);
                var ExpireDate = new DateTime(years, months, days, hours, minutes, 0);
                Player.SendMessage(p, "&1Rank Information of " + message);
                Player.SendMessage(p, "&aNew rank: " + newrankcolor.color + newrank);
                Player.SendMessage(p, "&aOld Rank: " + oldrankcolor.color + oldrank);
                Player.SendMessage(p, "&aDate of assignment: " + ExpireDate.ToString());
                Player.SendMessage(p, "&aRanked by: " + assigner);
            BrightShaderz is soy btw


        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/rankinfo - Returns the information available about someones ranking");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
