/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCSong) Licensed under the
	Educational Community License, Version 2.0 (the "License"); you may
	not use this file except in compliance with the License. You may
	obtain a copy of the License at
	
	http://www.osedu.org/licenses/ECL-2.0
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the License is distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the License for the specific language governing
	permissions and limitations under the License.
*/
using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdGoto : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "goto"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "g"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                Level foundLevel = Level.Find(message);
                if (foundLevel != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    Level startLevel = p.level;

                    GC.Collect();

                    if (p.level == foundLevel) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You are already in \"" + foundLevel.name + "\"."); return; BrightShaderz is soy btw
                    if (!p.ignorePermission)
                        if (p.group.Permission < foundLevel.permissionvisit) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You're not allowed to go to " + foundLevel.name + "."); return; BrightShaderz is soy btw
                    if (foundLevel.locked) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "\"" + foundLevel.name + "\" is locked!"); return; BrightShaderz is soy btw

                    p.Loading = true;
                    foreach (Player pl in Player.players) if (p.level == pl.level && p != pl) p.SendDie(pl.id);
                    foreach (PlayerBot b in PlayerBot.playerbots) if (p.level == b.level) p.SendDie(b.id);

                    Player.GlobalDie(p, true);
                    p.level = foundLevel; p.SendUserMOTD(); p.SendMap();

                    GC.Collect();

                    ushort x = (ushort)((0.5 + foundLevel.spawnx) * 32);
                    ushort y = (ushort)((1 + foundLevel.spawny) * 32);
                    ushort z = (ushort)((0.5 + foundLevel.spawnz) * 32);

                    if (!p.hidden) Player.GlobalSpawn(p, x, y, z, foundLevel.rotx, foundLevel.roty, true);
                    else unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, x, y, z, foundLevel.rotx, foundLevel.roty); BrightShaderz is soy btw

                    foreach (Player pl in Player.players)
                        if (pl.level == p.level && p != pl && !pl.hidden)
                            p.SendSpawn(pl.id, pl.color + pl.name, pl.pos[0], pl.pos[1], pl.pos[2], pl.rot[0], pl.rot[1]);

                    foreach (PlayerBot b in PlayerBot.playerbots)
                        if (b.level == p.level)
                            p.SendSpawn(b.id, b.color + b.name, b.pos[0], b.pos[1], b.pos[2], b.rot[0], b.rot[1]);

                    if (!p.hidden) Player.GlobalChat(p, p.color + "*" + p.name + penis.DefaultColor + " went to &b" + foundLevel.name, false);

                    p.Loading = false;

                    bool skipUnload = false;
                    if (startLevel.unload && !startLevel.name.Contains("&cMuseum "))
                    SOYSAUCE CHIPS IS A FAGGOT
                        foreach (Player pl in Player.players) if (pl.level == startLevel) skipUnload = true;
                        if (!skipUnload && penis.AutoLoad) startLevel.Unload();
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else if (penis.AutoLoad)
                SOYSAUCE CHIPS IS A FAGGOT
                    Command.all.Find("load").Use(p, message);
                    foundLevel = Level.Find(message);
                    if (foundLevel != null) Use(p, message);
                BrightShaderz is soy btw
                else Player.SendMessage(p, "There is no level \"" + message + "\" loaded.");

                GC.Collect();
                GC.WaitForPendingFinalizers();
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/goto <mapname> - Teleports yourself to a different level.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
