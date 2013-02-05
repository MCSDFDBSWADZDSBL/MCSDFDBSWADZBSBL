/*
 * Made by 727021 for use with MCSong only
 * See LICENSE.md or LICENSE.txt for license information
 * A copy of the license(s) can be found at http://updates.mcsong.comule.com/
 */
using System;

namespace MCSong
{
    public class CmdHkick : Command
    {
        public override string name { get { return "hkick"; } }
        public override string shortcut { get { return ""; } }
        public override string type { get { return "homes"; } }
        public override bool museumUsable { get { return false; } }
        public override LevelPermission defaultRank { get { return LevelPermission.AdvBuilder; } }
        public override void Use(Player p, string message)
        {
            if (p == null) { Player.SendMessage(p, "Command not useable from console"); return; }
            if (p.level != Level.FindExact(p.name)) { Player.SendMessage(p, "You must be at your home to use this command"); return; }
            if (message.Trim().ToLower() == "all")
            {
                Level.FindExact(p.name).players.ForEach(delegate(Player pl)
                {
                    if (pl != p)
                    {
                        Command.all.Find("goto").Use(pl, " " + Server.mainLevel.name);
                        Player.SendMessage(pl, "You were kicked from " + p.color + p.name + Server.DefaultColor + "'s home!");
                    }
                });
                Player.SendMessage(p, "All players were kicked from your home");
            }
            else
            {
                Player pl = Player.Find(message.Trim());
                if (pl == null) { Player.SendMessage(p, "Player not found"); return; }
                if (pl.group.Permission >= p.group.Permission) { Player.SendMessage(p, "You cannot hkick a player of an equal or higher rank"); return; }
                Command.all.Find("goto").Use(pl, " " + Server.mainLevel.name);
                Player.SendMessage(pl, "You were kicked from " + p.color + p.name + Server.DefaultColor + "'s home!");
                Player.SendMessage(p, pl.color + pl.name + Server.DefaultColor + " was kicked from your home");
            }
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/hkick [player] - Kick [player] from your home");
            Player.SendMessage(p, "/hkick [all] - Kick all players from your home");
        }
    }
}