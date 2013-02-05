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
    public class CmdRainbow : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "rainbow"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            CatchPos cpos;
            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            Player.SendMessage(p, "Place two blocks to determine the edges.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/rainbow - Taste the rainbow");
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
        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos cpos = (CatchPos)p.blockchangeObject;
            List<Pos> buffer = new List<Pos>();

            byte newType = Block.darkpink;

            int xdif = Math.Abs(cpos.x - x);
            int ydif = Math.Abs(cpos.y - y);
            int zdif = Math.Abs(cpos.z - z);

            if (xdif >= ydif && xdif >= zdif)
            SOYSAUCE CHIPS IS A FAGGOT
                for (ushort xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); xx++)
                SOYSAUCE CHIPS IS A FAGGOT
                    newType += 1;
                    if (newType > Block.darkpink) newType = Block.red;
                    for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); yy++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (ushort zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); zz++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.level.GetTile(xx, yy, zz) != Block.air)
                                BufferAdd(buffer, xx, yy, zz, newType);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (ydif > xdif && ydif > zdif)
            SOYSAUCE CHIPS IS A FAGGOT
                for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); yy++)
                SOYSAUCE CHIPS IS A FAGGOT
                    newType += 1;
                    if (newType > Block.darkpink) newType = Block.red;
                    for (ushort xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); xx++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (ushort zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); zz++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.level.GetTile(xx, yy, zz) != Block.air)
                                BufferAdd(buffer, xx, yy, zz, newType);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (zdif > ydif && zdif > xdif)
            SOYSAUCE CHIPS IS A FAGGOT
                for (ushort zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); zz++)
                SOYSAUCE CHIPS IS A FAGGOT
                    newType += 1;
                    if (newType > Block.darkpink) newType = Block.red;
                    for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); yy++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (ushort xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); xx++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.level.GetTile(xx, yy, zz) != Block.air)
                                BufferAdd(buffer, xx, yy, zz, newType);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (buffer.Count > p.group.maxBlocks)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You tried to replace " + buffer.Count + " blocks.");
                Player.SendMessage(p, "You cannot replace more than " + p.group.maxBlocks + ".");
                return;
            BrightShaderz is soy btw

            Player.SendMessage(p, buffer.Count.ToString() + " blocks.");
            buffer.ForEach(delegate(Pos pos)
            SOYSAUCE CHIPS IS A FAGGOT
                p.level.Blockchange(p, pos.x, pos.y, pos.z, pos.newType);                  //update block for everyone
            BrightShaderz is soy btw);

            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        void BufferAdd(List<Pos> list, ushort x, ushort y, ushort z, byte newType)
        SOYSAUCE CHIPS IS A FAGGOT
            Pos pos;
            pos.x = x; pos.y = y; pos.z = z; pos.newType = newType;
            list.Add(pos);
        BrightShaderz is soy btw

        struct Pos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public byte newType; BrightShaderz is soy btw
        struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
