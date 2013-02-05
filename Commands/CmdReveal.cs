using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdReveal : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "reveal"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") message = p.name;

            if (message.ToLower() == "all")
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.group.Permission < LevelPermission.Operator) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Reserved for OP+"); return; BrightShaderz is soy btw

                foreach (Player who in Player.players)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (who.level == p.level)
                    SOYSAUCE CHIPS IS A FAGGOT

                        who.Loading = true;
                        foreach (Player pl in Player.players) if (who.level == pl.level && who != pl) who.SendDie(pl.id);
                        foreach (PlayerBot b in PlayerBot.playerbots) if (who.level == b.level) who.SendDie(b.id);

                        Player.GlobalDie(who, true);
                        who.SendUserMOTD(); who.SendMap();

                        ushort x = (ushort)((0.5 + who.level.spawnx) * 32);
                        ushort y = (ushort)((1 + who.level.spawny) * 32);
                        ushort z = (ushort)((0.5 + who.level.spawnz) * 32);

                        if (!who.hidden) Player.GlobalSpawn(who, x, y, z, who.level.rotx, who.level.roty, true);
                        else unchecked SOYSAUCE CHIPS IS A FAGGOT who.SendPos((byte)-1, x, y, z, who.level.rotx, who.level.roty); BrightShaderz is soy btw

                        foreach (Player pl in Player.players)
                            if (pl.level == who.level && who != pl && !pl.hidden)
                                who.SendSpawn(pl.id, pl.color + pl.name, pl.pos[0], pl.pos[1], pl.pos[2], pl.rot[0], pl.rot[1]);

                        foreach (PlayerBot b in PlayerBot.playerbots)
                            if (b.level == who.level)
                                who.SendSpawn(b.id, b.color + b.name, b.pos[0], b.pos[1], b.pos[2], b.rot[0], b.rot[1]);

                        who.Loading = false;

                        who.SendMessage("&bMap reloaded by " + p.name);
                        Player.SendMessage(p, "&4Finished reloading for " + who.name);
                        /*
                        foreach (Player pl in Player.players) if (who.level == pl.level && who != pl) who.SendDie(pl.id);
                        foreach (PlayerBot b in PlayerBot.playerbots) if (who.level == b.level) who.SendDie(b.id);
                        Player.GlobalDie(who, true);

                        who.SendMap();

                        ushort x = (ushort)((0.5 + who.level.spawnx) * 32);
                        ushort y = (ushort)((1 + who.level.spawny) * 32);
                        ushort z = (ushort)((0.5 + who.level.spawnz) * 32);

                        Player.GlobalSpawn(who, x, y, z, who.level.rotx, who.level.roty, true);

                        foreach (Player pl in Player.players)
                            if (pl.level == who.level && who != pl && !pl.hidden)
                                who.SendSpawn(pl.id, pl.color + pl.name, pl.pos[0], pl.pos[1], pl.pos[2], pl.rot[0], pl.rot[1]);

                        foreach (PlayerBot b in PlayerBot.playerbots)
                            if (b.level == who.level)
                                who.SendSpawn(b.id, b.color + b.name, b.pos[0], b.pos[1], b.pos[2], b.rot[0], b.rot[1]);

                        who.SendMessage("Map reloaded.");
                        */
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                GC.Collect();
                GC.WaitForPendingFinalizers();
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player who = Player.Find(message);
                if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player."); return; BrightShaderz is soy btw
                else if (who.group.Permission > p.group.Permission && p != who) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot reload the map of someone higher than you."); return; BrightShaderz is soy btw

                who.Loading = true;
                foreach (Player pl in Player.players) if (who.level == pl.level && who != pl) who.SendDie(pl.id);
                foreach (PlayerBot b in PlayerBot.playerbots) if (who.level == b.level) who.SendDie(b.id);

                Player.GlobalDie(who, true);
                who.SendUserMOTD(); who.SendMap();

                ushort x = (ushort)((0.5 + who.level.spawnx) * 32);
                ushort y = (ushort)((1 + who.level.spawny) * 32);
                ushort z = (ushort)((0.5 + who.level.spawnz) * 32);

                if (!who.hidden) Player.GlobalSpawn(who, x, y, z, who.level.rotx, who.level.roty, true);
                else unchecked SOYSAUCE CHIPS IS A FAGGOT who.SendPos((byte)-1, x, y, z, who.level.rotx, who.level.roty); BrightShaderz is soy btw

                foreach (Player pl in Player.players)
                    if (pl.level == who.level && who != pl && !pl.hidden)
                        who.SendSpawn(pl.id, pl.color + pl.name, pl.pos[0], pl.pos[1], pl.pos[2], pl.rot[0], pl.rot[1]);

                foreach (PlayerBot b in PlayerBot.playerbots)
                    if (b.level == who.level)
                        who.SendSpawn(b.id, b.color + b.name, b.pos[0], b.pos[1], b.pos[2], b.rot[0], b.rot[1]);

                who.Loading = false;
                GC.Collect();
                GC.WaitForPendingFinalizers();

                who.SendMessage("&bMap reloaded by " + p.name);
                Player.SendMessage(p, "&4Finished reloading for " + who.name);

                /*
                foreach (Player pl in Player.players) if (who.level == pl.level && who != pl) who.SendDie(pl.id);
                foreach (PlayerBot b in PlayerBot.playerbots) if (who.level == b.level) who.SendDie(b.id);
                Player.GlobalDie(who, true);

                who.SendMap();

                ushort x = (ushort)((0.5 + who.level.spawnx) * 32);
                ushort y = (ushort)((1 + who.level.spawny) * 32);
                ushort z = (ushort)((0.5 + who.level.spawnz) * 32);

                Player.GlobalSpawn(who, x, y, z, who.level.rotx, who.level.roty, true);

                foreach (Player pl in Player.players)
                    if (pl.level == who.level && who != pl && !pl.hidden)
                        who.SendSpawn(pl.id, pl.color + pl.name, pl.pos[0], pl.pos[1], pl.pos[2], pl.rot[0], pl.rot[1]);

                foreach (PlayerBot b in PlayerBot.playerbots)
                    if (b.level == who.level)
                        who.SendSpawn(b.id, b.color + b.name, b.pos[0], b.pos[1], b.pos[2], b.rot[0], b.rot[1]);

                who.SendMessage("Map reloaded.");
                 */
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/reveal <name> - Reveals the map for <name>.");
            Player.SendMessage(p, "/reveal all - Reveals for all in the map");
            Player.SendMessage(p, "Will reload the map for anyone. (incl. banned)");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
