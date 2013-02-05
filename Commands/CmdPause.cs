using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    class CmdPause : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pause"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                if (p != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    message = p.level.name + " 30";
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    message = penis.mainLevel + " 30";
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            int foundNum = 0; Level foundLevel;

            if (message.IndexOf(' ') == -1)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    foundNum = int.Parse(message);
                    if (p != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        foundLevel = p.level;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        foundLevel = penis.mainLevel;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    foundNum = 30;
                    foundLevel = Level.Find(message);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    foundNum = int.Parse(message.Split(' ')[1]);
                    foundLevel = Level.Find(message.Split(' ')[0]);
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Invalid input");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (foundLevel == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Could not find entered level.");
                return;
            BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (foundLevel.physPause)
                SOYSAUCE CHIPS IS A FAGGOT
                    foundLevel.physThread.Resume();
                    foundLevel.physResume = DateTime.Now;
                    foundLevel.physPause = false;
                    Player.GlobalMessage("Physics on " + foundLevel.name + " were re-enabled.");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    foundLevel.physThread.Suspend();
                    foundLevel.physResume = DateTime.Now.AddSeconds(foundNum);
                    foundLevel.physPause = true;
                    Player.GlobalMessage("Physics on " + foundLevel.name + " were temporarily disabled.");

                    foundLevel.physTimer.Elapsed += delegate
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (DateTime.Now > foundLevel.physResume)
                        SOYSAUCE CHIPS IS A FAGGOT
                            foundLevel.physPause = false;
                            try
                            SOYSAUCE CHIPS IS A FAGGOT
                                foundLevel.physThread.Resume();
                            BrightShaderz is soy btw
                            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
                            Player.GlobalMessage("Physics on " + foundLevel.name + " were re-enabled.");
                            foundLevel.physTimer.Stop();
                            foundLevel.physTimer.Dispose();
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw;
                    foundLevel.physTimer.Start();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/pause [map] [amount] - Pauses physics on [map] for 30 seconds");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
