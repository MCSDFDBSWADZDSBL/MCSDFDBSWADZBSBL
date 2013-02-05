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
using System;
using System.IO;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdTempRank : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "temprank"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "tr"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdTempRank() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string player = "", rank = "", period = "";
            try
            SOYSAUCE CHIPS IS A FAGGOT
                player = message.Split(' ')[0];
                rank = message.Split(' ')[1];
                period = message.Split(' ')[2];
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
            BrightShaderz is soy btw
           
            Player who = Player.Find(player);
            
            
            if (player == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "&cYou have to enter a player!"); return; BrightShaderz is soy btw          
            if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "&cPlayer &a" + player + "&c not found!"); return; BrightShaderz is soy btw
            if (rank == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "&cYou have to enter a rank!"); return; BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Group groupNew = Group.Find(rank);
                if (groupNew == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "&cRank &a" + rank + "&c does not exist");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (period == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "&cYou have to enter a time period!"); return; BrightShaderz is soy btw
            Boolean isnumber = true;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                Convert.ToInt32(period);
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                isnumber = false;
            BrightShaderz is soy btw
            if (!isnumber)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "&cThe period needs to be a number!");
                return;
            BrightShaderz is soy btw

            string alltext = File.ReadAllText("text/tempranks.txt");
            if (alltext.Contains(player))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "&cThe player already has a temporary rank assigned!");
                return;
            BrightShaderz is soy btw
            bool byconsole;
            if (p == null)
            SOYSAUCE CHIPS IS A FAGGOT
                byconsole = true;
                goto skipper;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                byconsole = false;
            BrightShaderz is soy btw
            if (player == p.name)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "&cYou cannot assign yourself a temporary rank!");
                return;
            BrightShaderz is soy btw
            Player who3 = Player.Find(player);
            if (who3.group.Permission >= p.group.Permission)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Cannot change the temporary rank of someone equal or higher to yourself.");
                return;
            BrightShaderz is soy btw
            Group newRank2 = Group.Find(rank);
            if (newRank2.Permission >= p.group.Permission)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Cannot change the temporary rank to a higher rank than yourself");
                return;
            BrightShaderz is soy btw
        skipper:
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string oldrank = who.group.name;
            string assigner;
            if (byconsole)
            SOYSAUCE CHIPS IS A FAGGOT
                assigner = "Console";
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT
                assigner = p.name;
            BrightShaderz is soy btw
        
            Boolean tryer = true;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                StreamWriter sw;
                sw = File.AppendText("text/tempranks.txt");
                sw.WriteLine(who.name + " " + rank + " " + oldrank + " " + period + " " + minute + " " + hour + " " + day + " " + month + " " + year + " " + assigner);
                sw.Close();
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                tryer = false;
            BrightShaderz is soy btw

            
                if (!tryer)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "&cAn error occurred!");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Group newgroup = Group.Find(rank);
                    Command.all.Find("setrank").Use(null, who.name + " " + newgroup.name);
                    Player.SendMessage(p, "Temporary rank (" + rank + ") is assigned succesfully to " + player + " for " + period + " hours");
                    Player who2 = Player.Find(player);
                    Player.SendMessage(who2, "Your Temporary rank (" + rank + ") is assigned succesfully for " + period + " hours");
                BrightShaderz is soy btw
            
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/temprank <player> <rank> <period(hours)> - Sets a temporary rank for the specified player.");
        BrightShaderz is soy btw
            
    BrightShaderz is soy btw
BrightShaderz is soy btw
