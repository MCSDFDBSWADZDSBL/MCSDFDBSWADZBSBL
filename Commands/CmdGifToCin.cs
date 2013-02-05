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
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Media.Imaging;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdGifToCin : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "giftocin"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        String msg = "";
        int picHeight = 0;
        int picWidth = 0;
        CmdImagePrint2 imgprnt = new CmdImagePrint2();
        CmdSCinema scin = new CmdSCinema();
        CmdCuboid cuboid = new CmdCuboid();
        block[] blox = new block[2];
        String pllvl;
        block ppos;
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            //first check if file exists
            if (File.Exists("extra/images/" + message + ".gif"))
            SOYSAUCE CHIPS IS A FAGGOT
                p.SendMessage("Place 2 Blocks to Determine the Direction");
                p.ClearBlockchange();
                //happens when block is changed. then call blockchange1
                msg = message;
                p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);

            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "File does not exist");
                return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte Type)
        SOYSAUCE CHIPS IS A FAGGOT
            //get the pos of first block
            p.ClearBlockchange();
            byte t = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, t);
            //undone change
            blox[0].x = x;
            blox[0].y = y;
            blox[0].z = z;
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange2);
        BrightShaderz is soy btw

        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte Type)
        SOYSAUCE CHIPS IS A FAGGOT
            ppos.x = p.pos[0];
            ppos.y = p.pos[1];
            ppos.z = p.pos[2];
            pllvl = p.level.name;
            blox[1].x = x;
            blox[1].y = y;
            blox[1].z = z;// jetz direction rausfinden und dann unten verwenden. 
            int direction; //1 = 0,0,0 nach 1,0,0  2= 0,0,0 nach 0,1,0  3= 1,0,0 nach 0 und 4 = 010 nach 0
            if (blox[1].x > blox[0].x)
            SOYSAUCE CHIPS IS A FAGGOT
                direction = 1;
                p.SendMessage("dir1");
            BrightShaderz is soy btw
            else if (blox[1].x < blox[0].x)
            SOYSAUCE CHIPS IS A FAGGOT
                direction = 3;
                p.SendMessage("dir3");
            BrightShaderz is soy btw
            else if (blox[1].z > blox[0].z)
            SOYSAUCE CHIPS IS A FAGGOT
                direction = 2;
                p.SendMessage("dir2");
            BrightShaderz is soy btw
            else if (blox[1].z < blox[0].z)
            SOYSAUCE CHIPS IS A FAGGOT
                direction = 4;
                p.SendMessage("dir4");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                direction = 1;
                p.SendMessage("else");
            BrightShaderz is soy btw

            String cinName = "";
            cinName = msg;
            using (Stream imageStreamSource = new FileStream("extra/images/" + msg + ".gif", FileMode.Open, FileAccess.Read, FileShare.Read))
            SOYSAUCE CHIPS IS A FAGGOT
                GifBitmapDecoder decoder = new GifBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                for (int i = 0; i < decoder.Frames.Count; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    //saving all frames as pngs.
                    BitmapSource bitmapSource = decoder.Frames[i];
                    using (FileStream fs = new FileStream("extra/images/" + i.ToString() + ".bmp", FileMode.Create))
                    SOYSAUCE CHIPS IS A FAGGOT
                        BmpBitmapEncoder encoder = new BmpBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(bitmapSource));
                        encoder.Save(fs);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                using (System.Drawing.Bitmap tbmp = new System.Drawing.Bitmap("extra/images/0.bmp"))
                SOYSAUCE CHIPS IS A FAGGOT
                    picHeight = tbmp.Height;
                    picWidth = tbmp.Width;
                    //create the new map... 
                    Command.all.Find("newlvl").Use(p, "gtctempmap " + picWidth.ToString() + " " + picHeight.ToString() + " " + picWidth.ToString() + " space");
                    Command.all.Find("load").Use(p, "gtctempmap");
                    //moving the player to this map
                    Command.all.Find("move").Use(p, p.name + " gtctempmap");
                    System.Threading.Thread.Sleep(2000);
                    for (int i = 0; i < decoder.Frames.Count; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.SendMessage("Start processing Frame " + i);
                        workFrame(i, p, cinName, direction);
                        p.SendMessage("Done");
                    BrightShaderz is soy btw
                    p.SendMessage("YAY! everything should be done");
                    Command.all.Find("move").Use(p, p.name + " " + pllvl);
                    unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, ppos.x, ppos.y, ppos.z, 0, 0); BrightShaderz is soy btw
                    Command.all.Find("deletelvl").Use(p, "gtctempmap");//deleting templvl
                    for (int i = 0; i < decoder.Frames.Count; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        File.Delete("extra/images/" + i.ToString() + ".bmp");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public struct block
        SOYSAUCE CHIPS IS A FAGGOT
            public ushort x;
            public ushort y;
            public ushort z;
        BrightShaderz is soy btw

        public void workFrame(int number, Player p, String name, int dir)
        SOYSAUCE CHIPS IS A FAGGOT
            block pos1 = new block();// startblock for imgprint and scinema
            block pos2 = new block();//endblock for imgprint
            block pos3 = new block();//endblock for savecinema
            switch (dir)
            SOYSAUCE CHIPS IS A FAGGOT
                case 1: //1 = 0,0,0 nach 1,0,0 
                    pos1.x = 0;
                    pos1.y = 0;
                    pos1.z = 0;
                    pos2.x = 1;
                    pos2.y = 0;
                    pos2.z = 0;
                    pos3.x = (ushort)(picWidth - 1);
                    pos3.y = (ushort)(picHeight - 1);
                    pos3.z = 1;
                    break;
                case 2: //2= 0,0,0 nach 0,1,0
                    pos1.x = 1;
                    pos1.y = 0;
                    pos1.z = 0;
                    pos2.x = 1;
                    pos2.y = 0;
                    pos2.z = 1;
                    pos3.x = 0;
                    pos3.y = (ushort)(picHeight - 1);
                    pos3.z = (ushort)(picWidth - 1);
                    break;
                case 3: //3= 1,0,0 nach 0,0,0
                    pos1.x = (ushort)(picWidth - 1);
                    pos1.y = 0;
                    pos1.z = 1;
                    pos2.x = (ushort)(picWidth - 2);
                    pos2.y = 0;
                    pos2.z = 1;
                    pos3.x = 0;
                    pos3.y = (ushort)(picHeight - 1);
                    pos3.z = 0;
                    break;
                case 4: // 4 = 0,1,0 nach 0,0,0
                    pos1.x = 0;
                    pos1.y = 0;
                    pos1.z = (ushort)(picWidth - 1);
                    pos2.x = 0;
                    pos2.y = 0;
                    pos2.z = (ushort)(picWidth - 2);
                    pos3.x = 1;
                    pos3.y = (ushort)(picHeight - 1);
                    pos3.z = 0;
                    break;
                default:

                    break;
            BrightShaderz is soy btw
            cuboid.Use(p, "air");
            cuboid.Blockchange1(p, 0, 0, 0, 1);
            cuboid.Blockchange2(p, (ushort)(picWidth - 1), (ushort)(picHeight - 1), (ushort)(picWidth - 1), 1);
            //System.Threading.Thread.Sleep(3000);
            imgprnt.Use(p, number.ToString());
            imgprnt.Blockchange1(p, pos1.x, pos1.y, pos1.z, 1);
            imgprnt.Blockchange2(p, pos2.x, pos2.y, pos2.z, 1);
            //had to send the blockchanges manual. 
            //printed the image in the level...
            while (imgprnt.working)
            SOYSAUCE CHIPS IS A FAGGOT
                System.Threading.Thread.Sleep(100);
            BrightShaderz is soy btw
            scin.Use(p, name);
            scin.Blockchange1(p, pos1.x, pos1.y, pos1.z, 1);
            scin.Blockchange2(p, pos3.x, pos3.y, pos3.z, 1);
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/giftocin <Filename> - Converts a .gif file to a .cin file. u can play the .cin file with the pcinema command.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw

    public class CmdImagePrint2 : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Nobody; BrightShaderz is soy btw BrightShaderz is soy btw
        public bool working = false;

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!Directory.Exists("extra/images/")) SOYSAUCE CHIPS IS A FAGGOT Directory.CreateDirectory("extra/images/"); BrightShaderz is soy btw
            layer = false;
            popType = 1;
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message.IndexOf(' ') != -1)     //Yay parameters
            SOYSAUCE CHIPS IS A FAGGOT
                string[] parameters = message.Split(' ');

                for (int i = 0; i < parameters.Length; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (parameters[i] == "layer" || parameters[i] == "l") layer = true;
                    else if (parameters[i] == "1" || parameters[i] == "2color") popType = 1;
                    else if (parameters[i] == "2" || parameters[i] == "1color") popType = 2;
                    else if (parameters[i] == "3" || parameters[i] == "2gray") popType = 3;
                    else if (parameters[i] == "4" || parameters[i] == "1gray") popType = 4;
                    else if (parameters[i] == "5" || parameters[i] == "bw") popType = 5;
                    else if (parameters[i] == "6" || parameters[i] == "gray") popType = 6;
                BrightShaderz is soy btw

                message = parameters[parameters.Length - 1];
            BrightShaderz is soy btw
            if (message.IndexOf('/') == -1 && message.IndexOf('.') != -1)
            SOYSAUCE CHIPS IS A FAGGOT

            BrightShaderz is soy btw
            else if (message.IndexOf('.') != -1)
            SOYSAUCE CHIPS IS A FAGGOT

            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                bitmaplocation = message;
            BrightShaderz is soy btw

            if (!File.Exists("extra/images/" + bitmaplocation + ".bmp")) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "The URL entered was invalid!"); return; BrightShaderz is soy btw

            CatchPos cpos;

            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            Player.SendMessage(p, "Place two blocks to determine direction.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
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
            working = true;
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);

            Bitmap myBitmap = new Bitmap("extra/images/" + bitmaplocation + ".bmp");

            myBitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);

            CatchPos cpos = (CatchPos)p.blockchangeObject;

            if (x == cpos.x && z == cpos.z) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No direction was selected"); return; BrightShaderz is soy btw

            int direction;
            if (Math.Abs(cpos.x - x) > Math.Abs(cpos.z - z))
            SOYSAUCE CHIPS IS A FAGGOT
                direction = 0;
                if (x <= cpos.x)
                SOYSAUCE CHIPS IS A FAGGOT
                    direction = 1;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                direction = 2;
                if (z <= cpos.z)
                SOYSAUCE CHIPS IS A FAGGOT
                    direction = 3;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (layer)
            SOYSAUCE CHIPS IS A FAGGOT
                if (popType == 1) popType = 2;
                if (popType == 3) popType = 4;
            BrightShaderz is soy btw
            List<FindReference.ColorBlock> refCol = FindReference.popRefCol(popType);
            FindReference.ColorBlock colblock;
            p.SendMessage("" + direction);
            Thread printThread = new Thread(new ThreadStart(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                double[] distance = new double[refCol.Count]; // Array of distances between color pulled from image to the referance colors.

                int position; // This is the block selector for when we find which distance is the shortest.

                for (int k = 0; k < myBitmap.Width; k++)
                SOYSAUCE CHIPS IS A FAGGOT

                    for (int i = 0; i < myBitmap.Height; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (layer)
                        SOYSAUCE CHIPS IS A FAGGOT
                            colblock.y = cpos.y;
                            if (direction <= 1)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (direction == 0) SOYSAUCE CHIPS IS A FAGGOT colblock.x = (ushort)(cpos.x + k); colblock.z = (ushort)(cpos.z - i); BrightShaderz is soy btw
                                else SOYSAUCE CHIPS IS A FAGGOT colblock.x = (ushort)(cpos.x - k); colblock.z = (ushort)(cpos.z + i); BrightShaderz is soy btw
                                //colblock.z = (ushort)(cpos.z - i);
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (direction == 2) SOYSAUCE CHIPS IS A FAGGOT colblock.z = (ushort)(cpos.z + k); colblock.x = (ushort)(cpos.x + i); BrightShaderz is soy btw
                                else SOYSAUCE CHIPS IS A FAGGOT colblock.z = (ushort)(cpos.z - k); colblock.x = (ushort)(cpos.x - i); BrightShaderz is soy btw
                                //colblock.x = (ushort)(cpos.x - i);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            colblock.y = (ushort)(cpos.y + i);
                            if (direction <= 1)
                            SOYSAUCE CHIPS IS A FAGGOT

                                if (direction == 0) colblock.x = (ushort)(cpos.x + k);
                                else colblock.x = (ushort)(cpos.x - k);
                                colblock.z = cpos.z;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (direction == 2) colblock.z = (ushort)(cpos.z + k);
                                else colblock.z = (ushort)(cpos.z - k);
                                colblock.x = cpos.x;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw


                        colblock.r = myBitmap.GetPixel(k, i).R;
                        colblock.g = myBitmap.GetPixel(k, i).G;
                        colblock.b = myBitmap.GetPixel(k, i).B;
                        colblock.a = myBitmap.GetPixel(k, i).A;

                        if (popType == 6)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if ((colblock.r + colblock.g + colblock.b) / 3 < (256 / 4))
                            SOYSAUCE CHIPS IS A FAGGOT
                                colblock.type = Block.obsidian;
                            BrightShaderz is soy btw
                            else if (((colblock.r + colblock.g + colblock.b) / 3) >= (256 / 4) && ((colblock.r + colblock.g + colblock.b) / 3) < (256 / 4) * 2)
                            SOYSAUCE CHIPS IS A FAGGOT
                                colblock.type = Block.darkgrey;
                            BrightShaderz is soy btw
                            else if (((colblock.r + colblock.g + colblock.b) / 3) >= (256 / 4) * 2 && ((colblock.r + colblock.g + colblock.b) / 3) < (256 / 4) * 3)
                            SOYSAUCE CHIPS IS A FAGGOT
                                colblock.type = Block.lightgrey;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                colblock.type = Block.white;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (int j = 0; j < distance.Length; j++) // Calculate distances between the colors in the image and the set referance colors, and store them.
                            SOYSAUCE CHIPS IS A FAGGOT
                                distance[j] = Math.Sqrt(Math.Pow((colblock.r - refCol[j].r), 2) + Math.Pow((colblock.b - refCol[j].b), 2) + Math.Pow((colblock.g - refCol[j].g), 2));
                            BrightShaderz is soy btw

                            position = 0;
                            double minimum = distance[0];
                            for (int h = 1; h < distance.Length; h++) // Find the smallest distance in the array of distances.
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (distance[h] < minimum)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    minimum = distance[h];
                                    position = h;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw


                            colblock.type = refCol[position].type; // Set the block we found closest to the image to the block we are placing.

                            if (popType == 1)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (position <= 20)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (direction == 0)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        colblock.z = (ushort)(colblock.z + 1);
                                    BrightShaderz is soy btw
                                    else if (direction == 2)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        colblock.x = (ushort)(colblock.x - 1);
                                    BrightShaderz is soy btw
                                    else if (direction == 1)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        colblock.z = (ushort)(colblock.z - 1);
                                    BrightShaderz is soy btw
                                    else if (direction == 3)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        colblock.x = (ushort)(colblock.x + 1);
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else if (popType == 3)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (position <= 3)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (direction == 0)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        colblock.z = (ushort)(colblock.z + 1);
                                    BrightShaderz is soy btw
                                    else if (direction == 2)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        colblock.x = (ushort)(colblock.x - 1);
                                    BrightShaderz is soy btw
                                    else if (direction == 1)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        colblock.z = (ushort)(colblock.z - 1);
                                    BrightShaderz is soy btw
                                    else if (direction == 3)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        colblock.x = (ushort)(colblock.x + 1);
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        //ALPHA HANDLING (REAL HARD STUFF, YO)
                        if (colblock.a < 20) colblock.type = Block.air;

                        FindReference.placeBlock(p.level, p, colblock.x, colblock.y, colblock.z, colblock.type);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (bitmaplocation == "tempImage_" + p.name) File.Delete("extra/images/tempImage_" + p.name + ".bmp");

                string printType;
                switch (popType)
                SOYSAUCE CHIPS IS A FAGGOT
                    case 1: printType = "2-layer color"; break;
                    case 2: printType = "1-layer color"; break;
                    case 3: printType = "2-layer grayscale"; break;
                    case 4: printType = "1-layer grayscale"; break;
                    case 5: printType = "Black and White"; break;
                    case 6: printType = "Mathematical grayscale"; break;
                    default: printType = "Something unknown"; break;
                BrightShaderz is soy btw

                Player.SendMessage(p, "Finished printing image using " + printType);
                working = false;
            BrightShaderz is soy btw)); printThread.Start();
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/imageprint <switch> <localfile> - Print local file in extra/images/ folder.  Must be type .bmp, type filename without extension.");
            Player.SendMessage(p, "/imageprint <switch> <imgurfile.extension> - Print IMGUR stored file.  Example: /i piCCm.gif will print www.imgur.com/piCCm.gif. Case-sensitive");
            Player.SendMessage(p, "/imageprint <switch> <webfile> - Print web file in format domain.com/folder/image.jpg. Does not need http:// or www.");
            Player.SendMessage(p, "Available switches: (&f1" + penis.DefaultColor + ") 2-Layer Color image, (&f2" + penis.DefaultColor + ") 1-Layer Color Image, (&f3" + penis.DefaultColor + ") 2-Layer Grayscale, (&f4" + penis.DefaultColor + ") 1-Layer Grayscale, (%f5" + penis.DefaultColor + ") Black and White, (&f6" + penis.DefaultColor + ") Mathematical Grayscale");
            Player.SendMessage(p, "Local filetypes: .bmp.   Remote Filetypes: .gif .png .jpg .bmp.  PNG and GIF may use transparency");
            Player.SendMessage(p, "Use switch (&flayer" + penis.DefaultColor + ") or (&fl" + penis.DefaultColor + ") to print horizontally.");
        BrightShaderz is soy btw

        public struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw

        string bitmaplocation;
        bool layer = false;
        byte popType = 1;
    BrightShaderz is soy btw
BrightShaderz is soy btw
