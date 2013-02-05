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
    /// <summary>
    /// This is the command /splace
    /// use /help splace in game for more info
    /// </summary>
    public sealed class CmdSPlace : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "splace"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "set"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw
        private ushort distance, interval;
        private byte blocktype = (byte)1;
        public CmdSPlace() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            distance = 0; interval = 0;
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message.Split(' ').Length > 1)
            SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT ushort.TryParse(message.Split(' ')[0], out distance); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Distance must be a number."); return; BrightShaderz is soy btw
                try SOYSAUCE CHIPS IS A FAGGOT ushort.TryParse(message.Split(' ')[1], out interval); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Interval must be a number."); return; BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT ushort.TryParse(message, out distance); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Distance must be a number."); return; BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (distance < 1)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Enter a distance greater than 0."); return;
            BrightShaderz is soy btw
            if (interval >= distance)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "The Interval cannot be greater than the distance."); return;
            BrightShaderz is soy btw

            CatchPos cpos;
            cpos.givenMessage = message;
            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            Player.SendMessage(p, "Place two blocks to determine direction.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/splace [distance] [interval] - Measures a set [distance] and places a stone block at each end.");
            Player.SendMessage(p, "Optionally place a block at set [interval] between them.");
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
            type = p.bindings[type];
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos cpos = (CatchPos)p.blockchangeObject;
            if (x == cpos.x && z == cpos.z) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No direction was selected"); return; BrightShaderz is soy btw
            if (Math.Abs(cpos.x - x) > Math.Abs(cpos.z - z))
            SOYSAUCE CHIPS IS A FAGGOT
                if (x > cpos.x)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Blockchange(p, (ushort)(cpos.x + (distance - 1)), cpos.y, cpos.z, blocktype);
                    p.level.Blockchange(p, cpos.x, cpos.y, cpos.z, blocktype);
                    if (interval > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (ushort offset = interval; cpos.x + offset < cpos.x + (distance - 1); offset += interval)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.level.Blockchange(p, (ushort)(cpos.x + offset), cpos.y, cpos.z, blocktype);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Blockchange(p, (ushort)(cpos.x - (distance - 1)), cpos.y, cpos.z, blocktype);
                    p.level.Blockchange(p, cpos.x, cpos.y, cpos.z, b = blocktype);
                    if (interval > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (ushort offset = interval; cpos.x - (distance - 1) < cpos.x - offset; offset += interval)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.level.Blockchange(p, (ushort)(cpos.x - offset), cpos.y, cpos.z, blocktype);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (z > cpos.z)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Blockchange(p, cpos.x, cpos.y, (ushort)(cpos.z + (distance - 1)), blocktype);
                    p.level.Blockchange(p, cpos.x, cpos.y, cpos.z, blocktype);
                    if (interval > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (ushort offset = interval; cpos.z + offset < cpos.z + (distance - 1); offset += interval)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.level.Blockchange(p, cpos.x, cpos.y, (ushort)(cpos.z + offset), blocktype);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Blockchange(p, cpos.x, cpos.y, (ushort)(cpos.z - (distance - 1)), blocktype);
                    p.level.Blockchange(p, cpos.x, cpos.y, cpos.z, blocktype);
                    if (interval > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (ushort offset = interval; cpos.z - (distance - 1) < cpos.z - offset; offset += interval)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.level.Blockchange(p, cpos.x, cpos.y, (ushort)(cpos.z - offset), blocktype);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (interval > 0)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Placed stone blocks " + interval + " apart");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Placed stone blocks " + distance + " apart");
            BrightShaderz is soy btw
            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        struct CatchPos
        SOYSAUCE CHIPS IS A FAGGOT
            public ushort x, y, z; public string givenMessage;
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
