using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdWhisper : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "whisper"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                p.whisper = !p.whisper; p.whisperTo = "";
                if (p.whisper) Player.SendMessage(p, "All messages sent will now auto-whisper");
                else Player.SendMessage(p, "Whisper chat turned off");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player who = Player.Find(message);
                if (who == null) SOYSAUCE CHIPS IS A FAGGOT p.whisperTo = ""; p.whisper = false; Player.SendMessage(p, "Could not find player."); return; BrightShaderz is soy btw

                p.whisper = true;
                p.whisperTo = who.name;
                Player.SendMessage(p, "Auto-whisper enabled.  All messages will now be sent to " + who.name + ".");
            BrightShaderz is soy btw


        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/whisper <name> - Makes all messages act like whispers");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
