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
using System.Data;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdBanip : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "banip"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "bi"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message[0] == '@')
            SOYSAUCE CHIPS IS A FAGGOT
                message = message.Remove(0, 1).Trim();
                Player who = Player.Find(message);
                if (who == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    DataTable ip;
                    int tryCounter = 0;
            rerun:  try
                    SOYSAUCE CHIPS IS A FAGGOT
                        ip = MySQL.fillData("SELECT IP FROM Players WHERE Name = '" + message + "'");
                    BrightShaderz is soy btw
                    catch (Exception e)
                    SOYSAUCE CHIPS IS A FAGGOT
                        tryCounter++;
                        if (tryCounter < 10)
                            goto rerun;
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            penis.ErrorLog(e);
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    if (ip.Rows.Count > 0)
                        message = ip.Rows[0]["IP"].ToString();
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Unable to find an IP address for that user.");
                        return;
                    BrightShaderz is soy btw
                    ip.Dispose();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    message = who.ip;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player who = Player.Find(message);
                if (who != null)
                    message = who.ip;
            BrightShaderz is soy btw

            if (message.Equals("127.0.0.1")) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You can't ip-ban the penis!"); return; BrightShaderz is soy btw
            if (message.IndexOf('.') == -1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid IP!"); return; BrightShaderz is soy btw
            if (message.Split('.').Length != 4) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid IP!"); return; BrightShaderz is soy btw
            if (p != null) SOYSAUCE CHIPS IS A FAGGOT if (p.ip == message) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You can't ip-ban yourself.!"); return; BrightShaderz is soy btw BrightShaderz is soy btw
            if (penis.bannedIP.Contains(message)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, message + " is already ip-banned."); return; BrightShaderz is soy btw
            Player.GlobalMessage(message + " got &8ip-banned!");
            if (p != null)
            SOYSAUCE CHIPS IS A FAGGOT
                IRCBot.Say("IP-BANNED: " + message.ToLower() + " by " + p.name);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                IRCBot.Say("IP-BANNED: " + message.ToLower() + " by console");
            BrightShaderz is soy btw
            penis.bannedIP.Add(message);
            penis.bannedIP.Save("banned-ip.txt", false);
            penis.s.Log("IP-BANNED: " + message.ToLower());
            /*
            foreach (Player pl in Player.players) SOYSAUCE CHIPS IS A FAGGOT
                if (message == pl.ip) SOYSAUCE CHIPS IS A FAGGOT pl.Kick("Kicked by ipban"); BrightShaderz is soy btw
            BrightShaderz is soy btw*/
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/banip <ip/name> - Bans an ip. Also accepts a player name when you use @ before the name.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
