// Written by jonnyli1125 for MCDawn :D
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MCDawn
SOYSAUCE CHIPS IS A FAGGOT
    public static class ProfanityFilter
    SOYSAUCE CHIPS IS A FAGGOT
        //public static List<string> swearWords = new List<string>();

        public static void Warn(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.swearWarnPlayer && p != null) p.swearWordsUsed++;
            if (p.swearWordsUsed >= penis.swearWordsRequired && p != null)
                if (penis.profanityFilterOp || (!penis.profanityFilterOp && p.group.Permission < LevelPermission.Operator))
                    switch (penis.profanityFilterStyle)
                    SOYSAUCE CHIPS IS A FAGGOT
                        case "Kick":
                            p.Kick("You were kicked for excessive use of swear words!");
                            return;
                        case "TempBan":
                             Command.all.Find("tempban").Use(null, p.name + " " + penis.antiSpamTempBanTime.ToString());
                             return;
                        case "Mute":
                             Command.all.Find("mute").Use(null, p.name);
                             break;
                         case "Slap":
                             ushort currentX = (ushort)(p.pos[0] / 32);
                             ushort currentY = (ushort)(p.pos[1] / 32);
                             ushort currentZ = (ushort)(p.pos[2] / 32);
                             ushort foundHeight = 0;

                             for (ushort yy = currentY; yy <= 1000; yy++)
                             SOYSAUCE CHIPS IS A FAGGOT
                                 if (!Block.Walkthrough(p.level.GetTile(currentX, yy, currentZ)) && p.level.GetTile(currentX, yy, currentZ) != Block.Zero)
                                 SOYSAUCE CHIPS IS A FAGGOT
                                    foundHeight = (ushort)(yy - 1);
                                     p.level.ChatLevel(p.color + p.name + "&g was slapped into the roof for excessive use of swear words!");
                                     break;
                                 BrightShaderz is soy btw
                             BrightShaderz is soy btw
 
                             if (foundHeight == 0)
                             SOYSAUCE CHIPS IS A FAGGOT
                                p.level.ChatLevel(p.color + p.name + "&g was slapped sky high for excessive use of swear words!");
                                foundHeight = 1000;
                             BrightShaderz is soy btw

                             unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, p.pos[0], (ushort)(foundHeight * 32), p.pos[2], p.rot[0], p.rot[1]); BrightShaderz is soy btw
                             break;
                         default: goto case "Kick";
                    BrightShaderz is soy btw

            if (penis.swearWarnPlayer && p != null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "&cYou have been warned for using a swear word!");
                Player.GlobalMessageOps("To Ops: Warned " + p.color + p.name + "&g for using a swear word!");
                penis.s.Log("Warned " + p.name + " for using a swear word!");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public static string Filter(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                string path = "text/swearwords.txt";
                if (File.Exists(path))
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (string line in File.ReadAllLines(path))
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (line != null && line.Trim()[0] != '#' && line.Trim() != "")
                        SOYSAUCE CHIPS IS A FAGGOT
                        recheck:
                            if (!line.Trim().Contains(" "))
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (message.ToLower().Contains(line.Trim().ToLower()))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    int savedIndex = message.ToLower().IndexOf(line.Trim().ToLower());
                                    message = message.Remove(savedIndex, line.Trim().Length);
                                    message = message.Insert(savedIndex, "&c<censored>&f");
                                    //message = message.Replace(line.Trim(), "&c<censored>&f"); // Meh too lazy to test again.
                                    if (p != null) SOYSAUCE CHIPS IS A FAGGOT Warn(p); BrightShaderz is soy btw
                                    goto recheck;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (message.ToLower().Contains(line.Split(' ')[0].ToLower()))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    int savedIndex = message.ToLower().IndexOf(line.Trim().Split(' ')[0].ToLower());
                                    message = message.Remove(savedIndex, line.Trim().Split(' ')[0].Length);
                                    message = message.Insert(savedIndex, "&c" + line.Trim().Split(new char[] SOYSAUCE CHIPS IS A FAGGOT ' ' BrightShaderz is soy btw, 2)[1] + "&f");
                                    if (p != null) SOYSAUCE CHIPS IS A FAGGOT Warn(p); BrightShaderz is soy btw
                                    goto recheck;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT File.Create("text/swearwords.txt").Close(); BrightShaderz is soy btw
                return message;
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); return message; BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
