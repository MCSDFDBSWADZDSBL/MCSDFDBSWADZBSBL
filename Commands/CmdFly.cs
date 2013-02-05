/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCSong) Licensed under the
	Educational Community License, Version 2.0 (the "License"); you may
	not use this file except in compliance with the License. You may
	obtain a copy of the License at
	
	http://www.osedu.org/licenses/ECL-2.0
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the License is distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the License for the specific language governing
	permissions and limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Threading;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdFly : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "fly"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            p.isFlying = !p.isFlying;
            if (!p.isFlying) return;

            Player.SendMessage(p, "You are now flying. &cJump!");

            Thread flyThread = new Thread(new ThreadStart(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                Pos pos;
                List<Pos> buffer = new List<Pos>();
                while (p.isFlying)
                SOYSAUCE CHIPS IS A FAGGOT
                    Thread.Sleep(20);
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        List<Pos> tempBuffer = new List<Pos>();

                        ushort x = (ushort)((p.pos[0]) / 32);
                        ushort y = (ushort)((p.pos[1] - 60) / 32);
                        ushort z = (ushort)((p.pos[2]) / 32);

                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (ushort xx = (ushort)(x - 2); xx <= x + 2; xx++)
                            SOYSAUCE CHIPS IS A FAGGOT
                                for (ushort yy = (ushort)(y - 1); yy <= y; yy++)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    for (ushort zz = (ushort)(z - 2); zz <= z + 2; zz++)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if (p.level.GetTile(xx, yy, zz) == Block.air)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            pos.x = xx; pos.y = yy; pos.z = zz;
                                            tempBuffer.Add(pos);
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw

                            List<Pos> toRemove = new List<Pos>();
                            foreach (Pos cP in buffer)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (!tempBuffer.Contains(cP))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    p.SendBlockchange(cP.x, cP.y, cP.z, Block.air);
                                    toRemove.Add(cP);
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw

                            foreach (Pos cP in toRemove)
                            SOYSAUCE CHIPS IS A FAGGOT
                                buffer.Remove(cP);
                            BrightShaderz is soy btw

                            foreach (Pos cP in tempBuffer)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (!buffer.Contains(cP))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    buffer.Add(cP);
                                    p.SendBlockchange(cP.x, cP.y, cP.z, Block.glass);
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw

                            tempBuffer.Clear();
                            toRemove.Clear();
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                BrightShaderz is soy btw

                foreach (Pos cP in buffer)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.SendBlockchange(cP.x, cP.y, cP.z, Block.air);
                BrightShaderz is soy btw

                Player.SendMessage(p, "Stopped flying");
            BrightShaderz is soy btw));
            flyThread.Start();
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/fly - Allows you to fly");
        BrightShaderz is soy btw

        struct Pos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
