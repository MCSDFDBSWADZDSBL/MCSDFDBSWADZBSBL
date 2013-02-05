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
using System.Collections.Generic;
using System.Threading;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdLoad : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "load"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                if (message.Split(' ').Length > 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                int pos = message.IndexOf(' ');
                string phys = "0";
                if (pos != -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    phys = message.Substring(pos + 1);
                    message = message.Substring(0, pos).ToLower();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    message = message.ToLower();
                BrightShaderz is soy btw

                foreach (Level l in penis.levels)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (l.name == message) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, message + " is already loaded!"); return; BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (penis.levels.Count == penis.levels.Capacity)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.levels.Capacity == 1)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "You can't load any levels!");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Command.all.Find("unload").Use(p, "empty");
                        if (penis.levels.Capacity == 1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "No maps are empty to unload. Cannot load map.");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (!File.Exists("levels/" + message + ".lvl"))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Level \"" + message + "\" doesn't exist!"); return;
                BrightShaderz is soy btw

                Level level = Level.Load(message);

                if (level == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (File.Exists("levels/" + message + ".lvl.backup"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.s.Log("Attempting to load backup.");
                        File.Copy("levels/" + message + ".lvl.backup", "levels/" + message + ".lvl", true);
                        level = Level.Load(message);
                        if (level == null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Backup of " + message + " failed.");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Backup of " + message + " does not exist.");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (p != null) if (level.permissionvisit > p.group.Permission)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "This map is for " + Level.PermissionToName(level.permissionvisit) + " only!");
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        return;
                    BrightShaderz is soy btw

                foreach (Level l in penis.levels)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (l.name == message)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, message + " is already loaded!");
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                lock (penis.levels) SOYSAUCE CHIPS IS A FAGGOT
                    penis.addLevel(level);
                BrightShaderz is soy btw

                level.physThread.Start();
                Player.GlobalMessage("Level \"" + level.name + "\" loaded.");
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    int temp = int.Parse(phys);
                    if (temp >= 1 && temp <= 4)
                    SOYSAUCE CHIPS IS A FAGGOT
                        level.setPhysics(temp);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Physics variable invalid");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalMessage("An error occured with /load");
                penis.ErrorLog(e);
            BrightShaderz is soy btw
            finally
            SOYSAUCE CHIPS IS A FAGGOT
                GC.Collect();
                GC.WaitForPendingFinalizers();
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/load <level> <physics> - Loads a level.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
