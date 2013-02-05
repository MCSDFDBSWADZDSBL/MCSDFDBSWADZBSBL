/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCSong) Licensed under the
	Educational Community License, Version 2.0 (the "License"); you may
	not use this file except in compliance with the License. You may
	obtain a copy of the License at
	
	http://www.osedu.org/licenses/ECL-2.0
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the License is distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the License for the specific language governing
	permissions and limitations under the License.
*/
using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdWhois : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "whois"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            Player who = null;
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT who = p; message = p.name; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT who = Player.Find(message); BrightShaderz is soy btw
            if (who != null && !who.hidden)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, who.color + who.name + penis.DefaultColor + " is on &b" + who.level.name);
                Player.SendMessage(p, who.color + who.prefix + who.name + penis.DefaultColor + " has :");
                Player.SendMessage(p, "> > the rank of " + who.group.color + who.group.name);
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!Group.Find("Nobody").commands.Contains("pay") && !Group.Find("Nobody").commands.Contains("give") && !Group.Find("Nobody").commands.Contains("take")) Player.SendMessage(p, "> > &a" + who.money + penis.DefaultColor + " " + penis.moneys);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                Player.SendMessage(p, "> > &cdied &a" + who.overallDeath + penis.DefaultColor + " times");
                Player.SendMessage(p, "> > &bmodified &a" + who.overallBlocks + penis.DefaultColor + " blocks, &a" + who.loginBlocks + penis.DefaultColor + " since logging in.");
                string storedTime = Convert.ToDateTime(DateTime.Now.Subtract(who.timeLogged).ToString()).ToString("HH:mm:ss");
                Player.SendMessage(p, "> > been logged in for &a" + storedTime);
                Player.SendMessage(p, "> > first logged into the penis on &a" + who.firstLogin.ToString("yyyy-MM-dd") + " at " + who.firstLogin.ToString("HH:mm:ss"));
                Player.SendMessage(p, "> > logged in &a" + who.totalLogins + penis.DefaultColor + " times, &c" + who.totalKicked + penis.DefaultColor + " of which ended in a kick.");
                Player.SendMessage(p, "> > " + Awards.awardAmount(who.name) + " awards");

                bool skip = false;
                if (p != null) if (p.group.Permission <= LevelPermission.AdvBuilder) skip = true;
                if (!skip)
                    SOYSAUCE CHIPS IS A FAGGOT
                        string givenIP;
                        if (penis.bannedIP.Contains(who.ip)) givenIP = "&8" + who.ip + ", which is banned"; 
                        else givenIP = who.ip;
                        Player.SendMessage(p, "> > the IP of " + givenIP);
                        if (penis.useWhitelist)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (penis.whiteList.Contains(who.name))
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "> > Player is &fWhitelisted");
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        if (penis.devs.Contains(who.name.ToLower()))
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, penis.DefaultColor + "> > Player is a &9Developer");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "\"" + message + "\" is offline! Using /whowas instead."); Command.all.Find("whowas").Use(p, message); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/whois [player] - Displays information about someone.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
