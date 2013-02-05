using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdTree : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "tree"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            switch (message.ToLower())
            SOYSAUCE CHIPS IS A FAGGOT
                case "2":
                case "cactus": p.Blockchange += new Player.BlockchangeEventHandler(AddCactus); break;
                default: p.Blockchange += new Player.BlockchangeEventHandler(AddTree); break;
            BrightShaderz is soy btw
            Player.SendMessage(p, "Select where you wish your tree to grow");
            p.painting = false;
        BrightShaderz is soy btw

        void AddTree(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            Random Rand = new Random();

            byte height = (byte)Rand.Next(5, 8);
            for (ushort yy = 0; yy < height; yy++) p.level.Blockchange(p, x, (ushort)(y + yy), z, Block.trunk);

            short top = (short)(height - Rand.Next(2, 4));

            for (short xx = (short)-top; xx <= top; ++xx)
            SOYSAUCE CHIPS IS A FAGGOT
                for (short yy = (short)-top; yy <= top; ++yy)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (short zz = (short)-top; zz <= top; ++zz)
                    SOYSAUCE CHIPS IS A FAGGOT
                        short Dist = (short)(Math.Sqrt(xx * xx + yy * yy + zz * zz));
                        if (Dist < top + 1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (Rand.Next((int)(Dist)) < 2)
                            SOYSAUCE CHIPS IS A FAGGOT
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    p.level.Blockchange(p, (ushort)(x + xx), (ushort)(y + yy + height), (ushort)(z + zz), Block.leaf);
                                BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (!p.staticCommands) p.ClearBlockchange();
        BrightShaderz is soy btw
        void AddCactus(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            Random Rand = new Random();

            byte height = (byte)Rand.Next(3, 6);
            ushort yy;

            for (yy = 0; yy <= height; yy++) p.level.Blockchange(p, x, (ushort)(y + yy), z, Block.green);

            int inX = 0, inZ = 0;

            switch (Rand.Next(1, 3))
            SOYSAUCE CHIPS IS A FAGGOT
                case 1: inX = -1; break;
                case 2:
                default: inZ = -1; break;
            BrightShaderz is soy btw

            for (yy = height; yy <= Rand.Next(height + 2, height + 5); yy++) p.level.Blockchange(p, (ushort)(x + inX), (ushort)(y + yy), (ushort)(z + inZ), Block.green);
            for (yy = height; yy <= Rand.Next(height + 2, height + 5); yy++) p.level.Blockchange(p, (ushort)(x - inX), (ushort)(y + yy), (ushort)(z - inZ), Block.green);

            if (!p.staticCommands) p.ClearBlockchange();
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/tree [type] - Turns tree mode on or off.");
            Player.SendMessage(p, "Types - (Fern | 1), (Cactus | 2)");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
