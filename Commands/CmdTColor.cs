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
    public class CmdTColor : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "tcolor"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!penis.useMySQL) SOYSAUCE CHIPS IS A FAGGOT p.SendMessage("MySQL has not been configured! Please configure MySQL to use Title Colors!"); return; BrightShaderz is soy btw
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            string[] args = message.Split(' ');
            Player who = Player.Find(args[0]);
            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Could not find player.");
                return;
            BrightShaderz is soy btw
            if (args.Length == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                who.titlecolor = "";
                Player.GlobalChat(who, who.color + who.name + penis.DefaultColor + " had their title color removed.", false);
                MySQL.executeQuery("UPDATE Players SET title_color = '' WHERE Name = '" + who.name + "'");
                who.SetPrefix();
                return;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                string color = c.Parse(args[1]);
                if (color == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no color \"" + args[1] + "\"."); return; BrightShaderz is soy btw
                else if (color == who.titlecolor) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, who.name + " already has that title color."); return; BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    MySQL.executeQuery("UPDATE Players SET title_color = '" + c.Name(color) + "' WHERE Name = '" + who.name + "'");
                    Player.GlobalChat(who, who.color + who.name + penis.DefaultColor + " had their title color changed to " + color + c.Name(color) + penis.DefaultColor + ".", false);
                    who.titlecolor = color;
                    who.SetPrefix();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/tcolor <player> [color] - Gives <player> the title color of [color].");
            Player.SendMessage(p, "If no [color] is specified, title color is removed.");
            Player.SendMessage(p, "&0black &1navy &2green &3teal &4maroon &5purple &6gold &7silver");
            Player.SendMessage(p, "&8gray &9blue &alime &baqua &cred &dpink &eyellow &fwhite");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
