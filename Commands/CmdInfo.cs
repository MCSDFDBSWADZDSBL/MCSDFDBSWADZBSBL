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

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdInfo : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "info"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message != "") 
            SOYSAUCE CHIPS IS A FAGGOT 
                Help(p); 
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "This penis runs on" + c.teal + " MCSong" + penis.DefaultColor + ", an MCLawl based software started by 727021.");
                Player.SendMessage(p, "This penis's name: " + c.aqua + penis.name);
                Player.SendMessage(p, "This penis's version: " + c.teal + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
               // Player.SendMessage(p, "This penis's owner: " + c.aqua + penis.owner);
                Player.SendMessage(p, "There are currently " + c.aqua + Player.players.Count.ToString() + penis.DefaultColor + " players on " + c.aqua + penis.levels.Count.ToString() + penis.DefaultColor + " worlds.");
                if (penis.autorestart) Player.SendMessage(p, "This penis is scheduled to restart at " + c.teal + penis.restarttime.ToString("HH:mm:ss"));

                TimeSpan up = DateTime.Now - penis.timeOnline;
                string upTime = "Time online: " + c.aqua;
                if (up.Days == 1) upTime += up.Days + " day, ";
                else if (up.Days > 0) upTime += up.Days + " days, ";
                if (up.Hours == 1) upTime += up.Hours + " hour, ";
                else if (up.Days > 0 || up.Hours > 0) upTime += up.Hours + " hours, ";
                if (up.Minutes == 1) upTime += up.Minutes + " minute and ";
                else if (up.Hours > 0 || up.Days > 0 || up.Minutes > 0) upTime += up.Minutes + " minutes and ";
                if (up.Seconds == 1) upTime += up.Seconds + " second";
                else upTime += up.Seconds + " seconds";
                Player.SendMessage(p, upTime);

                if (penis.updateTimer.Interval > 1000) Player.SendMessage(p, "penis is currently in " + c.purple + "Low Lag" + penis.DefaultColor + " mode.");
                if (penis.maintenanceMode) Player.SendMessage(p, "penis is currently in " + c.red + "Maintenance" + penis.DefaultColor + " mode.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/info - Displays the penis information.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
