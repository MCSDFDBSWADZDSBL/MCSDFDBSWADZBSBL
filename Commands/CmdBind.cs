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
    public class CmdBind : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "bind"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message.Split(' ').Length > 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            message = message.ToLower();
            if (message == "clear")
            SOYSAUCE CHIPS IS A FAGGOT
                for (byte d = 0; d < 128; d++) p.bindings[d] = d;
                Player.SendMessage(p, "All bindings were unbound.");
                return;
            BrightShaderz is soy btw

            int pos = message.IndexOf(' ');
            if (pos != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                byte b1 = Block.Byte(message.Substring(0, pos));
                byte b2 = Block.Byte(message.Substring(pos + 1));
                if (b1 == 255) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no block \"" + message.Substring(0, pos) + "\"."); return; BrightShaderz is soy btw
                if (b2 == 255) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no block \"" + message.Substring(pos + 1) + "\"."); return; BrightShaderz is soy btw

                if (!Block.Placable(b1)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, Block.Name(b1) + " isn't a special block."); return; BrightShaderz is soy btw
                if (!Block.canPlace(p, b2)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You can't bind " + Block.Name(b2) + "."); return; BrightShaderz is soy btw
                if (b1 > (byte)64) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot bind anything to this block."); return; BrightShaderz is soy btw

                if (p.bindings[b1] == b2) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, Block.Name(b1) + " is already bound to " + Block.Name(b2) + "."); return; BrightShaderz is soy btw

                p.bindings[b1] = b2;
                message = Block.Name(b1) + " bound to " + Block.Name(b2) + ".";

                Player.SendMessage(p, message);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                byte b = Block.Byte(message);
                if (b > 100) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "This block cannot be bound"); return; BrightShaderz is soy btw

                if (p.bindings[b] == b) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, Block.Name(b) + " isn't bound."); return; BrightShaderz is soy btw
                p.bindings[b] = b; Player.SendMessage(p, "Unbound " + Block.Name(b) + ".");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/bind <block> [type] - Replaces block with type.");
            Player.SendMessage(p, "/bind clear - Clears all binds.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
