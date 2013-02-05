using System;

namespace MCSong
{
    public class CmdHmotd : Command
    {
        public override string name { get { return "hmotd"; } }
        public override string shortcut { get { return ""; } }
        public override string type { get { return "homes"; } }
        public override bool museumUsable { get { return false; } }
        public override LevelPermission defaultRank { get { return LevelPermission.AdvBuilder; } }
        public override void Use(Player p, string message)
        {
            if (p == null) { Player.SendMessage(p, "Command not useable from console"); return; }
            if (p.level != Level.FindExact(p.name)) { Player.SendMessage(p, "You must be at your home to use this command"); return; }
            if (message == "") { Help(p); return; }
            Command.all.Find("map").Use(p, message);
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/hmotd <message> - Set your home's MOTD");
        }
    }
}