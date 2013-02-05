/*
	Copyright 2011 MCForge
	
	Written by GamezGalaxy (hypereddie10)
		
	Licensed under the
	Educational Community License, Version 2.0 (the "License"); you may
	not use this file except in compliance with the License. You may
	obtain a copy of the License at
	
	http://www.opensource.org/licenses/ecl2.php
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the License is distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the License for the specific language governing
	permissions and limitations under the License.
*/
using System;
using System.Threading;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdXmute : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "xmute"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw

            if (p == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "This command can only be used in-game. Use /mute [Player] instead.");
                return;
            BrightShaderz is soy btw

            var split = message.Split(' ');
            Player muter = Player.Find(split[0]);
            if (muter == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Player not found.");
                return;
            BrightShaderz is soy btw

            if (p != null && muter.group.Permission > p.group.Permission)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You cannot xmute someone ranked higher than you!");
                return;
            BrightShaderz is soy btw
            if (p == muter)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You cannot use xmute on yourself!");
                return;
            BrightShaderz is soy btw
            Command.all.Find("mute").Use(p, muter.name);

            int time = 120;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                time = Convert.ToInt32(message.Split(' ')[1]);
            BrightShaderz is soy btw
            catch/* (Exception ex)*/
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Invalid time given.");
                Help(p);
                return;
            BrightShaderz is soy btw

            Player.GlobalMessage(muter.color + muter.name + " has been muted for " + time + " seconds");
            Player.SendMessage(muter, "You have been muted for " + time + " seconds");

            Thread.Sleep(time * 1000);

            Command.all.Find("mute").Use(p, muter.name);
        BrightShaderz is soy btw

        // This one controls what happens when you use /help [commandname].
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/xmute <player> <seconds> - Mutes <player> for <seconds> seconds");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw


