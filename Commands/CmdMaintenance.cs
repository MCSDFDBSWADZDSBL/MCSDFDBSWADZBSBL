using System;

namespace MCSong
{
    class CmdMaintenance : Command
    {
        public override string name { get { return "maintenance"; } }
        public override string shortcut { get { return "maint"; } }
        public override string type { get { return "moderation"; } }
        public override bool museumUsable { get { return true; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Operator; } }
        public override void Use(Player p, string message)
        {
            Server.maintenanceMode = !Server.maintenanceMode;
            Server.Maintenance();
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/maintenance - Toggles maintenance mode");
            if (Server.maintenanceMode)
                Player.SendMessage(p, "Maintenance Mode is currently &cON");
            else
                Player.SendMessage(p, "Maintenance Mode is currently &cOFF");
        }
    }
}
