using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdMove : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "move"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            // /move name map
            // /move x y z
            // /move name x y z

            if (message.Split(' ').Length < 2 || message.Split(' ').Length > 4) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            if (message.Split(' ').Length == 2)     // /move name map
            SOYSAUCE CHIPS IS A FAGGOT
                Player who = Player.Find(message.Split(' ')[0]);
                Level where = Level.Find(message.Split(' ')[1]);
                if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player specified"); return; BrightShaderz is soy btw
                if (where == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find level specified"); return; BrightShaderz is soy btw
                if (p != null && who.group.Permission > p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot move someone of greater rank"); return; BrightShaderz is soy btw

                Command.all.Find("goto").Use(who, where.name);
                if (who.level == where)
                    Player.SendMessage(p, "Sent " + who.color + who.name + penis.DefaultColor + " to " + where.name);
                else
                    Player.SendMessage(p, where.name + " is not loaded");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                // /move name x y z
                // /move x y z

                Player who;

                if (message.Split(' ').Length == 4)
                SOYSAUCE CHIPS IS A FAGGOT
                    who = Player.Find(message.Split(' ')[0]);
                    if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player specified"); return; BrightShaderz is soy btw
                    if (p != null && who.group.Permission > p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot move someone of greater rank"); return; BrightShaderz is soy btw
                    message = message.Substring(message.IndexOf(' ') + 1);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    who = p;
                BrightShaderz is soy btw

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    ushort x = System.Convert.ToUInt16(message.Split(' ')[0]);
                    ushort y = System.Convert.ToUInt16(message.Split(' ')[1]);
                    ushort z = System.Convert.ToUInt16(message.Split(' ')[2]);
                    x *= 32; x += 16;
                    y *= 32; y += 32;
                    z *= 32; z += 16;
                    unchecked SOYSAUCE CHIPS IS A FAGGOT who.SendPos((byte)-1, x, y, z, p.rot[0], p.rot[1]); BrightShaderz is soy btw
                    if (p != who) Player.SendMessage(p, "Moved " + who.color + who.name);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid co-ordinates"); BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/move <player> <map> <x> <y> <z> - Move <player>");
            Player.SendMessage(p, "<map> must be blank if x, y or z is used and vice versa");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
