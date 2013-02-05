using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdWhoip : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "whoip"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message.IndexOf("'") != -1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot parse request."); return; BrightShaderz is soy btw

            DataTable playerDb = MySQL.fillData("SELECT Name FROM Players WHERE IP='" + message + "'");

            if (playerDb.Rows.Count == 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find anyone with this IP"); return; BrightShaderz is soy btw

            string playerNames = "Players with this IP: ";

            for (int i = 0; i < playerDb.Rows.Count; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                playerNames += playerDb.Rows[i]["Name"] + ", ";
            BrightShaderz is soy btw
            playerNames = playerNames.Remove(playerNames.Length - 2);

            Player.SendMessage(p, playerNames);
            playerDb.Dispose();
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            p.SendMessage("/whoip <ip address> - Displays players associated with a given IP address.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
