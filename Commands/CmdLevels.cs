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
using System.IO;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdLevels : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "levels"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT // TODO
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                message = "";
                string message2 = "";
                bool Once = false;
                penis.levels.ForEach(delegate(Level level)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (level.permissionvisit <= p.group.Permission)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (Group.findPerm(level.permissionbuild) != null)
                            message += ", " + Group.findPerm(level.permissionbuild).color + level.name + " &b[" + level.physics + "]";
                        else
                            message += ", " + level.name + " &b[" + level.physics + "]";
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!Once)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Once = true;
                            if (Group.findPerm(level.permissionvisit) != null)
                                message2 += Group.findPerm(level.permissionvisit).color + level.name + " &b[" + level.physics + "]";
                            else
                                message2 += level.name + " &b[" + level.physics + "]";
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (Group.findPerm(level.permissionvisit) != null)
                                message2 += ", " + Group.findPerm(level.permissionvisit).color + level.name + " &b[" + level.physics + "]";
                            else
                                message2 += ", " + level.name + " &b[" + level.physics + "]";
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw);
                Player.SendMessage(p, "Loaded: " + message.Remove(0, 2));
                if (message2 != "")
                    Player.SendMessage(p, "Can't Goto: " + message2);
                Player.SendMessage(p, "Use &4/unloaded for unloaded levels.");
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/levels - Lists all loaded levels and their physics levels.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
