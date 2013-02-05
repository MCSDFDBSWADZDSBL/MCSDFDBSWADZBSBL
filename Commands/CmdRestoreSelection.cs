/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
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
using System.IO;
using System.IO.Compression;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdRestoreSelection : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "rs"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message != "")
                if (File.Exists(@penis.backupLocation + "/" + p.level.name + "/" + message + "/" + p.level.name + ".lvl"))
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.blockchangeObject = new CatchPos() SOYSAUCE CHIPS IS A FAGGOT backup = int.Parse(message) BrightShaderz is soy btw;
                        p.ClearBlockchange();
                        p.Blockchange += Blockchange1;
                        p.SendMessage("Select two corners for restore.");
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Restore fail"); BrightShaderz is soy btw
                BrightShaderz is soy btw
                else Player.SendMessage(p, "Backup " + message + " does not exist."); 
            else Help(p);
        BrightShaderz is soy btw

        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            p.SendBlockchange(x, y, z, p.level.GetTile(x, y, z));
            CatchPos bp = (CatchPos)p.blockchangeObject;
            bp.x = x; bp.y = y; bp.z = z; p.blockchangeObject = bp;
            p.Blockchange += Blockchange2;
        BrightShaderz is soy btw

        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            p.SendBlockchange(x, y, z, p.level.GetTile(x, y, z));
            CatchPos cpos = (CatchPos)p.blockchangeObject;
            FileStream fs = File.OpenRead(@penis.backupLocation + "/" + p.level.name + "/" + cpos.backup + "/" + p.level.name + ".lvl");
            GZipStream gs = new GZipStream(fs, CompressionMode.Decompress);
            byte[] ver = new byte[2];
            gs.Read(ver, 0, ver.Length);
            ushort version = BitConverter.ToUInt16(ver, 0);
            ushort[] vars = new ushort[6];
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (version == 1874)
                SOYSAUCE CHIPS IS A FAGGOT
                    byte[] header = new byte[16]; gs.Read(header, 0, header.Length);

                    vars[0] = BitConverter.ToUInt16(header, 0);
                    vars[1] = BitConverter.ToUInt16(header, 2);
                    vars[2] = BitConverter.ToUInt16(header, 4);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    byte[] header = new byte[12]; gs.Read(header, 0, header.Length);

                    vars[0] = version;
                    vars[1] = BitConverter.ToUInt16(header, 0);
                    vars[2] = BitConverter.ToUInt16(header, 2);
                BrightShaderz is soy btw
                byte[] blocks = new byte[vars[0] * vars[2] * vars[1]];
                gs.Read(blocks, 0, blocks.Length);
                gs.Dispose();
                fs.Dispose();

                if (blocks.Length != p.level.blocks.Length) SOYSAUCE CHIPS IS A FAGGOT p.SendMessage("Cant restore selection of different size maps."); blocks = null; return; BrightShaderz is soy btw

                if (p.level.bufferblocks && !p.level.Instant)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (ushort xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); ++xx)
                        for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                            for (ushort zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                                BlockQueue.Addblock(p, xx, yy, zz, blocks[xx + (zz * vars[0]) + (yy * vars[0] * vars[1])]);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    for (ushort xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); ++xx)
                        for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                            for (ushort zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                                p.level.Blockchange(p, xx, yy, zz, blocks[xx + (zz * vars[0]) + (yy * vars[0] * vars[1])]);
                BrightShaderz is soy btw

                blocks = null;
                if (p.staticCommands) p.Blockchange += Blockchange1;
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Restore selection failed"); BrightShaderz is soy btw
        BrightShaderz is soy btw

        struct CatchPos
        SOYSAUCE CHIPS IS A FAGGOT
            public int backup;
            public ushort x, y, z;
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/restoreselection <number> - restores a previous backup of the current selection");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
