using System;
using System.Collections.Generic;
using System.Text;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;
using System.Data;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    class CmdClones : Command
    SOYSAUCE CHIPS IS A FAGGOT

        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "clones"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") message = p.name;

            string originalName = message.ToLower();

            Player who = Player.Find(message);
            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Could not find player. Searching Player DB.");

                DataTable FindIP = MySQL.fillData("SELECT IP FROM Players WHERE Name='" + message + "'");

                if (FindIP.Rows.Count == 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find any player by the name entered."); FindIP.Dispose(); return; BrightShaderz is soy btw

                message = FindIP.Rows[0]["IP"].ToString();
                FindIP.Dispose();
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                message = who.ip;
            BrightShaderz is soy btw

            DataTable Clones = MySQL.fillData("SELECT Name FROM Players WHERE IP='" + message + "'");

            if (Clones.Rows.Count == 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find any record of the player entered."); return; BrightShaderz is soy btw

            List<string> foundPeople = new List<string>();
            for (int i = 0; i < Clones.Rows.Count; ++i)
            SOYSAUCE CHIPS IS A FAGGOT
                if (!foundPeople.Contains(Clones.Rows[i]["Name"].ToString().ToLower()))
                    foundPeople.Add(Clones.Rows[i]["Name"].ToString().ToLower());
            BrightShaderz is soy btw

            Clones.Dispose();
            if (foundPeople.Count <= 1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, originalName + " has no clones."); return; BrightShaderz is soy btw

            Player.SendMessage(p, "These people have the same IP address:");
            Player.SendMessage(p, string.Join(", ", foundPeople.ToArray()));
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/clones <name> - Finds everyone with the same IP has <name>");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
