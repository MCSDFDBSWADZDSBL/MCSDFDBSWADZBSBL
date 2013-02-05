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
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdTempBan : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "tempban"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "tb"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "moderation"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message.IndexOf(' ') == -1) message = message + " 30";

            Player who = Player.Find(message.Split(' ')[0]);
            if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player"); return; BrightShaderz is soy btw
            if (who.group.Permission >= p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot ban someone of the same rank"); return; BrightShaderz is soy btw

            int minutes;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                minutes = int.Parse(message.Split(' ')[1]);
            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid minutes"); return; BrightShaderz is soy btw
            if (minutes > 60) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot ban for more than an hour"); return; BrightShaderz is soy btw
            if (minutes < 1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot ban someone for less than a minute"); return; BrightShaderz is soy btw
            
            penis.TempBan tBan;
            tBan.name = who.name;
            tBan.allowedJoin = DateTime.Now.AddMinutes(minutes);
            penis.tempBans.Add(tBan);
            who.Kick("Banned for " + minutes + " minutes!");
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/tempban <name> <minutes> - Bans <name> for <minutes>");
            Player.SendMessage(p, "Max time is 60. Default is 30");
            Player.SendMessage(p, "Temp bans will reset on penis restart");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
