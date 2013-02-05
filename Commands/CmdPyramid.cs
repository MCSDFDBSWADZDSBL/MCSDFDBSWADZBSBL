/*
    Thanks to aaron1tasker

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
using System.Collections.Generic;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdPyramid : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pyramid"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pd"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdPyramid() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public static byte wait;

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            wait = 0;
            p.pyramidblock = "stone";
            int number = message.Split(' ').Length;
            if (number > 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); wait = 1; return; BrightShaderz is soy btw
            if (number == 2)
            SOYSAUCE CHIPS IS A FAGGOT
                int pos = message.IndexOf(' ');
                string t = message.Substring(0, pos).ToLower();
                string s = message.Substring(pos + 1).ToLower();
                byte type = Block.Byte(t);
                if (type == 255) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no block \"" + t + "\"."); wait = 1; return; BrightShaderz is soy btw
                if (!Block.canPlace(p, type)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place that."); wait = 1; return; BrightShaderz is soy btw
                SolidType solid;
                if (s == "solid") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.solid; BrightShaderz is soy btw
                else if (s == "hollow") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.hollow; BrightShaderz is soy btw
                else if (s == "reverse") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.reverse; BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT Help(p); wait = 1; return; BrightShaderz is soy btw
                CatchPos cpos; cpos.solid = solid; cpos.type = type;
                cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
                cpos.type = Block.Byte(message);
                p.pyramidblock = t;
            BrightShaderz is soy btw
            else if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                SolidType solid = SolidType.hollow;
                message = message.ToLower();
                byte type; unchecked SOYSAUCE CHIPS IS A FAGGOT type = (byte)-1; BrightShaderz is soy btw
                p.pyramidblock = "stone";
                if (message == "solid") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.solid; BrightShaderz is soy btw
                else if (message == "hollow") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.hollow; BrightShaderz is soy btw
                else if (message == "reverse") SOYSAUCE CHIPS IS A FAGGOT solid = SolidType.reverse; BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    byte t = Block.Byte(message);
                    if (t == 255) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no block \"" + message + "\"."); wait = 1; return; BrightShaderz is soy btw
                    if (!Block.canPlace(p, t)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place that."); wait = 1; return; BrightShaderz is soy btw
                    p.pyramidblock = message;

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
            if (p.pyramidblock == "")
            SOYSAUCE CHIPS IS A FAGGOT
                p.pyramidblock = "stone";
            BrightShaderz is soy btw
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/pyramid [type] <solid/hollow/reverse> - create a pyramid of blocks.");
        BrightShaderz is soy btw
        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos bp = (CatchPos)p.blockchangeObject;
            bp.x = x; bp.y = y; bp.z = z; p.blockchangeObject = bp;
            p.pyramidx1 = bp.x;
            p.pyramidz1 = bp.y;
            p.pyramidy1 = bp.z;
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange2);
        BrightShaderz is soy btw
        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos cpos = (CatchPos)p.blockchangeObject;
            cpos.x = x; cpos.y = y; cpos.z = z; p.blockchangeObject = cpos;
            List<Pos> buffer = new List<Pos>();
            p.pyramidsilent = true;
            int total = calculate(p, cpos);
            if (total > p.group.maxBlocks)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Tried to modify " + total + " blocks, but your limit is " + p.group.maxBlocks + ".");
                return;
            BrightShaderz is soy btw

            switch (cpos.solid)
            SOYSAUCE CHIPS IS A FAGGOT
                case SolidType.solid:
                    buffer.Capacity = Math.Abs(cpos.x - x) * Math.Abs(cpos.y - y) * Math.Abs(cpos.z - z);
                    p.pyramidx2 = cpos.x;
                    p.pyramidz2 = cpos.y;
                    p.pyramidy2 = cpos.z;

                    if (p.pyramidz1 == p.pyramidz2) //checks if pyramid is on a level surface
                    SOYSAUCE CHIPS IS A FAGGOT

                        Command.all.Find("cuboid").Use(p, p.pyramidblock);
                        click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1);
                        click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2);

                        for (int i = 1; i > 0; ) //looper to create pyramid
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.pyramidx1 == p.pyramidx2)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2); //clicks on coords from text files
                                i--;
                            BrightShaderz is soy btw
                            else if (p.pyramidy1 == p.pyramidy2) SOYSAUCE CHIPS IS A FAGGOT i--; BrightShaderz is soy btw
                            if (p.pyramidx1 > p.pyramidx2) //checks if 2 coords are the same for x and provides escape sequence if they are
                            SOYSAUCE CHIPS IS A FAGGOT
                                if ((p.pyramidx1 - p.pyramidx2) == 1)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                    click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                    click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2); //clicks on coords
                                    i--;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else if ((p.pyramidx2 - p.pyramidx1) == 1)  //checks if 2 coords are the same for y and provides escape sequence if they are
                            SOYSAUCE CHIPS IS A FAGGOT
                                i--;
                            BrightShaderz is soy btw
                            if (p.pyramidy1 > p.pyramidy2) //checks if 2 coords are the same for x and provides escape sequence if they are
                            SOYSAUCE CHIPS IS A FAGGOT
                                if ((p.pyramidy1 - p.pyramidy2) == 1)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                    click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                    click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2); //clicks on coords
                                    i--;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else if ((p.pyramidy2 - p.pyramidy1) == 1)  //checks if 2 coords are the same for y and provides escape sequence if they are
                            SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2); //clicks on coords
                                i--;
                            BrightShaderz is soy btw
                            Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                            click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                            click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2); //clicks on coords
                            
                            if (p.pyramidx1 > p.pyramidx2) //checks if one is greater than the other. This way it knows which one to add one two and which one to minus one from so that it reaches the middle.
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.pyramidx1--;
                                p.pyramidx2++;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.pyramidx1++;
                                p.pyramidx2--;
                            BrightShaderz is soy btw

                            if (p.pyramidy1 > p.pyramidy2) //does the same for the y coords
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.pyramidy1--;
                                p.pyramidy2++;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.pyramidy1++;
                                p.pyramidy2--;
                            BrightShaderz is soy btw
                            p.pyramidz2++;                             
                        BrightShaderz is soy btw

                        p.pyramidx1 = 0;
                        p.pyramidx2 = 0;
                        p.pyramidy1 = 0;
                        p.pyramidy2 = 0;
                        p.pyramidz1 = 0;
                        p.pyramidx2 = 0;
                        p.pyramidblock = "";
                        p.pyramidsilent = false;
                        Player.SendMessage(p, "Pyramid completed.");
                        wait = 2;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.pyramidx1 = 0;
                        p.pyramidx2 = 0;
                        p.pyramidy1 = 0;
                        p.pyramidy2 = 0;
                        p.pyramidz1 = 0;
                        p.pyramidx2 = 0;
                        p.pyramidblock = "";
                        Player.SendMessage(p, "The two edges of the pyramid must be on the same level");
                        wait = 1;
                    BrightShaderz is soy btw

                    break;

                case SolidType.reverse:
                    p.pyramidx2 = cpos.x;
                    p.pyramidz2 = cpos.y;
                    p.pyramidy2 = cpos.z;

                    if (p.pyramidz1 == p.pyramidz2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (int i = 1; i > 0; )
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.pyramidx1 == p.pyramidx2)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2); //clicks on coords
                                i--;
                            BrightShaderz is soy btw
                            else if (p.pyramidy1 == p.pyramidy2) SOYSAUCE CHIPS IS A FAGGOT i--; BrightShaderz is soy btw
                            if (p.pyramidx1 > p.pyramidx2) //checks if 2 coords are the same for x and provides escape sequence if they are
                            SOYSAUCE CHIPS IS A FAGGOT
                                if ((p.pyramidx1 - p.pyramidx2) == 1)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                    click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                    click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2); //clicks on coords
                                    i--;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else if ((p.pyramidx2 - p.pyramidx1) == 1)  //checks if 2 coords are the same for y and provides escape sequence if they are
                            SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2); //clicks on coords
                                i--;
                            BrightShaderz is soy btw
                            if (p.pyramidy1 > p.pyramidy2) //checks if 2 coords are the same for x and provides escape sequence if they are
                            SOYSAUCE CHIPS IS A FAGGOT
                                if ((p.pyramidy1 - p.pyramidy2) == 1)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                    click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                    click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2);
                                    i--;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else if ((p.pyramidy2 - p.pyramidy1) == 1)  //checks if 2 coords are the same for y and provides escape sequence if they are
                            SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords from text files
                                click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2);
                                i--;
                            BrightShaderz is soy btw
                            Command.all.Find("cuboid").Use(p, "air");
                            click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1);
                            click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2);
                            Command.all.Find("cuboid").Use(p, p.pyramidblock + " " + "walls");
                            click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1);
                            click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2);

                            if (p.pyramidx1 > p.pyramidx2)
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.pyramidx1--;
                                p.pyramidx2++;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.pyramidx1++;
                                p.pyramidx2--;
                            BrightShaderz is soy btw

                            if (p.pyramidy1 > p.pyramidy2)
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.pyramidy1--;
                                p.pyramidy2++;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.pyramidy1++;
                                p.pyramidy2--;
                            BrightShaderz is soy btw
                            p.pyramidz2--;
                        BrightShaderz is soy btw

                        p.pyramidx1 = 0;
                        p.pyramidx2 = 0;
                        p.pyramidy1 = 0;
                        p.pyramidy2 = 0;
                        p.pyramidz1 = 0;
                        p.pyramidz2 = 0;
                        p.pyramidblock = "";
                        wait = 2;
                        p.pyramidsilent = false;
                        Player.SendMessage(p, "Pyramid Completed");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.pyramidx1 = 0;
                        p.pyramidx2 = 0;
                        p.pyramidy1 = 0;
                        p.pyramidy2 = 0;
                        p.pyramidz1 = 0;
                        p.pyramidz2 = 0;
                        p.pyramidblock = "";
                        wait = 1;
                        Player.SendMessage(p, "The two edges of the pyramid must be on the same level");
                    BrightShaderz is soy btw
                    break;

                case SolidType.hollow:
                    p.pyramidx2 = cpos.x;
                    p.pyramidz2 = cpos.y;
                    p.pyramidy2 = cpos.z;

                    if (p.pyramidz1 == p.pyramidz2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Command.all.Find("cuboid").Use(p, p.pyramidblock);
                        click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1);
                        click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2);

                        for (int i = 1; i > 0; )
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.pyramidx1 == p.pyramidx2)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2);
                                i--;
                            BrightShaderz is soy btw
                            else if (p.pyramidy1 == p.pyramidy2) SOYSAUCE CHIPS IS A FAGGOT i--; BrightShaderz is soy btw
                            if (p.pyramidx1 > p.pyramidx2) //checks if 2 coords are the same for x and provides escape sequence if they are
                            SOYSAUCE CHIPS IS A FAGGOT
                                if ((p.pyramidx1 - p.pyramidx2) == 1)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                    click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                    click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2);
                                    i--;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else if ((p.pyramidx2 - p.pyramidx1) == 1)  //checks if 2 coords are the same for y and provides escape sequence if they are
                            SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2);
                                i--;
                            BrightShaderz is soy btw
                            if (p.pyramidy1 > p.pyramidy2) //checks if 2 coords are the same for x and provides escape sequence if they are
                            SOYSAUCE CHIPS IS A FAGGOT
                                if ((p.pyramidy1 - p.pyramidy2) == 1)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                    click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                    click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2);
                                    i--;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else if ((p.pyramidy2 - p.pyramidy1) == 1)  //checks if 2 coords are the same for y and provides escape sequence if they are
                            SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("cuboid").Use(p, p.pyramidblock); //cuboid
                                click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1); //clicks on coords
                                click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2);
                                i--;
                            BrightShaderz is soy btw
                            Command.all.Find("cuboid").Use(p, p.pyramidblock + " " + "walls");
                            click(p, p.pyramidx1 + " " + p.pyramidz2 + " " + p.pyramidy1);
                            click(p, p.pyramidx2 + " " + p.pyramidz2 + " " + p.pyramidy2);

                            if (p.pyramidx1 > p.pyramidx2)
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.pyramidx1--;
                                p.pyramidx2++;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.pyramidx1++;
                                p.pyramidx2--;
                            BrightShaderz is soy btw

                            if (p.pyramidy1 > p.pyramidy2)
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.pyramidy1--;
                                p.pyramidy2++;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.pyramidy1++;
                                p.pyramidy2--;
                            BrightShaderz is soy btw
                            p.pyramidz2++;
                        BrightShaderz is soy btw
                        p.pyramidx1 = 0;
                        p.pyramidx2 = 0;
                        p.pyramidy1 = 0;
                        p.pyramidy2 = 0;
                        p.pyramidz1 = 0;
                        p.pyramidz2 = 0;
                        p.pyramidblock = "";
                        wait = 2;
                        p.pyramidsilent = false;
                        Player.SendMessage(p, "Pyramid Completed");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.pyramidx1 = 0;
                        p.pyramidx2 = 0;
                        p.pyramidy1 = 0;
                        p.pyramidy2 = 0;
                        p.pyramidz1 = 0;
                        p.pyramidz2 = 0;
                        p.pyramidblock = "";
                        wait = 1;
                        Player.SendMessage(p, "The two edges of the pyramid must be on the same level");
                    BrightShaderz is soy btw
                    break;
            BrightShaderz is soy btw

            /*if (penis.forceCuboid)
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
                    Player.SendMessage(p, "Tried to pyramid " + buffer.Count + " blocks, but your limit is " + p.group.maxBlocks + ".");
                    Player.SendMessage(p, "Executed pyramid up to limit.");
                    wait = 2;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, buffer.Count.ToString() + " blocks.");
                BrightShaderz is soy btw
                wait = 2;
                if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
                return;
            BrightShaderz is soy btw

            if (buffer.Count > p.group.maxBlocks)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You tried to pyramid " + buffer.Count + " blocks.");
                Player.SendMessage(p, "You cannot pyramid more than " + p.group.maxBlocks + ".");
                wait = 1;
                return;
            BrightShaderz is soy btw*/

            Player.SendMessage(p, total + " blocks.");

            /*buffer.ForEach(delegate(Pos pos)
            SOYSAUCE CHIPS IS A FAGGOT
                p.level.Blockchange(p, pos.x, pos.y, pos.z, type);
            BrightShaderz is soy btw);
            wait = 2;*/
            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        private static int calculate(Player p, CatchPos cpos)
        SOYSAUCE CHIPS IS A FAGGOT
            int total = 0;
            for (int xx = Math.Min(cpos.x, p.pyramidx1); xx <= Math.Max(cpos.x, p.pyramidx1); ++xx)
                for (int zz = Math.Min(cpos.z, p.pyramidy1); zz <= Math.Max(cpos.z, p.pyramidy1); ++zz)
                SOYSAUCE CHIPS IS A FAGGOT
                    total += 1;
                BrightShaderz is soy btw
            int finaltotal = 0;
            int totald2 = (int)Math.Sqrt(total);
            int xxx = 0;
            int zzz = 0;
            int minx = Math.Min(cpos.x, p.pyramidx1);
            int maxx = Math.Max(cpos.x, p.pyramidx1);
            int minz = Math.Min(cpos.z, p.pyramidy1);
            int maxz = Math.Max(cpos.z, p.pyramidy1);
            for (int i = 0; i < totald2 / 2; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                for (int xx = minx; xx <= maxx; ++xx)
                    xxx += 1;
                for (int zz = minz; zz <= maxz; ++zz)
                    zzz += 1;
                finaltotal += xxx * zzz;
                xxx = 0;
                zzz = 0;
                maxx -= 2;
                maxz -= 2;
            BrightShaderz is soy btw
            if (cpos.solid == SolidType.hollow) finaltotal = finaltotal - calculatehollow(p, cpos);
            return finaltotal;
        BrightShaderz is soy btw
        private static int calculatehollow(Player p, CatchPos cpos)
        SOYSAUCE CHIPS IS A FAGGOT
            int total = 0;
            int minx = Math.Min(cpos.x, p.pyramidx1);
            int maxx = Math.Max(cpos.x, p.pyramidx1) - 2;
            int minz = Math.Min(cpos.z, p.pyramidy1);
            int maxz = Math.Max(cpos.z, p.pyramidy1) - 2;
            for (int xx = minx; xx <= maxx; ++xx)
                for (int zz = minz; zz <= maxz; ++zz)
                SOYSAUCE CHIPS IS A FAGGOT
                    total += 1;
                BrightShaderz is soy btw
            int finaltotal = 0;
            int totald2 = (int)Math.Sqrt(total);
            int xxx = 0;
            int zzz = 0;
            for (int i = 0; i < totald2 / 2; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                for (int xx = minx; xx <= maxx; ++xx)
                    xxx += 1;
                for (int zz = minz; zz <= maxz; ++zz)
                    zzz += 1;
                finaltotal += xxx * zzz;
                xxx = 0;
                zzz = 0;
                maxx -= 2;
                maxz -= 2;
            BrightShaderz is soy btw
            finaltotal -= total;
            return finaltotal;
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
        enum SolidType SOYSAUCE CHIPS IS A FAGGOT solid, hollow, reverse BrightShaderz is soy btw;
        //<click command to stop text>
        public void click(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string[] parameters = message.Split(' ');
            ushort[] click = p.lastClick;
            if (message.IndexOf(' ') != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                if (parameters.Length != 3)
                SOYSAUCE CHIPS IS A FAGGOT
                    Help(p);
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int value = 0; value < 3; value++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (parameters[value].ToLower() == "x" || parameters[value].ToLower() == "y" || parameters[value].ToLower() == "z")
                            click[value] = p.lastClick[value];
                        else if (isValid(parameters[value], value, p))
                            click[value] = ushort.Parse(parameters[value]);
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "\"" + parameters[value] + "\" was not valid");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            p.manualChange(click[0], click[1], click[2], 0, Block.rock);
        BrightShaderz is soy btw
        //</click command to stop text>

        //<something to do with click command>
        private bool isValid(string message, int dimension, Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            ushort testValue;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                testValue = ushort.Parse(message);
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw
            if (testValue < 0)
                return false;
            if (testValue >= p.level.width && dimension == 0) return false;
            else if (testValue >= p.level.depth && dimension == 1) return false;
            else if (testValue >= p.level.height && dimension == 2) return false;
            return true;
        BrightShaderz is soy btw
        //</something to do with click command> 
    BrightShaderz is soy btw
BrightShaderz is soy btw
