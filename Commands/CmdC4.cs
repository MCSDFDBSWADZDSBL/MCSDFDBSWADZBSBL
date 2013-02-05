/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdC4 : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "c4"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdC4() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p != null)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level.physics >= 1 && p.level.physics < 5)
                SOYSAUCE CHIPS IS A FAGGOT
                    sbyte numb = Level.C4.NextCircuit(p.level);
                    Level.C4.C4s c4 = new Level.C4.C4s(numb);
                    p.level.C4list.Add(c4);
                    p.c4circuitNumber = numb;
                    Player.SendMessage(p, "Place any block for c4 and place a " + c.red + "red" + penis.DefaultColor + " block for the detonator!");
                    p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "To use c4, the physics level must be 1, 2, 3 or 4");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            Player.SendMessage(p, "This command can only be used in-game!");
            return;
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/c4 - Place c4!");
        BrightShaderz is soy btw
        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();

            if (type == Block.red) SOYSAUCE CHIPS IS A FAGGOT Blockchange2(p, x, y, z, type); return; BrightShaderz is soy btw
            if (type != Block.air)
            SOYSAUCE CHIPS IS A FAGGOT
                p.level.Blockchange(p, x, y, z, Block.c4);
            BrightShaderz is soy btw
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw

        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.level.Blockchange(p, x, y, z, Block.c4det);
            Player.SendMessage(p, "Placed detonator block!");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
