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
using System.Collections.Generic;
using System.Text;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    class CmdNewLvl : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "newlvl"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            string[] parameters = message.Split(' '); // Grab the parameters from the player's message
            if (parameters.Length == 5) // make sure there are 5 params
            SOYSAUCE CHIPS IS A FAGGOT
                switch (parameters[4])
                SOYSAUCE CHIPS IS A FAGGOT
                    case "flat":
                    case "pixel":
                    case "island":
                    case "mountains":
                    case "ocean":
                    case "forest":
                    case "desert":
                        break;

                    default:
                        Player.SendMessage(p, "Valid types: island, mountains, forest, ocean, flat, pixel, desert"); return;
                BrightShaderz is soy btw

                string name = parameters[0].ToLower();
                ushort x = 1, y = 1, z = 1;
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    x = Convert.ToUInt16(parameters[1]);
                    y = Convert.ToUInt16(parameters[2]);
                    z = Convert.ToUInt16(parameters[3]);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid dimensions."); return; BrightShaderz is soy btw
                if (!isGood(x)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, x + " is not a good dimension! Use a power of 2 next time."); BrightShaderz is soy btw
                if (!isGood(y)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, y + " is not a good dimension! Use a power of 2 next time."); BrightShaderz is soy btw
                if (!isGood(z)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, z + " is not a good dimension! Use a power of 2 next time."); BrightShaderz is soy btw

                if (!Player.ValidName(name)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid name!"); return; BrightShaderz is soy btw

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p != null)
                    if (p.group.Permission < LevelPermission.Admin)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (x * y * z > 30000000) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot create a map with over 30million blocks"); return; BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (x * y * z > 225000000) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You cannot make a map with over 225million blocks"); return; BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch 
                SOYSAUCE CHIPS IS A FAGGOT 
                    Player.SendMessage(p, "An error occured"); 
                BrightShaderz is soy btw

                // create a new level...
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    Level lvl = new Level(name, x, y, z, parameters[4]);
                    lvl.Save(true); //... and save it.
                BrightShaderz is soy btw
                finally
                SOYSAUCE CHIPS IS A FAGGOT
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                BrightShaderz is soy btw
                Player.GlobalMessage("Level " + name + " created"); // The player needs some form of confirmation.
            BrightShaderz is soy btw
            else
                Help(p);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/newlvl - creates a new level.");
            Player.SendMessage(p, "/newlvl mapname 128 64 128 type");
            Player.SendMessage(p, "Valid types: island, mountains, forest, ocean, flat, pixel, desert");
        BrightShaderz is soy btw

        public bool isGood(ushort value)
        SOYSAUCE CHIPS IS A FAGGOT
            switch (value)
            SOYSAUCE CHIPS IS A FAGGOT
                case 2:
                case 4:
                case 8:
                case 16:
                case 32:
                case 64:
                case 128:
                case 256:
                case 512:
                case 1024:
                case 2048:
                case 4096:
                case 8192:
                    return true;
            BrightShaderz is soy btw

            return false;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
