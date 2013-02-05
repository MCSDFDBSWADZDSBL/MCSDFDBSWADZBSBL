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
    public class CmdReplace : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "replace"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "r"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            int number = message.Split(' ').Length;
            if (number != 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            int pos = message.IndexOf(' ');
            string t = message.Substring(0, pos).ToLower();
            string t2 = message.Substring(pos + 1).ToLower();
            byte type = Block.Byte(t);
            if (type == 255) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no block \"" + t + "\"."); return; BrightShaderz is soy btw
            byte type2 = Block.Byte(t2);
            if (type2 == 255) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no block \"" + t2 + "\"."); return; BrightShaderz is soy btw

            if (!Block.canPlace(p, type) && !Block.BuildIn(type)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot replace that."); return; BrightShaderz is soy btw

            if (!Block.canPlace(p, type2)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place that."); return; BrightShaderz is soy btw

            CatchPos cpos; cpos.type2 = type2; cpos.type = type;
            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            Player.SendMessage(p, "Place two blocks to determine the edges.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/replace [type] [type2] - replace type with type2 inside a selected cuboid");
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
            unchecked SOYSAUCE CHIPS IS A FAGGOT if (cpos.type != (byte)-1) SOYSAUCE CHIPS IS A FAGGOT type = cpos.type; BrightShaderz is soy btw BrightShaderz is soy btw
            List<Pos> buffer = new List<Pos>();

            for (ushort xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); ++xx)
            SOYSAUCE CHIPS IS A FAGGOT
                for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (ushort zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (p.level.GetTile(xx, yy, zz) == type) SOYSAUCE CHIPS IS A FAGGOT BufferAdd(buffer, xx, yy, zz); BrightShaderz is soy btw
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
                p.level.Blockchange(p, pos.x, pos.y, pos.z, cpos.type2);                  //update block for everyone
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
            public byte type;
            public byte type2;
            public ushort x, y, z;
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
