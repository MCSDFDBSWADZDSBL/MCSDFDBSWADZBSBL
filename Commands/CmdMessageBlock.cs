using System;
using System.Collections.Generic;
using System.Data;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdMessageBlock : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mb"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!penis.useMySQL) SOYSAUCE CHIPS IS A FAGGOT p.SendMessage("MySQL has not been configured! Please configure MySQL to use Message Blocks!"); return; BrightShaderz is soy btw
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            CatchPos cpos;
            cpos.message = "";

            try
            SOYSAUCE CHIPS IS A FAGGOT
                switch (message.Split(' ')[0])
                SOYSAUCE CHIPS IS A FAGGOT
                    case "air": cpos.type = Block.MsgAir; break;
                    case "water": cpos.type = Block.MsgWater; break;
                    case "lava": cpos.type = Block.MsgLava; break;
                    case "black": cpos.type = Block.MsgBlack; break;
                    case "white": cpos.type = Block.MsgWhite; break;
                    case "show": showMBs(p); return;
                    default: cpos.type = Block.MsgWhite; cpos.message = message; break;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT cpos.type = Block.MsgWhite; cpos.message = message; BrightShaderz is soy btw

            if (cpos.message == "") cpos.message = message.Substring(message.IndexOf(' ') + 1);
            p.blockchangeObject = cpos;

            Player.SendMessage(p, "Place where you wish the message block to go."); p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/mb [block] [message] - Places a message in your next block.");
            Player.SendMessage(p, "Valid blocks: white, black, air, water, lava");
            Player.SendMessage(p, "/mb show shows or hides MBs");
        BrightShaderz is soy btw

        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            CatchPos cpos = (CatchPos)p.blockchangeObject;

            cpos.message = cpos.message.Replace("'", "\\'");

            DataTable Messages = MySQL.fillData("SELECT * FROM `Messages" + p.level.name + "` WHERE X=" + (int)x + " AND Y=" + (int)y + " AND Z=" + (int)z);
            Messages.Dispose();

            if (Messages.Rows.Count == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                MySQL.executeQuery("INSERT INTO `Messages" + p.level.name + "` (X, Y, Z, Message) VALUES (" + (int)x + ", " + (int)y + ", " + (int)z + ", '" + cpos.message + "')");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                MySQL.executeQuery("UPDATE `Messages" + p.level.name + "` SET Message='" + cpos.message + "' WHERE X=" + (int)x + " AND Y=" + (int)y + " AND Z=" + (int)z);
            BrightShaderz is soy btw

            Player.SendMessage(p, "Message block placed.");
            p.level.Blockchange(p, x, y, z, cpos.type);
            p.SendBlockchange(x, y, z, cpos.type);

            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw

        struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public string message; public byte type; BrightShaderz is soy btw

        public void showMBs(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            p.showMBs = !p.showMBs;

            DataTable Messages = new DataTable("Messages");
            Messages = MySQL.fillData("SELECT * FROM `Messages" + p.level.name + "`");

            int i;

            if (p.showMBs)
            SOYSAUCE CHIPS IS A FAGGOT
                for (i = 0; i < Messages.Rows.Count; i++)
                    p.SendBlockchange((ushort)Messages.Rows[i]["X"], (ushort)Messages.Rows[i]["Y"], (ushort)Messages.Rows[i]["Z"], Block.MsgWhite);
                Player.SendMessage(p, "Now showing &a" + i.ToString() + penis.DefaultColor + " MBs.");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                for (i = 0; i < Messages.Rows.Count; i++)
                    p.SendBlockchange((ushort)Messages.Rows[i]["X"], (ushort)Messages.Rows[i]["Y"], (ushort)Messages.Rows[i]["Z"], p.level.GetTile((ushort)Messages.Rows[i]["X"], (ushort)Messages.Rows[i]["Y"], (ushort)Messages.Rows[i]["Z"]));
                Player.SendMessage(p, "Now hiding MBs.");
            BrightShaderz is soy btw
            Messages.Dispose();
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
