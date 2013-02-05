using System;

namespace MCSong
{
    public class CmdUnwarn : Command
    {
        public override string name { get { return "unwarn"; } }
        public override string shortcut { get { return ""; } }
        public override string type { get { return "moderation"; } }
        public override bool museumUsable { get { return true; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Operator; } }

        public override void Use(Player p, string message)
        {
            Player pl = Player.Find(message);
            if (message == "") { Help(p); return; }
            if (p == null)
            {
                if (pl == null) { Player.SendMessage(p, "Player \"" + message + "\"not found!"); return; }
                if (!pl.warned) { Player.SendMessage(p, pl.color + pl.name + Server.DefaultColor + " has not been warned!"); return; }
                pl.warned = false;
                Player.SendMessage(pl, "Unwarned by &cConsole");
                Player.GlobalMessageOps("To Ops" + c.white + " - " + pl.color + pl.name + c.white + " was unwarned by &aConsole");
                Server.s.Log(pl.name + " was unwarned by Console");
            }
            else
            {
                if (pl == null) { Player.SendMessage(p, "Player \"" + message + "\"not found!"); return; }
                if (pl == p) { Player.SendMessage(p, "You cannot unwarn yourself!"); return; }
                if (p.warned) { Player.SendMessage(p, "You cannot unwarn a player if you are warned!"); return; }
                if (p.group.Permission <= pl.group.Permission) { Player.SendMessage(p, "You can't unwarn a player of an equal or higher rank!"); return; }
                if (!pl.warned) { Player.SendMessage(p, pl.color + pl.name + Server.DefaultColor + " has not been warned!"); return; }
                pl.warned = false;
                Player.SendMessage(pl, "Unwarned by " + p.color + p.name);
                Player.GlobalMessageOps("To Ops" + c.white + " - " + pl.color + pl.name + c.white + " was unwarned by " + p.color + p.name);
                Server.s.Log(pl.name + " was unwarned by " + p.name);
                if (p.group.Permission < Server.opchatperm)
                {
                    Player.SendMessage(p, pl.color + pl.name + c.white + "was unwarned by " + p.color + p.name);
                }
            }
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/unwarn <player> - Remove a player's warned status");
        }
    }
}