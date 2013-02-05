using System;
using System.Collections.Generic;
using System.Data;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdTimer : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "timer"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p.cmdTimer == true) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Can only have one timer at a time. Use /abort to cancel your previous timer."); return; BrightShaderz is soy btw

            System.Timers.Timer messageTimer = new System.Timers.Timer(5000);
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            int TotalTime = 0;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                TotalTime = int.Parse(message.Split(' ')[0]);
                message = message.Substring(message.IndexOf(' ') + 1);
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                TotalTime = 60;
            BrightShaderz is soy btw

            if (TotalTime > 300) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot have more than 5 minutes in a timer"); return; BrightShaderz is soy btw

            Player.GlobalChatLevel(p, penis.DefaultColor + "Timer lasting for " + TotalTime + " seconds has started.", false);
            TotalTime = (int)(TotalTime / 5);

            Player.GlobalChatLevel(p, penis.DefaultColor + message, false);

            p.cmdTimer = true;
            messageTimer.Elapsed += delegate
            SOYSAUCE CHIPS IS A FAGGOT
                TotalTime--;
                if (TotalTime < 1 || p.cmdTimer == false)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Timer ended.");
                    messageTimer.Stop();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalChatLevel(p, penis.DefaultColor + message, false);
                    Player.GlobalChatLevel(p, "Timer has " + (TotalTime * 5) + " seconds remaining.", false);
                BrightShaderz is soy btw
            BrightShaderz is soy btw;

            messageTimer.Start();
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/timer [time] [message] - Starts a timer which repeats [message] every 5 seconds.");
            Player.SendMessage(p, "Repeats constantly until [time] has passed");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
