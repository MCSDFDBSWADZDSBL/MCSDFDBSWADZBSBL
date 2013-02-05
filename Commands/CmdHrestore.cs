/*
 * Made by 727021 for use with MCSong only
 * See LICENSE.md or LICENSE.txt for license information
 * A copy of the license(s) can be found at http://updates.mcsong.comule.com/
 */
using System;

namespace MCSong
{
    public class CmdHrestore : Command
    {
        public override string name { get { return "hrestore"; } }
        public override string shortcut { get { return ""; } }
        public override string type { get { return "homes"; } }
        public override bool museumUsable { get { return false; } }
        public override LevelPermission defaultRank { get { return LevelPermission.AdvBuilder; } }
        public override void Use(Player p, string message)
        {
            if (p == null) { Player.SendMessage(p, "Command not useable from console"); return; }
            if (p.level != Level.FindExact(p.name)) { Player.SendMessage(p, "You must be at your home to use this command"); return; }
            p.ignorePermission = true;
            Command.all.Find("restore").Use(p, message);
            p.ignorePermission = false;
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/hrestore <backup> - Restores a previous backup of your home");
        }
    }
}