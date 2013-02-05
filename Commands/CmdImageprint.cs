using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdImageprint : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "imageprint"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "i"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

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
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    WebClient web = new WebClient();
                    Player.SendMessage(p, "Downloading IMGUR file from: &fhttp://www.imgur.com/" + message);
                    web.DownloadFile("http://www.imgur.com/" + message, "extra/images/tempImage_" + p.name + ".bmp");
                    web.Dispose();
                    Player.SendMessage(p, "Download complete.");
                    bitmaplocation = "tempImage_" + p.name;
                    message = bitmaplocation;   
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (message.IndexOf('.') != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    WebClient web = new WebClient();
                    if (message.Substring(0, 4) != "http")
                    SOYSAUCE CHIPS IS A FAGGOT
                        message = "http://" + message;
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "Downloading file from: &f" + message + penis.DefaultColor + ", please wait.");
                    web.DownloadFile(message, "extra/images/tempImage_" + p.name + ".bmp");
                    web.Dispose();
                    Player.SendMessage(p, "Download complete.");
                    bitmaplocation = "tempImage_" + p.name;
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
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

