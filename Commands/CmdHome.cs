using System;

namespace MCSong
{
    public class CmdHome : Command
    {
        public override string name { get { return "home"; } }
        public override string shortcut { get { return "h"; } }
        public override string type { get { return "homes"; } }
        public override bool museumUsable { get { return true; } }
        public override LevelPermission defaultRank { get { return LevelPermission.AdvBuilder; } }
        public override void Use(Player p, string message)
        {
            if (p == null) { Player.SendMessage(p, "Command not useable from console"); return; }
            if (p.level == Level.FindExact(p.name)) { Player.SendMessage(p, "You are already at your home!"); return; }
            if (Level.Exists(p.name))
            {
                p.ignorePermission = true;
                Command.all.Find("goto").Use(p, " " + p.name);
                p.ignorePermission = false;
                return;
            }
            if (p.group.Permission >= Server.homeRank)
            {
                p.ignorePermission = true;
                Command.all.Find("newlvl").Use(p, " " + p.name + " " + Server.homeX + " " + Server.homeY + " " + Server.homeZ + " " + Server.homeType);
                Command.all.Find("load").Use(p, " " + p.name);
                Command.all.Find("goto").Use(p, " " + p.name);
                Command.all.Find("save").Use(p, " " + p.name + " wipe");
                Command.all.Find("xzone").Use(p, " " + p.name + " " + p.name);
                p.ignorePermission = false;
            }
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/home - Takes you to your home or creates a home for you");
        }
    }
}