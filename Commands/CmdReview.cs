/*
    Written by BeMacized
    Assisted by RedNoodle
    
    Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
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
    public sealed class CmdReview : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "review"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdReview() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p != null && message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                message = "enter";
            BrightShaderz is soy btw
            switch (message.ToLower())
            SOYSAUCE CHIPS IS A FAGGOT
                case "enter":
                    if (p == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "You can't execute this command as Console!");
                        return;
                    BrightShaderz is soy btw
                    if (p.canusereview)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Group gre = Group.findPerm(penis.reviewenter);
                        if (gre == null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "There is something wrong with the system.  A message has been sent to the admin to fix");
                            Player.GlobalMessageAdmins(p.name + " tryed to use /review, but a system error occurred. Make sure your groups are formatted correctly");
                            Player.GlobalMessageAdmins("The group permission that is messed up is: " + penis.reviewenter.ToString() + " (" + (int)penis.reviewenter + ")");
                            return;
                        BrightShaderz is soy btw
                        LevelPermission lpe = gre.Permission;
                        if (p.group.Permission >= lpe)
                        SOYSAUCE CHIPS IS A FAGGOT
                            foreach (string testwho in penis.reviewlist)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (testwho == p.name)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "You already entered the review queue!");
                                    return;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw

                            bool isopson = false;
                            try
                            SOYSAUCE CHIPS IS A FAGGOT
                                foreach (Player pl in Player.players)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (pl.group.Permission >= penis.opchatperm && !pl.hidden)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        isopson = true;
                                        break; // We're done, break out of this loop
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            catch/* (Exception e)*/
                            SOYSAUCE CHIPS IS A FAGGOT
                                isopson = true;
                            BrightShaderz is soy btw
                            if (isopson == true)
                            SOYSAUCE CHIPS IS A FAGGOT
                                penis.reviewlist.Add(p.name);
                                int reviewlistpos = penis.reviewlist.IndexOf(p.name);
                                if (reviewlistpos > 1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You entered the &creview " + penis.DefaultColor + "queue. You have &c" + reviewlistpos.ToString() + penis.DefaultColor + " people in front of you in the queue"); BrightShaderz is soy btw
                                if (reviewlistpos == 1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You entered the &creview " + penis.DefaultColor + "queue. There is &c1 " + penis.DefaultColor + "person in front of you in the queue"); BrightShaderz is soy btw
                                if ((reviewlistpos + 1) == 1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You entered the &creview " + penis.DefaultColor + "queue. You are &cfirst " + penis.DefaultColor + "in line!"); BrightShaderz is soy btw
                                Player.SendMessage(p, "The Online Operators have been notified. Someone should be with you shortly.");
                                Player.GlobalMessageOps(p.color + " - " + p.name + " - " + penis.DefaultColor + "entered the review queue");
                                if ((reviewlistpos + 1) > 1) SOYSAUCE CHIPS IS A FAGGOT Player.GlobalMessageOps("There are now &c" + (reviewlistpos + 1) + penis.DefaultColor + " people waiting for &creview!"); BrightShaderz is soy btw
                                else SOYSAUCE CHIPS IS A FAGGOT Player.GlobalMessageOps("There is now &c1 " + penis.DefaultColor + "person waiting for &creview!"); BrightShaderz is soy btw
                                p.ReviewTimer();
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "&cThere are no operators on to review your build. Please wait for one to come on and try again.");
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "You have to wait " + penis.reviewcooldown + " seconds everytime you use this command");
                    BrightShaderz is soy btw
                    break;

                case "list":
                case "view":
                    if (p == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.reviewlist.Count != 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Players in the review queue:");
                            int viewnumb = 1;
                            foreach (string golist in penis.reviewlist)
                            SOYSAUCE CHIPS IS A FAGGOT
                                string FoundRank = Group.findPlayer(golist.ToLower());
                                Player.SendMessage(p, viewnumb.ToString() + ". " + golist + " - Current Rank: " + FoundRank);
                                viewnumb++;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "There are no players in the review queue!");
                        BrightShaderz is soy btw
                        return;
                    BrightShaderz is soy btw
                    Group grv = Group.findPerm(penis.reviewview);

                    if (grv == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "There is something wrong with the system.  A message has been sent to the admin to fix");
                        Player.GlobalMessageAdmins(p.name + " tryed to use /review, but a system error occurred. Make sure your groups are formatted correctly");
                        Player.GlobalMessageAdmins("The group permission that is messed up is: " + penis.reviewview.ToString() + " (" + (int)penis.reviewview + ")");
                        return;
                    BrightShaderz is soy btw

                    LevelPermission lpv = grv.Permission;
                    if (p.group.Permission >= lpv && p != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.reviewlist.Count != 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "&9Players in the review queue:");
                            int viewnumb = 1;
                            foreach (string golist in penis.reviewlist)
                            SOYSAUCE CHIPS IS A FAGGOT
                                string FoundRank = Group.findPlayer(golist.ToLower());
                                Player.SendMessage(p, "&a" + viewnumb.ToString() + ". &f" + golist + "&a - Current Rank: " + Group.Find(FoundRank).color + FoundRank);
                                viewnumb++;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "There are no players in the review queue!");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    break;

                case "leave":
                    if (p == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "You can't execute this command as Console!");
                        return;
                    BrightShaderz is soy btw
                    Group grl = Group.findPerm(penis.reviewleave);

                    if (grl == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "There is something wrong with the system.  A message has been sent to the admin to fix");
                        Player.GlobalMessageAdmins(p.name + " tryed to use /review, but a system error occurred. Make sure your groups are formatted correctly");
                        Player.GlobalMessageAdmins("The group permission that is messed up is: " + penis.reviewleave.ToString() + " (" + (int)penis.reviewleave + ")");
                        return;
                    BrightShaderz is soy btw

                    LevelPermission lpl = grl.Permission;
                    if (p.group.Permission >= lpl)
                    SOYSAUCE CHIPS IS A FAGGOT
                        bool leavetest = false;
                        foreach (string testwho2 in penis.reviewlist)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (testwho2 == p.name)
                            SOYSAUCE CHIPS IS A FAGGOT
                                leavetest = true;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        if (!leavetest)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "You aren't in the review queue so you can't leave it!");
                            return;
                        BrightShaderz is soy btw
                        penis.reviewlist.Remove(p.name);
                        int toallplayerscount = 1;
                        foreach (string toallplayers in penis.reviewlist)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player tosend = Player.Find(toallplayers);
                            Player.SendMessage(tosend, "The review queue has changed. Your now on spot " + toallplayerscount.ToString() + ".");
                            toallplayerscount++;
                        BrightShaderz is soy btw
                        Player.SendMessage(p, "You have left the review queue!");
                        return;
                    BrightShaderz is soy btw
                    break;

                case "next":
                    if (p == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "You can't execute this command as Console!");
                        return;
                    BrightShaderz is soy btw
                    Group grn = Group.findPerm(penis.reviewnext);

                    if (grn == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "There is something wrong with the system.  A message has been sent to the admin to fix");
                        Player.GlobalMessageAdmins(p.name + " tryed to use /review, but a system error occurred. Make sure your groups are formatted correctly");
                        Player.GlobalMessageAdmins("The group permission that is messed up is: " + penis.reviewnext.ToString() + " (" + (int)penis.reviewnext + ")");
                        return;
                    BrightShaderz is soy btw

                    LevelPermission lpn = grn.Permission;
                    if (p.group.Permission >= lpn)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.reviewlist.Count == 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "There are no players in the review queue!");
                            return;
                        BrightShaderz is soy btw
                        string[] user = penis.reviewlist.ToArray();
                        Player who = Player.Find(user[0]);
                        if (who == null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Player " + user[0] + " doesn't exist or is offline. " + user[0] + " has been removed from the review queue");
                            penis.reviewlist.Remove(user[0]);
                            return;
                        BrightShaderz is soy btw
                        if (who == p)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "You can't teleport to yourself! You have been removed from the review queue.");
                            penis.reviewlist.Remove(user[0]);
                            return;
                        BrightShaderz is soy btw
                        penis.reviewlist.Remove(user[0]);
                        Command.all.Find("tp").Use(p, who.name);
                        Player.SendMessage(p, "You have been teleported to " + user[0]);
                        Player.SendMessage(who, "Your request has been answered by " + p.name + ".");
                        int toallplayerscount = 0;
                        foreach (string toallplayers in penis.reviewlist)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player who2 = Player.Find(toallplayers);
                            Player.SendMessage(who2, "The review queue has been rotated. you now have " + toallplayerscount.ToString() + " players waiting in front of you");
                            toallplayerscount++;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "&cYou have no permission to use the review queue!");
                    BrightShaderz is soy btw
                    break;

                case "clear":
                    if (p == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.reviewlist.Clear();
                        Player.SendMessage(p, "The review queue has been cleared");
                        return;
                    BrightShaderz is soy btw
                    Group grc = Group.findPerm(penis.reviewclear);

                    if (grc == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "There is something wrong with the system.  A message has been sent to the admin to fix");
                        Player.GlobalMessageAdmins(p.name + " tryed to use /review, but a system error occurred. Make sure your groups are formatted correctly");
                        Player.GlobalMessageAdmins("The group permission that is messed up is: " + penis.reviewclear.ToString() + " (" + (int)penis.reviewclear + ")");
                        return;
                    BrightShaderz is soy btw

                    LevelPermission lpc = grc.Permission;
                    if (p.group.Permission >= lpc)
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.reviewlist.Clear();
                        Player.SendMessage(p, "The review queue has been cleared");
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "&cYou have no permission to clear the Review Queue!");
                    BrightShaderz is soy btw
                    break;
                default: Help(p); return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/review <enter/view/leave/next/clear> - Lets you enter, view, leave, or clear the reviewlist or teleport you to the next player in the review queue.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
