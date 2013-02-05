using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdJail : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "jail"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if ((message.ToLower() == "create" || message.ToLower() == "") && p != null)
            SOYSAUCE CHIPS IS A FAGGOT
                p.level.jailx = p.pos[0]; p.level.jaily = p.pos[1]; p.level.jailz = p.pos[2];
                p.level.jailrotx = p.rot[0]; p.level.jailroty = p.rot[1];
                Player.SendMessage(p, "Set Jail point.");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player who = Player.Find(message);
                if (who != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!who.jailed)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (p != null) if (who.group.Permission >= p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot jail someone of equal or greater rank."); return; BrightShaderz is soy btw
                        if (who.level != p.level) Command.all.Find("goto").Use(who, p.level.name);
                        Player.GlobalDie(who, false);
                        Player.GlobalSpawn(who, p.level.jailx, p.level.jaily, p.level.jailz, p.level.jailrotx, p.level.jailroty, true);
                        who.jailed = true;
                        Player.GlobalChat(null, who.color + who.name + penis.DefaultColor + " was &8jailed", false);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        who.jailed = false;
                        Player.GlobalChat(null, who.color + who.name + penis.DefaultColor + " was &afreed" + penis.DefaultColor + " from jail", false);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Could not find specified player.");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/jail [user] - Places [user] in jail unable to use commands.");
            Player.SendMessage(p, "/jail [create] - Creates the jail point for the map.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
