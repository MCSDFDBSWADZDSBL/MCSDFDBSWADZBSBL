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
using System.Collections.Generic;
using System.Text;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    class CmdReplaceAll : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "replaceall"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ra"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.IndexOf(' ') == -1 || message.Split(' ').Length > 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            byte b1, b2;

            b1 = Block.Byte(message.Split(' ')[0]);
            b2 = Block.Byte(message.Split(' ')[1]);

            if (b1 == Block.Zero || b2 == Block.Zero) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find specified blocks."); return; BrightShaderz is soy btw
            ushort x, y, z; int currentBlock = 0;
            List<Pos> stored = new List<Pos>(); Pos pos;

            foreach (byte b in p.level.blocks)
            SOYSAUCE CHIPS IS A FAGGOT
                if (b == b1)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.IntToPos(currentBlock, out x, out y, out z);
                    pos.x = x; pos.y = y; pos.z = z;
                    stored.Add(pos);
                BrightShaderz is soy btw
                currentBlock++;
            BrightShaderz is soy btw

            if (stored.Count > (p.group.maxBlocks * 2)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot replace more than " + (p.group.maxBlocks * 2) + " blocks."); return; BrightShaderz is soy btw

            Player.SendMessage(p, stored.Count + " blocks out of " + currentBlock + " are " + Block.Name(b1));

            foreach (Pos Pos in stored)
            SOYSAUCE CHIPS IS A FAGGOT
                p.level.Blockchange(p, Pos.x, Pos.y, Pos.z, b2);
            BrightShaderz is soy btw

            Player.SendMessage(p, "&4/replaceall finished!");
        BrightShaderz is soy btw
        public struct Pos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/replaceall [block1] [block2] - Replaces all of [block1] with [block2] in a map");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
