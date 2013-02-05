/*
	Copyright 2011 MCForge
	
	Written by SebbiUltimate
		
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
    public sealed class CmdSendCmd : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "sendcmd"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Nobody; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            int length = message.Split().Length;
            Player player = null;
            if (length >= 1)
                player = Player.Find(message.Split(' ')[0]);
            else return;
            if (player == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Error: Player is not online.");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (p == null) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT if (player.group.Permission >= p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot use this on someone of equal or greater rank."); return; BrightShaderz is soy btw BrightShaderz is soy btw
                string command;
                string cmdMsg = "";
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    command = message.Split(' ')[1];
                    for(int i = 2; i < length; i++)
                        cmdMsg += message.Split(' ')[i] + " ";
                    cmdMsg.Remove(cmdMsg.Length - 1); //removing the space " " at the end of the msg
                    Command.all.Find(command).Use(player, cmdMsg);
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Error: No parameter found");
                    command = message.Split(' ')[1];
                    Command.all.Find(command).Use(player, "");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/sendcmd - Make another user use a command, (/sendcmd player command parameter)");
            Player.SendMessage(p, "ex: /sendcmd bob tp bob2");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw



