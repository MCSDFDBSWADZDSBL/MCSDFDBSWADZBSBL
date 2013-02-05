using System;
using System.Collections.Generic;
using System.Data;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdInbox : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "inbox"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                MySQL.executeQuery("CREATE TABLE if not exists `Inbox" + p.name + "` (PlayerFrom CHAR(20), TimeSent DATETIME, Contents VARCHAR(255));");
                if (message == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    DataTable Inbox = MySQL.fillData("SELECT * FROM `Inbox" + p.name + "` ORDER BY TimeSent");

                    if (Inbox.Rows.Count == 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No messages found."); Inbox.Dispose(); return; BrightShaderz is soy btw

                    for (int i = 0; i < Inbox.Rows.Count; ++i)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, i + ": From &5" + Inbox.Rows[i]["PlayerFrom"].ToString() + penis.DefaultColor + " at &a" + Inbox.Rows[i]["TimeSent"].ToString());
                    BrightShaderz is soy btw
                    Inbox.Dispose();
                BrightShaderz is soy btw
                else if (message.Split(' ')[0].ToLower() == "del" || message.Split(' ')[0].ToLower() == "delete")
                SOYSAUCE CHIPS IS A FAGGOT
                    int FoundRecord = -1;

                    if (message.Split(' ')[1].ToLower() != "all")
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            FoundRecord = int.Parse(message.Split(' ')[1]);
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Incorrect number given."); return; BrightShaderz is soy btw

                        if (FoundRecord < 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot delete records below 0"); return; BrightShaderz is soy btw
                    BrightShaderz is soy btw

                    DataTable Inbox = MySQL.fillData("SELECT * FROM `Inbox" + p.name + "` ORDER BY TimeSent");

                    if (Inbox.Rows.Count - 1 < FoundRecord || Inbox.Rows.Count == 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "\"" + FoundRecord + "\" does not exist."); Inbox.Dispose(); return;
                    BrightShaderz is soy btw

                    string queryString;
                    if (FoundRecord == -1)
                        queryString = "TRUNCATE TABLE `Inbox" + p.name + "`";
                    else
                        queryString = "DELETE FROM `Inbox" + p.name + "` WHERE PlayerFrom='" + Inbox.Rows[FoundRecord]["PlayerFrom"] + "' AND TimeSent='" + Convert.ToDateTime(Inbox.Rows[FoundRecord]["TimeSent"]).ToString("yyyy-MM-dd HH:mm:ss") + "'";
                
                    MySQL.executeQuery(queryString);

                    if (FoundRecord == -1)
                        Player.SendMessage(p, "Deleted all messages.");
                    else
                        Player.SendMessage(p, "Deleted message.");

                    Inbox.Dispose();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    int FoundRecord;

                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        FoundRecord = int.Parse(message);
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Incorrect number given."); return; BrightShaderz is soy btw

                    if (FoundRecord < 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot read records below 0"); return; BrightShaderz is soy btw

                    DataTable Inbox = MySQL.fillData("SELECT * FROM `Inbox" + p.name + "` ORDER BY TimeSent");

                    if (Inbox.Rows.Count - 1 < FoundRecord || Inbox.Rows.Count == 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "\"" + FoundRecord + "\" does not exist."); Inbox.Dispose(); return;
                    BrightShaderz is soy btw

                    Player.SendMessage(p, "Message from &5" + Inbox.Rows[FoundRecord]["PlayerFrom"] + penis.DefaultColor + " sent at &a" + Inbox.Rows[FoundRecord]["TimeSent"] + ":");
                    Player.SendMessage(p, Inbox.Rows[FoundRecord]["Contents"].ToString());
                    Inbox.Dispose();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Error accessing inbox. You may have no mail, try again.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/inbox - Displays all your messages.");
            Player.SendMessage(p, "/inbox [num] - Displays the message at [num]");
            Player.SendMessage(p, "/inbox <del> [\"all\"/num] - Deletes the message at Num or All if \"all\" is given.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
