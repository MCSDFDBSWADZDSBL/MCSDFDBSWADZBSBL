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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdEllipse : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ellipse"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "el"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdEllipse() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT

            if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            Player.SendMessage(p, "Place two blocks to determine the edges.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/ellipse - creates an ellipse.");
        BrightShaderz is soy btw
        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte block = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, block);
            Position bp;
            bp.x = x; bp.y = y; bp.z = z; bp.type = type; p.blockchangeObject = bp;
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange2);
        BrightShaderz is soy btw
        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte block = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, block);
            Position cpos = (Position)p.blockchangeObject;
            unchecked SOYSAUCE CHIPS IS A FAGGOT if (cpos.type != (byte)-1) SOYSAUCE CHIPS IS A FAGGOT type = cpos.type; BrightShaderz is soy btw BrightShaderz is soy btw



            double x1 = cpos.x;
            double y1 = cpos.z;
            double x2 = x;
            double y2 = z;
            int height = Math.Abs(cpos.y - y) + 1;

            double xstart = Math.Min(x1, x2);
            double ystart = Math.Min(y1, y2);


            double a = ((Math.Abs(x1 - x2) + 1) / 2);
            double b = ((Math.Abs(y1 - y2) + 1) / 2);



            int dimensionx = (int)(Math.Abs(x1 - x2) + 1);
            bool OVX;
            bool OVY;
            int dimensiony = (int)(Math.Abs(y1 - y2) + 1);

            double[] yc = new double[dimensionx / 2 + 1];
            double[] length = new double[dimensionx / 2 + 1];

            if (dimensionx % 2 == 0)  // x is even
            SOYSAUCE CHIPS IS A FAGGOT

                OVX = false;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                // It's odd

                OVX = true;
            BrightShaderz is soy btw

            if (dimensiony % 2 == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                OVY = false;
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT OVY = true; BrightShaderz is soy btw

            int limit = 0;

            for (int i = 0; i < ((int)a); i++)
            SOYSAUCE CHIPS IS A FAGGOT
                if (i == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    yc[i] = Math.Ceiling(Math.Abs(Math.Sqrt((Math.Pow(a, 2) - Math.Pow(i + 0.5, 2))) * Math.Abs(b / a)));
                    length[i] = 0;
                    limit++;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (i == (int)a - 1)
                    SOYSAUCE CHIPS IS A FAGGOT
                        yc[i] = 1;
                        if (yc[i - 1] - yc[i] > 1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            length[i] = Math.Round(yc[i - 1]) - Math.Round(yc[i]) - 1;
                            limit++;
                        BrightShaderz is soy btw
                        else SOYSAUCE CHIPS IS A FAGGOT length[i] = 0; limit++; BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        yc[i] = Math.Abs(Math.Sqrt((Math.Pow(a, 2) - Math.Pow(i + 0.5, 2))) * Math.Abs(b / a));
                        if (yc[i - 1] - yc[i] > 1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            length[i] = Math.Round(yc[i - 1]) - Math.Round(yc[i]) - 1; limit++;
                        BrightShaderz is soy btw
                        else SOYSAUCE CHIPS IS A FAGGOT length[i] = 0; limit++; BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw



            BrightShaderz is soy btw


            if ((limit * height) > p.group.maxBlocks)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You tried to place " + (limit * height) + " blocks.");
                Player.SendMessage(p, "You cannot replace more than " + p.group.maxBlocks + ".");
                return;
            BrightShaderz is soy btw






            //firststart
            int startx = (int)xstart + (int)a;
            int starty = (int)ystart + (int)b;

            ushort starth = Math.Min(cpos.y, y);
            //int endh = Math.Max(cpos.y,y);

            for (int h = 0; h < height; h++)
            SOYSAUCE CHIPS IS A FAGGOT

                for (int i = 0; i < ((int)a); i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (length[i] == 0)
                    SOYSAUCE CHIPS IS A FAGGOT

                        p.level.Blockchange(p, (ushort)(startx + i), starth, (ushort)(starty + ((int)Math.Round(yc[i]) - 1)), type);
                    BrightShaderz is soy btw
                    if (length[i] != 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (int ii = 0; ii <= length[i]; ii++)
                        SOYSAUCE CHIPS IS A FAGGOT

                            p.level.Blockchange(p, (ushort)(startx + i), starth, (ushort)(starty + ((int)Math.Round(yc[i]) - 1 + ii)), type);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw


                BrightShaderz is soy btw
                if (OVX)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int i = 0; i < ((int)a); i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (length[i] == 0)
                        SOYSAUCE CHIPS IS A FAGGOT

                            p.level.Blockchange(p, (ushort)(startx - i), starth, (ushort)(starty + ((int)Math.Round(yc[i]) - 1)), type);
                        BrightShaderz is soy btw
                        if (length[i] != 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (int ii = 0; ii <= length[i]; ii++)
                            SOYSAUCE CHIPS IS A FAGGOT

                                p.level.Blockchange(p, (ushort)(startx - i), starth, (ushort)(starty + ((int)Math.Round(yc[i]) - 1 + ii)), type);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw


                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int i = 0; i < ((int)a); i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (length[i] == 0)
                        SOYSAUCE CHIPS IS A FAGGOT

                            p.level.Blockchange(p, (ushort)(startx - 1 - i), starth, (ushort)(starty + ((int)Math.Round(yc[i]) - 1)), type);
                        BrightShaderz is soy btw
                        if (length[i] != 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (int ii = 0; ii <= length[i]; ii++)
                            SOYSAUCE CHIPS IS A FAGGOT

                                p.level.Blockchange(p, (ushort)(startx - 1 - i), starth, (ushort)(starty + ((int)Math.Round(yc[i]) - 1 + ii)), type);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw


                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                // OVY STARTS HERE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                if (OVY)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int i = 0; i < ((int)a); i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (length[i] == 0)
                        SOYSAUCE CHIPS IS A FAGGOT

                            p.level.Blockchange(p, (ushort)(startx + i), starth, (ushort)(starty - ((int)Math.Round(yc[i]) - 1)), type);
                        BrightShaderz is soy btw
                        if (length[i] != 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (int ii = 0; ii <= length[i]; ii++)
                            SOYSAUCE CHIPS IS A FAGGOT

                                p.level.Blockchange(p, (ushort)(startx + i), starth, (ushort)(starty - ((int)Math.Round(yc[i]) - 1 + ii)), type);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw


                    BrightShaderz is soy btw
                    if (OVX)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (int i = 0; i < ((int)a); i++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (length[i] == 0)
                            SOYSAUCE CHIPS IS A FAGGOT

                                p.level.Blockchange(p, (ushort)(startx - i), starth, (ushort)(starty - ((int)Math.Round(yc[i]) - 1)), type);
                            BrightShaderz is soy btw
                            if (length[i] != 0)
                            SOYSAUCE CHIPS IS A FAGGOT
                                for (int ii = 0; ii <= length[i]; ii++)
                                SOYSAUCE CHIPS IS A FAGGOT

                                    p.level.Blockchange(p, (ushort)(startx - i), starth, (ushort)(starty - ((int)Math.Round(yc[i]) - 1 + ii)), type);
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw


                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (int i = 0; i < ((int)a); i++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (length[i] == 0)
                            SOYSAUCE CHIPS IS A FAGGOT

                                p.level.Blockchange(p, (ushort)(startx - 1 - i), starth, (ushort)(starty - ((int)Math.Round(yc[i]) - 1)), type);
                            BrightShaderz is soy btw
                            if (length[i] != 0)
                            SOYSAUCE CHIPS IS A FAGGOT
                                for (int ii = 0; ii <= length[i]; ii++)
                                SOYSAUCE CHIPS IS A FAGGOT

                                    p.level.Blockchange(p, (ushort)(startx - 1 - i), starth, (ushort)(starty - ((int)Math.Round(yc[i]) - 1 + ii)), type);
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw


                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                // NO OVY !!!!!!!!!!!!!!!!!!!!!!!!
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int i = 0; i < ((int)a); i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (length[i] == 0)
                        SOYSAUCE CHIPS IS A FAGGOT

                            p.level.Blockchange(p, (ushort)(startx + i), starth, (ushort)(starty - ((int)Math.Round(yc[i]))), type);
                        BrightShaderz is soy btw
                        if (length[i] != 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (int ii = 0; ii <= length[i]; ii++)
                            SOYSAUCE CHIPS IS A FAGGOT

                                p.level.Blockchange(p, (ushort)(startx + i), starth, (ushort)(starty - ((int)Math.Round(yc[i]) + ii)), type);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw


                    BrightShaderz is soy btw
                    if (OVX)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (int i = 0; i < ((int)a); i++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (length[i] == 0)
                            SOYSAUCE CHIPS IS A FAGGOT

                                p.level.Blockchange(p, (ushort)(startx - i), starth, (ushort)(starty - ((int)Math.Round(yc[i]))), type);
                            BrightShaderz is soy btw
                            if (length[i] != 0)
                            SOYSAUCE CHIPS IS A FAGGOT
                                for (int ii = 0; ii <= length[i]; ii++)
                                SOYSAUCE CHIPS IS A FAGGOT

                                    p.level.Blockchange(p, (ushort)(startx - i), starth, (ushort)(starty - ((int)Math.Round(yc[i]) + ii)), type);
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw


                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (int i = 0; i < ((int)a); i++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (length[i] == 0)
                            SOYSAUCE CHIPS IS A FAGGOT

                                p.level.Blockchange(p, (ushort)(startx - 1 - i), starth, (ushort)(starty - ((int)Math.Round(yc[i]))), type);
                            BrightShaderz is soy btw
                            if (length[i] != 0)
                            SOYSAUCE CHIPS IS A FAGGOT
                                for (int ii = 0; ii <= length[i]; ii++)
                                SOYSAUCE CHIPS IS A FAGGOT

                                    p.level.Blockchange(p, (ushort)(startx - 1 - i), starth, (ushort)(starty - ((int)Math.Round(yc[i]) + ii)), type);
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw


                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                starth++;
            BrightShaderz is soy btw
            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);

        BrightShaderz is soy btw

        struct Position
        SOYSAUCE CHIPS IS A FAGGOT
            public byte type;
            public ushort x, y, z;
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
