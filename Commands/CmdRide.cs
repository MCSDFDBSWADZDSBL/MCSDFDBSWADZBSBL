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
using System.IO;
using System.Threading;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdRide : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ride"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            p.onTrain = !p.onTrain;

            if (!p.onTrain) return;

            Thread trainThread = new Thread(new ThreadStart(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                while (p.onTrain)
                SOYSAUCE CHIPS IS A FAGGOT
                    Thread.Sleep(3);

                    ushort x = (ushort)(p.pos[0] / 32);
                    ushort y = (ushort)(p.pos[1] / 32);
                    ushort z = (ushort)(p.pos[2] / 32);

                    for (ushort xx = (ushort)(x - 1); xx <= x + 1; xx++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (ushort yy = (ushort)(y - 1); yy <= y + 1; yy++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (ushort zz = (ushort)(z - 1); zz <= z + 1; zz++)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (p.level.GetTile(xx, yy, zz) == Block.train)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    p.invincible = true; p.trainGrab = true;
                                    byte newY = 0;

                                    if (y - yy == -1) newY = 240;
                                    else if (y - yy == 0) newY = 0;
                                    else newY = 8;

                                    unchecked
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if (x - xx == -1)
                                            if (z - zz == -1) p.SendPos((byte)-1, (ushort)(xx * 32 + 16), (ushort)((yy + 1) * 32 - 2), (ushort)(zz * 32 + 16), (byte)96, newY);
                                            else if (z - zz == 0) p.SendPos((byte)-1, (ushort)(xx * 32 + 16), (ushort)((yy + 1) * 32 - 2), (ushort)(zz * 32 + 16), (byte)64, newY);
                                            else p.SendPos((byte)-1, (ushort)(xx * 32 + 16), (ushort)((yy + 1) * 32 - 2), (ushort)(zz * 32 + 16), (byte)32, newY);
                                        else if (x - xx == 0)
                                            if (z - zz == -1) p.SendPos((byte)-1, (ushort)(xx * 32 + 16), (ushort)((yy + 1) * 32 - 2), (ushort)(zz * 32 + 16), (byte)128, newY);
                                            else if (z - zz == 0) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                                            else p.SendPos((byte)-1, (ushort)(xx * 32 + 16), (ushort)((yy + 1) * 32 - 2), (ushort)(zz * 32 + 16), (byte)0, newY);
                                        else
                                            if (z - zz == -1) p.SendPos((byte)-1, (ushort)(xx * 32 + 16), (ushort)((yy + 1) * 32 - 2), (ushort)(zz * 32 + 16), (byte)160, newY);
                                            else if (z - zz == 0) p.SendPos((byte)-1, (ushort)(xx * 32 + 16), (ushort)((yy + 1) * 32 - 2), (ushort)(zz * 32 + 16), (byte)192, newY);
                                            else p.SendPos((byte)-1, (ushort)(xx * 32 + 16), (ushort)((yy + 1) * 32 - 2), (ushort)(zz * 32 + 16), (byte)224, newY);
                                    BrightShaderz is soy btw
                                    goto skip;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw

                    Thread.Sleep(3);
                    p.invincible = false;
                    p.trainGrab = false;
            skip:   ;                 
                BrightShaderz is soy btw

                Player.SendMessage(p, "Dismounted");
                Thread.Sleep(1000);
                p.invincible = false;
                p.trainGrab = false;
            BrightShaderz is soy btw));
            trainThread.Start();
            Player.SendMessage(p, "Stand near a train to mount it");
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/ride - Rides a nearby train.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
