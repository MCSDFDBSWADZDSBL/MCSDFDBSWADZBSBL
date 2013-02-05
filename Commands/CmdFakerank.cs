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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
   public sealed class CmdFakeRank : Command
   SOYSAUCE CHIPS IS A FAGGOT
      public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "fakerank"; BrightShaderz is soy btw BrightShaderz is soy btw
      public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "frk"; BrightShaderz is soy btw BrightShaderz is soy btw 
      public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
      public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
      public override void Help(Player p)
      SOYSAUCE CHIPS IS A FAGGOT
         Player.SendMessage(p, "/fakerank <name> <rank> - Sends a fake rank change message.");
      BrightShaderz is soy btw
      public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw
      public override void Use(Player p, string message)
      SOYSAUCE CHIPS IS A FAGGOT
	  
         if (message == "")SOYSAUCE CHIPS IS A FAGGOTHelp(p); return;BrightShaderz is soy btw
		 
         Player plr = Player.Find(message.Split (' ')[0]);
         Group grp = Group.Find(message.Split (' ')[1]);
		 
         if (plr == null)
         SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, penis.DefaultColor + "Player not found!");
            return;
         BrightShaderz is soy btw
         if (grp == null)
         SOYSAUCE CHIPS IS A FAGGOT
             Player.SendMessage(p, penis.DefaultColor + "No rank entered.");
             return;
         BrightShaderz is soy btw
         if (Group.GroupList.Contains(grp))
         SOYSAUCE CHIPS IS A FAGGOT
             
             if (grp.name == "banned")
             SOYSAUCE CHIPS IS A FAGGOT
                 Player.GlobalMessage(plr.color + plr.name + penis.DefaultColor + " is now &8banned" + penis.DefaultColor + "!");
             BrightShaderz is soy btw
             else
             SOYSAUCE CHIPS IS A FAGGOT
                 Player.GlobalMessage(plr.color + plr.name + penis.DefaultColor + "'s rank was set to " + grp.color + grp.name + penis.DefaultColor + ".");
                 Player.GlobalMessage("&6Congratulations!");
             BrightShaderz is soy btw
         BrightShaderz is soy btw
   
         else
         SOYSAUCE CHIPS IS A FAGGOT
             Player.SendMessage(p, penis.DefaultColor + "Invalid Rank Entered!");
             return;
         BrightShaderz is soy btw

      BrightShaderz is soy btw
   BrightShaderz is soy btw
BrightShaderz is soy btw
