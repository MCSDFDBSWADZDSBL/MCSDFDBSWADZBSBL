/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
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
    public sealed class CmdBaninfo : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "baninfo"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdBaninfo() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string[] data;
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message.Length <= 3) SOYSAUCE CHIPS IS A FAGGOT Help(p); BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (Ban.Isbanned(message))
                SOYSAUCE CHIPS IS A FAGGOT
                    data = Ban.Getbandata(message);
                    // string[] end = SOYSAUCE CHIPS IS A FAGGOT bannedby, reason, timedate, oldrank, stealth BrightShaderz is soy btw;
                    // usefull to know :-)
                    string reason = data[1].Replace("%20", " ");
                    string datetime = data[2].Replace("%20", " ");
                    Player.SendMessage(p, "&9User: &e" + message);
                    Player.SendMessage(p, "&9Banned by: &e" + data[0]);
                    Player.SendMessage(p, "&9Reason: &e" + reason);
                    Player.SendMessage(p, "&9Date and time: &e" + datetime);
                    Player.SendMessage(p, "&9Old rank: &e" + data[3]);
                    string stealth; if (data[4] == "true") stealth = "&aYes"; else stealth = "&cNo";
                    Player.SendMessage(p, "&9Stealth banned: " + stealth);
                BrightShaderz is soy btw
                else if (!Group.findPerm(LevelPermission.Banned).playerList.Contains(message)) Player.SendMessage(p, "That player isn't banned");
                else if (!Ban.Isbanned(message)) Player.SendMessage(p, "Couldn't find ban info about " + message + ".");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/baninfo <player> - returns info about banned player.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
