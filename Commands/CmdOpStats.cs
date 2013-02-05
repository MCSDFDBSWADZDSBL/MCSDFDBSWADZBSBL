/*
	Written by RedNoodle
   
    Copyright 2011 MCForge
	
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
using System.Data;
using MCForge.SQL;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdOpStats : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "opstats"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdOpStats() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            bool debug = false;
            Player who = null;
            string timespanend = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string timespan = "thismonth";
            string timespanname = "This Month";
            bool tspanoption = false;
            if (message == "" && p != null) SOYSAUCE CHIPS IS A FAGGOT who = p; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT who = (message.Split(' ').Length > 1 ? Player.Find(message.Split(' ')[0]) : Player.Find(message)); BrightShaderz is soy btw
            if (p != null && (message == "today" || message == "yesterday" || message == "thismonth" || message == "lastmonth" || message == "all")) SOYSAUCE CHIPS IS A FAGGOT who = p; BrightShaderz is soy btw
            if (p == null && message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message.Split(' ').Length == 1 && (message == "today" || message == "yesterday" || message == "thismonth" || message == "lastmonth" || message == "all")) SOYSAUCE CHIPS IS A FAGGOT timespan = message; BrightShaderz is soy btw
            if (message.Split(' ').Length == 2 && (message.Split(' ')[1].ToLower() == "today" || message.Split(' ')[1].ToLower() == "yesterday" || message.Split(' ')[1].ToLower() == "thismonth" || message.Split(' ')[1].ToLower() == "lastmonth" || message.Split(' ')[1].ToLower() == "all")) SOYSAUCE CHIPS IS A FAGGOT timespan = message.Split(' ')[1].ToLower(); BrightShaderz is soy btw
            if (debug) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Message = " + message); BrightShaderz is soy btw
            if (timespan.ToLower() == "today") 
            SOYSAUCE CHIPS IS A FAGGOT 
                timespan = DateTime.Now.ToString("yyyy-MM-dd 00:00:00"); 
                timespanname = "Today"; 
                tspanoption = true; 
            BrightShaderz is soy btw
            if (timespan.ToLower() == "yesterday") 
            SOYSAUCE CHIPS IS A FAGGOT 
                timespan = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd 00:00:00");
                timespanend = DateTime.Now.ToString("yyyy-MM-dd 00:00:00"); 
                timespanname = "Yesterday"; 
                tspanoption = true; 
            BrightShaderz is soy btw
            if (timespan.ToLower() == "thismonth") 
            SOYSAUCE CHIPS IS A FAGGOT 
                timespan = DateTime.Now.ToString("yyyy-MM-01 00:00:00"); 
                tspanoption = true; 
            BrightShaderz is soy btw
            if (timespan.ToLower() == "lastmonth") 
            SOYSAUCE CHIPS IS A FAGGOT 
                timespan = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-01 00:00:00");
                timespanend = DateTime.Now.ToString("yyyy-MM-01 00:00:00");
                timespanname = "Last Month"; 
                tspanoption = true; 
            BrightShaderz is soy btw
            if (timespan.ToLower() == "all") 
            SOYSAUCE CHIPS IS A FAGGOT 
                timespan = "0000-00-00 00:00:00"; 
                timespanname = "ALL"; 
                tspanoption = true; 
            BrightShaderz is soy btw
            if (!tspanoption) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (debug) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Timespan = " + timespan); BrightShaderz is soy btw
            if (debug) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TimespanName = " + timespanname); BrightShaderz is soy btw
            if (who != null) SOYSAUCE CHIPS IS A FAGGOT message = who.name; BrightShaderz is soy btw // Online full player name is converted to message
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Database.AddParams("@Name", (message.Split(' ').Length > 1 ? message.Split(' ')[0] : message));
                using (DataTable playerDb = Database.fillData("SELECT * FROM Players WHERE Name=@Name"))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (playerDb.Rows != null && playerDb.Rows.Count > 0) // Check if player exists in database since we couldn't find player online
                    SOYSAUCE CHIPS IS A FAGGOT
                        message = playerDb.Rows[0]["Name"].ToString(); // Proper case of player name is pulled from database and converted to message
                        playerDb.Dispose();
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Unable to find player"); // Player wasn't online and didn't exist in database
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            DataTable reviewcount = penis.useMySQL ? MySQL.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'review' AND Cmdmsg LIKE 'next'") : SQLite.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'review' AND Cmdmsg LIKE 'next'");
            DataTable promotecount = penis.useMySQL ? MySQL.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'promote' AND Cmdmsg !=''") : SQLite.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'promote' AND Cmdmsg !=''");
            DataTable demotecount = penis.useMySQL ? MySQL.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'demote' AND Cmdmsg !=''") : SQLite.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'demote' AND Cmdmsg !=''");
            DataTable griefercount = penis.useMySQL ? MySQL.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'griefer' AND Cmdmsg !=''") : SQLite.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'griefer' AND Cmdmsg !=''");
            DataTable undocount = penis.useMySQL ? MySQL.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'undo' AND Cmdmsg !=''") : SQLite.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'undo' AND Cmdmsg !=''");
            DataTable freezecount = penis.useMySQL ? MySQL.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'freeze' AND Cmdmsg !=''") : SQLite.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'freeze' AND Cmdmsg !=''");
            DataTable mutecount = penis.useMySQL ? MySQL.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'mute' AND Cmdmsg !=''") : SQLite.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'mute' AND Cmdmsg !=''");
            DataTable warncount = penis.useMySQL ? MySQL.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'warn' AND Cmdmsg !=''") : SQLite.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'warn' AND Cmdmsg !=''");
            DataTable kickcount = penis.useMySQL ? MySQL.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'kick' AND Cmdmsg !=''") : SQLite.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'kick' AND Cmdmsg !=''");
            DataTable tempbancount = penis.useMySQL ? MySQL.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'tempban' AND Cmdmsg !=''") : SQLite.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'tempban' AND Cmdmsg !=''");
            DataTable bancount = penis.useMySQL ? MySQL.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'ban' AND Cmdmsg !=''") : SQLite.fillData("SELECT COUNT(ID) FROM Opstats WHERE Time >= '" + timespan + "' AND Time < '" + timespanend + "' AND Name LIKE '" + message + "' AND Cmd LIKE 'ban' AND Cmdmsg !=''");
            Player.SendMessage(p, (p == null ? "" : "&d") + "OpStats for " + (p == null ? "" : "&c") + message); // Use colorcodes if in game, don't use color if in console
            Player.SendMessage(p, (p == null ? "" : "&d") + "Showing " + timespanname + " Starting from " + timespan);
            Player.SendMessage(p, (p == null ? "" : "&0") + "----------------");
            Player.SendMessage(p, (p == null ? "" : "&a") + "Reviews - " + (p == null ? "" : "&5") + reviewcount.Rows[0]["COUNT(id)"]); // Count results within datatable
            Player.SendMessage(p, (p == null ? "" : "&a") + "Promotes - " + (p == null ? "" : "&5") + promotecount.Rows[0]["COUNT(id)"]);
            Player.SendMessage(p, (p == null ? "" : "&a") + "Demotes - " + (p == null ? "" : "&5") + demotecount.Rows[0]["COUNT(id)"]);
            Player.SendMessage(p, (p == null ? "" : "&a") + "Griefers - " + (p == null ? "" : "&5") + griefercount.Rows[0]["COUNT(id)"]);
            Player.SendMessage(p, (p == null ? "" : "&a") + "Undo - " + (p == null ? "" : "&5") + undocount.Rows[0]["COUNT(id)"]);
            Player.SendMessage(p, (p == null ? "" : "&a") + "Freezes - " + (p == null ? "" : "&5") + freezecount.Rows[0]["COUNT(id)"]);
            Player.SendMessage(p, (p == null ? "" : "&a") + "Mutes - " + (p == null ? "" : "&5") + mutecount.Rows[0]["COUNT(id)"]);
            Player.SendMessage(p, (p == null ? "" : "&a") + "Warns - " + (p == null ? "" : "&5") + warncount.Rows[0]["COUNT(id)"]);
            Player.SendMessage(p, (p == null ? "" : "&a") + "Kicks - " + (p == null ? "" : "&5") + kickcount.Rows[0]["COUNT(id)"]);
            Player.SendMessage(p, (p == null ? "" : "&a") + "Tempbans - " + (p == null ? "" : "&5") + tempbancount.Rows[0]["COUNT(id)"]);
            Player.SendMessage(p, (p == null ? "" : "&a") + "Bans - " + (p == null ? "" : "&5") + bancount.Rows[0]["COUNT(id)"]);
            reviewcount.Dispose();
            promotecount.Dispose();
            demotecount.Dispose();
            griefercount.Dispose();
            undocount.Dispose();
            freezecount.Dispose();
            mutecount.Dispose();
            warncount.Dispose();
            kickcount.Dispose();
            tempbancount.Dispose();
            bancount.Dispose();
		BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/opstats [player] [today]|[yesterday]|[thismonth]|[lastmonth]|[all] - Displays information about operator command usage.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
