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

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdStairs : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "stairs"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT

            CatchPos cpos;
            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            Player.SendMessage(p, "Place two blocks to determine the height.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/stairs - Creates a spiral staircase the height you want.");
        BrightShaderz is soy btw
        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos bp = (CatchPos)p.blockchangeObject;
            bp.x = x; bp.y = y; bp.z = z; p.blockchangeObject = bp;
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange2);
        BrightShaderz is soy btw

        public void Swap(ref int a, ref int b)
        SOYSAUCE CHIPS IS A FAGGOT
            int c;
            c = a; a = b; b = c;
        BrightShaderz is soy btw

        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos cpos = (CatchPos)p.blockchangeObject;

            if (cpos.y == y)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Cannot create a stairway 0 blocks high.");
                return;
            BrightShaderz is soy btw

            ushort xx, zz; int currentState = 0;
            xx = cpos.x; zz = cpos.z;

            if (cpos.x > x && cpos.z > z) currentState = 0;
            else if (cpos.x > x && cpos.z < z) currentState = 1;
            else if (cpos.x < x && cpos.z > z) currentState = 2;
            else currentState = 3;

            for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
            SOYSAUCE CHIPS IS A FAGGOT
                if (currentState == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    xx++; p.level.Blockchange(p, xx, yy, zz, Block.staircasestep);
                    xx++; p.level.Blockchange(p, xx, yy, zz, Block.staircasefull);
                    currentState = 1;
                BrightShaderz is soy btw
                else if (currentState == 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    zz++; p.level.Blockchange(p, xx, yy, zz, Block.staircasestep);
                    zz++; p.level.Blockchange(p, xx, yy, zz, Block.staircasefull);
                    currentState = 2;
                BrightShaderz is soy btw
                else if (currentState == 2)
                SOYSAUCE CHIPS IS A FAGGOT
                    xx--; p.level.Blockchange(p, xx, yy, zz, Block.staircasestep);
                    xx--; p.level.Blockchange(p, xx, yy, zz, Block.staircasefull);
                    currentState = 3;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    zz--; p.level.Blockchange(p, xx, yy, zz, Block.staircasestep);
                    zz--; p.level.Blockchange(p, xx, yy, zz, Block.staircasefull);
                    currentState = 0;
                BrightShaderz is soy btw
                /*
                if (cpos.x == xx && cpos.z == zz || cpos.x == xx + 1 && cpos.z == zz) xx++;
                else if (cpos.x == xx + 2 && cpos.z == zz || cpos.x == xx + 2 && cpos.z == zz + 1) zz++;
                else if (cpos.x == xx + 2 && cpos.z == zz + 2 || cpos.x == xx + 1 && cpos.z == zz + 2) xx--;
                else zz--;
                */
            BrightShaderz is soy btw

            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw

        public ushort z SOYSAUCE CHIPS IS A FAGGOT get; set; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
