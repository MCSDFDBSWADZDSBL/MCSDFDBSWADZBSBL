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
    public class CmdBlockSet : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "blockset"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "" || message.IndexOf(' ') == -1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            byte foundBlock = Block.Byte(message.Split(' ')[0]);
            if (foundBlock == Block.Zero) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find block entered"); return; BrightShaderz is soy btw
            LevelPermission newPerm = Level.PermissionFromName(message.Split(' ')[1]);
            if (newPerm == LevelPermission.Null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find rank specified"); return; BrightShaderz is soy btw
            if (p != null && newPerm > p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot set to a rank higher than yourself."); return; BrightShaderz is soy btw

            if (p != null && !Block.canPlace(p, foundBlock)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot modify a block set for a higher rank"); return; BrightShaderz is soy btw

            Block.Blocks newBlock = Block.BlockList.Find(bs => bs.type == foundBlock);
            newBlock.lowestRank = newPerm;

            Block.BlockList[Block.BlockList.FindIndex(bL => bL.type == foundBlock)] = newBlock;

            Block.SaveBlocks(Block.BlockList);

            Player.GlobalMessage("&d" + Block.Name(foundBlock) + penis.DefaultColor + "'s permission was changed to " + Level.PermissionToName(newPerm));
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/blockset [block] [rank] - Changes [block] rank to [rank]");
            Player.SendMessage(p, "Only blocks you can use can be modified");
            Player.SendMessage(p, "Available ranks: " + Group.concatList());
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
