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
using System.Threading;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdChain : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "chain"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdChain() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        // Fields
        public int x;
        public int y;
        public int z;

        // Methods
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/chain - Shoots a chain of brown mushrooms and grabs a block and brings it back to the start.");
        BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Sorry, you can't run this from console!");
                return;
            BrightShaderz is soy btw
            if (p.level.permissionbuild > p.group.Permission)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You cannot build on this map!");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                int num = p.rot[0];
                int num2 = p.pos[0] / 0x20;
                int num3 = p.pos[1] / 0x20;
                int num4 = p.pos[2] / 0x20;
                ushort x = Convert.ToUInt16(num2);
                ushort y = Convert.ToUInt16(num3);
                ushort z = Convert.ToUInt16(num4);
                int width = p.level.width;
                int num9 = width - num2;
                int length = p.level.height;
                int num11 = length - num4;
                if ((num > 0x21) && (num < 0x60))
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int i = 0; i <= num9; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        ushort num13 = Convert.ToUInt16((int)(x + i));
                        if (num13 == (width - 1))
                        SOYSAUCE CHIPS IS A FAGGOT
                            return;
                        BrightShaderz is soy btw
                        ushort num14 = Convert.ToUInt16((int)(num13 + 1));
                        Thread.Sleep(250);
                        p.level.Blockchange(p, num13, y, z, 0x27);
                        if (p.level.GetTile(num14, y, z) != 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            byte type = p.level.GetTile(num14, y, z);
                            for (int j = 0; j <= num9; j++)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (p.level.GetTile(x, y, z) == type)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    return;
                                BrightShaderz is soy btw
                                ushort num17 = Convert.ToUInt16((int)((x - j) + i));
                                if (num17 == 0)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    return;
                                BrightShaderz is soy btw
                                ushort num18 = Convert.ToUInt16((int)(num17 + 1));
                                Convert.ToUInt16((int)(num17 - 1));
                                Thread.Sleep(250);
                                p.level.Blockchange(p, num17, y, z, type);
                                p.level.Blockchange(p, num18, y, z, 0);
                            BrightShaderz is soy btw
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if ((num > 0xa1) && (num < 0xf4))
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int k = 0; k <= num9; k++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        ushort num20 = Convert.ToUInt16((int)(x - k));
                        if (num20 == 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            return;
                        BrightShaderz is soy btw
                        ushort num21 = Convert.ToUInt16((int)(num20 - 1));
                        Thread.Sleep(250);
                        p.level.Blockchange(p, num20, y, z, 0x27);
                        if (p.level.GetTile(num21, y, z) != 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            byte num22 = p.level.GetTile(num21, y, z);
                            for (int m = 0; m <= num9; m++)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (p.level.GetTile(x, y, z) != num22)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    ushort num24 = Convert.ToUInt16((int)((x + m) - k));
                                    ushort num25 = Convert.ToUInt16((int)(num24 - 1));
                                    Convert.ToUInt16((int)(num24 + 1));
                                    Thread.Sleep(250);
                                    p.level.Blockchange(p, num24, y, z, num22);
                                    p.level.Blockchange(p, num25, y, z, 0);
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    return;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if ((num > 0x61) && (num < 160))
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int n = 0; n <= num11; n++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        ushort num27 = Convert.ToUInt16((int)(z + n));
                        if (num27 == (length - 1))
                        SOYSAUCE CHIPS IS A FAGGOT
                            return;
                        BrightShaderz is soy btw
                        ushort num28 = Convert.ToUInt16((int)(num27 + 1));
                        Thread.Sleep(250);
                        p.level.Blockchange(p, x, y, num27, 0x27);
                        if (p.level.GetTile(x, y, num28) != 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            byte num29 = p.level.GetTile(x, y, num28);
                            for (int num30 = 0; num30 <= num9; num30++)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (p.level.GetTile(x, y, z) == num29)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    return;
                                BrightShaderz is soy btw
                                ushort num31 = Convert.ToUInt16((int)((z - num30) + n));
                                if (num31 == 0)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    return;
                                BrightShaderz is soy btw
                                ushort num32 = Convert.ToUInt16((int)(num31 + 1));
                                Convert.ToUInt16((int)(num31 - 1));
                                Thread.Sleep(250);
                                p.level.Blockchange(p, x, y, num31, num29);
                                p.level.Blockchange(p, x, y, num32, 0);
                            BrightShaderz is soy btw
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if ((num > 0xe0) || (num < 0x21))
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int num33 = 0; num33 <= num11; num33++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        ushort num34 = Convert.ToUInt16((int)(z - num33));
                        if (num34 == 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            return;
                        BrightShaderz is soy btw
                        ushort num35 = Convert.ToUInt16((int)(num34 - 1));
                        Thread.Sleep(250);
                        p.level.Blockchange(p, x, y, num34, 0x27);
                        if (p.level.GetTile(x, y, num35) != 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            byte num36 = p.level.GetTile(x, y, num35);
                            for (int num37 = 0; num37 <= num9; num37++)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (p.level.GetTile(x, y, z) != num36)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    ushort num38 = Convert.ToUInt16((int)((z + num37) - num33));
                                    ushort num39 = Convert.ToUInt16((int)(num38 - 1));
                                    Convert.ToUInt16((int)(num38 + 1));
                                    Thread.Sleep(250);
                                    p.level.Blockchange(p,x, y, num38, num36);
                                    p.level.Blockchange(p,x, y, num39, 0);
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    return;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw

BrightShaderz is soy btw


