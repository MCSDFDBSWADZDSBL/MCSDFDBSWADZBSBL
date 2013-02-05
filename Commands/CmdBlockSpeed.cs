/*
	Copyright 2011 MCForge
		
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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdBlockSpeed : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "blockspeed"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "bs"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdBlockSpeed() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string text)
        SOYSAUCE CHIPS IS A FAGGOT
            if (text == "")
            SOYSAUCE CHIPS IS A FAGGOT
                SendEstimation(p);
                return;
            BrightShaderz is soy btw
            if (text == "clear")
            SOYSAUCE CHIPS IS A FAGGOT
                penis.levels.ForEach((l) => SOYSAUCE CHIPS IS A FAGGOT l.blockqueue.Clear(); BrightShaderz is soy btw);
                return;
            BrightShaderz is soy btw
            if (text.StartsWith("bs"))
            SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT BlockQueue.blockupdates = int.Parse(text.Split(' ')[1]); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid number specified."); return; BrightShaderz is soy btw
                Player.SendMessage(p, String.Format("Blocks per interval is now SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw.", BlockQueue.blockupdates));
                return;
            BrightShaderz is soy btw
            if (text.StartsWith("ts"))
            SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT BlockQueue.time = int.Parse(text.Split(' ')[1]); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid number specified."); return; BrightShaderz is soy btw
                Player.SendMessage(p, String.Format("Block interval is now SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw.", BlockQueue.time));
                return;
            BrightShaderz is soy btw
            if (text.StartsWith("buf"))
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level.bufferblocks)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.bufferblocks = false;
                    Player.SendMessage(p, String.Format("Block buffering on SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw disabled.", p.level.name));
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.bufferblocks = true;
                    Player.SendMessage(p, String.Format("Block buffering on SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw enabled.", p.level.name));
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            if (text.StartsWith("net"))
            SOYSAUCE CHIPS IS A FAGGOT
                switch (int.Parse(text.Split(' ')[1]))
                SOYSAUCE CHIPS IS A FAGGOT
                    case 2:
                        BlockQueue.blockupdates = 25;
                        BlockQueue.time = 100;
                        break;
                    case 4:
                        BlockQueue.blockupdates = 50;
                        BlockQueue.time = 100;
                        break;
                    case 8:
                        BlockQueue.blockupdates = 100;
                        BlockQueue.time = 100;
                        break;
                    case 12:
                        BlockQueue.blockupdates = 200;
                        BlockQueue.time = 100;
                        break;
                    case 16:
                        BlockQueue.blockupdates = 200;
                        BlockQueue.time = 100;
                        break;
                    case 161:
                        BlockQueue.blockupdates = 100;
                        BlockQueue.time = 50;
                        break;
                    case 20:
                        BlockQueue.blockupdates = 125;
                        BlockQueue.time = 50;
                        break;
                    case 24:
                        BlockQueue.blockupdates = 150;
                        BlockQueue.time = 50;
                        break;
                    default:
                        BlockQueue.blockupdates = 200;
                        BlockQueue.time = 100;
                        break;
                BrightShaderz is soy btw
                SendEstimation(p);
                return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        private static void SendEstimation(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, String.Format("SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw blocks every SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw milliseconds = SOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw blocks per second.", BlockQueue.blockupdates, BlockQueue.time, BlockQueue.blockupdates * (1000 / BlockQueue.time)));
            Player.SendMessage(p, String.Format("Using ~SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btwKB/s times SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw player(s) = ~SOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btwKB/s", (BlockQueue.blockupdates * (1000 / BlockQueue.time) * 8) / 1000, Player.players.Count, Player.players.Count * ((BlockQueue.blockupdates * (1000 / BlockQueue.time) * 8) / 1000)));
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/bs [option] [option value] - Options for block speeds.");
            Player.SendMessage(p, "Options are: bs (blocks per interval), ts (interval in milliseconds), buf (toggles buffering), clear, net.");
            Player.SendMessage(p, "/bs net [2,4,8,12,16,20,24] - Presets, divide by 8 and times by 1000 to get blocks per second.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
