using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdDeleteLvl : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "deletelvl"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            Level foundLevel = Level.Find(message);
            if (foundLevel != null) foundLevel.Unload();

            if (foundLevel == penis.mainLevel) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot delete the main level."); return; BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (!Directory.Exists("levels/deleted")) Directory.CreateDirectory("levels/deleted");

                if (File.Exists("levels/" + message + ".lvl"))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (File.Exists("levels/deleted/" + message + ".lvl"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        int currentNum = 0;
                        while (File.Exists("levels/deleted/" + message + currentNum + ".lvl")) currentNum++;

                        File.Move("levels/" + message + ".lvl", "levels/deleted/" + message + currentNum + ".lvl");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        File.Move("levels/" + message + ".lvl", "levels/deleted/" + message + ".lvl");
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "Created backup.");

                    try SOYSAUCE CHIPS IS A FAGGOT File.Delete("levels/level properties/" + message + ".properties"); BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    try SOYSAUCE CHIPS IS A FAGGOT File.Delete("levels/level properties/" + message); BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                    MySQL.executeQuery("DROP TABLE `Block" + message + "`, `Portals" + message + "`, `Messages" + message + "`, `Zone" + message + "`");

                    Player.GlobalMessage("Level " + message + " was deleted.");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Could not find specified level.");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Error when deleting."); penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/deletelvl [map] - Completely deletes [map] (portals, MBs, everything");
            Player.SendMessage(p, "A backup of the map will be placed in the levels/deleted folder");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
