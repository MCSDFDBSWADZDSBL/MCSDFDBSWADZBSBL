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

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdCmdSet : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "cmdset"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "" || message.IndexOf(' ') == -1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            string foundBlah = Command.all.FindShort(message.Split(' ')[0]);

            Command foundCmd;
            if (foundBlah == "") foundCmd = Command.all.Find(message.Split(' ')[0]);
            else foundCmd = Command.all.Find(foundBlah);

            if (foundCmd == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find command entered"); return; BrightShaderz is soy btw
            if (p != null && !p.group.CanExecute(foundCmd)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "This command is higher than your rank."); return; BrightShaderz is soy btw

            LevelPermission newPerm = Level.PermissionFromName(message.Split(' ')[1]);
            if (newPerm == LevelPermission.Null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find rank specified"); return; BrightShaderz is soy btw
            if (p != null && newPerm > p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot set to a rank higher than yourself."); return; BrightShaderz is soy btw

            GrpCommands.rankAllowance newCmd = GrpCommands.allowedCommands.Find(rA => rA.commandName == foundCmd.name);
            newCmd.lowestRank = newPerm;
            GrpCommands.allowedCommands[GrpCommands.allowedCommands.FindIndex(rA => rA.commandName == foundCmd.name)] = newCmd;

            GrpCommands.Save(GrpCommands.allowedCommands);
            GrpCommands.fillRanks();
            Player.GlobalMessage("&d" + foundCmd.name + penis.DefaultColor + "'s permission was changed to " + Level.PermissionToName(newPerm));
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/cmdset [cmd] [rank] - Changes [cmd] rank to [rank]");
            Player.SendMessage(p, "Only commands you can use can be modified");
            Player.SendMessage(p, "Available ranks: " + Group.concatList());
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
