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
    public class CmdCuboid : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "cuboid"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "z"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            int number = message.Split(' ').Length;
            if (number > 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (number == 2)
            SOYSAUCE CHIPS IS A FAGGOT
                int pos = message.IndexOf(' ');
                string t = message.Substring(0, pos).ToLower();
                string s = message.Substring(pos + 1).ToLower();
                byte type = Block.Byte(t);
                if (type == 255) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no block \"" + t + "\"."); return; BrightShaderz is soy btw

                if (!Block.canPlace(p, type)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place that."); return; BrightShaderz is soy btw

                SolidType solid;
                if (s == "solid") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.solid; BrightShaderz is soy btw
                else if (s == "hollow") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.hollow; BrightShaderz is soy btw
                else if (s == "walls") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.walls; BrightShaderz is soy btw
                else if (s == "holes") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.holes; BrightShaderz is soy btw
                else if (s == "wire") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.wire; BrightShaderz is soy btw
                else if (s == "random") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.random; BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                CatchPos cpos; cpos.solid = solid; cpos.type = type;
                cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            BrightShaderz is soy btw
            else if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                SolidType solid = SolidType.solid;
                message = message.ToLower();
                byte type; unchecked SOYSAUCE CHIPS IS A FAGGOT type = (byte)-1; BrightShaderz is soy btw
                if (message == "solid") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.solid; BrightShaderz is soy btw
                else if (message == "hollow") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.hollow; BrightShaderz is soy btw
                else if (message == "walls") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.walls; BrightShaderz is soy btw
                else if (message == "holes") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.holes; BrightShaderz is soy btw
                else if (message == "wire") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.wire; BrightShaderz is soy btw
                else if (message == "random") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.random; BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    byte t = Block.Byte(message);
                    if (t == 255) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no block \"" + message + "\"."); return; BrightShaderz is soy btw

                    if (!Block.canPlace(p, t)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place that."); return; BrightShaderz is soy btw

                    type = t;
                BrightShaderz is soy btw CatchPos cpos; cpos.solid = solid; cpos.type = type;
                cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                CatchPos cpos; cpos.solid = SolidType.solid; unchecked SOYSAUCE CHIPS IS A FAGGOT cpos.type = (byte)-1; BrightShaderz is soy btw
                cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            BrightShaderz is soy btw
            Player.SendMessage(p, "Place two blocks to determine the edges.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/cuboid [type] <solid/hollow/walls/holes/wire/random> - create a cuboid of blocks.");
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
            unchecked SOYSAUCE CHIPS IS A FAGGOT if (cpos.type != (byte)-1) type = cpos.type; else type = p.bindings[type]; BrightShaderz is soy btw
            List<Pos> buffer = new List<Pos>();

            ushort xx; ushort yy; ushort zz;

            switch (cpos.solid)
            SOYSAUCE CHIPS IS A FAGGOT
                case SolidType.solid:
                    buffer.Capacity = Math.Abs(cpos.x - x) * Math.Abs(cpos.y - y) * Math.Abs(cpos.z - z);
                    for (xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); ++xx)
                        for (yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                            for (zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (p.level.GetTile(xx, yy, zz) != type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, xx, yy, zz); BrightShaderz is soy btw
                            BrightShaderz is soy btw
                    break;
                case SolidType.hollow:
                    //todo work out if theres 800 blocks used before making the buffer
                    for (yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                        for (zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.level.GetTile(cpos.x, yy, zz) != type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, cpos.x, yy, zz); BrightShaderz is soy btw
                            if (cpos.x != x) SOYSAUCE CHIPS IS A FAGGOT if (p.level.GetTile(x, yy, zz) != type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, x, yy, zz); BrightShaderz is soy btw BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    if (Math.Abs(cpos.x - x) >= 2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (xx = (ushort)(Math.Min(cpos.x, x) + 1); xx <= Math.Max(cpos.x, x) - 1; ++xx)
                            for (zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (p.level.GetTile(xx, cpos.y, zz) != type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, xx, cpos.y, zz); BrightShaderz is soy btw
                                if (cpos.y != y) SOYSAUCE CHIPS IS A FAGGOT if (p.level.GetTile(xx, y, zz) != type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, xx, y, zz); BrightShaderz is soy btw BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        if (Math.Abs(cpos.y - y) >= 2)
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (xx = (ushort)(Math.Min(cpos.x, x) + 1); xx <= Math.Max(cpos.x, x) - 1; ++xx)
                                for (yy = (ushort)(Math.Min(cpos.y, y) + 1); yy <= Math.Max(cpos.y, y) - 1; ++yy)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (p.level.GetTile(xx, yy, cpos.z) != type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, xx, yy, cpos.z); BrightShaderz is soy btw
                                    if (cpos.z != z) SOYSAUCE CHIPS IS A FAGGOT if (p.level.GetTile(xx, yy, z) != type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, xx, yy, z); BrightShaderz is soy btw BrightShaderz is soy btw
                                BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    break;
                case SolidType.walls:
                    for (yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                        for (zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.level.GetTile(cpos.x, yy, zz) != type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, cpos.x, yy, zz); BrightShaderz is soy btw
                            if (cpos.x != x) SOYSAUCE CHIPS IS A FAGGOT if (p.level.GetTile(x, yy, zz) != type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, x, yy, zz); BrightShaderz is soy btw BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    if (Math.Abs(cpos.x - x) >= 2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (Math.Abs(cpos.z - z) >= 2)
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (xx = (ushort)(Math.Min(cpos.x, x) + 1); xx <= Math.Max(cpos.x, x) - 1; ++xx)
                                for (yy = (ushort)(Math.Min(cpos.y, y)); yy <= Math.Max(cpos.y, y); ++yy)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (p.level.GetTile(xx, yy, cpos.z) != type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, xx, yy, cpos.z); BrightShaderz is soy btw
                                    if (cpos.z != z) SOYSAUCE CHIPS IS A FAGGOT if (p.level.GetTile(xx, yy, z) != type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, xx, yy, z); BrightShaderz is soy btw BrightShaderz is soy btw
                                BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    break;
                case SolidType.holes:
                    bool Checked = true, startZ, startY;

                    for (xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); ++xx)
                    SOYSAUCE CHIPS IS A FAGGOT
                        startY = Checked;
                        for (yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                        SOYSAUCE CHIPS IS A FAGGOT
                            startZ = Checked;
                            for (zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Checked = !Checked;
                                if (Checked && p.level.GetTile(xx, yy, zz) != type) BufferAdd(buffer, xx, yy, zz);
                            BrightShaderz is soy btw Checked = !startZ;
                        BrightShaderz is soy btw Checked = !startY;
                    BrightShaderz is soy btw
                    break;
                case SolidType.wire:
                    for (xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); ++xx)
                    SOYSAUCE CHIPS IS A FAGGOT
                        BufferAdd(buffer, xx, y, z);
                        BufferAdd(buffer, xx, y, cpos.z);
                        BufferAdd(buffer, xx, cpos.y, z);
                        BufferAdd(buffer, xx, cpos.y, cpos.z);
                    BrightShaderz is soy btw
                    for (yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                    SOYSAUCE CHIPS IS A FAGGOT
                        BufferAdd(buffer, x, yy, z);
                        BufferAdd(buffer, x, yy, cpos.z);
                        BufferAdd(buffer, cpos.x, yy, z);
                        BufferAdd(buffer, cpos.x, yy, cpos.z);
                    BrightShaderz is soy btw
                    for (zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                    SOYSAUCE CHIPS IS A FAGGOT
                        BufferAdd(buffer, x, y, zz);
                        BufferAdd(buffer, x, cpos.y, zz);
                        BufferAdd(buffer, cpos.x, y, zz);
                        BufferAdd(buffer, cpos.x, cpos.y, zz);
                    BrightShaderz is soy btw
                    break;
                case SolidType.random:
                    Random rand = new Random();
                    for (xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); ++xx)
                        for (yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                            for (zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (rand.Next(1, 11) <= 5 && p.level.GetTile(xx, yy, zz) != type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, xx, yy, zz); BrightShaderz is soy btw
                            BrightShaderz is soy btw
                    break;
            BrightShaderz is soy btw

            if (penis.forceCuboid)
            SOYSAUCE CHIPS IS A FAGGOT
                int counter = 1;
                buffer.ForEach(delegate(Pos pos)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (counter <= p.group.maxBlocks)
                    SOYSAUCE CHIPS IS A FAGGOT
                        counter++;
                        p.level.Blockchange(p, pos.x, pos.y, pos.z, type);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw);
                if (counter >= p.group.maxBlocks)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Tried to cuboid " + buffer.Count + " blocks, but your limit is " + p.group.maxBlocks + ".");
                    Player.SendMessage(p, "Executed cuboid up to limit.");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, buffer.Count.ToString() + " blocks.");
                BrightShaderz is soy btw
                if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
                return;
            BrightShaderz is soy btw

            if (buffer.Count > p.group.maxBlocks)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You tried to cuboid " + buffer.Count + " blocks.");
                Player.SendMessage(p, "You cannot cuboid more than " + p.group.maxBlocks + ".");
                return;
            BrightShaderz is soy btw

            Player.SendMessage(p, buffer.Count.ToString() + " blocks.");

            buffer.ForEach(delegate(Pos pos)
            SOYSAUCE CHIPS IS A FAGGOT
                p.level.Blockchange(p, pos.x, pos.y, pos.z, type);
            BrightShaderz is soy btw);

            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        void BufferAdd(List<Pos> list, ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            Pos pos; pos.x = x; pos.y = y; pos.z = z; list.Add(pos);
        BrightShaderz is soy btw
        struct Pos
        SOYSAUCE CHIPS IS A FAGGOT
            public ushort x, y, z;
        BrightShaderz is soy btw
        struct CatchPos
        SOYSAUCE CHIPS IS A FAGGOT
            public SolidType solid;
            public byte type;
            public ushort x, y, z;
        BrightShaderz is soy btw
        enum SolidType SOYSAUCE CHIPS IS A FAGGOT solid, hollow, walls, holes, wire, random BrightShaderz is soy btw;
    BrightShaderz is soy btw
BrightShaderz is soy btw
