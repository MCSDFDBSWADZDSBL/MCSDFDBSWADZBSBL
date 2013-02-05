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
using System.Data;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdWhowas : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "whowas"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            Player pl = Player.Find(message); 
            if (pl != null && !pl.hidden)
            SOYSAUCE CHIPS IS A FAGGOT 
                Player.SendMessage(p, pl.color + pl.name + penis.DefaultColor + " is online, using /whois instead."); 
                Command.all.Find("whois").Use(p, message);
                return; 
            BrightShaderz is soy btw

            if (message.IndexOf("'") != -1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot parse request."); return; BrightShaderz is soy btw

            string FoundRank = Group.findPlayer(message.ToLower());

            DataTable playerDb = MySQL.fillData("SELECT * FROM Players WHERE Name='" + message + "'");
            if (playerDb.Rows.Count == 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, Group.Find(FoundRank).color + message + penis.DefaultColor + " has the rank of " + Group.Find(FoundRank).color + FoundRank); return; BrightShaderz is soy btw

            Player.SendMessage(p, Group.Find(FoundRank).color + playerDb.Rows[0]["Title"] + " " + message + penis.DefaultColor + " has :");
            Player.SendMessage(p, "> > the rank of \"" + Group.Find(FoundRank).color + FoundRank);
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (!Group.Find("Nobody").commands.Contains("pay") && !Group.Find("Nobody").commands.Contains("give") && !Group.Find("Nobody").commands.Contains("take")) Player.SendMessage(p, "> > &a" + playerDb.Rows[0]["Money"] + penis.DefaultColor + " " + penis.moneys);
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            Player.SendMessage(p, "> > &cdied &a" + playerDb.Rows[0]["TotalDeaths"] + penis.DefaultColor + " times");
            Player.SendMessage(p, "> > &bmodified &a" + playerDb.Rows[0]["totalBlocks"] + penis.DefaultColor + " blocks.");
            Player.SendMessage(p, "> > was last seen on &a" + playerDb.Rows[0]["LastLogin"]);
            Player.SendMessage(p, "> > first logged into the penis on &a" + playerDb.Rows[0]["FirstLogin"]);
            Player.SendMessage(p, "> > logged in &a" + playerDb.Rows[0]["totalLogin"] + penis.DefaultColor + " times, &c" + playerDb.Rows[0]["totalKicked"] + penis.DefaultColor + " of which ended in a kick.");
            Player.SendMessage(p, "> > " + Awards.awardAmount(message) + " awards");

            bool skip = false;
            if (p != null) if (p.group.Permission <= LevelPermission.AdvBuilder) skip = true;

            if (!skip)
            SOYSAUCE CHIPS IS A FAGGOT
                if (penis.bannedIP.Contains(playerDb.Rows[0]["IP"].ToString()))
                    playerDb.Rows[0]["IP"] = "&8" + playerDb.Rows[0]["IP"] + ", which is banned";
                Player.SendMessage(p, "> > the IP of " + playerDb.Rows[0]["IP"]);
                if (penis.useWhitelist)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.whiteList.Contains(message.ToLower()))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "> > Player is &fWhitelisted");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (penis.devs.Contains(message.ToLower()))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, penis.DefaultColor + "> > Player is a &9Developer");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            playerDb.Dispose();
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/whowas <name> - Displays information about someone who left.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
