using System;

namespace MCSong
{
    public class CmdHwipe : Command
    {
        public override string name { get { return "hwipe"; } }
        public override string shortcut { get { return "hw"; } }
        public override string type { get { return "homes"; } }
        public override bool museumUsable { get { return false; } }
        public override LevelPermission defaultRank { get { return LevelPermission.AdvBuilder; } }
        public override void Use(Player p, string message)
        {
            if (p == null) { Player.SendMessage(p, "Command not useable from console"); return; }
            if (p.level != Level.FindExact(p.name)) { Player.SendMessage(p, "You must be at your home to use this command!"); return; }
            if (message.ToLower().Trim() != "confirm") { Player.SendMessage(p, "Type &b/hwipe confirm" + Server.DefaultColor + " to restore your home to flatgrass."); return; }
            p.ignorePermission = true;
            Command.all.Find("restore").Use(p, " wipe");
            p.ignorePermission = false;
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/hwipe - Restores your home to flatgrass");
        }
    }
}