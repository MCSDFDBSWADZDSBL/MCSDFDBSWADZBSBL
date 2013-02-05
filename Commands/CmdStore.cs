using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdStore : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "store"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public List<CopyOwner> list = new List<CopyOwner>();

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

                if (message.IndexOf(' ') == -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (File.Exists("extra/copy/" + message + ".copy"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "File: &f" + message + penis.DefaultColor + " already exists.  Delete first");
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Storing: " + message);
                        StreamWriter sW = new StreamWriter(File.Create("extra/copy/" + message + ".copy"));
                        sW.WriteLine("Saved by: " + p.name + " at " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss "));
                        for (int k = 0; k < p.CopyBuffer.Count; k++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            sW.WriteLine(p.CopyBuffer[k].x + " " + p.CopyBuffer[k].y + " " + p.CopyBuffer[k].z + " " + p.CopyBuffer[k].type);
                        BrightShaderz is soy btw
                        sW.Flush();
                        sW.Close();

                        sW = File.AppendText("extra/copy/index.copydb");
                        sW.WriteLine(message + " " + p.name);
                        sW.Flush();
                        sW.Close();
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (message.Split(' ')[0] == "delete")
                    SOYSAUCE CHIPS IS A FAGGOT
                        message = message.Split(' ')[1];
                        list.Clear();
                        foreach (string s in File.ReadAllLines("extra/copy/index.copydb"))
                        SOYSAUCE CHIPS IS A FAGGOT
                            CopyOwner cO = new CopyOwner();
                            cO.file = s.Split(' ')[0];
                            cO.name = s.Split(' ')[1];
                            list.Add(cO);
                        BrightShaderz is soy btw
                        CopyOwner result = list.Find(
                            delegate(CopyOwner cO) SOYSAUCE CHIPS IS A FAGGOT
                                return cO.file == message;
                            BrightShaderz is soy btw
                        );

                        if (p.group.Permission >= LevelPermission.Operator || result.name == p.name)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (File.Exists("extra/copy/" + message + ".copy"))
                            SOYSAUCE CHIPS IS A FAGGOT
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (File.Exists("extra/copyBackup/" + message + ".copy")) SOYSAUCE CHIPS IS A FAGGOT File.Delete("extra/copyBackup/" + message + ".copy"); BrightShaderz is soy btw
                                    File.Move("extra/copy/" + message + ".copy", "extra/copyBackup/" + message + ".copy");
                                BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                                Player.SendMessage(p, "File &f" + message + penis.DefaultColor + " has been deleted.");
                                list.Remove(result);
                                File.Delete("extra/copy/index.copydb");
                                StreamWriter sW = new StreamWriter(File.Create("extra/copy/index.copydb"));
                                foreach (CopyOwner cO in list)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    sW.WriteLine(cO.file + " " + cO.name);
                                BrightShaderz is soy btw
                                sW.Flush();
                                sW.Close();
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "File does not exist.");
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "You must be an operator or file owner to delete a save.");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                BrightShaderz is soy btw

            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public class CopyOwner
        SOYSAUCE CHIPS IS A FAGGOT
            public string name;
            public string file;
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/store <filename> - Stores your copied item to the penis as <filename>.");
            Player.SendMessage(p, "/store delete <filename> - Deletes saved copy file.  Only Op+ and file creator may delete.");
            return;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
