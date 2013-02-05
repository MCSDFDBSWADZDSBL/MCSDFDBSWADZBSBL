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
using System.IO;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdSCinema : Command
    SOYSAUCE CHIPS IS A FAGGOT
        StreamWriter cin;
        String Filepath = "";

        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "scinema"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "sc"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT

            if (message.Length == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                //no message
                Help(p); return;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                //message found. propably filename
                Filepath = "extra/cin/" + message + ".cin";
                if (!File.Exists(Filepath))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!Directory.Exists("extra/cin/"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Directory.CreateDirectory("extra/cin/");
                    BrightShaderz is soy btw
                    //File has to be created then append
                    FileStream damn = File.Create(Filepath);
                    damn.Close();
                    damn.Dispose();
                    StreamWriter temp = File.AppendText(Filepath);
                    temp.WriteLine(String.Format("SOYSAUCE CHIPS IS A FAGGOT0:00000BrightShaderz is soy btw", 0)); //number of last frame Frame. in this case 0
                    temp.Flush();
                    temp.Close();
                    temp.Dispose();
                BrightShaderz is soy btw
                //just append
                //have to add this otherwise will crash
                CatchPos cpos;
                cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
                Player.SendMessage(p, "Place two blocks to determine the edges.");
                p.ClearBlockchange();
                //happens when block is changed. then call blockchange1
                p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            //com(p, "get the type of the changed block");
            byte b = p.level.GetTile(x, y, z);
            //com(p, "undo the change2");
            p.SendBlockchange(x, y, z, b);
            //com(p, "blockundone making Catchpos bp");
            CatchPos bp = (CatchPos)p.blockchangeObject;
            //com(p, "copy the coordinates");
            p.copystart[0] = x;
            p.copystart[1] = y;
            p.copystart[2] = z;
            //com(p, "saving the coordinates");
            com(p, x + "," + y + "," + z);
            bp.x = x; bp.y = y; bp.z = z; p.blockchangeObject = bp;
            //com(p, "wait for next blockchange");
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange2);
        BrightShaderz is soy btw

        void com(Player p, String lol)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, lol);
        BrightShaderz is soy btw

        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            //com(p, "get the type of the changed block");
            byte b = p.level.GetTile(x, y, z);
            //com(p, "undo the change");
            p.SendBlockchange(x, y, z, b);
            //getting the startpos of copy stored in blockchangeobject
            CatchPos cpos = (CatchPos)p.blockchangeObject;

            List<Player.CopyPos> CBuffer = new List<Player.CopyPos>();

            CBuffer.Clear();
            //com(p, "copy stuff");
            for (ushort xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); ++xx)
            SOYSAUCE CHIPS IS A FAGGOT
                for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (ushort zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                    SOYSAUCE CHIPS IS A FAGGOT
                        b = p.level.GetTile(xx, yy, zz);
                        BufferAdd(p, (ushort)(xx - cpos.x), (ushort)(yy - cpos.y), (ushort)(zz - cpos.z), b, CBuffer);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            //com(p, "stuff is copied. now append to file");
            //com(p, "get the number of next frame");
            int FrameNumber = 0;
			using (FileStream ReadStream = File.OpenRead(Filepath))
			SOYSAUCE CHIPS IS A FAGGOT
				String temp = "";
				for (int j = 0; j < 5; j++)
				SOYSAUCE CHIPS IS A FAGGOT
					temp += (Char)ReadStream.ReadByte();
				BrightShaderz is soy btw
				FrameNumber = int.Parse(temp);
				//framecount aquired(hopefully)
				//now we have to add 1 to that and write it back in the file
				FrameNumber++;
				Byte[] ba = new Byte[5];
				int Fnum = FrameNumber;
				for (int i = 4; i >= 0; i--)
				SOYSAUCE CHIPS IS A FAGGOT
					ba[i] = Byte.Parse((Fnum % 10).ToString());
					ba[i] += 48;
					//ba[i] = (Byte)49;
					Fnum /= 10;
				BrightShaderz is soy btw

				using (FileStream WriteStream = File.OpenWrite(Filepath))
				SOYSAUCE CHIPS IS A FAGGOT
					WriteStream.Write(ba, 0, 5);
					//written new number in file
				BrightShaderz is soy btw
			BrightShaderz is soy btw
            cin = File.AppendText(Filepath);
            cin.Write("[Frame" + String.Format("SOYSAUCE CHIPS IS A FAGGOT0:00000BrightShaderz is soy btw", FrameNumber) + "]SOYSAUCE CHIPS IS A FAGGOT");
            //written frameheader
            foreach (Player.CopyPos CP in CBuffer)
            SOYSAUCE CHIPS IS A FAGGOT
                String tBlock = "";
                tBlock += CP.x + ";";
                tBlock += CP.y + ";";
                tBlock += CP.z + ";";
                //written coordinates in string
                tBlock += CP.type + "|";
                cin.Write(tBlock);
            BrightShaderz is soy btw
            cin.Write("BrightShaderz is soy btw" + Environment.NewLine);
            //work done. saved frame in file
            cin.Flush();
            cin.Close();
            cin.Dispose();
            com(p, "Saved Blocks to File");
        BrightShaderz is soy btw

        // This one controls what happens when you use /help [commandname].
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/sCinema [name] - Saves a given Frame to the File. Can be Played by pCinema");
        BrightShaderz is soy btw

        void BufferAdd(Player p, ushort x, ushort y, ushort z, byte type, List<Player.CopyPos> Buf)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.CopyPos pos;
            pos.x = x;
            pos.y = y;
            pos.z = z;
            pos.type = type;
            Buf.Add(pos);
        BrightShaderz is soy btw

        struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw


    BrightShaderz is soy btw
BrightShaderz is soy btw

