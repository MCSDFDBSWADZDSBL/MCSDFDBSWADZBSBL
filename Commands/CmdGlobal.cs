/*
	Copyright 2011 MCForge
	
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.opensource.org/licenses/ecl2.php
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdGlobal : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "global"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "gc"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdGlobal() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        //bla
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p != null && (p.isGCMod || p.isMod || p.isDev) && !p.verifiedName) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You can't use GC, because the penis hasn't verify-names on"); return; BrightShaderz is soy btw

            if (String.IsNullOrEmpty(message)) SOYSAUCE CHIPS IS A FAGGOT 
                p.InGlobalChat = !p.InGlobalChat;
                Player.SendMessage(p, p.InGlobalChat ? "%aGlobal Chat enabled" : "%cGlobal Chat Disabled");
                return;
             BrightShaderz is soy btw

            if (!penis.UseGlobalChat) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Global Chat is disabled."); return; BrightShaderz is soy btw
            if (p != null && p.muted) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You are muted."); return; BrightShaderz is soy btw
            if (p != null && p.muteGlobal) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You cannot use Global Chat while you have it muted."); return; BrightShaderz is soy btw
            if (p != null && penis.chatmod && !p.voice) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You cannot use Global Chat while in Chat Moderation!"); return; BrightShaderz is soy btw
            if (p != null && !penis.gcaccepted.Contains(p.name.ToLower())) SOYSAUCE CHIPS IS A FAGGOT RulesMethod(p); return; BrightShaderz is soy btw
            if (p != null)
            SOYSAUCE CHIPS IS A FAGGOT
                string reason;
                if (penis.gcnamebans.TryGetValue(p.name.ToLower(), out reason)) SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You are %cBANNED" + penis.DefaultColor + " from" + penis.GlobalChatColor + " Global Chat" + penis.DefaultColor + " by " + reason);
                    Player.SendMessage(p, "You can apply a 'Ban Appeal' at %9www.mcforge.net");
                    return;
                BrightShaderz is soy btw
                if (penis.gcipbans.TryGetValue(p.exIP, out reason)) SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Your IP is %cBANNED" + penis.DefaultColor + " from" + penis.GlobalChatColor + " Global Chat" + penis.DefaultColor + " by " + reason);
                    Player.SendMessage(p, "You can apply a 'Ban Appeal' at %9www.mcforge.net");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw            //penis.GlobalChat.Say((p != null ? p.name + ": " : "Console: ") + message, p);
            penis.GlobalChat.Say(p == null ? "Console: " + message : p.name + ": " + message, p);
            Player.GlobalMessage(penis.GlobalChatColor + "<[Global] " + (p != null ? p.name + ": " : "Console: ") + "&f" + (penis.profanityFilter ? ProfanityFilter.Parse(message) : message), true);

        BrightShaderz is soy btw
        public void RulesMethod(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "&cBy using the Global Chat you agree to the following rules:");
            Player.SendMessage(p, "1. No Spamming");
            Player.SendMessage(p, "2. No Advertising (Trying to get people to your penis)");
            Player.SendMessage(p, "3. No links");
            Player.SendMessage(p, "4. No Excessive Cursing (You are allowed to curse, but not pointed at anybody)");
            Player.SendMessage(p, "5. No use of $ Variables.");
            Player.SendMessage(p, "6. English only. No exceptions.");
            Player.SendMessage(p, "7. Be respectful");
            Player.SendMessage(p, "8. Do not ask for ranks");
            Player.SendMessage(p, "9. Do not ask for a penis name");
            Player.SendMessage(p, "10. Use common sense.");
            Player.SendMessage(p, "11. Don't say any penis name");
            Player.SendMessage(p, "&3Type /gcaccept to accept these rules");
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/global [message] - Send a message to Global Chat.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
