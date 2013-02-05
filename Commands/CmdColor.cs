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
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdColor : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "color"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!penis.useMySQL) SOYSAUCE CHIPS IS A FAGGOT p.SendMessage("MySQL has not been configured! Please configure MySQL to use Colors!"); return; BrightShaderz is soy btw
            if (message == "" || message.Split(' ').Length > 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            int pos = message.IndexOf(' ');
            if (pos != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Player who = Player.Find(message.Substring(0, pos));
                if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no player \"" + message.Substring(0, pos) + "\"!"); return; BrightShaderz is soy btw
                if (message.Substring(pos + 1) == "del")
                SOYSAUCE CHIPS IS A FAGGOT
                    MySQL.executeQuery("UPDATE Players SET color = '' WHERE name = '" + who.name + "'");
                    Player.GlobalChat(who, who.color + "*" + Name(who.name) + " color reverted to " + who.group.color + "their group's default" + penis.DefaultColor + ".", false);
                    who.color = who.group.color;

                    Player.GlobalDie(who, false);
                    Player.GlobalSpawn(who, who.pos[0], who.pos[1], who.pos[2], who.rot[0], who.rot[1], false);
                    who.SetPrefix();
                    return;
                BrightShaderz is soy btw
                string color = c.Parse(message.Substring(pos + 1));
                if (color == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no color \"" + message + "\"."); BrightShaderz is soy btw
                else if (color == who.color) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, who.name + " already has that color."); BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    //Player.GlobalChat(who, p.color + "*" + p.name + "&e changed " + who.color + Name(who.name) +
                    //                  " color to " + color +
                    //                  c.Name(color) + "&e.", false);
                    MySQL.executeQuery("UPDATE Players SET color = '" + c.Name(color) + "' WHERE name = '" + who.name + "'");

                    Player.GlobalChat(who, who.color + "*" + Name(who.name) + " color changed to " + color + c.Name(color) + penis.DefaultColor + ".", false);
                    who.color = color;

                    Player.GlobalDie(who, false);
                    Player.GlobalSpawn(who, who.pos[0], who.pos[1], who.pos[2], who.rot[0], who.rot[1], false);
                    who.SetPrefix();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (message == "del")
                SOYSAUCE CHIPS IS A FAGGOT
                    MySQL.executeQuery("UPDATE Players SET color = '' WHERE name = '" + p.name + "'");

                    Player.GlobalChat(p, p.color + "*" + Name(p.name) + " color reverted to " + p.group.color + "their group's default" + penis.DefaultColor + ".", false);
                    p.color = p.group.color;

                    Player.GlobalDie(p, false);
                    Player.GlobalSpawn(p, p.pos[0], p.pos[1], p.pos[2], p.rot[0], p.rot[1], false);
                    p.SetPrefix();
                    return;
                BrightShaderz is soy btw
                string color = c.Parse(message);
                if (color == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no color \"" + message + "\"."); BrightShaderz is soy btw
                else if (color == p.color) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You already have that color."); BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    MySQL.executeQuery("UPDATE Players SET color = '" + c.Name(color) + "' WHERE name = '" + p.name + "'");

                    Player.GlobalChat(p, p.color + "*" + Name(p.name) + " color changed to " + color + c.Name(color) + penis.DefaultColor + ".", false);
                    p.color = color;

                    Player.GlobalDie(p, false);
                    Player.GlobalSpawn(p, p.pos[0], p.pos[1], p.pos[2], p.rot[0], p.rot[1], false);
                    p.SetPrefix();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/color [player] <color/del>- Changes the nick color.  Using 'del' removes color.");
            Player.SendMessage(p, "&0black &1navy &2green &3teal &4maroon &5purple &6gold &7silver");
            Player.SendMessage(p, "&8gray &9blue &alime &baqua &cred &dpink &eyellow &fwhite");
        BrightShaderz is soy btw
        static string Name(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            string ch = name[name.Length - 1].ToString().ToLower();
            if (ch == "s" || ch == "x") SOYSAUCE CHIPS IS A FAGGOT return name + penis.DefaultColor + "'"; BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT return name + penis.DefaultColor + "'s"; BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
