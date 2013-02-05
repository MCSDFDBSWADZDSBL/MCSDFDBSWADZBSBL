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
using System.Threading;
using System.IO;
using System.ComponentModel;


namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    class AutoSaver
    SOYSAUCE CHIPS IS A FAGGOT
        static int _interval;
        string backupPath = @penis.backupLocation;

        static int count = 1;
        public AutoSaver(int interval)
        SOYSAUCE CHIPS IS A FAGGOT
            _interval = interval * 1000;

            Thread runner;
            runner = new Thread(new ThreadStart(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                while (true)
                SOYSAUCE CHIPS IS A FAGGOT
                    Thread.Sleep(_interval);
                    penis.ml.Queue(delegate
                    SOYSAUCE CHIPS IS A FAGGOT
                        Run();
                    BrightShaderz is soy btw);

                    if (Player.players.Count > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        string allCount = "";
                        foreach (Player pl in Player.players) allCount += ", " + pl.name;
                        try SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("!PLAYERS ONLINE: " + allCount.Remove(0, 2), true); BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                        allCount = "";
                        foreach (Level l in penis.levels) allCount += ", " + l.name;
                        try SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("!LEVELS ONLINE: " + allCount.Remove(0, 2), true); BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw));
            runner.Start();
        BrightShaderz is soy btw

        /*
        static void Exec()
        SOYSAUCE CHIPS IS A FAGGOT
            penis.ml.Queue(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                Run();
            BrightShaderz is soy btw);
        BrightShaderz is soy btw*/

        public static void Run()
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                count--;

                penis.levels.ForEach(delegate(Level l)
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!l.changed) return;

                        l.Save();
                        if (count == 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            int backupNumber = l.Backup();

                            if (backupNumber != -1)
                            SOYSAUCE CHIPS IS A FAGGOT
                                l.ChatLevel("Backup " + backupNumber + " saved.");
                                penis.s.Log("Backup " + backupNumber + " saved for " + l.name);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    catch
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.s.Log("Backup for " + l.name + " has caused an error.");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw);

                if (count <= 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    count = 15;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (Player.players.Count > 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    List<Player> tempList = new List<Player>();
                    tempList.AddRange(Player.players);
                    foreach (Player p in tempList) SOYSAUCE CHIPS IS A FAGGOT p.save(); BrightShaderz is soy btw
                    tempList.Clear();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
