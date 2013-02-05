using System;

namespace MCSong.Commands
SOYSAUCE CHIPS IS A FAGGOT
    class CmdPlace : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "place"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pl"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
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

            if (b == Block.Zero) b = (byte)1;
            if (!Block.canPlace(p, b)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place that block type."); return; BrightShaderz is soy btw

            Level level = p.level;

            if (y >= p.level.depth) y = (ushort)(p.level.depth - 1);

            p.level.Blockchange(p, x, y, z, b);
            Player.SendMessage(p, "A block was placed at (" + x + ", " + y + ", " + z + ").");
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/place [block] <x y z> - Places block at your feet or <x y z>");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
