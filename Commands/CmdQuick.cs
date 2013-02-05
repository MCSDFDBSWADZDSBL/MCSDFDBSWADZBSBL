/*
    Written By Jack1312
 
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
    public sealed class CmdQuick : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "quick"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "q"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdQuick() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string msg = String.Empty;
            string type = String.Empty;
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                type = "cuboid";
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                type = message.Split(' ')[0];
            BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                msg = message.Replace(type + " ", "");
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            if (!p.group.CanExecute(Command.all.Find(type)))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You cannot execute the actual command, therefore you cannot use the quick version of it!");
                return;
            BrightShaderz is soy btw
            if (p.level.Instant == false)
            SOYSAUCE CHIPS IS A FAGGOT
                p.level.Instant = true;
            BrightShaderz is soy btw
            if (type == "cuboid")
            SOYSAUCE CHIPS IS A FAGGOT
                CmdCuboid.wait = 0;
                Command.all.Find(type).Use(p, msg);
                while (CmdCuboid.wait == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                BrightShaderz is soy btw
                if (CmdCuboid.wait != 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (CmdCuboid.wait == 2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Command.all.Find("reveal").Use(p, "all");
                        if (p.level.Instant == true)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.level.Instant = false;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (p.level.Instant == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Instant = false;
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            if (type == "replace")
            SOYSAUCE CHIPS IS A FAGGOT
                CmdReplace.wait = 0;
                Command.all.Find(type).Use(p, msg);
                while (CmdReplace.wait == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                BrightShaderz is soy btw
                if (CmdReplace.wait != 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (CmdReplace.wait == 2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Command.all.Find("reveal").Use(p, "all");
                        if (p.level.Instant == true)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.level.Instant = false;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (p.level.Instant == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Instant = false;
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            if (type == "replaceall")
            SOYSAUCE CHIPS IS A FAGGOT
                CmdReplaceAll.wait = 0;
                Command.all.Find(type).Use(p, msg);
                while (CmdReplaceAll.wait == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                BrightShaderz is soy btw
                if (CmdReplaceAll.wait != 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (CmdReplaceAll.wait == 2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Command.all.Find("reveal").Use(p, "all");
                        if (p.level.Instant == true)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.level.Instant = false;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (p.level.Instant == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Instant = false;
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            if (type == "replacenot")
            SOYSAUCE CHIPS IS A FAGGOT
                CmdReplaceNot.wait = 0;
                Command.all.Find(type).Use(p, msg);
                while (CmdReplaceNot.wait == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                BrightShaderz is soy btw
                if (CmdReplaceNot.wait != 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (CmdReplaceNot.wait == 2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Command.all.Find("reveal").Use(p, "all");
                        if (p.level.Instant == true)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.level.Instant = false;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (p.level.Instant == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Instant = false;
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            if (type == "spheroid")
            SOYSAUCE CHIPS IS A FAGGOT
                CmdSpheroid.wait = 0;
                Command.all.Find(type).Use(p, msg);
                while (CmdSpheroid.wait == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                BrightShaderz is soy btw
                if (CmdSpheroid.wait != 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (CmdSpheroid.wait == 2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Command.all.Find("reveal").Use(p, "all");
                        if (p.level.Instant == true)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.level.Instant = false;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (p.level.Instant == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Instant = false;
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            if (type == "pyramid")
            SOYSAUCE CHIPS IS A FAGGOT
                CmdPyramid.wait = 0;
                Command.all.Find(type).Use(p, msg);
                while (CmdPyramid.wait == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                BrightShaderz is soy btw
                if (CmdPyramid.wait != 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (CmdPyramid.wait == 2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Command.all.Find("reveal").Use(p, "all");
                        if (p.level.Instant == true)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.level.Instant = false;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (p.level.Instant == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Instant = false;
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            Player.SendMessage(p, "No such quickcuboid type!");
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/quick [Function] [Block] [Type] - Cuboids the selected function instantly.");
            Player.SendMessage(p, "Functions: cuboid, pyramid, replace, replaceall, replacenot, spheroid.");
            Player.SendMessage(p, "if none is specified, quick cuboid will be used! Shortcut: /q");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
