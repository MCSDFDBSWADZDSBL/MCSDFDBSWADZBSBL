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
using System.Data;
using System.Text.RegularExpressions;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdUnbanip : Command
    SOYSAUCE CHIPS IS A FAGGOT
        Regex regex = new Regex(@"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\." +
                                "([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))SOYSAUCE CHIPS IS A FAGGOT3BrightShaderz is soy btw$");
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "unbanip"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
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
             rerun: try
                    SOYSAUCE CHIPS IS A FAGGOT
                        ip = MySQL.fillData("SELECT IP FROM Players WHERE Name = '" + message + "'");
                    BrightShaderz is soy btw
                    catch (Exception e)
                    SOYSAUCE CHIPS IS A FAGGOT
                        tryCounter++;
                        if (tryCounter < 10)
                        SOYSAUCE CHIPS IS A FAGGOT
                            goto rerun;
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            penis.ErrorLog(e);
                            Player.SendMessage(p, "There was a database error fetching the IP address.  It has been logged.");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    if (ip.Rows.Count > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        message = ip.Rows[0]["IP"].ToString();
                    BrightShaderz is soy btw
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

            if (!regex.IsMatch(message)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Not a valid ip!"); return; BrightShaderz is soy btw
            if (p != null) if (p.ip == message) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You shouldn't be able to use this command..."); return; BrightShaderz is soy btw
            if (!penis.bannedIP.Contains(message)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, message + " doesn't seem to be banned..."); return; BrightShaderz is soy btw
            Player.GlobalMessage(message + " got &8unip-banned" + penis.DefaultColor + "!");
            penis.bannedIP.Remove(message); penis.bannedIP.Save("banned-ip.txt", false);
            penis.s.Log("IP-UNBANNED: " + message.ToLower());
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/unbanip <ip> - Un-bans an ip.  Also accepts a player name when you use @ before the name.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
