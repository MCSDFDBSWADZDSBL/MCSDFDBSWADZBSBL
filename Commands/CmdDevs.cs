/*
	Copyright 2010 MCSong Team - Written by Valek
 
    Licensed under the
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
    public class CmdDevs : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "devs"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "staff"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            string devlist = "";
            string temp;
            foreach (string dev in penis.devs)
            SOYSAUCE CHIPS IS A FAGGOT
                temp = dev.Substring(0, 1);
                temp = temp.ToUpper() + dev.Remove(0, 1);
                devlist += temp + ", ";
            BrightShaderz is soy btw
            devlist = devlist.Remove(devlist.Length - 2);
            Player.SendMessage(p, "&9MCSong Development Team: " + penis.DefaultColor + devlist);
            if (penis.staff.Count > 0)
            SOYSAUCE CHIPS IS A FAGGOT
                string stafflist = "";
                string tmp;
                foreach (string staff in penis.staff)
                SOYSAUCE CHIPS IS A FAGGOT
                    tmp = staff.Substring(0, 1);
                    tmp = tmp.ToUpper() + staff.Remove(0, 1);
                    stafflist += tmp + ", ";
                BrightShaderz is soy btw
                stafflist = stafflist.Remove(stafflist.Length - 2);
                Player.SendMessage(p, "&9MCSong Administration Team: " + penis.DefaultColor + stafflist);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/devs - Displays the list of MCSong developers and administrators.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
