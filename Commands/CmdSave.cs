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
using System.IO;
using System.Data;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdSave : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "save"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.ToLower() == "all")
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Level l in penis.levels)
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        l.Save();
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                BrightShaderz is soy btw
                Player.GlobalMessage("All levels have been saved.");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (message.Split(' ').Length == 1)         //Just save level given
                SOYSAUCE CHIPS IS A FAGGOT
                    Level foundLevel = Level.Find(message);
                    if (foundLevel != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        foundLevel.Save(true);
                        Player.SendMessage(p, "Level \"" + foundLevel.name + "\" saved.");
                        int backupNumber = p.level.Backup(true);
                        if (backupNumber != -1)
                            p.level.ChatLevel("Backup " + backupNumber + " saved.");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Could not find level specified");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else if (message.Split(' ').Length == 2)
                SOYSAUCE CHIPS IS A FAGGOT
                    Level foundLevel = Level.Find(message.Split(' ')[0]);
                    string restoreName = message.Split(' ')[1].ToLower();
                    if (foundLevel != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        foundLevel.Save(true);
                        int backupNumber = p.level.Backup(true, restoreName);
                        Player.GlobalMessage(foundLevel.name + " had a backup created named &b" + restoreName);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Could not find level specified");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Use(p, "all");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.Save(true);
                        Player.SendMessage(p, "Level \"" + p.level.name + "\" saved.");

                        int backupNumber = p.level.Backup(true);
                        if (backupNumber != -1)
                            p.level.ChatLevel("Backup " + backupNumber + " saved.");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/save - Saves the level you are currently in");
            Player.SendMessage(p, "/save all - Saves all loaded levels.");
            Player.SendMessage(p, "/save <map> - Saves the specified map.");
            Player.SendMessage(p, "/save <map> <name> - Backups the map with a given restore name");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
