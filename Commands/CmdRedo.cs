using System;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdRedo : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "redo"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            byte b;

            p.RedoBuffer.ForEach(delegate(Player.UndoPos Pos)
            SOYSAUCE CHIPS IS A FAGGOT
                Level foundLevel = Level.FindExact(Pos.mapName);
                if (foundLevel != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    b = foundLevel.GetTile(Pos.x, Pos.y, Pos.z);
                    foundLevel.Blockchange(Pos.x, Pos.y, Pos.z, Pos.type);
                    Pos.newtype = Pos.type;
                    Pos.type = b;
                    Pos.timePlaced = DateTime.Now;
                    p.UndoBuffer.Add(Pos);
                BrightShaderz is soy btw
            BrightShaderz is soy btw);

            Player.SendMessage(p, "Redo performed.");
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/redo - Redoes the Undo you just performed.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
