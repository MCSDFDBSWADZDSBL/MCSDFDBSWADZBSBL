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
using System.Threading;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdWarp : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "warp"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "This command can only be used in-game"); return; BrightShaderz is soy btw
            string[] command = message.ToLower().Split(' ');
            string par0 = String.Empty;
            string par1 = String.Empty;
            string par2 = String.Empty;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                par0 = command[0];
                par1 = command[1];
                par2 = command[2];
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            if (par0 == "list" || par0 == "view" || par0 == "l" || par0 == "v")
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Warps:");
                foreach (Warp.Wrp wr in Warp.Warps)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Level.Find(wr.lvlname) != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, wr.name + " : " + wr.lvlname);
                        Thread.Sleep(300); // I feel this is needed so that if there are a lot of warps, they do not immediatly go off the screen!
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw

            if (par0 == "create" || par0 == "add" || par0 == "c" || par0 == "a")
            SOYSAUCE CHIPS IS A FAGGOT
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 1))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (par1 == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You didn't specify a name for the warp!"); return; BrightShaderz is soy btw
                    if (Warp.WarpExists(par1)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Warp has already been created!!"); return; BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (par2 == null) SOYSAUCE CHIPS IS A FAGGOT Warp.AddWarp(par1, p); BrightShaderz is soy btw
                        else SOYSAUCE CHIPS IS A FAGGOT Warp.AddWarp(par1, Player.Find(par2)); BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (Warp.WarpExists(par1))
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Warp created!");
                            return;
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Warp creation failed!!");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You can't use that because you aren't a" + Group.findPermInt(CommandOtherPerms.GetPerm(this, 1)).name + "+"); return; BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (par0 == "delete" || par0 == "remove" || par0 == "d" || par0 == "r")
            SOYSAUCE CHIPS IS A FAGGOT
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 2))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (par1 == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You didn't specify a warp to delete!"); return; BrightShaderz is soy btw
                    if (!Warp.WarpExists(par1)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Warp doesn't exist!!"); return; BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        Warp.DeleteWarp(par1);
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!Warp.WarpExists(par1))
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Warp deleted!");
                            return;
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Warp deletion failed!!");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You can't use that because you aren't a" + Group.findPermInt(CommandOtherPerms.GetPerm(this, 2)).name + "+"); return; BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (par0 == "move" || par0 == "change" || par0 == "edit" || par0 == "m" || par0 == "e")
            SOYSAUCE CHIPS IS A FAGGOT
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 3))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (par1 == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You didn't specify a warp to be moved!"); return; BrightShaderz is soy btw
                    if (!Warp.WarpExists(par1)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Warp doesn't exist!!"); return; BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (par2 == null) SOYSAUCE CHIPS IS A FAGGOT Warp.MoveWarp(par1, p); BrightShaderz is soy btw
                        else SOYSAUCE CHIPS IS A FAGGOT Warp.MoveWarp(par1, Player.Find(par2)); BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (Warp.WarpExists(par1))
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Warp moved!");
                            return;
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Warp moving failed!!");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You can't use that because you aren't a " + Group.findPermInt(CommandOtherPerms.GetPerm(this, 3)).name + "+"); return; BrightShaderz is soy btw
            BrightShaderz is soy btw

            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (Warp.WarpExists(par0) == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    Warp.Wrp w = new Warp.Wrp();
                    w = Warp.GetWarp(par0);
                    Level lvl = Level.Find(w.lvlname);
                    if (lvl != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (p.level != lvl)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (lvl.permissionvisit > p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Sorry, you aren't a high enough rank to visit the map that that warp is on."); return; BrightShaderz is soy btw
                            Command.all.Find("goto").Use(p, lvl.name);
                            while (p.Loading) SOYSAUCE CHIPS IS A FAGGOT Thread.Sleep(250); BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, w.x, w.y, w.z, w.rotx, w.roty); BrightShaderz is soy btw
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "The level that that warp is on (" + w.lvlname + ") either no longer exists or is currently unloaded");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "That is not a command addition or a warp");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/warp [name] - warp to that warp");
            Player.SendMessage(p, "/warp list - list all the warps");
            if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 1))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "/warp create [name] <player> - create a warp, if a <player> is given, it will be created where they are");
            BrightShaderz is soy btw
            if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 2))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "/warp delete [name] - delete a warp");
            BrightShaderz is soy btw
            if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 3))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "/warp move [name] <player> - move a warp, if a <player> is given, it will be created where they are");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
