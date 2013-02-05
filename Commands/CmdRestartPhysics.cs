using System;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdRestartPhysics : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "restartphysics"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "rp"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            CatchPos cpos;
            cpos.x = 0; cpos.y = 0; cpos.z = 0;

            message = message.ToLower();
            cpos.extraInfo = "";

            if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                int currentLoop = 0; string[] storedArray; bool skip = false;

            retry: foreach (string s in message.Split(' '))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (currentLoop % 2 == 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        switch (s)
                        SOYSAUCE CHIPS IS A FAGGOT
                            case "drop":
                            case "explode":
                            case "dissipate":
                            case "finite":
                            case "wait":
                            case "rainbow":
                                break;
                            case "revert":
                                if (skip) break;
                                storedArray = message.Split(' ');
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    storedArray[currentLoop + 1] = Block.Byte(message.Split(' ')[currentLoop + 1].ToString().ToLower()).ToString();
                                    if (storedArray[currentLoop + 1].ToString() == "255") throw new OverflowException();
                                BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid block type."); return; BrightShaderz is soy btw

                                message = string.Join(" ", storedArray);
                                skip = true; currentLoop = 0;

                                goto retry;
                            default:
                                Player.SendMessage(p, s + " is not supported."); return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (int.Parse(s) < 1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Values must be above 0"); return; BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "/rp [text] [num] [text] [num]"); return; BrightShaderz is soy btw
                    BrightShaderz is soy btw

                    currentLoop++;
                BrightShaderz is soy btw

                if (currentLoop % 2 != 1) cpos.extraInfo = message;
                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Number of parameters must be even"); Help(p); return; BrightShaderz is soy btw
            BrightShaderz is soy btw

            p.blockchangeObject = cpos;
            Player.SendMessage(p, "Place two blocks to determine the edges.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/restartphysics ([type] [num]) ([type2] [num2]) (...) - Restarts every physics block in an area");
            Player.SendMessage(p, "[type] will set custom physics for selected blocks");
            Player.SendMessage(p, "Possible [types]: drop, explode, dissipate, finite, wait, rainbow, revert");
            Player.SendMessage(p, "/rp revert takes block names");
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
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos cpos = (CatchPos)p.blockchangeObject;
            List<CatchPos> buffer = new List<CatchPos>();
            CatchPos pos = new CatchPos();
            //int totalChecks = 0;

            //if (Math.Abs(cpos.x - x) * Math.Abs(cpos.y - y) * Math.Abs(cpos.z - z) > 8000) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Tried to restart too many blocks. You may only restart 8000"); return; BrightShaderz is soy btw

            for (ushort xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); ++xx)
            SOYSAUCE CHIPS IS A FAGGOT
                for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (ushort zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (p.level.GetTile(xx, yy, zz) != Block.air)
                        SOYSAUCE CHIPS IS A FAGGOT
                            pos.x = xx; pos.y = yy; pos.z = zz;
                            pos.extraInfo = cpos.extraInfo;
                            buffer.Add(pos);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (cpos.extraInfo == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (buffer.Count > penis.rpNormLimit)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Cannot restart more than " + penis.rpNormLimit + " blocks.");
                        Player.SendMessage(p, "Tried to restart " + buffer.Count + " blocks.");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (buffer.Count > penis.rpLimit)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Tried to add physics to " + buffer.Count + " blocks.");
                        Player.SendMessage(p, "Cannot add physics to more than " + penis.rpLimit + " blocks.");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw

            foreach (CatchPos pos1 in buffer)
            SOYSAUCE CHIPS IS A FAGGOT
                p.level.AddCheck(p.level.PosToInt(pos1.x, pos1.y, pos1.z), pos1.extraInfo, true);
            BrightShaderz is soy btw

            Player.SendMessage(p, "Activated " + buffer.Count + " blocks.");
            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw

        struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public string extraInfo; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
