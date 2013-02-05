using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdBotSet : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "botset"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (message.Split(' ').Length == 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    PlayerBot pB = PlayerBot.Find(message);
                    try SOYSAUCE CHIPS IS A FAGGOT pB.Waypoints.Clear(); BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    pB.kill = false;
                    pB.hunt = false;
                    pB.AIName = "";
                    Player.SendMessage(p, pB.color + pB.name + penis.DefaultColor + "'s AI was turned off.");
                    return;
                BrightShaderz is soy btw
                else if (message.Split(' ').Length != 2)
                SOYSAUCE CHIPS IS A FAGGOT
                    Help(p); return;
                BrightShaderz is soy btw

                PlayerBot Pb = PlayerBot.Find(message.Split(' ')[0]);
                if (Pb == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find specified Bot"); return; BrightShaderz is soy btw
                string foundPath = message.Split(' ')[1].ToLower();

                if (foundPath == "hunt")
                SOYSAUCE CHIPS IS A FAGGOT
                    Pb.hunt = !Pb.hunt;
                    try SOYSAUCE CHIPS IS A FAGGOT Pb.Waypoints.Clear(); BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    Pb.AIName = "";
                    if (p != null) Player.GlobalChatLevel(p, Pb.color + Pb.name + penis.DefaultColor + "'s hunt instinct: " + Pb.hunt, false);
                    return;
                BrightShaderz is soy btw
                else if (foundPath == "kill")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.group.Permission < LevelPermission.Operator) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Only an OP may toggle killer instinct."); return; BrightShaderz is soy btw
                    Pb.kill = !Pb.kill;
                    if (p != null) Player.GlobalChatLevel(p, Pb.color + Pb.name + penis.DefaultColor + "'s kill instinct: " + Pb.kill, false);
                    return;
                BrightShaderz is soy btw

                if (!File.Exists("bots/" + foundPath)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find specified AI."); return; BrightShaderz is soy btw

                string[] foundWay = File.ReadAllLines("bots/" + foundPath);

                if (foundWay[0] != "#Version 2") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid file version. Remake"); return; BrightShaderz is soy btw

                PlayerBot.Pos newPos = new PlayerBot.Pos();
                try SOYSAUCE CHIPS IS A FAGGOT Pb.Waypoints.Clear(); Pb.currentPoint = 0; Pb.countdown = 0; Pb.movementSpeed = 12; BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (string s in foundWay)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (s != "" && s[0] != '#')
                        SOYSAUCE CHIPS IS A FAGGOT
                            bool skip = false;
                            newPos.type = s.Split(' ')[0];
                            switch (s.Split(' ')[0].ToLower())
                            SOYSAUCE CHIPS IS A FAGGOT
                                case "walk":
                                case "teleport":
                                    newPos.x = Convert.ToUInt16(s.Split(' ')[1]);
                                    newPos.y = Convert.ToUInt16(s.Split(' ')[2]);
                                    newPos.z = Convert.ToUInt16(s.Split(' ')[3]);
                                    newPos.rotx = Convert.ToByte(s.Split(' ')[4]);
                                    newPos.roty = Convert.ToByte(s.Split(' ')[5]);
                                    break;
                                case "wait":
                                case "speed":
                                    newPos.seconds = Convert.ToInt16(s.Split(' ')[1]); break;
                                case "nod":
                                case "spin":
                                    newPos.seconds = Convert.ToInt16(s.Split(' ')[1]);
                                    newPos.rotspeed = Convert.ToInt16(s.Split(' ')[2]);
                                    break;
                                case "linkscript":
                                    newPos.newscript = s.Split(' ')[1]; break;
                                case "reset":
                                case "jump":
                                case "remove": break;
                                default: skip = true; break;
                            BrightShaderz is soy btw
                            if (!skip) Pb.Waypoints.Add(newPos);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "AI file corrupt."); return; BrightShaderz is soy btw

                Pb.AIName = foundPath;
                if (p != null) Player.GlobalChatLevel(p, Pb.color + Pb.name + penis.DefaultColor + "'s AI is now set to " + foundPath, false);
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Error"); return; BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/botset <bot> <AI script> - Makes <bot> do <AI script>");
            Player.SendMessage(p, "Special AI scripts: Kill and Hunt");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
