using System;
using System.Data;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdClearBlockChanges : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "clearblockchanges"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "cbc"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!penis.useMySQL) SOYSAUCE CHIPS IS A FAGGOT p.SendMessage("MySQL has not been configured! Please configure MySQL to use Block Logging!"); return; BrightShaderz is soy btw
            Level l = Level.Find(message);
            if (l == null && message != "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find level."); return; BrightShaderz is soy btw
            if (l == null) l = p.level;

            MySQL.executeQuery("TRUNCATE TABLE `Block" + l.name + "`");
            Player.SendMessage(p, "Cleared &cALL" + penis.DefaultColor + " recorded block changes in: &d" + l.name);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/clearblockchanges <map> - Clears the block changes stored in /about for <map>.");
            Player.SendMessage(p, "&cUSE WITH CAUTION");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
