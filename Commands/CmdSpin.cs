using System;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdSpin : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "spin"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.Split(' ').Length > 1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message == "") message = "90";

            List<Player.CopyPos> newBuffer = new List<Player.CopyPos>();
            int TotalLoop = 0; ushort temp;
            newBuffer.Clear();

            switch (message)
            SOYSAUCE CHIPS IS A FAGGOT
                case "90":
                    p.CopyBuffer.ForEach(delegate(Player.CopyPos Pos)
                    SOYSAUCE CHIPS IS A FAGGOT
                        temp = Pos.z; Pos.z = Pos.x; Pos.x = temp;
                        p.CopyBuffer[TotalLoop] = Pos;
                        TotalLoop += 1;
                    BrightShaderz is soy btw);
                    goto case "m";
                case "180":
                    TotalLoop = p.CopyBuffer.Count;
                    p.CopyBuffer.ForEach(delegate(Player.CopyPos Pos)
                    SOYSAUCE CHIPS IS A FAGGOT
                        TotalLoop -= 1;
                        Pos.x = p.CopyBuffer[TotalLoop].x;
                        Pos.z = p.CopyBuffer[TotalLoop].z;
                        newBuffer.Add(Pos);
                    BrightShaderz is soy btw);
                    p.CopyBuffer.Clear();
                    p.CopyBuffer = newBuffer;
                    break;
                case "upsidedown":
                case "u":
                    TotalLoop = p.CopyBuffer.Count;
                    p.CopyBuffer.ForEach(delegate(Player.CopyPos Pos)
                    SOYSAUCE CHIPS IS A FAGGOT
                        TotalLoop -= 1;
                        Pos.y = p.CopyBuffer[TotalLoop].y;
                        newBuffer.Add(Pos);
                    BrightShaderz is soy btw);
                    p.CopyBuffer.Clear();
                    p.CopyBuffer = newBuffer;
                    break;
                case "mirror":
                case "m":
                    TotalLoop = p.CopyBuffer.Count;
                    p.CopyBuffer.ForEach(delegate(Player.CopyPos Pos)
                    SOYSAUCE CHIPS IS A FAGGOT
                        TotalLoop -= 1;
                        Pos.x = p.CopyBuffer[TotalLoop].x;
                        newBuffer.Add(Pos);
                    BrightShaderz is soy btw);
                    p.CopyBuffer.Clear();
                    p.CopyBuffer = newBuffer;
                    break;
                case "z":
                    TotalLoop = p.CopyBuffer.Count;
                    p.CopyBuffer.ForEach(delegate(Player.CopyPos Pos)
                    SOYSAUCE CHIPS IS A FAGGOT
                        TotalLoop -= 1;
                        Pos.x = (ushort)(p.CopyBuffer[TotalLoop].y - (2 * p.CopyBuffer[TotalLoop].y));
                        Pos.y = p.CopyBuffer[TotalLoop].x;
                        newBuffer.Add(Pos);
                    BrightShaderz is soy btw);
                    p.CopyBuffer.Clear();
                    p.CopyBuffer = newBuffer;
                    break;
                case "x":
                    TotalLoop = p.CopyBuffer.Count;
                    p.CopyBuffer.ForEach(delegate(Player.CopyPos Pos)
                    SOYSAUCE CHIPS IS A FAGGOT
                        TotalLoop -= 1;
                        Pos.z = (ushort)(p.CopyBuffer[TotalLoop].y - (2 * p.CopyBuffer[TotalLoop].y));
                        Pos.y = p.CopyBuffer[TotalLoop].z;
                        newBuffer.Add(Pos);
                    BrightShaderz is soy btw);
                    p.CopyBuffer.Clear();
                    p.CopyBuffer = newBuffer;
                    break;

                default:
                    Player.SendMessage(p, "Incorrect syntax"); Help(p);
                    return;
            BrightShaderz is soy btw

            Player.SendMessage(p, "Spun: &b" + message);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/spin <90/180/mirror/upsidedown> - Spins the copied object.");
            Player.SendMessage(p, "Shotcuts: m for mirror, u for upside down, x for spin 90 on x, z for spin 90 on z.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
