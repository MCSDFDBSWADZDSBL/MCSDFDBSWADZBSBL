using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdImport : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "import"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            string fileName;
            fileName = "extra/import/" + message + ".dat";

            if (!Directory.Exists("extra/import")) Directory.CreateDirectory("extra/import");
            if (!File.Exists(fileName))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Could not find .dat file");
                return;
            BrightShaderz is soy btw
            
            FileStream fs = File.OpenRead(fileName);
            if (ConvertDat.Load(fs, message) != null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Converted map!");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "The map conversion failed.");
                return;
            BrightShaderz is soy btw
            fs.Close();

            Command.all.Find("load").Use(p, message);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/import [.dat file] - Imports the .dat file given");
            Player.SendMessage(p, ".dat files should be located in the /extra/import/ folder");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
