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
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdTp : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "tp"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("spawn");
                return;
            BrightShaderz is soy btw
            string[] split = message.Split(' ');
            if (split.Length <= 1)
            SOYSAUCE CHIPS IS A FAGGOT
                Player who = Player.Find(message);
                if (who == null || (who.hidden && p.group.Permission < LevelPermission.Admin)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no player \"" + message + "\"!"); return; BrightShaderz is soy btw
                if (p.level != who.level)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (who.level.name.Contains("cMuseum"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Player \"" + message + "\" is in a museum!");
                        return;
                    BrightShaderz is soy btw
                    if (who.level.locked)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Player \"" + message + "\" is in a locked level!");
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Command.all.Find("goto").Use(p, who.level.name);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (p.level == who.level)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (who.Loading)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Waiting for " + who.color + who.name + penis.DefaultColor + " to spawn...");
                        while (who.Loading) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    while (p.Loading) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw  //Wait for player to spawn in new map
                    unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, who.pos[0], who.pos[1], who.pos[2], who.rot[0], 0); BrightShaderz is soy btw
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            if (split.Length <= 2)
            SOYSAUCE CHIPS IS A FAGGOT
                ushort x;
                ushort y;
                ushort z;
                try // X (width)
                SOYSAUCE CHIPS IS A FAGGOT
                    x = Convert.ToUInt16(split[0]);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid coordinates!"); return; BrightShaderz is soy btw
                try // Y (height)
                SOYSAUCE CHIPS IS A FAGGOT
                    y = Convert.ToUInt16(split[1]);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid coordinates!"); return; BrightShaderz is soy btw
                try // Z (depth)
                SOYSAUCE CHIPS IS A FAGGOT
                    z = Convert.ToUInt16(split[2]);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid coordinates!"); return; BrightShaderz is soy btw
                if ((x > p.level.width) || (y > p.level.height) || (z > p.level.depth)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid coordinates!"); return; BrightShaderz is soy btw
                unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, x, y, z, p.rot[0], 0); BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/tp <x> <y> <z> - Teleports you to the coordinates x,y,z.");
            Player.SendMessage(p, "/tp <player> - Teleports yourself to a player.");
            Player.SendMessage(p, "If <player> is blank, /spawn is used.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
