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
using System.Collections.Generic;
using System.IO;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public static class Warp
    SOYSAUCE CHIPS IS A FAGGOT
        public static List<Wrp> Warps = new List<Wrp>();
        private static List<Wrp> TempDeletedWarpsList = new List<Wrp>();
        private static List<Wrp> FailedLoadingWarpsList = new List<Wrp>();

        public class Wrp
        SOYSAUCE CHIPS IS A FAGGOT
            public string name;
            public string lvlname;
            public ushort x;
            public ushort y;
            public ushort z;
            public byte rotx;
            public byte roty;
        BrightShaderz is soy btw

        public static Wrp GetWarp(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (Wrp w in Warps)
            SOYSAUCE CHIPS IS A FAGGOT
                if (w.name.ToLower().Trim() == name.ToLower().Trim())
                SOYSAUCE CHIPS IS A FAGGOT
                    return w;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            return null;
        BrightShaderz is soy btw

        public static void AddWarp(string name, Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Wrp w = new Wrp();
            try
            SOYSAUCE CHIPS IS A FAGGOT
                w.name = name;
                w.lvlname = p.level.name;
                w.x = p.pos[0];
                w.y = p.pos[1];
                w.z = p.pos[2];
                w.rotx = p.rot[0];
                w.roty = p.rot[1];
                Warps.Add(w);
                SAVE();
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void DeleteWarp(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            Wrp wa = new Wrp();
            foreach (Wrp w in Warps)
            SOYSAUCE CHIPS IS A FAGGOT
                if (w.name.ToLower().Trim() == name.ToLower().Trim())
                SOYSAUCE CHIPS IS A FAGGOT
                    wa = w;
                    break;
                BrightShaderz is soy btw
                
            BrightShaderz is soy btw
            TempDeletedWarpsList.Add(wa);
            Warps.Remove(wa); 
            SAVE();
        BrightShaderz is soy btw

        public static void MoveWarp(string Wrp, Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Wrp w = new Wrp();
            w = GetWarp(Wrp);
            Wrp wa = new Wrp();
            try
            SOYSAUCE CHIPS IS A FAGGOT
                Warps.Remove(w);
                wa.name = w.name;
                wa.lvlname = p.level.name;
                wa.x = p.pos[0];
                wa.y = p.pos[1];
                wa.z = p.pos[2];
                wa.rotx = p.rot[0];
                wa.roty = p.rot[1];
                Warps.Add(wa);
                SAVE();
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static bool WarpExists(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (Wrp w in Warps)
            SOYSAUCE CHIPS IS A FAGGOT
                if (w.name.ToLower().Trim() == name.ToLower().Trim())
                SOYSAUCE CHIPS IS A FAGGOT
                    return true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            return false;
        BrightShaderz is soy btw

        public static void SAVE()
        SOYSAUCE CHIPS IS A FAGGOT
            using (StreamWriter SW = new StreamWriter("extra/warps.save"))
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Wrp warp in Warps)
                SOYSAUCE CHIPS IS A FAGGOT
                    SW.WriteLine(warp.name + ":" + warp.lvlname + ":" + warp.x.ToString() + ":" + warp.y.ToString() + ":" + warp.z.ToString() + ":" + warp.rotx.ToString() + ":" + warp.roty.ToString());
                BrightShaderz is soy btw

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (TempDeletedWarpsList.Count >= 1)
                    SOYSAUCE CHIPS IS A FAGGOT
                        SW.WriteLine("");
                        SW.WriteLine("#Deleted Warps:");
                        foreach (Wrp BAKwarp in TempDeletedWarpsList)
                        SOYSAUCE CHIPS IS A FAGGOT
                            SW.WriteLine("#" + BAKwarp.name + ":" + BAKwarp.lvlname + ":" + BAKwarp.x.ToString() + ":" + BAKwarp.y.ToString() + ":" + BAKwarp.z.ToString() + ":" + BAKwarp.rotx.ToString() + ":" + BAKwarp.roty.ToString());
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    TempDeletedWarpsList.Clear();
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Saving backups of deleted warps failed!"); BrightShaderz is soy btw

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (FailedLoadingWarpsList.Count >= 1)
                    SOYSAUCE CHIPS IS A FAGGOT
                        SW.WriteLine("#");
                        SW.WriteLine("#FAILED LOADING:");
                        foreach (Wrp FAILwarp in FailedLoadingWarpsList)
                        SOYSAUCE CHIPS IS A FAGGOT
                            SW.WriteLine("#" + FAILwarp.name + ":" + FAILwarp.lvlname + ":" + FAILwarp.x.ToString() + ":" + FAILwarp.y.ToString() + ":" + FAILwarp.z.ToString() + ":" + FAILwarp.rotx.ToString() + ":" + FAILwarp.roty.ToString());
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    FailedLoadingWarpsList.Clear();
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Saving failed loading warps failed!"); BrightShaderz is soy btw
                SW.Dispose();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void LOAD()
        SOYSAUCE CHIPS IS A FAGGOT
            if (File.Exists("extra/warps.save"))
            SOYSAUCE CHIPS IS A FAGGOT
                using (StreamReader SR = new StreamReader("extra/warps.save"))
                SOYSAUCE CHIPS IS A FAGGOT
                    bool failed = false;
                    bool anyfailed = false;
                    string line;
                    while (SR.EndOfStream == false)
                    SOYSAUCE CHIPS IS A FAGGOT
                        line = SR.ReadLine().ToLower().Trim();
                        if (!line.StartsWith("#") && line.Contains(":"))
                        SOYSAUCE CHIPS IS A FAGGOT
                            string[] LINE = line.ToLower().Split(':');
                            Wrp warp = new Wrp();
                            failed = false;
                            try
                            SOYSAUCE CHIPS IS A FAGGOT
                                warp.name = LINE[0];
                                warp.lvlname = LINE[1];
                                warp.x = ushort.Parse(LINE[2]);
                                warp.y = ushort.Parse(LINE[3]);
                                warp.z = ushort.Parse(LINE[4]);
                                warp.rotx = byte.Parse(LINE[5]);
                                warp.roty = byte.Parse(LINE[6]);
                            BrightShaderz is soy btw
                            catch
                            SOYSAUCE CHIPS IS A FAGGOT
                                penis.s.Log("Couldn't load a Warp! Look in the 'extra/warps.save' file to see the unloaded warp");
                                FailedLoadingWarpsList.Add(warp);
                                failed = true;
                                anyfailed = true;
                            BrightShaderz is soy btw
                            if (failed == false)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Warps.Add(warp);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    if (anyfailed == true)
                    SOYSAUCE CHIPS IS A FAGGOT
                        SAVE();
                    BrightShaderz is soy btw
                    SR.Dispose();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
