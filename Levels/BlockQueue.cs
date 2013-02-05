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
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public static class BlockQueue
    SOYSAUCE CHIPS IS A FAGGOT
        public static int time SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return (int)blocktimer.Interval; BrightShaderz is soy btw set SOYSAUCE CHIPS IS A FAGGOT blocktimer.Interval = value; BrightShaderz is soy btw BrightShaderz is soy btw
        public static int blockupdates = 200;
        static block b = new block();
        static System.Timers.Timer blocktimer = new System.Timers.Timer(100);
        static byte started = 0;

        public static void Start()
        SOYSAUCE CHIPS IS A FAGGOT
            blocktimer.Elapsed += delegate
            SOYSAUCE CHIPS IS A FAGGOT
                if (started == 1) return;
                started = 1;
                penis.levels.ForEach((l) =>
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (l.blockqueue.Count < 1) return;
                        int count;
                        if (l.blockqueue.Count < blockupdates || l.players.Count == 0) count = l.blockqueue.Count;
                        else count = blockupdates;

                        for (int c = 0; c < count; c++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            l.Blockchange(l.blockqueue[c].p, l.blockqueue[c].x, l.blockqueue[c].y, l.blockqueue[c].z, l.blockqueue[c].type);
                        BrightShaderz is soy btw
                        l.blockqueue.RemoveRange(0, count);
                    BrightShaderz is soy btw
                    catch (Exception e)
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.s.ErrorCase("error:" + e);
                        penis.s.Log(String.Format("Block cache failed for map: SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw. SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw lost.", l.name, l.blockqueue.Count));
                        l.blockqueue.Clear();
                    BrightShaderz is soy btw
                BrightShaderz is soy btw);
                started = 0;
            BrightShaderz is soy btw;
            blocktimer.Start();
        BrightShaderz is soy btw
        public static void pause() SOYSAUCE CHIPS IS A FAGGOT blocktimer.Enabled = false; BrightShaderz is soy btw
        public static void resume() SOYSAUCE CHIPS IS A FAGGOT blocktimer.Enabled = true; BrightShaderz is soy btw

        public static void Addblock(Player P, ushort X, ushort Y, ushort Z, byte Type)
        SOYSAUCE CHIPS IS A FAGGOT
            b.x = X; b.y = Y; b.z = Z; b.type = Type; b.p = P;
            P.level.blockqueue.Add(b);
        BrightShaderz is soy btw

        public struct block SOYSAUCE CHIPS IS A FAGGOT public Player p; public ushort x; public ushort y; public ushort z; public byte type; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
