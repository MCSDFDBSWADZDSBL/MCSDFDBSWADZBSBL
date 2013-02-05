/*
	Copyright 2010 MCSong Team - Written by Valek
 
    Licensed under the
	Educational Community License, Version 2.0 (the "License"); you may
	not use this file except in compliance with the License. You may
	obtain a copy of the License at
	
	http://www.osedu.org/licenses/ECL-2.0
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the License is distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the License for the specific language governing
	permissions and limitations under the License.
*/

using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdPossess : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "possess"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.Split(' ').Length > 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Console possession?  Nope.avi."); return; BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                string skin = (message.Split(' ').Length == 2) ? message.Split(' ')[1] : "";
                message = message.Split(' ')[0];
                if (message == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.possess == "")
                    SOYSAUCE CHIPS IS A FAGGOT
                        Help(p);
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player who = Player.Find(p.possess);
                        if (who == null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.possess = "";
                            Player.SendMessage(p, "Possession disabled.");
                            return;
                        BrightShaderz is soy btw
                        who.following = "";
                        who.canBuild = true;
                        p.possess = "";
                        if (!who.MarkPossessed())
                        SOYSAUCE CHIPS IS A FAGGOT
                            return;
                        BrightShaderz is soy btw
                        p.invincible = false;
                        Command.all.Find("hide").Use(p, "");
                        Player.SendMessage(p, "Stopped possessing " + who.color + who.name + penis.DefaultColor + ".");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else if (message == p.possess)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player who = Player.Find(p.possess);
                    if (who == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.possess = "";
                        Player.SendMessage(p, "Possession disabled.");
                        return;
                    BrightShaderz is soy btw
                    if (who == p)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Cannot possess yourself!");
                        return;
                    BrightShaderz is soy btw
                    who.following = "";
                    who.canBuild = true;
                    p.possess = "";
                    if (!who.MarkPossessed())
                    SOYSAUCE CHIPS IS A FAGGOT
                        return;
                    BrightShaderz is soy btw
                    p.invincible = false;
                    Command.all.Find("hide").Use(p, "");
                    Player.SendMessage(p, "Stopped possessing " + who.color + who.name + penis.DefaultColor + ".");
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player who = Player.Find(message);
                    if (who == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Could not find player.");
                        return;
                    BrightShaderz is soy btw
                    if (who.group.Permission >= p.group.Permission)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Cannot possess someone of equal or greater rank.");
                        return;
                    BrightShaderz is soy btw
                    if (who.possess != "")
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "That player is currently possessing someone!");
                        return;
                    BrightShaderz is soy btw
                    if (who.following != "")
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "That player is either following someone or already possessed.");
                        return;
                    BrightShaderz is soy btw
                    if (p.possess != "")
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player oldwho = Player.Find(p.possess);
                        if (oldwho != null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            oldwho.following = "";
                            oldwho.canBuild = true;
                            if (!oldwho.MarkPossessed())
                            SOYSAUCE CHIPS IS A FAGGOT
                                return;
                            BrightShaderz is soy btw
                            //p.SendSpawn(oldwho.id, oldwho.color + oldwho.name, oldwho.pos[0], oldwho.pos[1], oldwho.pos[2], oldwho.rot[0], oldwho.rot[1]);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    Command.all.Find("tp").Use(p, who.name);
                    if (!p.hidden)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Command.all.Find("hide").Use(p, "");
                    BrightShaderz is soy btw
                    p.possess = who.name;
                    who.following = p.name;
                    if (!p.invincible)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.invincible = true;
                    BrightShaderz is soy btw
                    bool result = (skin == "#") ? who.MarkPossessed() : who.MarkPossessed(p.name);
                    if (!result)
                    SOYSAUCE CHIPS IS A FAGGOT
                        return;
                    BrightShaderz is soy btw
                    p.SendDie(who.id);
                    who.canBuild = false;
                    Player.SendMessage(p, "Successfully possessed " + who.color + who.name + penis.DefaultColor + ".");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                Player.SendMessage(p, "There was an error.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/possess <player> [skin as #] - DEMONIC POSSESSION HUE HUE");
            Player.SendMessage(p, "Using # after player name makes possessed keep their custom skin during possession.");
            Player.SendMessage(p, "Not using it makes them lose their skin, and makes their name show as \"Player (YourName)\".");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
