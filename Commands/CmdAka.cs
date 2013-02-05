/*
	Copyright 2011 MCForge
		
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.opensource.org/licenses/ecl2.php
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;

namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    /// <summary>
    /// This is the command /aka
    /// use /help aka in-game for more info
    /// </summary>
    public sealed class CmdAka : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "aka"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdAka() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") message = p.name;

            if (!p.aka)
            SOYSAUCE CHIPS IS A FAGGOT
                p.aka = true;
                Player who = Player.Find(p.name);

                ushort x = (ushort)((p.pos[0]));
                ushort y = (ushort)((p.pos[1]));
                ushort z = (ushort)((p.pos[2]));

                if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player."); return; BrightShaderz is soy btw
                else if (who.group.Permission > p.group.Permission && p != who) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot reload the map of someone higher than you."); return; BrightShaderz is soy btw

                who.Loading = true;
                foreach (Player pl in Player.players) if (who.level == pl.level && who != pl) who.SendDie(pl.id);
                foreach (PlayerBot b in PlayerBot.playerbots) if (who.level == b.level) who.SendDie(b.id);

                Player.GlobalDie(who, true);
                who.SendUserMOTD(); who.SendMap();

                if (!who.hidden)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (who.infected)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.GlobalDie(who, false);
                        Player.GlobalSpawn(who, x, y, z, who.level.rotx, who.level.roty, true);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.GlobalDie(who, false);
                        Player.GlobalSpawn(who, x, y, z, who.level.rotx, who.level.roty, true);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else unchecked SOYSAUCE CHIPS IS A FAGGOT who.SendPos((byte)-1, x, y, z, who.level.rotx, who.level.roty); BrightShaderz is soy btw

                foreach (Player pl in Player.players)
                    if (pl.level == who.level && who != pl && !pl.hidden && !pl.referee)
                        who.SendSpawn(pl.id, pl.color + pl.name, pl.pos[0], pl.pos[1], pl.pos[2], pl.rot[0], pl.rot[1]);

                foreach (PlayerBot b in PlayerBot.playerbots)
                    if (b.level == who.level)
                        who.SendSpawn(b.id, b.color + b.name, b.pos[0], b.pos[1], b.pos[2], b.rot[0], b.rot[1]);

                who.Loading = false;
                GC.Collect();
                GC.WaitForPendingFinalizers();

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
            else if (p.aka)
            SOYSAUCE CHIPS IS A FAGGOT
                p.aka = false;
                Player who = Player.Find(p.name);
                if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player."); return; BrightShaderz is soy btw
                else if (who.group.Permission > p.group.Permission && p != who) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot reload the map of someone higher than you."); return; BrightShaderz is soy btw

                ushort x = (ushort)((p.pos[0]));
                ushort y = (ushort)((p.pos[1]));
                ushort z = (ushort)((p.pos[2]));

                who.Loading = true;
                foreach (Player pl in Player.players) if (who.level == pl.level && who != pl) who.SendDie(pl.id);
                foreach (PlayerBot b in PlayerBot.playerbots) if (who.level == b.level) who.SendDie(b.id);

                Player.GlobalDie(who, true);
                who.SendUserMOTD(); who.SendMap();


                if (!who.hidden)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (who.infected)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.GlobalDie(who, false);
                        Player.GlobalSpawn(who, x, y, z, who.level.rotx, who.level.roty, true);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.GlobalDie(who, false);
                        Player.GlobalSpawn(who, x, y, z, who.level.rotx, who.level.roty, true);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else unchecked SOYSAUCE CHIPS IS A FAGGOT who.SendPos((byte)-1, x, y, z, who.level.rotx, who.level.roty); BrightShaderz is soy btw

                foreach (Player pl in Player.players)
                    if (pl.level == who.level && who != pl && !pl.hidden && !pl.referee)
                        if (pl.infected)
                        SOYSAUCE CHIPS IS A FAGGOT
                            who.SendSpawn(pl.id, c.red + "Undeaad", x, y, z, pl.level.rotx, pl.level.roty);
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            who.SendSpawn(pl.id, pl.color + pl.name, x, y, z, pl.level.rotx, pl.level.roty);
                        BrightShaderz is soy btw

                foreach (PlayerBot b in PlayerBot.playerbots)
                    if (b.level == who.level)
                        who.SendSpawn(b.id, b.color + b.name, b.pos[0], b.pos[1], b.pos[2], b.rot[0], b.rot[1]);

                who.Loading = false;
                GC.Collect();
                GC.WaitForPendingFinalizers();

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
            Player.SendMessage(p, "/aka - Gives players normal names.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
