/*
	Copyright 2011 MCForge
	
	Written by jordanneil23 with alot of help from TheMusiKid.
		
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.opensource.org/licenses/ecl2.php
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;
using System.IO;
using System.Threading;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdShutdown : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "shutdown"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Help(Player p) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "/shutdown [time] [message] - Shuts the penis down"); BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            int secTime = 10;
            bool shutdown = true;
            string file = "stopShutdown";
            if (File.Exists(file)) SOYSAUCE CHIPS IS A FAGGOT File.Delete(file); BrightShaderz is soy btw
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT message = "penis is going to shutdown in " + secTime + " seconds"; BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (message == "cancel") SOYSAUCE CHIPS IS A FAGGOT File.Create(file).Close(); shutdown = false; message = "Shutdown cancelled"; BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!message.StartsWith("0"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        string[] split = message.Split(' ');
                        bool isNumber = false;
                        try SOYSAUCE CHIPS IS A FAGGOT secTime = Convert.ToInt32(split[0]); isNumber = true; BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT secTime = 10; isNumber = false; BrightShaderz is soy btw
                        if (split.Length > 1) SOYSAUCE CHIPS IS A FAGGOT if (isNumber) SOYSAUCE CHIPS IS A FAGGOT message = message.Substring(1 + split[0].Length); BrightShaderz is soy btw BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Countdown time cannot be zero"); return; BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (shutdown)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalMessage("%4" + message);
                penis.s.Log(message);
                for (int t = secTime; t > 0; t = t - 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!File.Exists(file)) SOYSAUCE CHIPS IS A FAGGOT Player.GlobalMessage("%4penis shutdown in " + t + " seconds"); penis.s.Log("penis shutdown in " + t + " seconds"); Thread.Sleep(1000); BrightShaderz is soy btw
                    else SOYSAUCE CHIPS IS A FAGGOT File.Delete(file); Player.GlobalMessage("Shutdown cancelled"); penis.s.Log("Shutdown cancelled"); return; BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (!File.Exists(file)) SOYSAUCE CHIPS IS A FAGGOT MCForge_.Gui.Program.ExitProgram(false); return; BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT File.Delete(file); Player.GlobalMessage("Shutdown cancelled"); penis.s.Log("Shutdown cancelled"); return; BrightShaderz is soy btw
            BrightShaderz is soy btw
            return;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
