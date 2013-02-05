/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCSong) Licensed under the
	Educational Community License, Version 2.0 (the "License"); you may
	not use this file except in compliance with the License. You may
	obtain a copy of the License at
	
	http://www.osedu.org/licenses/ECL-2.0
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the License is distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the License for the specific language governing
	permissions and limitations under the License.
*/
using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdBlocks : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "blocks"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (message == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Basic blocks: ");
                    for (byte i = 0; i < 50; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        message += ", " + Block.Name(i);
                    BrightShaderz is soy btw
                    Player.SendMessage(p, message.Remove(0, 2));
                    Player.SendMessage(p, "&d/blocks all <0/1/2/3/4> " + penis.DefaultColor + "will show the rest.");
                BrightShaderz is soy btw
                else if (message.ToLower() == "all")
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Complex blocks: ");
                    for (byte i = 50; i < 255; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (Block.Name(i).ToLower() != "unknown") message += ", " + Block.Name(i);
                    BrightShaderz is soy btw
                    Player.SendMessage(p, message.Remove(0, 2));
                    Player.SendMessage(p, "Use &d/blocks all <0/1/2/3/4> " + penis.DefaultColor + "for a readable list.");
                BrightShaderz is soy btw
                else if (message.ToLower().IndexOf(' ') != -1 && message.Split(' ')[0] == "all")
                SOYSAUCE CHIPS IS A FAGGOT
                    int foundRange = 0;
                    try SOYSAUCE CHIPS IS A FAGGOT foundRange = int.Parse(message.Split(' ')[1]); BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Incorrect syntax"); return; BrightShaderz is soy btw

                    if (foundRange >= 5 || foundRange < 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Number must be between 0 and 4"); return; BrightShaderz is soy btw

                    message = "";
                    Player.SendMessage(p, "Blocks between " + foundRange * 51 + " and " + (foundRange + 1) * 51);
                    for (byte i = (byte)(foundRange * 51); i < (byte)((foundRange + 1) * 51); i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (Block.Name(i).ToLower() != "unknown") message += ", " + Block.Name(i);
                    BrightShaderz is soy btw
                    Player.SendMessage(p, message.Remove(0, 2));
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    string printMessage = ">>>&b";

                    if (Block.Byte(message) != Block.Zero)
                    SOYSAUCE CHIPS IS A FAGGOT
                        byte b = Block.Byte(message);
                        if (b < 51)
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (byte i = 51; i < 255; i++)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (Block.Convert(i) == b)
                                    printMessage += Block.Name(i) + ", ";
                            BrightShaderz is soy btw

                            if (printMessage != ">>>&b")
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "Blocks which look like \"" + message + "\":");
                                Player.SendMessage(p, printMessage.Remove(printMessage.Length - 2));
                            BrightShaderz is soy btw
                            else Player.SendMessage(p, "No Complex Blocks look like \"" + message + "\"");
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "&bComplex information for \"" + message + "\":");
                            Player.SendMessage(p, "&cBlock will appear as a \"" + Block.Name(Block.Convert(b)) + "\" block");

                            if (Block.LightPass(b)) Player.SendMessage(p, "Block will allow light through");
                            if (Block.Physics(b)) Player.SendMessage(p, "Block effects physics in some way");
                            else Player.SendMessage(p, "Block will not effect physics in any way");
                            if (Block.NeedRestart(b)) Player.SendMessage(p, "The block's physics will auto-start");

                            if (Block.OPBlocks(b)) Player.SendMessage(p, "Block is unaffected by explosions");

                            if (Block.AllowBreak(b)) Player.SendMessage(p, "Anybody can activate the block");
                            if (Block.Walkthrough(b)) Player.SendMessage(p, "Block can be walked through");
                            if (Block.Death(b)) Player.SendMessage(p, "Walking through block will kill you");

                            if (Block.DoorAirs(b) != (byte)0) Player.SendMessage(p, "Block is an ordinary door");
                            if (Block.tDoor(b)) Player.SendMessage(p, "Block is a tdoor, which allows other blocks through when open");
                            if (Block.odoor(b) != Block.Zero) Player.SendMessage(p, "Block is an odoor, which toggles (GLITCHY)");

                            if (Block.Mover(b)) Player.SendMessage(p, "Block can be activated by walking through it");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else if (Group.Find(message) != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        LevelPermission Perm = Group.Find(message).Permission;
                        foreach (Block.Blocks bL in Block.BlockList)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (Block.canPlace(Perm, bL.type) && Block.Name(bL.type).ToLower() != "unknown") printMessage += Block.Name(bL.type) + ", ";
                        BrightShaderz is soy btw

                        if (printMessage != ">>>&b")
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Blocks which " + Group.Find(message).color + Group.Find(message).name + penis.DefaultColor + " can place: ");
                            Player.SendMessage(p, printMessage.Remove(printMessage.Length - 2));
                        BrightShaderz is soy btw
                        else Player.SendMessage(p, "No blocks are specific to this rank");
                    BrightShaderz is soy btw
                    else if (message.IndexOf(' ') == -1)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (message.ToLower() == "count") Player.SendMessage(p, "Blocks in this map: " + p.level.blocks.Length);
                        else Help(p);
                    BrightShaderz is soy btw
                    else if (message.Split(' ')[0].ToLower() == "count")
                    SOYSAUCE CHIPS IS A FAGGOT
                        int foundNum = 0; byte foundBlock = Block.Byte(message.Split(' ')[1]);
                        if (foundBlock == Block.Zero) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find block specified"); return; BrightShaderz is soy btw

                        for (int i = 0; i < p.level.blocks.Length; i++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (foundBlock == p.level.blocks[i]) foundNum++;
                        BrightShaderz is soy btw

                        if (foundNum == 0) Player.SendMessage(p, "No blocks were of type \"" + message.Split(' ')[1] + "\"");
                        else if (foundNum == 1) Player.SendMessage(p, "1 block was of type \"" + message.Split(' ')[1] + "\"");
                        else Player.SendMessage(p, foundNum.ToString() + " blocks were of type \"" + message.Split(' ')[1] + "\"");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Unable to find block or rank");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); Help(p); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/blocks - Lists all basic blocks");
            Player.SendMessage(p, "/blocks all - Lists all complex blocks");
            Player.SendMessage(p, "/blocks [basic block] - Lists all blocks which look the same");
            Player.SendMessage(p, "/blocks [complex block] - Lists specific information on block");
            Player.SendMessage(p, "/blocks <rank> - Lists all blocks <rank> can use");
            Player.SendMessage(p, ">> " + Group.concatList());
            Player.SendMessage(p, "/blocks count <block> - Finds total count for <block> in map");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
