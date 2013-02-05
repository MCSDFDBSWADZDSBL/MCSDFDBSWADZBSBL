using System;
using System.Collections.Generic;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdUndo : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "undo"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "u"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            byte b; Int64 seconds; Player who; Player.UndoPos Pos; int CurrentPos = 0;
            if (p != null) p.RedoBuffer.Clear();

            if (message == "") message = p.name + " 30";

            if (message.Split(' ').Length == 2)
            SOYSAUCE CHIPS IS A FAGGOT
                if (message.Split(' ')[1].ToLower() == "all" && p.group.Permission > LevelPermission.Operator)
                SOYSAUCE CHIPS IS A FAGGOT
                    seconds = 500000;
                BrightShaderz is soy btw
                else
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
                    seconds = 30;
                    message = message + " 30";
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            //if (message.Split(' ').Length == 1) if (char.IsDigit(message, 0)) SOYSAUCE CHIPS IS A FAGGOT message = p.name + " " + message; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT message = message + " 30"; BrightShaderz is soy btw

            //try SOYSAUCE CHIPS IS A FAGGOT seconds = Convert.ToInt16(message.Split(' ')[1]); BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT seconds = 2; BrightShaderz is soy btw
            if (seconds == 0) seconds = 5400;

            who = Player.Find(message.Split(' ')[0]);
            if (who != null)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (who.group.Permission > p.group.Permission && who != p) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot undo a user of higher or equal rank"); return; BrightShaderz is soy btw
                    if (who != p && p.group.Permission < LevelPermission.Operator) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Only an OP+ may undo other people's actions"); return; BrightShaderz is soy btw

                    if (p.group.Permission < LevelPermission.Builder && seconds > 120) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Guests may only undo 2 minutes."); return; BrightShaderz is soy btw
                    else if (p.group.Permission < LevelPermission.AdvBuilder && seconds > 300) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Builders may only undo 300 seconds."); return; BrightShaderz is soy btw
                    else if (p.group.Permission < LevelPermission.Operator && seconds > 1200) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "AdvBuilders may only undo 600 seconds."); return; BrightShaderz is soy btw
                    else if (p.group.Permission == LevelPermission.Operator && seconds > 5400) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Operators may only undo 5400 seconds."); return; BrightShaderz is soy btw
                BrightShaderz is soy btw

                for (CurrentPos = who.UndoBuffer.Count - 1; CurrentPos >= 0; --CurrentPos)
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        Pos = who.UndoBuffer[CurrentPos];
                        Level foundLevel = Level.FindExact(Pos.mapName);
                        b = foundLevel.GetTile(Pos.x, Pos.y, Pos.z);
                        if (Pos.timePlaced.AddSeconds(seconds) >= DateTime.Now)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (b == Pos.newtype || Block.Convert(b) == Block.water || Block.Convert(b) == Block.lava)
                            SOYSAUCE CHIPS IS A FAGGOT
                                foundLevel.Blockchange(Pos.x, Pos.y, Pos.z, Pos.type, true);

                                Pos.newtype = Pos.type; Pos.type = b;
                                if (p != null) p.RedoBuffer.Add(Pos);
                                who.UndoBuffer.RemoveAt(CurrentPos);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            break;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (p != who) Player.GlobalChat(p, who.color + who.name + penis.DefaultColor + "'s actions for the past &b" + seconds + " seconds were undone.", false);
                else Player.SendMessage(p, "Undid your actions for the past &b" + seconds + penis.DefaultColor + " seconds.");
                return;
            BrightShaderz is soy btw
            else if (message.Split(' ')[0].ToLower() == "physics")
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.group.Permission < LevelPermission.AdvBuilder) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Reserved for Adv+"); return; BrightShaderz is soy btw
                else if (p.group.Permission < LevelPermission.Operator && seconds > 1200) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "AdvBuilders may only undo 1200 seconds."); return; BrightShaderz is soy btw
                else if (p.group.Permission == LevelPermission.Operator && seconds > 5400) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Operators may only undo 5400 seconds."); return; BrightShaderz is soy btw

                Command.all.Find("pause").Use(p, "120");
                Level.UndoPos uP;
                ushort x, y, z;

                if (p.level.UndoBuffer.Count != penis.physUndo)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (CurrentPos = p.level.currentUndo; CurrentPos >= 0; CurrentPos--)
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            uP = p.level.UndoBuffer[CurrentPos];
                            b = p.level.GetTile(uP.location);
                            if (uP.timePerformed.AddSeconds(seconds) >= DateTime.Now)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (b == uP.newType || Block.Convert(b) == Block.water || Block.Convert(b) == Block.lava)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    p.level.IntToPos(uP.location, out x, out y, out z);
                                    p.level.Blockchange(p, x, y, z, uP.oldType, true);
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                break;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    for (CurrentPos = p.level.currentUndo; CurrentPos != p.level.currentUndo + 1; CurrentPos--)
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (CurrentPos < 0) CurrentPos = p.level.UndoBuffer.Count - 1;
                            uP = p.level.UndoBuffer[CurrentPos];
                            b = p.level.GetTile(uP.location);
                            if (uP.timePerformed.AddSeconds(seconds) >= DateTime.Now)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (b == uP.newType || Block.Convert(b) == Block.water || Block.Convert(b) == Block.lava)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    p.level.IntToPos(uP.location, out x, out y, out z);
                                    p.level.Blockchange(p, x, y, z, uP.oldType, true);
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                break;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                Command.all.Find("pause").Use(p, "");
                Player.GlobalMessage("Physics were undone &b" + seconds + penis.DefaultColor + " seconds");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (p != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.group.Permission < LevelPermission.Operator) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Reserved for OP+"); return; BrightShaderz is soy btw
                    if (seconds > 5400 && p.group.Permission == LevelPermission.Operator) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Only SuperOPs may undo more than 90 minutes."); return; BrightShaderz is soy btw
                BrightShaderz is soy btw

                bool FoundUser = false;

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    DirectoryInfo di;
                    string[] fileContent;

                    p.RedoBuffer.Clear();

                    if (Directory.Exists("extra/undo/" + message.Split(' ')[0]))
                    SOYSAUCE CHIPS IS A FAGGOT
                        di = new DirectoryInfo("extra/undo/" + message.Split(' ')[0]);

                        for (int i = di.GetFiles("*.undo").Length - 1; i >= 0; i--)
                        SOYSAUCE CHIPS IS A FAGGOT
                            fileContent = File.ReadAllText("extra/undo/" + message.Split(' ')[0] + "/" + i + ".undo").Split(' ');
                            if (!undoBlah(fileContent, seconds, p)) break;
                        BrightShaderz is soy btw
                        FoundUser = true;
                    BrightShaderz is soy btw

                    if (Directory.Exists("extra/undoPrevious/" + message.Split(' ')[0]))
                    SOYSAUCE CHIPS IS A FAGGOT
                        di = new DirectoryInfo("extra/undoPrevious/" + message.Split(' ')[0]);

                        for (int i = di.GetFiles("*.undo").Length - 1; i >= 0; i--)
                        SOYSAUCE CHIPS IS A FAGGOT
                            fileContent = File.ReadAllText("extra/undoPrevious/" + message.Split(' ')[0] + "/" + i + ".undo").Split(' ');
                            if (!undoBlah(fileContent, seconds, p)) break;
                        BrightShaderz is soy btw
                        FoundUser = true;
                    BrightShaderz is soy btw
                    
                    if (FoundUser) Player.GlobalChat(p, penis.FindColor(message.Split(' ')[0]) + message.Split(' ')[0] + penis.DefaultColor + "'s actions for the past &b" + seconds + penis.DefaultColor + " seconds were undone.", false);
                    else Player.SendMessage(p, "Could not find player specified.");
                BrightShaderz is soy btw
                catch (Exception e)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.ErrorLog(e);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public bool undoBlah(string[] fileContent, Int64 seconds, Player p)
        SOYSAUCE CHIPS IS A FAGGOT

            //fileContents += uP.map.name + " " + uP.x + " " + uP.y + " " + uP.z + " ";
            //fileContents += uP.timePlaced + " " + uP.type + " " + uP.newtype + " ";

            //Maps = 0, 7, 14, 21, 28, 35...
            //X = 1, 8, 15...
            //newtype = 6, 13, 20, 27...

            Player.UndoPos Pos;

            for (int i = fileContent.Length / 7; i >= 0; i--)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Convert.ToDateTime(fileContent[(i * 7) + 4].Replace('&', ' ')).AddSeconds(seconds) >= DateTime.Now)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Level foundLevel = Level.FindExact(fileContent[i * 7]);
                        if (foundLevel != null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Pos.mapName = foundLevel.name;
                            Pos.x = Convert.ToUInt16(fileContent[(i * 7) + 1]);
                            Pos.y = Convert.ToUInt16(fileContent[(i * 7) + 2]);
                            Pos.z = Convert.ToUInt16(fileContent[(i * 7) + 3]);

                            Pos.type = foundLevel.GetTile(Pos.x, Pos.y, Pos.z);

                            if (Pos.type == Convert.ToByte(fileContent[(i * 7) + 6]) || Block.Convert(Pos.type) == Block.water || Block.Convert(Pos.type) == Block.lava || Pos.type == Block.grass)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Pos.newtype = Convert.ToByte(fileContent[(i * 7) + 5]);
                                Pos.timePlaced = DateTime.Now;

                                foundLevel.Blockchange(Pos.x, Pos.y, Pos.z, Pos.newtype, true);
                                if (p != null) p.RedoBuffer.Add(Pos);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else return false;
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw

            return true;
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/undo [player] [seconds] - Undoes the blockchanges made by [player] in the previous [seconds].");
            Player.SendMessage(p, "/undo [player] all - &cWill undo 138 hours for [player] <SuperOP+>");
            Player.SendMessage(p, "/undo [player] 0 - &cWill undo 30 minutes <Operator+>");
            Player.SendMessage(p, "/undo physics [seconds] - Undoes the physics for the current map");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
