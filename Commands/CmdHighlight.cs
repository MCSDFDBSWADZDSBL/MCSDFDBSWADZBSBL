using System;
using System.Collections.Generic;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdHighlight : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "highlight"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "moderation"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            byte b; Int64 seconds;
            Player who;
            Player.UndoPos Pos;
            int CurrentPos = 0;
            bool FoundUser = false;

            if (message == "") message = p.name + " 300";

            if (message.Split(' ').Length == 2)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    seconds = Int64.Parse(message.Split(' ')[1]);
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Invalid seconds.");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    seconds = int.Parse(message);
                    if (p != null) message = p.name + " " + message;
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    seconds = 300;
                    message = message + " 300";
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (seconds == 0) seconds = 5400;

            who = Player.Find(message.Split(' ')[0]);
            if (who != null)
            SOYSAUCE CHIPS IS A FAGGOT
                message = who.name + " " + seconds;
                FoundUser = true;
                for (CurrentPos = who.UndoBuffer.Count - 1; CurrentPos >= 0; --CurrentPos)
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        Pos = who.UndoBuffer[CurrentPos];
                        Level foundLevel = Level.Find(Pos.mapName);
                        if (foundLevel == p.level)
                        SOYSAUCE CHIPS IS A FAGGOT
                            b = foundLevel.GetTile(Pos.x, Pos.y, Pos.z);
                            if (Pos.timePlaced.AddSeconds(seconds) >= DateTime.Now)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (b == Pos.newtype || Block.Convert(b) == Block.water || Block.Convert(b) == Block.lava)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (b == Block.air || Block.Convert(b) == Block.water || Block.Convert(b) == Block.lava) p.SendBlockchange(Pos.x, Pos.y, Pos.z, Block.red);
                                    else p.SendBlockchange(Pos.x, Pos.y, Pos.z, Block.green);
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                break;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                DirectoryInfo di;
                string[] fileContent;

                if (Directory.Exists("extra/undo/" + message.Split(' ')[0]))
                SOYSAUCE CHIPS IS A FAGGOT
                    di = new DirectoryInfo("extra/undo/" + message.Split(' ')[0]);

                    for (int i = 0; i < di.GetFiles("*.undo").Length; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        fileContent = File.ReadAllText("extra/undo/" + message.Split(' ')[0] + "/" + i + ".undo").Split(' ');
                        highlightStuff(fileContent, seconds, p);
                    BrightShaderz is soy btw
                    FoundUser = true;
                BrightShaderz is soy btw

                if (Directory.Exists("extra/undoPrevious/" + message.Split(' ')[0]))
                SOYSAUCE CHIPS IS A FAGGOT
                    di = new DirectoryInfo("extra/undoPrevious/" + message.Split(' ')[0]);

                    for (int i = 0; i < di.GetFiles("*.undo").Length; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        fileContent = File.ReadAllText("extra/undoPrevious/" + message.Split(' ')[0] + "/" + i + ".undo").Split(' ');
                        highlightStuff(fileContent, seconds, p);
                    BrightShaderz is soy btw
                    FoundUser = true;
                BrightShaderz is soy btw

                if (FoundUser)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Now highlighting &b" + seconds + penis.DefaultColor + " seconds for " + penis.FindColor(message.Split(' ')[0]) + message.Split(' ')[0]);
                    Player.SendMessage(p, "&cUse /reveal to un-highlight");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Could not find player specified.");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void highlightStuff(string[] fileContent, Int64 seconds, Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.UndoPos Pos;

            for (int i = fileContent.Length / 7; i >= 0; i--)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Convert.ToDateTime(fileContent[(i * 7) + 4].Replace('&', ' ')).AddSeconds(seconds) >= DateTime.Now)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Level foundLevel = Level.Find(fileContent[i * 7]);
                        if (foundLevel != null && foundLevel == p.level)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Pos.mapName = foundLevel.name;
                            Pos.x = Convert.ToUInt16(fileContent[(i * 7) + 1]);
                            Pos.y = Convert.ToUInt16(fileContent[(i * 7) + 2]);
                            Pos.z = Convert.ToUInt16(fileContent[(i * 7) + 3]);

                            Pos.type = foundLevel.GetTile(Pos.x, Pos.y, Pos.z);

                            if (Pos.type == Convert.ToByte(fileContent[(i * 7) + 6]) || Block.Convert(Pos.type) == Block.water || Block.Convert(Pos.type) == Block.lava)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (Pos.type == Block.air || Block.Convert(Pos.type) == Block.water || Block.Convert(Pos.type) == Block.lava)
                                    p.SendBlockchange(Pos.x, Pos.y, Pos.z, Block.red);
                                else p.SendBlockchange(Pos.x, Pos.y, Pos.z, Block.green);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else break;
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/highlight [player] [seconds] - Highlights blocks modified by [player] in the last [seconds]");
            Player.SendMessage(p, "/highlight [player] 0 - Will highlight 30 minutes");
            Player.SendMessage(p, "&c/highlight cannot be disabled, you must use /reveal to un-highlight");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
