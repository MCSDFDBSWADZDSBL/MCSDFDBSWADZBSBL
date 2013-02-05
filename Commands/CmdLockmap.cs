using System;

namespace MCSong
{
    class CmdLockmap : Command
    {
        public override string name { get { return "lockmap"; } }
        public override string shortcut { get { return "lm"; } }
        public override string type { get { return "moderation"; } }
        public override bool museumUsable { get { return true; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Operator; } }
        public override void Use(Player p, string message)
        {
            Level l = Level.Find(message);
            if (l == null) { Player.SendMessage(p, "Level \"" + message + "\" not found!"); return; }
            if (l.locked)
            {
                l.locked = false;
                Player.GlobalMessage(l.name + " was unlocked!");
                return;
            }
            if (!l.locked)
            {
                l.locked = true;
                Player.GlobalMessage(l.name + " was locked!");
                return;
            }
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/lockmap [mapname] - Prevent players from entering a map");
            Player.SendMessage(p, "If [mapname] is left blank, your current map is used");
        }
    }
}
