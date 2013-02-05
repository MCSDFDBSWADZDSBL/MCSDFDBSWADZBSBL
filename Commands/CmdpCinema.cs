/*
	Copyright 2011 MCForge
	
	Written by Frederik Gelder
		
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
    public sealed class CmdpCinema : Command
    SOYSAUCE CHIPS IS A FAGGOT
        CmdpCinema2[] cmdPC = new CmdpCinema2[100]; //reserving space for 100 movies.
        bool[] used = new bool[100];

        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pcinema"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            String[] tempmsg = message.Split(' ');
            String send = "";
            int movnum = 0;
            if (tempmsg.Length < 2 || tempmsg.Length > 3)
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw

            if (tempmsg.Length == 2)
            SOYSAUCE CHIPS IS A FAGGOT
                if (tempmsg[0].ToLower() == "abort")
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        cmdPC[int.Parse(tempmsg[1])].abort();

                        used[int.Parse(tempmsg[1])] = false;
                    BrightShaderz is soy btw
                    catch
                    SOYSAUCE CHIPS IS A FAGGOT
                        Help(p);
                        return;
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "movie " + tempmsg[1] + " was aborted.");
                    return;
                BrightShaderz is soy btw
                else if (tempmsg[0].ToLower() == "delete")
                SOYSAUCE CHIPS IS A FAGGOT
                    if(System.IO.File.Exists("extra/cin/" + tempmsg[1] + ".cin"))SOYSAUCE CHIPS IS A FAGGOT
                        System.IO.File.Delete("extra/cin/" + tempmsg[1] + ".cin");
                    BrightShaderz is soy btw
                    return;
                BrightShaderz is soy btw
                //no frametime. use default 1000. but that does pcinema2 for us
                send = tempmsg[1];
            BrightShaderz is soy btw
            else if (tempmsg.Length == 3)
            SOYSAUCE CHIPS IS A FAGGOT
                //frametime given
                send = tempmsg[1] + " " + tempmsg[2];
            BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                movnum = int.Parse(tempmsg[0]);
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw

            if (used[movnum])
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Movie is already used. stop it by using /pcinema abort [movienumber]");
                return;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                //cmdPC[movnum] = new CmdpCinema2();
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    cmdPC[movnum].Use(p, send);//better not use a new instance. it worked but they were not stopable.
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    cmdPC[movnum] = new CmdpCinema2();
                    cmdPC[movnum].Use(p, send);
                BrightShaderz is soy btw
                used[movnum] = true;
            BrightShaderz is soy btw

        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/pCinema [movienumber] [filename] <frametime> - movienumber can be 0-99. filename explains itself. frametime is the time in ms each rame is displayed.no values under 200 accepted.else set to 200. You can delete unwanted movies with /pcinema delete <filename>");
        BrightShaderz is soy btw
    BrightShaderz is soy btw

    public sealed class CmdpCinema2 : Command
    SOYSAUCE CHIPS IS A FAGGOT
        String FilePath;
        int frameLonging;
        String temp = "";
        CFrame[] Frames;
        int FrameCount = 0;
        int Framenow = 0;
        System.Timers.Timer lool;
        Player MEEE;
        public bool running;
        Level plLevel;


        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pcinema2"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Nobody; BrightShaderz is soy btw BrightShaderz is soy btw

        public void abort()
        SOYSAUCE CHIPS IS A FAGGOT
            FilePath = "";
            Frames = null;
            Framenow = 0;
            lool.Enabled = false;//even i dispose it,i disable it because i dont know if it really stops
            lool.Dispose();
            running = false;
        BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.Length == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p); return;
            BrightShaderz is soy btw
            String[] tempa = message.Split(' ');
            if (tempa.Length > 2)
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p); return;
            BrightShaderz is soy btw
            else if (tempa.Length == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                if (tempa[0].ToLower() == "abort")
                SOYSAUCE CHIPS IS A FAGGOT
                    //player wants to abort the running action
                    if (!running)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "There is no movie running");
                        return;
                    BrightShaderz is soy btw
                    //abortion
                    abort();
                    return;
                BrightShaderz is soy btw
                else if (running)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Movie is already running.Abort first");
                    return;
                BrightShaderz is soy btw
                //frametime not given << default
                frameLonging = 1000;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                frameLonging = int.Parse(tempa[1]);
                if (frameLonging < 200) frameLonging = 200;
            BrightShaderz is soy btw
            FilePath = "extra/cin/" + tempa[0] + ".cin";
            if (!File.Exists(FilePath))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "File does not exist");
                return;
            BrightShaderz is soy btw
            MEEE = p;
            //temp[0] is the name of the file and temp[1] in ms is the time each frame is displayed
            Player.SendMessage(p, "Place a Block to determine the position");
            p.ClearBlockchange();
            //happens when block is changed. then call blockchange1
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);

        BrightShaderz is soy btw

        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            //com(p, "get the type of the changed block");
            byte b = p.level.GetTile(x, y, z);
            //com(p, "undo the change2");
            p.SendBlockchange(x, y, z, b);
            //now we have to load the stuff from the temp string
            Player.SendMessage(p, "Reading file, please wait...");
            temp = readFile(FilePath);
            Player.SendMessage(p, "File read");
            String[] textFrames = temp.Split('[');
            //[0] is the framecount. rest is in this format: FrameXXXXX]SOYSAUCE CHIPS IS A FAGGOT0,0,0,0|0,0,0,0|BrightShaderz is soy btw
            FrameCount = int.Parse(textFrames[0]);
            Frames = new CFrame[FrameCount];
            plLevel = p.level;
            for (int i = 0; i < FrameCount; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, String.Format("Frame SOYSAUCE CHIPS IS A FAGGOT0:00000BrightShaderz is soy btw...", i + 1));
                textFrames[i + 1] = textFrames[i + 1].Replace(String.Format("FrameSOYSAUCE CHIPS IS A FAGGOT0:00000BrightShaderz is soy btw]", i + 1), "");
                textFrames[i + 1] = textFrames[i + 1].Replace("SOYSAUCE CHIPS IS A FAGGOT", "");
                textFrames[i + 1] = textFrames[i + 1].Replace("BrightShaderz is soy btw", "");
                String[] Coords = textFrames[i + 1].Split('|');
                Frames[i].BlockCollection = new List<Blok>();
                //coords now in array with format: 0,0,0,0
                //now split by , and write in XYZ,type
                for (int j = 0; j < Coords.Length - 1; j++)
                SOYSAUCE CHIPS IS A FAGGOT
                    String[] tempXYZ = Coords[j].Split(';');
                    Frames[i].BlockCollection.Add(new Blok((ushort)(x + int.Parse(tempXYZ[0])),
                        (ushort)(y + int.Parse(tempXYZ[1])),
                        (ushort)(z + int.Parse(tempXYZ[2])),
                        (Byte)int.Parse(tempXYZ[3])));
                    //frame has now its blocks.
                BrightShaderz is soy btw
                Player.SendMessage(p, "Done!");
            BrightShaderz is soy btw
            //frames are all aquired
            Player.SendMessage(p, "Frames ready! start Playing");

            //better using timers.timer. forms timer doesnt work sometimes for fcking reasons o.O
            lool = new System.Timers.Timer(frameLonging);
            lool.Elapsed += new System.Timers.ElapsedEventHandler(nextFrameUpdate);
            lool.Enabled = true;
            running = true;
        BrightShaderz is soy btw

        void nextFrameUpdate(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            //update the frames
            foreach (Blok Bl in Frames[Framenow].BlockCollection)
            SOYSAUCE CHIPS IS A FAGGOT
                Bl.applyBlockToMap(MEEE, plLevel);
            BrightShaderz is soy btw
            //blaahhh write blocks to map
            Framenow++;
            if (Framenow >= FrameCount)
            SOYSAUCE CHIPS IS A FAGGOT
                Framenow = 0;//begin from start again
            BrightShaderz is soy btw

        BrightShaderz is soy btw

        String readFile(String Path)
        SOYSAUCE CHIPS IS A FAGGOT
            if (File.Exists(Path))
            SOYSAUCE CHIPS IS A FAGGOT
                return File.ReadAllText(Path);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                return null;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        struct CFrame
        SOYSAUCE CHIPS IS A FAGGOT
            public List<Blok> BlockCollection;
        BrightShaderz is soy btw

        struct Blok
        SOYSAUCE CHIPS IS A FAGGOT
            public ushort X, Y, Z;
            public byte Type;
            public Blok(ushort x, ushort y, ushort z, byte typ)
            SOYSAUCE CHIPS IS A FAGGOT
                X = x;
                Y = y;
                Z = z;
                Type = typ;
            BrightShaderz is soy btw
            public void applyBlockToMap(Player p, Level l)
            SOYSAUCE CHIPS IS A FAGGOT
                l.Blockchange(p, X, Y, Z, Type);
                //p.SendBlockchange(X, Y, Z, Type);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/pcinema2 should not be used directly. better use pcinema.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
