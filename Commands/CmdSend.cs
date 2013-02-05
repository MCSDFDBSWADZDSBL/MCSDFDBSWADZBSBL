using System;
using System.Collections.Generic;
using System.Data;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdSend : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "send"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "" || message.IndexOf(' ') == -1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            Player who = Player.Find(message.Split(' ')[0]);

            string whoTo;
            if (who != null) whoTo = who.name;
            else whoTo = message.Split(' ')[0];

            message = message.Substring(message.IndexOf(' ') + 1);

            //DB
            MySQL.executeQuery("CREATE TABLE if not exists `Inbox" + whoTo + "` (PlayerFrom CHAR(20), TimeSent DATETIME, Contents VARCHAR(255));");
            MySQL.executeQuery("INSERT INTO `Inbox" + whoTo + "` (PlayerFrom, TimeSent, Contents) VALUES ('" + p.name + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + message.Replace("'", "\\'") + "')");
            //DB

            Player.SendMessage(p, "Message sent to &5" + whoTo + ".");
            if (who != null) who.SendMessage("Message recieved from &5" + p.name + penis.DefaultColor + ".");
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/send [name] <message> - Sends <message> to [name].");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
