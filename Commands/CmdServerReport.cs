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
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdpenisReport : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "penisreport"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "sr"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.PCCounter == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Starting PCCounter...one second");
                penis.PCCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                penis.PCCounter.BeginInit();
                penis.PCCounter.NextValue();
            BrightShaderz is soy btw
            if (penis.ProcessCounter == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Starting ProcessCounter...one second");
                penis.ProcessCounter = new PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);
                penis.ProcessCounter.BeginInit();
                penis.ProcessCounter.NextValue();
            BrightShaderz is soy btw

            TimeSpan tp = Process.GetCurrentProcess().TotalProcessorTime;
            TimeSpan up = (DateTime.Now - Process.GetCurrentProcess().StartTime);

            //To get actual CPU% is OS dependant
            string ProcessorUsage = "CPU Usage (Processes : All Processes):" + penis.ProcessCounter.NextValue() + " : " + penis.PCCounter.NextValue();
            //Alternative Average?
            //string ProcessorUsage = "CPU Usage is Not Implemented: So here is ProcessUsageTime/ProcessTotalTime:"+String.Format("00.00",(((tp.Ticks/up.Ticks))*100))+"%";
            //reports Private Bytes because it is what the process has reserved for itself and is unsharable
            string MemoryUsage = "Memory Usage: " + Math.Round((double)Process.GetCurrentProcess().PrivateMemorySize64 / 1048576).ToString() + " Megabytes";
            string Uptime = "Uptime: " + up.Days + " Days " + up.Hours + " Hours " + up.Minutes + " Minutes " + up.Seconds + " Seconds";
            string Threads = "Threads: " + Process.GetCurrentProcess().Threads.Count;
            Player.SendMessage(p, Uptime);
            Player.SendMessage(p, MemoryUsage);
            Player.SendMessage(p, ProcessorUsage);
            Player.SendMessage(p, Threads);

        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/penisreport - Get penis CPU%, RAM usage, and uptime.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
