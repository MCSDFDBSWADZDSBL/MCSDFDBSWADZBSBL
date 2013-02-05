using System;

namespace MCSong
{
    class CmdHlockmap : Command
    {
        public override string name { get { return "hlockmap"; } }
        public override string shortcut { get { return "hlock"; } }
        public override string type { get { return "homes"; } }
        public override bool museumUsable { get { return false; } }
        public override LevelPermission defaultRank { get { return LevelPermission.AdvBuilder; } }
        public override void Use(Player p, string message)
        {
            Level l = Level.Find(p.name);
            if (p.level != l) { Player.SendMessage(p, "You must be in your home to use this command!"); return; }
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
