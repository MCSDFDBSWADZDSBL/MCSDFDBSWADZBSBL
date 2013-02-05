/*
    Written by Jack1312
  
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
    public sealed class CmdExplode : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "explode"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ex"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdExplode() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/explode - Satisfying all your exploding needs :)");
            Player.SendMessage(p, "/explode me - Explodes at your location");
            Player.SendMessage(p, "/explode [Player] - Explode the specified player");
            Player.SendMessage(p, "/explode [X] [Y] [Z] - Explode at the specified co-ordinates");

        BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            int number = message.Split(' ').Length;
            if (number > 3) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "What are you on about?"); return; BrightShaderz is soy btw
            if (message == "me")
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level.physics <3)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "The physics on this level are not sufficient for exploding!");
                    return;
                BrightShaderz is soy btw
                Command.all.Find("explode").Use(p, p.name);
                return;
            BrightShaderz is soy btw
            if (number == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.level.physics < 3)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "The physics on this level are not sufficient for exploding!");
                        return;
                    BrightShaderz is soy btw
                        Player who = Player.Find(message);
                        ushort x = (ushort)(who.pos[0] / 32);
                        ushort y = (ushort)(who.pos[1] / 32);
                        ushort z = (ushort)(who.pos[2] / 32);
                        p.level.MakeExplosion(x, y, z, 1);
                        Player.SendMessage(p, who.color + who.name + penis.DefaultColor + " has been exploded!");
                        return;
                BrightShaderz is soy btw
                Player.SendMessage(p, "The specified player does not exist!");
                return;
            BrightShaderz is soy btw
            if (number == 3)
            SOYSAUCE CHIPS IS A FAGGOT
                SOYSAUCE CHIPS IS A FAGGOT
                    byte b = Block.Zero;
                    ushort x = 0; ushort y = 0; ushort z = 0;

                    x = (ushort)(p.pos[0] / 32);
                    y = (ushort)((p.pos[1] / 32) - 1);
                    z = (ushort)(p.pos[2] / 32);

                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        switch (message.Split(' ').Length)
                        SOYSAUCE CHIPS IS A FAGGOT
                            case 0: b = Block.rock; break;
                            case 1: b = Block.Byte(message); break;
                            case 3:
                                x = Convert.ToUInt16(message.Split(' ')[0]);
                                y = Convert.ToUInt16(message.Split(' ')[1]);
                                z = Convert.ToUInt16(message.Split(' ')[2]);
                                break;
                            case 4:
                                b = Block.Byte(message.Split(' ')[0]);
                                x = Convert.ToUInt16(message.Split(' ')[1]);
                                y = Convert.ToUInt16(message.Split(' ')[2]);
                                z = Convert.ToUInt16(message.Split(' ')[3]);
                                break;
                            default: Player.SendMessage(p, "Invalid parameters"); return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid parameters"); return; BrightShaderz is soy btw

                    Level level = p.level;

                    if (y >= p.level.depth) y = (ushort)(p.level.depth - 1);

                    if (p.level.physics < 3)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "The physics on this level are not sufficient for exploding!");
                        return;
                    BrightShaderz is soy btw
                        p.level.MakeExplosion(x, y, z, 1);
                        Player.SendMessage(p, "An explosion was made at (" + x + ", " + y + ", " + z + ").");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
