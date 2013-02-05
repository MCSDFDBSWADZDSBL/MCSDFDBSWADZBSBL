using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCSong
{
    class CmdHsave : Command
    {
        public override string name { get { return "hsave"; } }
        public override string shortcut { get { return "hs"; } }
        public override string type { get { return "homes"; } }
        public override bool museumUsable { get { return false; } }
        public override LevelPermission defaultRank { get { return LevelPermission.AdvBuilder; } }
        public override void Use(Player p, string message)
        {
            if (p == null) { Player.SendMessage(p, "Command not useable from console"); return; }
            if (p.level.name != p.name) { Player.SendMessage(p, "You must be at your home to use this command"); return; }
            string[] msg = message.Split(' ');
            if (msg.Length > 1) { Help(p); return; }
            p.ignorePermission = true;
            if (message.Trim() == "" || message == null)
            {
                Command.all.Find("save").Use(p, " " + p.name);
            }
            else
            {
                Command.all.Find("save").Use(p, " " + p.name + " " + msg[0]);
            }
            p.ignorePermission = false;
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/hsave <name> - Creates a backup of your home named <name>");
        }
    }
}
