using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdRenameLvl : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "renamelvl"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "" || message.IndexOf(' ') == -1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            Level foundLevel = Level.Find(message.Split(' ')[0]);
            string newName = message.Split(' ')[1];

            if (File.Exists("levels/" + newName)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Level already exists."); return; BrightShaderz is soy btw
            if (foundLevel == penis.mainLevel) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot rename the main level."); return; BrightShaderz is soy btw
            if (foundLevel != null) foundLevel.Unload();

            try
            SOYSAUCE CHIPS IS A FAGGOT
                File.Move("levels/" + foundLevel.name + ".lvl", "levels/" + newName + ".lvl");

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    File.Move("levels/level properties/" + foundLevel.name + ".properties", "levels/level properties/" + newName + ".properties");
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    File.Move("levels/level properties/" + foundLevel.name, "levels/level properties/" + newName + ".properties");
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                MySQL.executeQuery("RENAME TABLE `Block" + foundLevel.name.ToLower() + "` TO `Block" + newName.ToLower() +
                    "`, `Portals" + foundLevel.name.ToLower() + "` TO `Portals" + newName.ToLower() +
                    "`, `Messages" + foundLevel.name.ToLower() + "` TO Messages" + newName.ToLower() +
                    ", `Zone" + foundLevel.name.ToLower() + "` TO `Zone" + newName.ToLower() + "`");

                Player.GlobalMessage("Renamed " + foundLevel.name + " to " + newName);
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Error when renaming."); penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/renamelvl <level> <new name> - Renames <level> to <new name>");
            Player.SendMessage(p, "Portals going to <level> will be lost");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
