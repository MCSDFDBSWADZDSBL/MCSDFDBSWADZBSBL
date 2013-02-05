using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCSong.Commands
{
    class CmdXzone : Command
    {
        public override string name { get { return "xzone"; } }
        public override string shortcut { get { return "xz"; } }
        public override string type { get { return "moderation"; } }
        public override bool museumUsable { get { return false; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Admin; } }
        public override void Use(Player p, string message)
        {
            if (!Server.useMySQL) { Player.SendMessage(p, "MySQL has not been configured! Please configure MySQL to use Zones!"); return; }
            if (p == null) { Player.SendMessage(p, "Command not useable from console."); return; }
            string[] split = message.Split(' ');
            string pl = split[0];
            string lv = split[1];
            Player plr = Player.Find(pl);
            if (plr == null) { Player.SendMessage(p, "Player not found!"); return; }
            Level lvl = Level.Find(lv);
            if (split.Length == 2)
            {
                if (lvl == null) { Player.SendMessage(p, "Map not found!"); return; }
                goto makeZone;
            }
            else if (split.Length == 1)
            {
                lvl = p.level;
                goto makeZone;
            }
            else
            {
                Help(p); return;
            }
        makeZone:
            Level.Zone zn;
            zn.smallX = 0;
            zn.smallY = 0;
            zn.smallZ = 0;
            zn.bigX = Convert.ToUInt16(lvl.width - 1);
            zn.bigY = Convert.ToUInt16(lvl.height - 1);
            zn.bigZ = Convert.ToUInt16(lvl.depth - 1);
            zn.Owner = plr.name;
            lvl.ZoneList.Add(zn);
            MySQL.executeQuery("INSERT INTO `Zone" + lvl.name + "` (SmallX, SmallY, SmallZ, BigX, BigY, BigZ, Owner) VALUES (" + zn.smallX + ", " + zn.smallY + ", " + zn.smallZ + ", " + zn.bigX + ", " + zn.bigY + ", " + zn.bigZ + ", '" + zn.Owner + "')");
            Player.SendMessage(p, "Zoned entire map for " + plr.name);
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/xzone <player> [map] - Zones an entire map for <player>");
            Player.SendMessage(p, "If [map] is left blank, your current map is used.");
        }
    }
}
