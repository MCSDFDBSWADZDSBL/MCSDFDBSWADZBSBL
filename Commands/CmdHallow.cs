/*
 * Made by 727021 for use with MCSong only
 * See LICENSE.md or LICENSE.txt for license information
 * A copy of the license(s) can be found at http://updates.mcsong.comule.com/
 */
using System;

namespace MCSong
{
    public class CmdHallow : Command
    {
        public override string name { get { return "hallow"; } }
        public override string shortcut { get { return ""; } }
        public override string type { get { return "homes"; } }
        public override bool museumUsable { get { return false; } }
        public override LevelPermission defaultRank { get { return LevelPermission.AdvBuilder; } }
        public override void Use(Player p, string message)
        {
            if (p == null) { Player.SendMessage(p, "Command not useable from console"); return; }
            if (p.level != Level.FindExact(p.name)) { Player.SendMessage(p, "You must be at your home to use this command"); return; }
            Player pl = Player.Find(message.Split(' ')[0]);
            Level lvl = Level.FindExact(p.name);
            if (message.Split(' ')[1].Trim().ToLower() == "del")
            {
                if (pl == p) { Player.SendMessage(p, "You cannot disallow yourself from building in your home!"); return; }
                p.level.ZoneList.ForEach(delegate(Level.Zone Zn)
                {
                    if (Zn.Owner.Trim().ToLower() == Player.Find(message).name.Trim().ToLower())
                    {
                        MySQL.executeQuery("DELETE FROM `Zone" + lvl.name + "` WHERE Owner='" + Zn.Owner + "' AND SmallX='" + Zn.smallX + "' AND SMALLY='" + Zn.smallY + "' AND SMALLZ='" + Zn.smallZ + "' AND BIGX='" + Zn.bigX + "' AND BIGY='" + Zn.bigY + "' AND BIGZ='" + Zn.bigZ + "'");
                        lvl.ZoneList.Remove(Zn);
                        Player.SendMessage(p, "Removed zone for " + pl.name);
                    }
                });
                return;
            }
            Level.Zone zn;
            zn.smallX = 0;
            zn.smallY = 0;
            zn.smallZ = 0;
            zn.bigX = Convert.ToUInt16(lvl.width - 1);
            zn.bigY = Convert.ToUInt16(lvl.height - 1);
            zn.bigZ = Convert.ToUInt16(lvl.depth - 1);
            zn.Owner = pl.name;
            lvl.ZoneList.Add(zn);
            MySQL.executeQuery("INSERT INTO `Zone" + lvl.name + "` (SmallX, SmallY, SmallZ, BigX, BigY, BigZ, Owner) VALUES (" + zn.smallX + ", " + zn.smallY + ", " + zn.smallZ + ", " + zn.bigX + ", " + zn.bigY + ", " + zn.bigZ + ", '" + zn.Owner + "')");
            Player.SendMessage(p, "Zoned entire map for " + pl.name);
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/hallow <player> - Allow <player> to build in your home");
            Player.SendMessage(p, "/hallow <player> [del] - Disallow <player> from building in your home");
        }
    }
}