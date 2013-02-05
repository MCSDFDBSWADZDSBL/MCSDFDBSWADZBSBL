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
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    class CmdRestore : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "restore"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            //Thread CrossThread;

            if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log(@penis.backupLocation + "/" + p.level.name + "/" + message + "/" + p.level.name + ".lvl");
                if (File.Exists(@penis.backupLocation + "/" + p.level.name + "/" + message + "/" + p.level.name + ".lvl"))
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        File.Copy(@penis.backupLocation + "/" + p.level.name + "/" + message + "/" + p.level.name + ".lvl", "levels/" + p.level.name + ".lvl", true);
                        Level temp = Level.Load(p.level.name);
                        temp.physThread.Start();
                        if (temp != null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.level.spawnx = temp.spawnx;
                            p.level.spawny = temp.spawny;
                            p.level.spawnz = temp.spawnz;

                            p.level.height = temp.height;
                            p.level.width = temp.width;
                            p.level.depth = temp.depth;

                            p.level.blocks = temp.blocks;
                            p.level.setPhysics(0);
                            p.level.ClearPhysics();

                            Command.all.Find("reveal").Use(p, "all");
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            penis.s.Log("Restore nulled");
                            File.Copy("levels/" + p.level.name + ".lvl.backup", "levels/" + p.level.name + ".lvl", true);
                        BrightShaderz is soy btw

                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Restore fail"); BrightShaderz is soy btw
                BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Backup " + message + " does not exist."); BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (Directory.Exists(@penis.backupLocation + "/" + p.level.name))
                SOYSAUCE CHIPS IS A FAGGOT
                    string[] directories = Directory.GetDirectories(@penis.backupLocation + "/" + p.level.name);
                    int backupNumber = directories.Length;
                    Player.SendMessage(p, p.level.name + " has " + backupNumber + " backups .");

                    bool foundOne = false; string foundRestores = "";
                    foreach (string s in directories)
                    SOYSAUCE CHIPS IS A FAGGOT
                        string directoryName = s.Substring(s.LastIndexOf('\\') + 1);
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            int.Parse(directoryName);
                        BrightShaderz is soy btw
                        catch
                        SOYSAUCE CHIPS IS A FAGGOT
                            foundOne = true;
                            foundRestores += ", " + directoryName;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw

                    if (foundOne)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Custom-named restores:");
                        Player.SendMessage(p, "> " + foundRestores.Remove(0, 2));
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, p.level.name + " has no backups yet.");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/restore <backup> - restores a previous backup of the current map");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
