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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdDescend : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "descend"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdDescend() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            ushort posy = (ushort)((p.pos[1] / 32) - 1);
            bool found = false;
            ushort xpos = (ushort)(p.pos[0] / 32);
            ushort zpos = (ushort)(p.pos[2] / 32);
            while (!found && posy > 0)
            SOYSAUCE CHIPS IS A FAGGOT
                posy = (ushort)(posy - 1);
                byte block = p.level.GetTile(xpos, posy, zpos);
                if (block == Block.air || block == Block.air_door || block == Block.air_switch || block == Block.Zero)
                SOYSAUCE CHIPS IS A FAGGOT
                    ushort blockabove = (ushort)(posy + 1);
                    ushort blockunder = (ushort)(posy - 1);
                    if (p.level.GetTile(xpos, blockabove, zpos) == Block.air || p.level.GetTile(xpos, blockabove, zpos) == Block.air_door || p.level.GetTile(xpos, blockabove, zpos) == Block.air_switch || p.level.GetTile(xpos, blockabove, zpos) == Block.Zero)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (p.level.GetTile(xpos, blockunder, zpos) != Block.air && p.level.GetTile(xpos, blockunder, zpos) != Block.air_switch && p.level.GetTile(xpos, blockunder, zpos) != Block.air_door && p.level.GetTile(xpos, blockunder, zpos) != Block.air_flood && p.level.GetTile(xpos, blockunder, zpos) != Block.air_flood_down && p.level.GetTile(xpos, blockunder, zpos) != Block.air_flood_layer && p.level.GetTile(xpos, blockunder, zpos) != Block.air_flood_up && p.level.GetTile(xpos, blockunder, zpos) != Block.air_portal && p.level.GetTile(xpos, blockunder, zpos) != Block.redflower && p.level.GetTile(xpos, blockunder, zpos) != Block.yellowflower && p.level.GetTile(xpos, blockunder, zpos) != Block.finiteWater && p.level.GetTile(xpos, blockunder, zpos) != Block.finiteLava && p.level.GetTile(xpos, blockunder, zpos) != Block.fire && p.level.GetTile(xpos, blockunder, zpos) != Block.water && p.level.GetTile(xpos, blockunder, zpos) != Block.water_door && p.level.GetTile(xpos, blockunder, zpos) != Block.water_portal && p.level.GetTile(xpos, blockunder, zpos) != Block.WaterDown && p.level.GetTile(xpos, blockunder, zpos) != Block.WaterFaucet && p.level.GetTile(xpos, blockunder, zpos) != Block.lava && p.level.GetTile(xpos, blockunder, zpos) != Block.lava_door && p.level.GetTile(xpos, blockunder, zpos) != Block.lava_fast && p.level.GetTile(xpos, blockunder, zpos) != Block.lava_portal && p.level.GetTile(xpos, blockunder, zpos) != Block.LavaDown && p.level.GetTile(xpos, blockunder, zpos) != Block.lavastill && p.level.GetTile(xpos, blockunder, zpos) != Block.Zero)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Teleported you down!");
                            unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, p.pos[0], (ushort)((posy + 1) * 32), p.pos[2], p.rot[0], p.rot[1]); BrightShaderz is soy btw
                            found = true;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (!found)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "No free spaces found below you");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/descend - Teleports you to the first free space below you.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
