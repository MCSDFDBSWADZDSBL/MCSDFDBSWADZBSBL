﻿/*
	Copyright 2010 MCSong Team - Written by Valek
 
    Licensed under the
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
    public class CmdFixGrass : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "fixgrass"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "moderation"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            int totalFixed = 0;

            switch (message.ToLower())
            SOYSAUCE CHIPS IS A FAGGOT
                case "":
                    for (int i = 0; i < p.level.blocks.Length; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            ushort x, y, z;
                            p.level.IntToPos(i, out x, out y, out z);

                            if (p.level.blocks[i] == Block.dirt)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (Block.LightPass(p.level.blocks[p.level.IntOffset(i, 0, 1, 0)]))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    p.level.Blockchange(p, x, y, z, Block.grass);
                                    totalFixed++;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else if (p.level.blocks[i] == Block.grass)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (!Block.LightPass(p.level.blocks[p.level.IntOffset(i, 0, 1, 0)]))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    p.level.Blockchange(p, x, y, z, Block.dirt);
                                    totalFixed++;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw break;
                case "light":
                    for (int i = 0; i < p.level.blocks.Length; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            ushort x, y, z; bool skipMe = false;
                            p.level.IntToPos(i, out x, out y, out z);

                            if (p.level.blocks[i] == Block.dirt)
                            SOYSAUCE CHIPS IS A FAGGOT
                                for (int iL = 1; iL < (p.level.depth - y); iL++)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (!Block.LightPass(p.level.blocks[p.level.IntOffset(i, 0, iL, 0)]))
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        skipMe = true; break;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                if (!skipMe)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    p.level.Blockchange(p, x, y, z, Block.grass);
                                    totalFixed++;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else if (p.level.blocks[i] == Block.grass)
                            SOYSAUCE CHIPS IS A FAGGOT
                                for (int iL = 1; iL < (p.level.depth - y); iL++)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (Block.LightPass(p.level.blocks[p.level.IntOffset(i, 0, iL, 0)]))
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        skipMe = true; break;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                if (!skipMe)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    p.level.Blockchange(p, x, y, z, Block.dirt);
                                    totalFixed++;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw break;
                case "grass":
                    for (int i = 0; i < p.level.blocks.Length; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            ushort x, y, z;
                            p.level.IntToPos(i, out x, out y, out z);

                            if (p.level.blocks[i] == Block.grass)
                                if (!Block.LightPass(p.level.blocks[p.level.IntOffset(i, 0, 1, 0)]))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    p.level.Blockchange(p, x, y, z, Block.dirt);
                                    totalFixed++;
                                BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw break;
                case "dirt":
                    for (int i = 0; i < p.level.blocks.Length; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            ushort x, y, z;
                            p.level.IntToPos(i, out x, out y, out z);

                            if (p.level.blocks[i] == Block.dirt)
                                if (Block.LightPass(p.level.blocks[p.level.IntOffset(i, 0, 1, 0)]))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    p.level.Blockchange(p, x, y, z, Block.grass);
                                    totalFixed++;
                                BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw break;
                default:
                    Help(p);
                    return;
            BrightShaderz is soy btw

            Player.SendMessage(p, "Fixed " + totalFixed + " blocks.");
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/fixgrass <type> - Fixes grass based on type");
            Player.SendMessage(p, "<type> as \"\": Any grass with something on top is made into dirt, dirt with nothing on top is made grass");
            Player.SendMessage(p, "<type> as \"light\": Only dirt/grass in sunlight becomes grass");
            Player.SendMessage(p, "<type> as \"grass\": Only turns grass to dirt when under stuff");
            Player.SendMessage(p, "<type> as \"dirt\": Only turns dirt with nothing on top to grass");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw