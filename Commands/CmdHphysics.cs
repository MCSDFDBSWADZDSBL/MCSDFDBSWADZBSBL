using System;

namespace MCSong
{
    public class CmdHphysics : Command
    {
        public override string name { get { return "hphysics"; } }
        public override string shortcut { get { return "hphys"; } }
        public override string type { get { return "homes"; } }
        public override bool museumUsable { get { return false; } }
        public override LevelPermission defaultRank { get { return LevelPermission.AdvBuilder; } }
        public override void Use(Player p, string message)
        {
            if (p == null) { Player.SendMessage(p, "Command not useable from console"); return; }
            if (p.level != Level.FindExact(p.name)) { Player.SendMessage(p, "You must be at your home to use this command"); return; }
            int ph = Convert.ToInt32(Server.homePhys);
            Level lvl = Level.Find(p.name);
            if (lvl.physics != ph)
            {
                lvl.setPhysics(ph);
                switch (ph)
                {
                    case 0:
                        lvl.ClearPhysics();
                        Player.GlobalMessage("Physics are now &cOFF" + Server.DefaultColor + " on &b" + lvl.name + Server.DefaultColor + ".");
                        Server.s.Log("Physics are now OFF on " + lvl.name + ".");
                        IRCBot.Say("Physics are now OFF on " + lvl.name + ".");
                        break;
                    case 1:
                        Player.GlobalMessage("Physics are now &aNormal" + Server.DefaultColor + " on &b" + lvl.name + Server.DefaultColor + ".");
                        Server.s.Log("Physics are now NORMAL on " + lvl.name + ".");
                        IRCBot.Say("Physics are now NORMAL on " + lvl.name + ".");
                        break;
                    case 2:
                        Player.GlobalMessage("Physics are now &aAdvanced" + Server.DefaultColor + " on &b" + lvl.name + Server.DefaultColor + ".");
                        Server.s.Log("Physics are now ADVANCED on " + lvl.name + ".");
                        IRCBot.Say("Physics are now ADVANCED on " + lvl.name + ".");
                        break;
                    case 3:
                        Player.GlobalMessage("Physics are now &aHardcore" + Server.DefaultColor + " on &b" + lvl.name + Server.DefaultColor + ".");
                        Server.s.Log("Physics are now HARDCORE on " + lvl.name + ".");
                        IRCBot.Say("Physics are now HARDCORE on " + lvl.name + ".");
                        break;
                    case 4:
                        Player.GlobalMessage("Physics are now &aInstant" + Server.DefaultColor + "on &b" + lvl.name + Server.DefaultColor + ".");
                        Server.s.Log("Physics are now INSTANT on " + lvl.name + ".");
                        Server.s.Log("Physics are now INSTANT on " + lvl.name + ".");
                        break;
                }
            }
            else
            {
                lvl.ClearPhysics();
                Player.GlobalMessage("Physics are now &cOFF" + Server.DefaultColor + " on &b" + lvl.name + Server.DefaultColor + ".");
                Server.s.Log("Physics are now OFF on " + lvl.name + ".");
                IRCBot.Say("Physics are now OFF on " + lvl.name + ".");
            }
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/hphysics - Toggles physics on/off for your home");
        }
    }
}