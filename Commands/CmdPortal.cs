using System;
using System.IO;
using System.Collections.Generic;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;
using System.Data;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdPortal : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "portal"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "o"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!penis.useMySQL) SOYSAUCE CHIPS IS A FAGGOT p.SendMessage("MySQL has not been configured! Please configure MySQL to use Portals!"); return; BrightShaderz is soy btw
            portalPos portalPos;

            portalPos.Multi = false;

            if (message.IndexOf(' ') != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                if (message.Split(' ')[1].ToLower() == "multi")
                SOYSAUCE CHIPS IS A FAGGOT
                    portalPos.Multi = true;
                    message = message.Split(' ')[0];
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Invalid parameters");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (message.ToLower() == "blue" || message == "") SOYSAUCE CHIPS IS A FAGGOT portalPos.type = Block.blue_portal; BrightShaderz is soy btw
            else if (message.ToLower() == "orange") SOYSAUCE CHIPS IS A FAGGOT portalPos.type = Block.orange_portal; BrightShaderz is soy btw
            else if (message.ToLower() == "air") SOYSAUCE CHIPS IS A FAGGOT portalPos.type = Block.air_portal; BrightShaderz is soy btw
            else if (message.ToLower() == "water") SOYSAUCE CHIPS IS A FAGGOT portalPos.type = Block.water_portal; BrightShaderz is soy btw
            else if (message.ToLower() == "lava") SOYSAUCE CHIPS IS A FAGGOT portalPos.type = Block.lava_portal; BrightShaderz is soy btw
            else if (message.ToLower() == "show") SOYSAUCE CHIPS IS A FAGGOT showPortals(p); return; BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            p.ClearBlockchange();

            portPos port;

            port.x = 0; port.y = 0; port.z = 0; port.portMapName = "";
            portalPos.port = new List<portPos>();

            p.blockchangeObject = portalPos;
            Player.SendMessage(p, "Place a the &aEntry block" + penis.DefaultColor + " for the portal"); p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(EntryChange);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/portal [orange/blue/air/water/lava] [multi] - Activates Portal mode.");
            Player.SendMessage(p, "/portal [type] multi - Place Entry blocks until exit is wanted.");
            Player.SendMessage(p, "/portal show - Shows portals, green = in, red = out.");
        BrightShaderz is soy btw

        public void EntryChange(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            portalPos bp = (portalPos)p.blockchangeObject;

            if (bp.Multi && type == Block.red && bp.port.Count > 0) SOYSAUCE CHIPS IS A FAGGOT ExitChange(p, x, y, z, type); return; BrightShaderz is soy btw

            byte b = p.level.GetTile(x, y, z);
            p.level.Blockchange(p, x, y, z, bp.type);
            p.SendBlockchange(x, y, z, Block.green);
            portPos Port;

            Port.portMapName = p.level.name;
            Port.x = x; Port.y = y; Port.z = z;

            bp.port.Add(Port);

            p.blockchangeObject = bp;

            if (!bp.Multi)
            SOYSAUCE CHIPS IS A FAGGOT
                p.Blockchange += new Player.BlockchangeEventHandler(ExitChange);
                Player.SendMessage(p, "&aEntry block placed");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                p.Blockchange += new Player.BlockchangeEventHandler(EntryChange);
                Player.SendMessage(p, "&aEntry block placed. &cRed block for exit");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void ExitChange(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            portalPos bp = (portalPos)p.blockchangeObject;

            foreach (portPos pos in bp.port)
            SOYSAUCE CHIPS IS A FAGGOT
                DataTable Portals = MySQL.fillData("SELECT * FROM `Portals" + pos.portMapName + "` WHERE EntryX=" + (int)pos.x + " AND EntryY=" + (int)pos.y + " AND EntryZ=" + (int)pos.z);
                Portals.Dispose();

                if (Portals.Rows.Count == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    MySQL.executeQuery("INSERT INTO `Portals" + pos.portMapName + "` (EntryX, EntryY, EntryZ, ExitMap, ExitX, ExitY, ExitZ) VALUES (" + (int)pos.x + ", " + (int)pos.y + ", " + (int)pos.z + ", '" + p.level.name + "', " + (int)x + ", " + (int)y + ", " + (int)z + ")");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    MySQL.executeQuery("UPDATE `Portals" + pos.portMapName + "` SET ExitMap='" + p.level.name + "', ExitX=" + (int)x + ", ExitY=" + (int)y + ", ExitZ=" + (int)z + " WHERE EntryX=" + (int)pos.x + " AND EntryY=" + (int)pos.y + " AND EntryZ=" + (int)pos.z);
                BrightShaderz is soy btw
                //DB

                if (pos.portMapName == p.level.name) p.SendBlockchange(pos.x, pos.y, pos.z, bp.type);
            BrightShaderz is soy btw

            Player.SendMessage(p, "&3Exit" + penis.DefaultColor + " block placed");

            if (p.staticCommands) SOYSAUCE CHIPS IS A FAGGOT bp.port.Clear(); p.blockchangeObject = bp; p.Blockchange += new Player.BlockchangeEventHandler(EntryChange); BrightShaderz is soy btw
        BrightShaderz is soy btw

        public struct portalPos SOYSAUCE CHIPS IS A FAGGOT public List<portPos> port; public byte type; public bool Multi; BrightShaderz is soy btw
        public struct portPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public string portMapName; BrightShaderz is soy btw

        public void showPortals(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            p.showPortals = !p.showPortals;

            DataTable Portals = MySQL.fillData("SELECT * FROM `Portals" + p.level.name + "`");

            int i;

            if (p.showPortals)
            SOYSAUCE CHIPS IS A FAGGOT
                for (i = 0; i < Portals.Rows.Count; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Portals.Rows[i]["ExitMap"].ToString() == p.level.name)
                        p.SendBlockchange((ushort)Portals.Rows[i]["ExitX"], (ushort)Portals.Rows[i]["ExitY"], (ushort)Portals.Rows[i]["ExitZ"], Block.orange_portal);
                    p.SendBlockchange((ushort)Portals.Rows[i]["EntryX"], (ushort)Portals.Rows[i]["EntryY"], (ushort)Portals.Rows[i]["EntryZ"], Block.blue_portal);
                BrightShaderz is soy btw

                Player.SendMessage(p, "Now showing &a" + i.ToString() + penis.DefaultColor + " portals.");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                for (i = 0; i < Portals.Rows.Count; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Portals.Rows[i]["ExitMap"].ToString() == p.level.name)
                        p.SendBlockchange((ushort)Portals.Rows[i]["ExitX"], (ushort)Portals.Rows[i]["ExitY"], (ushort)Portals.Rows[i]["ExitZ"], Block.air);

                    p.SendBlockchange((ushort)Portals.Rows[i]["EntryX"], (ushort)Portals.Rows[i]["EntryY"], (ushort)Portals.Rows[i]["EntryZ"], p.level.GetTile((ushort)Portals.Rows[i]["EntryX"], (ushort)Portals.Rows[i]["EntryY"], (ushort)Portals.Rows[i]["EntryZ"]));
                BrightShaderz is soy btw

                Player.SendMessage(p, "Now hiding portals.");
            BrightShaderz is soy btw

            Portals.Dispose();
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
