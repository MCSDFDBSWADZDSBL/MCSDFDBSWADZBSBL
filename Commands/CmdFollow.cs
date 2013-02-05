using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdFollow : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "follow"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!p.canBuild)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You're currently being &4possessed" + penis.DefaultColor + "!");
                return;
            BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                bool stealth = false;

                if (message != "")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (message == "#")
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (p.following != "")
                        SOYSAUCE CHIPS IS A FAGGOT
                            stealth = true;
                            message = "";
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Help(p);
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else if (message.IndexOf(' ') != -1)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (message.Split(' ')[0] == "#")
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.hidden) stealth = true;
                            message = message.Split(' ')[1];
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                Player who = Player.Find(message);
                if (message == "" && p.following == "") SOYSAUCE CHIPS IS A FAGGOT
                    Help(p);
                    return;
                BrightShaderz is soy btw
                else if (message == "" && p.following != "" || message == p.following)
                SOYSAUCE CHIPS IS A FAGGOT
                    who = Player.Find(p.following);
                    p.following = "";
                    if (p.hidden)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (who != null)
                            p.SendSpawn(who.id, who.color + who.name, who.pos[0], who.pos[1], who.pos[2], who.rot[0], who.rot[1]);
                        if (!stealth)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Command.all.Find("hide").Use(p, "");
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (who != null)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "You have stopped following " + who.color + who.name + penis.DefaultColor + " and remained hidden.");
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "Following stopped.");
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player."); return; BrightShaderz is soy btw
                else if (who == p) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot follow yourself."); return; BrightShaderz is soy btw
                else if (who.group.Permission >= p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot follow someone of equal or greater rank."); return; BrightShaderz is soy btw
                else if (who.following != "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, who.name + " is already following " + who.following); return; BrightShaderz is soy btw

                if (!p.hidden) Command.all.Find("hide").Use(p, "");

                if (p.level != who.level) Command.all.Find("tp").Use(p, who.name);
                if (p.following != "")
                SOYSAUCE CHIPS IS A FAGGOT
                    who = Player.Find(p.following);
                    p.SendSpawn(who.id, who.color + who.name, who.pos[0], who.pos[1], who.pos[2], who.rot[0], who.rot[1]);
                BrightShaderz is soy btw
                who = Player.Find(message);
                p.following = who.name;
                Player.SendMessage(p, "Following " + who.name + ". Use \"/follow\" to stop.");
                p.SendDie(who.id);
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); Player.SendMessage(p, "Error occured"); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/follow <name> - Follows <name> until the command is cancelled");
            Player.SendMessage(p, "/follow # <name> - Will cause /hide not to be toggled");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
