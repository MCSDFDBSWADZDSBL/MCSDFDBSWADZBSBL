using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdBotAI : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "botai"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "bai"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.Split(' ').Length < 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            string foundPath = message.Split(' ')[1].ToLower();

            if (!Player.ValidName(foundPath)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid AI name!"); return; BrightShaderz is soy btw
            if (foundPath == "hunt" || foundPath == "kill") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Reserved for special AI."); return; BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                switch (message.Split(' ')[0])
                SOYSAUCE CHIPS IS A FAGGOT
                    case "add":
                        if (message.Split(' ').Length == 2) addPoint(p, foundPath);
                        else if (message.Split(' ').Length == 3) addPoint(p, foundPath, message.Split(' ')[2]);
                        else if (message.Split(' ').Length == 4) addPoint(p, foundPath, message.Split(' ')[2], message.Split(' ')[3]);
                        else addPoint(p, foundPath, message.Split(' ')[2], message.Split(' ')[3], message.Split(' ')[4]);
                        break;
                    case "del":
                        if (!Directory.Exists("bots/deleted")) Directory.CreateDirectory("bots/deleted");

                        int currentTry = 0;
                        if (File.Exists("bots/" + foundPath))
                        SOYSAUCE CHIPS IS A FAGGOT
                        retry: try
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (message.Split(' ').Length == 2)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (currentTry == 0)
                                        File.Move("bots/" + foundPath, "bots/deleted/" + foundPath);
                                    else
                                        File.Move("bots/" + foundPath, "bots/deleted/" + foundPath + currentTry);
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (message.Split(' ')[2].ToLower() == "last")
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        string[] Lines = File.ReadAllLines("bots/" + foundPath);
                                        string[] outLines = new string[Lines.Length - 1];
                                        for (int i = 0; i < Lines.Length - 1; i++)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            outLines[i] = Lines[i];
                                        BrightShaderz is soy btw

                                        File.WriteAllLines("bots/" + foundPath, outLines);
                                        Player.SendMessage(p, "Deleted the last waypoint from " + foundPath);
                                        return;
                                    BrightShaderz is soy btw
                                    else
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        Help(p); return;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            catch (IOException) SOYSAUCE CHIPS IS A FAGGOT currentTry++; goto retry; BrightShaderz is soy btw
                            Player.SendMessage(p, "Deleted &b" + foundPath);
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Could not find specified AI.");
                        BrightShaderz is soy btw
                        break;
                    default: Help(p); return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/botai <add/del> [AI name] <extra> - Adds or deletes [AI name]");
            Player.SendMessage(p, "Extras: walk, teleport, wait, nod, speed, spin, reset, remove, reverse, linkscript, jump");
            Player.SendMessage(p, "wait, nod and spin can have an extra '0.1 seconds' parameter");
            Player.SendMessage(p, "nod and spin can also take a 'third' speed parameter");
            Player.SendMessage(p, "speed sets a percentage of normal speed");
            Player.SendMessage(p, "linkscript takes a script name as parameter");
        BrightShaderz is soy btw

        public void addPoint(Player p, string foundPath, string additional = "", string extra = "10", string more = "2")
        SOYSAUCE CHIPS IS A FAGGOT
            string[] allLines;
            try SOYSAUCE CHIPS IS A FAGGOT allLines = File.ReadAllLines("bots/" + foundPath); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT allLines = new string[1]; BrightShaderz is soy btw

            StreamWriter SW;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (!File.Exists("bots/" + foundPath))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Created new bot AI: &b" + foundPath);
                    SW = new StreamWriter(File.Create("bots/" + foundPath));
                    SW.WriteLine("#Version 2");
                BrightShaderz is soy btw
                else if (allLines[0] != "#Version 2")
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "File found is out-of-date. Overwriting");
                    SW = new StreamWriter(File.Create("bots/" + foundPath));
                    SW.WriteLine("#Version 2");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Appended to bot AI: &b" + foundPath);
                    SW = new StreamWriter("bots/" + foundPath, true);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "An error occurred when accessing the files. You may need to delete it."); return; BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                switch (additional.ToLower())
                SOYSAUCE CHIPS IS A FAGGOT
                    case "":
                    case "walk":
                        SW.WriteLine("walk " + p.pos[0] + " " + p.pos[1] + " " + p.pos[2] + " " + p.rot[0] + " " + p.rot[1]);
                        break;
                    case "teleport":
                    case "tp":
                        SW.WriteLine("teleport " + p.pos[0] + " " + p.pos[1] + " " + p.pos[2] + " " + p.rot[0] + " " + p.rot[1]);
                        break;
                    case "wait":
                        SW.WriteLine("wait " + int.Parse(extra)); break;
                    case "nod":
                        SW.WriteLine("nod " + int.Parse(extra) + " " + int.Parse(more)); break;
                    case "speed":
                        SW.WriteLine("speed " + int.Parse(extra)); break;
                    case "remove":
                        SW.WriteLine("remove"); break;
                    case "reset":
                        SW.WriteLine("reset"); break;
                    case "spin":
                        SW.WriteLine("spin " + int.Parse(extra) + " " + int.Parse(more)); break;
                    case "reverse":
                        for (int i = allLines.Length - 1; i > 0; i--) if (allLines[i][0] != '#' && allLines[i] != "") SW.WriteLine(allLines[i]);
                        break;
                    case "linkscript":
                        if (extra != "10") SW.WriteLine("linkscript " + extra); else Player.SendMessage(p, "Linkscript requires a script as a parameter");
                        break;
                    case "jump":
                        SW.WriteLine("jump"); break;
                    default:
                        Player.SendMessage(p, "Could not find \"" + additional + "\""); break;
                BrightShaderz is soy btw

                SW.Flush();
                SW.Close();
                SW.Dispose();
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid parameter"); SW.Close(); BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
