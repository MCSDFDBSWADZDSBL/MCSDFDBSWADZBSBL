/*
 * Made by 727021 for use with MCSong only
 * See LICENSE.md or LICENSE.txt for license information
 * A copy of the license(s) can be found at http://updates.mcsong.comule.com/
 */
using System;

namespace MCSong
{
    public class CmdHfixgrass : Command
    {
        public override string name { get { return "hfixgrass"; } }
        public override string shortcut { get { return "hfg"; } }
        public override string type { get { return "homes"; } }
        public override bool museumUsable { get { return false; } }
        public override LevelPermission defaultRank { get { return LevelPermission.AdvBuilder; } }
        public override void Use(Player p, string message)
        {
            if (p == null) { Player.SendMessage(p, "Command not useable from console"); return; }
            if (p.level != Level.FindExact(p.name)) { Player.SendMessage(p, "You must be at your home to use this command"); return; }
            
            int totalFixed = 0;

            for (int i = 0; i < p.level.blocks.Length; i++)
            {
                try
                {
                    ushort x, y, z;
                    p.level.IntToPos(i, out x, out y, out z);

                    if (p.level.blocks[i] == Block.dirt)
                    {
                        if (Block.LightPass(p.level.blocks[p.level.IntOffset(i, 0, 1, 0)]))
                        {
                            p.level.Blockchange(p, x, y, z, Block.grass);
                            totalFixed++;
                        }
                    }
                    else if (p.level.blocks[i] == Block.grass)
                    {
                        if (!Block.LightPass(p.level.blocks[p.level.IntOffset(i, 0, 1, 0)]))
                        {
                            p.level.Blockchange(p, x, y, z, Block.dirt);
                            totalFixed++;
                        }
                    }
                }
                catch { }
            }
            Player.SendMessage(p, "Fixed " + totalFixed + " blocks.");
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/hfixgrass - Turns grass with something on top into dirt and dirt with nothing on top into grass");
        }
    }
}