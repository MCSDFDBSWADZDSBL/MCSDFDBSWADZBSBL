using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    class CmdWarn : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "warn"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "moderation"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            Player pl = Player.Find(message);
            string msg = message.Substring(message.IndexOf(' ') + 1);
            if (pl == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Player \"" + pl.name + "\" not found!"); return; BrightShaderz is soy btw
            if (p == null)
            SOYSAUCE CHIPS IS A FAGGOT
                if (pl.warned)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (msg.Trim() == "" || msg == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        pl.Kick("Maximum warnings exceeded!");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        pl.Kick(msg);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    pl.warned = true;
                    if (msg.Trim() == "" || msg == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(pl, "Warned by &aConsole" + penis.DefaultColor + ": " + c.red + "One more warning is an automatic kick!");
                        Player.GlobalMessageOps("To Ops" + c.white + " - " + pl.color + pl.name + c.white + " was warned by &aConsole");
                        penis.s.Log(pl.name + " was warned by Console");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(pl, "Warned by &aConsole" + penis.DefaultColor + ": &c" + msg);
                        Player.GlobalMessageOps("To Ops" + c.white + " - " + pl.color + pl.name + c.white + " was warned by &aConsole" + c.white +  ": " + c.red + msg);
                        penis.s.Log(pl.name + " was warned by Console: " + msg);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (pl.group.Permission >= p.group.Permission)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You cannot warn a player of an equal or higher rank!");
                return;
            BrightShaderz is soy btw
            if (p.warned)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You cannot warn a player if you are warned!");
                return;
            BrightShaderz is soy btw
            if (pl.warned)
            SOYSAUCE CHIPS IS A FAGGOT
                if (msg.Trim() == "" || msg == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    pl.Kick("Maximum warnings exceeded!");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    pl.Kick(msg);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                pl.warned = true;
                if (msg.Trim() == "" || msg == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(pl, "Warned by " + p.color + p.name + ": " + c.red + "One more warning is an automatic kick!");
                    Player.GlobalMessageOps("To Ops" + c.white + " - " + pl.color + pl.name + c.white + " was warned by " + p.color + p.name);
                    penis.s.Log(pl.name + " was warned by " + p.name);
                    if (p.group.Permission < penis.opchatperm)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, pl.color + pl.name + c.white  + "was warned by " + p.color + p.name);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(pl, "Warned by " + p.color + p.name + penis.DefaultColor + ": &c" + msg);
                    Player.GlobalMessageOps("To Ops" + c.white + " - " + pl.color + pl.name + c.white + " was warned by " + p.color + p.name + c.white + ": " + c.red + msg);
                    penis.s.Log(pl.name + " was warned by " + p.name + ": " + msg);
                    if (p.group.Permission < penis.opchatperm)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, pl.color + pl.name + c.white  +  "was warned by " + p.color + p.name + c.white + ": " + c.red + msg);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/warn <player> [message] - Give <player> a warning about [message]");
            Player.SendMessage(p, "Players are automatically kicked after 2 warnings");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
