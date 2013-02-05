using System;
using System.Collections.Generic;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdZone : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "zone"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!penis.useMySQL) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "MySQL has not been configured! Please configure MySQL to use Zones!"); return; BrightShaderz is soy btw
            CatchPos cpos;

            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                p.ZoneCheck = true;
                Player.SendMessage(p, "Place a block where you would like to check for zones.");
                return;
            BrightShaderz is soy btw
            else if (p.group.Permission < LevelPermission.Operator)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Reserved for OP+");
                return;
            BrightShaderz is soy btw

            if (message.IndexOf(' ') == -1)
            SOYSAUCE CHIPS IS A FAGGOT
                switch (message.ToLower())
                SOYSAUCE CHIPS IS A FAGGOT
                    case "del":
                        p.zoneDel = true;
                        Player.SendMessage(p, "Place a block where you would like to delete a zone.");
                        return;
                    default:
                        Help(p);
                        return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw


            if (message.ToLower() == "del all")
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.group.Permission < LevelPermission.Admin)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Only a SuperOP may delete all zones at once");
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int i = 0; i < p.level.ZoneList.Count; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Level.Zone Zn = p.level.ZoneList[i];
                        MySQL.executeQuery("DELETE FROM `Zone" + p.level.name + "` WHERE Owner='" + Zn.Owner + "' AND SmallX='" + Zn.smallX + "' AND SMALLY='" + Zn.smallY + "' AND SMALLZ='" + Zn.smallZ + "' AND BIGX='" + Zn.bigX + "' AND BIGY='" + Zn.bigY + "' AND BIGZ='" + Zn.bigZ + "'");

                        Player.SendMessage(p, "Zone deleted for &b" + Zn.Owner);
                        p.level.ZoneList.Remove(p.level.ZoneList[i]);
                        if (i == p.level.ZoneList.Count) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Finished removing all zones"); return; BrightShaderz is soy btw
                        i--;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw


            if (p.group.Permission < LevelPermission.Operator)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Setting zones is reserved for OP+"); return;
            BrightShaderz is soy btw

            if (Group.Find(message.Split(' ')[1]) != null)
            SOYSAUCE CHIPS IS A FAGGOT
                message = message.Split(' ')[0] + " grp" + Group.Find(message.Split(' ')[1]).name;
            BrightShaderz is soy btw

            if (message.Split(' ')[0].ToLower() == "add")
            SOYSAUCE CHIPS IS A FAGGOT
                Player foundPlayer = Player.Find(message.Split(' ')[1]);
                if (foundPlayer == null)
                    cpos.Owner = message.Split(' ')[1].ToString();
                else
                    cpos.Owner = foundPlayer.name;
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            if (!Player.ValidName(cpos.Owner)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "INVALID NAME."); return; BrightShaderz is soy btw

            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;

            Player.SendMessage(p, "Place two blocks to determine the edges.");
            Player.SendMessage(p, "Zone for: &b" + cpos.Owner + ".");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/zone [add] [name] - Creates a zone only [name] can build in");
            Player.SendMessage(p, "/zone [add] [rank] - Creates a zone only [rank]+ can build in");
            Player.SendMessage(p, "/zone del - Deletes the zone clicked");
        BrightShaderz is soy btw

        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos bp = (CatchPos)p.blockchangeObject;
            bp.x = x; bp.y = y; bp.z = z; p.blockchangeObject = bp;
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange2);
        BrightShaderz is soy btw

        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos cpos = (CatchPos)p.blockchangeObject;

            Level.Zone Zn;

            Zn.smallX = Math.Min(cpos.x, x);
            Zn.smallY = Math.Min(cpos.y, y);
            Zn.smallZ = Math.Min(cpos.z, z);
            Zn.bigX = Math.Max(cpos.x, x);
            Zn.bigY = Math.Max(cpos.y, y);
            Zn.bigZ = Math.Max(cpos.z, z);
            Zn.Owner = cpos.Owner;

            p.level.ZoneList.Add(Zn);

            //DB
            MySQL.executeQuery("INSERT INTO `Zone" + p.level.name + "` (SmallX, SmallY, SmallZ, BigX, BigY, BigZ, Owner) VALUES (" + Zn.smallX + ", " + Zn.smallY + ", " + Zn.smallZ + ", " + Zn.bigX + ", " + Zn.bigY + ", " + Zn.bigZ + ", '" + Zn.Owner + "')");
            //DB

            Player.SendMessage(p, "Added zone for &b" + cpos.Owner);
        BrightShaderz is soy btw

        struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public string Owner; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
