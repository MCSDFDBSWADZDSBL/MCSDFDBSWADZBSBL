/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl) Licensed under the
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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdPlayerBlock : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "playerblock"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pblock"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdPlayerBlock() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            Player who = Player.Find(message.Split(' ')[0]);
            if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player"); return; BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (message.Split(' ').Length == 2)
                SOYSAUCE CHIPS IS A FAGGOT
                    who.blockCount = int.Parse(message.Split(' ')[1]);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            finally
            SOYSAUCE CHIPS IS A FAGGOT
                p.SendMessage(who.color + who.name + penis.DefaultColor + " has " + who.blockCount.ToString() + " blocks.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/playerblock <player> [blocks] - sets <player>'s block count to [blocks]");
            Player.SendMessage(p, "/playerblock <player> - shows you <player>'s block count");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
