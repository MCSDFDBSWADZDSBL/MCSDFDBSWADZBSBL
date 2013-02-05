using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdRetrieve : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "retrieve"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public List<CopyOwner> list = new List<CopyOwner>();

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (!File.Exists("extra/copy/index.copydb")) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No copy index found! Save something before trying to retrieve it!"); return; BrightShaderz is soy btw
                if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                if (message.Split(' ')[0] == "info")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (message.IndexOf(' ') != -1)
                    SOYSAUCE CHIPS IS A FAGGOT
                        message = message.Split(' ')[1];
                        if (File.Exists("extra/copy/" + message + ".copy"))
                        SOYSAUCE CHIPS IS A FAGGOT
                            StreamReader sR = new StreamReader(File.OpenRead("extra/copy/" + message + ".copy"));
                            string infoline = sR.ReadLine();
                            sR.Close();
                            sR.Dispose();
                            Player.SendMessage(p, infoline);
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Help(p);
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (message.Split(' ')[0] == "find")
                SOYSAUCE CHIPS IS A FAGGOT
                    message = message.Replace("find", "");
                    string storedcopies = ""; int maxCopies = 0; int findnum = 0; int currentnum = 0;
                    bool isint = int.TryParse(message, out findnum);
                    if (message == "") SOYSAUCE CHIPS IS A FAGGOT goto retrieve; BrightShaderz is soy btw
                    if (!isint)
                    SOYSAUCE CHIPS IS A FAGGOT
                        message = message.Trim();
                        list.Clear();
                        foreach (string s in File.ReadAllLines("extra/copy/index.copydb"))
                        SOYSAUCE CHIPS IS A FAGGOT
                            CopyOwner cO = new CopyOwner();
                            cO.file = s.Split(' ')[0];
                            cO.name = s.Split(' ')[1];
                            list.Add(cO);
                        BrightShaderz is soy btw
                        List<CopyOwner> results = new List<CopyOwner>();
                        for (int i = 0; i < list.Count; i++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (list[i].name.ToLower() == message.ToLower())
                            SOYSAUCE CHIPS IS A FAGGOT
                                storedcopies += ", " + list[i].file;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        if (storedcopies == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No saves found for player: " + message); BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Saved copy files: ");
                            Player.SendMessage(p, "&f " + storedcopies.Remove(0, 2));
                        BrightShaderz is soy btw
                        return;
                    BrightShaderz is soy btw

                    // SEARCH BASED ON NAME STUFF ABOVE HERE
                    if (isint)
                    SOYSAUCE CHIPS IS A FAGGOT
                        maxCopies = findnum * 50; currentnum = maxCopies - 50;
                    BrightShaderz is soy btw
        retrieve:   DirectoryInfo di = new DirectoryInfo("extra/copy/");
                    FileInfo[] fi = di.GetFiles("*.copy");

                    if (maxCopies == 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        foreach (FileInfo file in fi)
                        SOYSAUCE CHIPS IS A FAGGOT
                            storedcopies += ", " + file.Name.Replace(".copy", "");
                        BrightShaderz is soy btw
                        if (storedcopies != "")
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Saved copy files: ");
                            Player.SendMessage(p, "&f " + storedcopies.Remove(0, 2));
                            if (fi.Length > 50) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "For a more structured list, use /retrieve find <1/2/3/...>"); BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There are no saved copies."); BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (maxCopies > fi.Length) maxCopies = fi.Length;
                        if (currentnum > fi.Length) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No saved copies beyond number " + fi.Length); return; BrightShaderz is soy btw

                        Player.SendMessage(p, "Saved copies (" + currentnum + " to " + maxCopies + "):");
                        for (int i = currentnum; i < maxCopies; i++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            storedcopies += ", " + fi[i].Name.Replace(".copy", "");
                        BrightShaderz is soy btw
                        if (storedcopies != "")
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "&f" + storedcopies.Remove(0, 2));
                        BrightShaderz is soy btw
                        else Player.SendMessage(p, "There are no saved copies.");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (message.IndexOf(' ') == -1)
                    SOYSAUCE CHIPS IS A FAGGOT
                        message = message.Split(' ')[0];
                        if (File.Exists("extra/copy/" + message + ".copy"))
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.CopyBuffer.Clear();
                            bool readFirst = false;
                            foreach (string s in File.ReadAllLines("extra/copy/" + message + ".copy"))
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (readFirst)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.CopyPos cP;
                                    cP.x = Convert.ToUInt16(s.Split(' ')[0]);
                                    cP.y = Convert.ToUInt16(s.Split(' ')[1]);
                                    cP.z = Convert.ToUInt16(s.Split(' ')[2]);
                                    cP.type = Convert.ToByte(s.Split(' ')[3]);
                                    p.CopyBuffer.Add(cP);
                                BrightShaderz is soy btw
                                else readFirst = true;
                            BrightShaderz is soy btw
                            Player.SendMessage(p, "&f" + message + penis.DefaultColor + " has been placed copybuffer.  Paste away!");
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Could not find copy specified");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else 
                    SOYSAUCE CHIPS IS A FAGGOT 
                        Help(p); 
                        return; 
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "An error occured"); penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw

        public class CopyOwner
        SOYSAUCE CHIPS IS A FAGGOT
            public string name;
            public string file;
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/retrieve <filename> - Retrieves saved copy file to your copy buffer. /paste to place it!");
            Player.SendMessage(p, "/retrieve info <filename> - Gets information about the saved file.");
            Player.SendMessage(p, "/retrieve find - Prints a list of all saved copies.");
            Player.SendMessage(p, "/retrieve find <1/2/3/..> - Shows a compact list.");
            Player.SendMessage(p, "/retrieve find <name> - Prints a list of all saved copies made by player <name>.");
            return;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw

    
        