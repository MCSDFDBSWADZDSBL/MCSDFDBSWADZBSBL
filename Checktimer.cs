/*
Copyright 2011 MCForge
Dual-licensed under the Educational Community License, Version 2.0 and
the GNU General Public License, Version 3 (the "Licenses"); you may
not use this file except in compliance with the Licenses. You may
obtain a copy of the Licenses at
http://www.opensource.org/licenses/ecl2.php
http://www.gnu.org/licenses/gpl-3.0.html
Unless required by applicable law or agreed to in writing,
software distributed under the Licenses are distributed on an "AS IS"
BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
or implied. See the Licenses for the specific language governing
permiusing MCForge;ssions and limitations under the Licenses.
*/
﻿using System;
using System.IO;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public static class Checktimer
    SOYSAUCE CHIPS IS A FAGGOT
        static System.Timers.Timer t;
        public static void StartTimer()
        SOYSAUCE CHIPS IS A FAGGOT
            t = new System.Timers.Timer();
            t.AutoReset = false;
            t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);
            t.Interval = GetInterval();
            t.Start();
        BrightShaderz is soy btw
        static double GetInterval()
        SOYSAUCE CHIPS IS A FAGGOT
            DateTime now = DateTime.Now;
            return ((60 - now.Second) * 1000 - now.Millisecond);
        BrightShaderz is soy btw
        /// <summary>
        /// Put methods to make them execute every 60 seconds
        /// </summary>
        /// <param name="sender">For the timer</param>
        /// <param name="e">For the timer</param>
        static void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            t.Interval = GetInterval();
            t.Start();

            // methods to be executed every 60 seconds!:
            TRExpiryCheck();
        BrightShaderz is soy btw
        public static void TRExpiryCheck()
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (Player p in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (string line3 in File.ReadAllLines("text/tempranks.txt"))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (line3.Contains(p.name))
                    SOYSAUCE CHIPS IS A FAGGOT
                        string player = line3.Split(' ')[0];
                        int period = Convert.ToInt32(line3.Split(' ')[3]);
                        int minutes = Convert.ToInt32(line3.Split(' ')[4]);
                        int hours = Convert.ToInt32(line3.Split(' ')[5]);
                        int days = Convert.ToInt32(line3.Split(' ')[6]);
                        int months = Convert.ToInt32(line3.Split(' ')[7]);
                        int years = Convert.ToInt32(line3.Split(' ')[8]);
                        Player who = Player.Find(player);
                        DateTime ExpireDate = new DateTime(years, months, days, hours, minutes, 0);
                        DateTime tocheck = ExpireDate.AddHours(Convert.ToDouble(period));
                        DateTime tochecknow = DateTime.Now;
                        double datecompare = DateTime.Compare(tocheck, tochecknow);
                        if (datecompare <= 0)
                            Command.all.Find("deltemprank").Use(null, who.name);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
