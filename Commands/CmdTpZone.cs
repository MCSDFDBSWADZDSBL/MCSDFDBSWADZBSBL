using System;
using System.Collections.Generic;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdTpZone : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "tpzone"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") message = "list";

            string[] parameters = message.Split(' ');

            if (parameters[0].ToLower() == "list")
            SOYSAUCE CHIPS IS A FAGGOT
                if (parameters.Length > 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    int pageNum, currentNum;
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        pageNum = int.Parse(parameters[1]) * 10; currentNum = pageNum - 10;
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

                    if (currentNum < 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Must be greater than 0"); return; BrightShaderz is soy btw
                    if (pageNum > p.level.ZoneList.Count) pageNum = p.level.ZoneList.Count;
                    if (currentNum > p.level.ZoneList.Count) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No Zones beyond number " + (p.level.ZoneList.Count - 1)); return; BrightShaderz is soy btw

                    Player.SendMessage(p, "Zones (" + currentNum + " to " + (pageNum - 1) + "):");
                    for (int i = currentNum; i < pageNum; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Level.Zone zone = p.level.ZoneList[i];
                        Player.SendMessage(p, "&c" + i + " &b(" +
                            zone.smallX + "-" + zone.bigX + ", " +
                            zone.smallY + "-" + zone.bigY + ", " +
                            zone.smallZ + "-" + zone.bigZ + ") &f" +
                            zone.Owner);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int i = 0; i < p.level.ZoneList.Count; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Level.Zone zone = p.level.ZoneList[i];
                        Player.SendMessage(p, "&c" + i + " &b(" +
                            zone.smallX + "-" + zone.bigX + ", " +
                            zone.smallY + "-" + zone.bigY + ", " +
                            zone.smallZ + "-" + zone.bigZ + ") &f" +
                            zone.Owner);
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "For a more structured list, use /tpzone list <1/2/3/..>");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                int zoneID;
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    zoneID = int.Parse(message);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

                if (zoneID < 0 || zoneID > p.level.ZoneList.Count)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "This zone doesn't exist");
                    return;
                BrightShaderz is soy btw

                Level.Zone zone = p.level.ZoneList[zoneID];
                unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, (ushort)(zone.bigX * 32 + 16), (ushort)(zone.bigY * 32 + 32), (ushort)(zone.bigZ * 32 + 16), p.rot[0], p.rot[1]); BrightShaderz is soy btw

                Player.SendMessage(p, "Teleported to zone &c" + zoneID + " &b(" +
                    zone.bigX + ", " + zone.bigY + ", " + zone.bigZ + ") &f" +
                    zone.Owner);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/tpzone <id> - Teleports to the zone with ID equal to <id>");
            Player.SendMessage(p, "/tpzone list - Lists all zones");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
