using System;
using System.Collections.Generic;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdPaste : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "paste"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "v"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public string loadname;
        
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            CatchPos cpos;
            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;

            Player.SendMessage(p, "Place a block in the corner of where you want to paste."); p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/paste - Pastes the stored copy.");
            Player.SendMessage(p, "&4BEWARE: " + penis.DefaultColor + "The blocks will always be pasted in a set direction");
        BrightShaderz is soy btw

        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);

            Player.UndoPos Pos1;
            //p.UndoBuffer.Clear();
            p.CopyBuffer.ForEach(delegate(Player.CopyPos pos)
            SOYSAUCE CHIPS IS A FAGGOT
                Pos1.x = (ushort)(Math.Abs(pos.x) + x);
                Pos1.y = (ushort)(Math.Abs(pos.y) + y);
                Pos1.z = (ushort)(Math.Abs(pos.z) + z);

                if (pos.type != Block.air || p.copyAir)
                    unchecked SOYSAUCE CHIPS IS A FAGGOT if (p.level.GetTile(Pos1.x, Pos1.y, Pos1.z) != Block.Zero) p.level.Blockchange(p, (ushort)(Pos1.x + p.copyoffset[0]), (ushort)(Pos1.y + p.copyoffset[1]), (ushort)(Pos1.z + p.copyoffset[2]), pos.type); BrightShaderz is soy btw
            BrightShaderz is soy btw);

            Player.SendMessage(p, "Pasted " + p.CopyBuffer.Count + " blocks.");

            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw

        struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
