/*
	Copyright 2010 MCLawl Team - Written by Valek (Modified for use with MCForge)
 
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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdGcmods : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "gcmods"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "gcmod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdGcmods() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            string gcmodlist = "";
            string tempgcmods;
            foreach (string gcmod in penis.GCmods)
            SOYSAUCE CHIPS IS A FAGGOT
                tempgcmods = gcmod.Substring(0, 1);
                tempgcmods = tempgcmods.ToUpper() + gcmod.Remove(0, 1);
                gcmodlist += tempgcmods + ", ";
            BrightShaderz is soy btw
            gcmodlist = gcmodlist.Remove(gcmodlist.Length - 2);
            Player.SendMessage(p, "&9MCForge Global Chat Moderation Team: " + penis.DefaultColor + gcmodlist + "&e.");
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/gcmods - Displays the list of MCForge global chat moderators.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
