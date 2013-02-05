/*
	Copyright 2010 MCSong Team - Written by Valek
 
    Licensed under the
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
    public class CmdWhitelist : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "whitelist"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "w"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            int pos = message.IndexOf(' ');
            if (pos != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                string action = message.Substring(0, pos);
                string player = message.Substring(pos + 1);

                switch (action)
                SOYSAUCE CHIPS IS A FAGGOT
                    case "add":
                        if (penis.whiteList.Contains(player))
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "&f" + player + penis.DefaultColor + " is already on the whitelist!");
                            break;
                        BrightShaderz is soy btw
                        penis.whiteList.Add(player);
                        Player.GlobalMessageOps(p.color + p.prefix + p.name + penis.DefaultColor + " added &f" + player + penis.DefaultColor + " to the whitelist.");
                        penis.whiteList.Save("whitelist.txt");
                        penis.s.Log("WHITELIST: Added " + player);
                        break;
                    case "del":
                        if (!penis.whiteList.Contains(player))
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "&f" + player + penis.DefaultColor + " is not on the whitelist!");
                            break;
                        BrightShaderz is soy btw
                        penis.whiteList.Remove(player);
                        Player.GlobalMessageOps(p.color + p.prefix + p.name + penis.DefaultColor + " removed &f" + player + penis.DefaultColor + " from the whitelist.");
                        penis.whiteList.Save("whitelist.txt");
                        penis.s.Log("WHITELIST: Removed " + player);
                        break;
                    case "list":
                        string output = "Whitelist:&f";
                        foreach (string wlName in penis.whiteList.All())
                        SOYSAUCE CHIPS IS A FAGGOT
                            output += " " + wlName + ",";
                        BrightShaderz is soy btw
                        output = output.Substring(0, output.Length - 1);
                        Player.SendMessage(p, output);
                        break;
                    default:
                        Help(p);
                        return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (message == "list")
                SOYSAUCE CHIPS IS A FAGGOT
                    string output = "Whitelist:&f";
                    foreach (string wlName in penis.whiteList.All())
                    SOYSAUCE CHIPS IS A FAGGOT
                        output += " " + wlName + ",";
                    BrightShaderz is soy btw
                    output = output.Substring(0, output.Length - 1);
                    Player.SendMessage(p, output);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Help(p);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/whitelist <add/del/list> [player] - Handles whitelist entry for [player], or lists all entries.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
