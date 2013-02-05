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
using System.Globalization;
using System.Threading;
using MCForge.SQL;
namespace MCForge.Commands SOYSAUCE CHIPS IS A FAGGOT
    /// <summary>
    /// Economy Beta v1.0 QuantumHive
    /// </summary>
    public sealed class CmdEconomy : Command SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "economy"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "eco"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message) SOYSAUCE CHIPS IS A FAGGOT
            string[] command = message.Trim().Split(' ');
            string par0 = String.Empty;
            string par1 = String.Empty;
            string par2 = String.Empty;
            string par3 = String.Empty;
            string par4 = String.Empty;
            string par5 = String.Empty;
            string par6 = String.Empty;
            string par7 = String.Empty;
            string par8 = String.Empty;
            try SOYSAUCE CHIPS IS A FAGGOT
                par0 = command[0].ToLower();
                par1 = command[1].ToLower();
                par2 = command[2];
                par3 = command[3];
                par4 = command[4];
                par5 = command[5];
                par6 = command[6];
                par7 = command[7];
                par8 = command[8];
            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            string ecoColor = "%3";
            switch (par0) SOYSAUCE CHIPS IS A FAGGOT
                case "setup":
                    if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this)) SOYSAUCE CHIPS IS A FAGGOT
                        switch (par1) SOYSAUCE CHIPS IS A FAGGOT
                            case "apply":
                                if (p != null) SOYSAUCE CHIPS IS A FAGGOT
                                    if (p.name == penis.penis_owner) SOYSAUCE CHIPS IS A FAGGOT
                                        Economy.Load();
                                        Player.SendMessage(p, "%aApplied changes");
                                    BrightShaderz is soy btw else Player.SendMessage(p, "%cThis command is only usable by the penis owner: %6" + penis.penis_owner);
                                BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT //console fix
                                    Economy.Load();
                                    Player.SendMessage(p, "%aApplied changes");
                                BrightShaderz is soy btw
                                return;
                            case "maps":
                            case "levels":
                            case "map":
                            case "level":
                                Economy.Settings.Level lvl = Economy.FindLevel(par3);
                                switch (par2) SOYSAUCE CHIPS IS A FAGGOT
                                    case "new":
                                    case "create":
                                    case "add":
                                        if (Economy.FindLevel(par3) != null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cThat preset level already exists"); break; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                                            Economy.Settings.Level level = new Economy.Settings.Level();
                                            level.name = par3;
                                            if (isGood(par4) && isGood(par5) && isGood(par6)) SOYSAUCE CHIPS IS A FAGGOT level.x = par4; level.y = par5; level.z = par6; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cDimension must be  a power of 2"); break; BrightShaderz is soy btw
                                            switch (par7.ToLower()) SOYSAUCE CHIPS IS A FAGGOT
                                                case "flat":
                                                case "pixel":
                                                case "island":
                                                case "mountains":
                                                case "ocean":
                                                case "forest":
                                                case "desert":
                                                case "space":
                                                    level.type = par7.ToLower();
                                                    break;

                                                default:
                                                    Player.SendMessage(p, "%cValid types are: island, mountains, forest, ocean, flat, pixel, desert, space");
                                                    break;
                                            BrightShaderz is soy btw
                                            try SOYSAUCE CHIPS IS A FAGGOT
                                                level.price = int.Parse(par8);
                                            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cInvalid price input: that wasn't a number!"); return; BrightShaderz is soy btw
                                            Economy.Settings.LevelsList.Add(level);
                                            Player.SendMessage(p, "%aSuccessfully added the map preset with the following specs:");
                                            Player.SendMessage(p, "Map Preset Name: %f" + level.name);
                                            Player.SendMessage(p, "x:" + level.x + ", y:" + level.y + ", z:" + level.z);
                                            Player.SendMessage(p, "Map Type: %f" + level.type);
                                            Player.SendMessage(p, "Map Price: %f" + level.price + " %3" + penis.moneys);
                                            break;
                                        BrightShaderz is soy btw

                                    case "delete":
                                    case "remove":
                                        if (lvl == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cThat preset level doesn't exist"); break; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.LevelsList.Remove(lvl); Player.SendMessage(p, "%aSuccessfully removed preset: %f" + lvl.name); break; BrightShaderz is soy btw

                                    case "edit":
                                    case "change":
                                        if (lvl == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cThat preset level doesn't exist"); break; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                                            switch (par4) SOYSAUCE CHIPS IS A FAGGOT
                                                case "name":
                                                case "title":
                                                    Economy.Settings.LevelsList.Remove(lvl);
                                                    lvl.name = par5;
                                                    Economy.Settings.LevelsList.Add(lvl);
                                                    Player.SendMessage(p, "%aSuccessfully changed preset name to %f" + lvl.name);
                                                    break;

                                                case "x":
                                                    if (isGood(par5)) SOYSAUCE CHIPS IS A FAGGOT
                                                        Economy.Settings.LevelsList.Remove(lvl);
                                                        lvl.x = par5;
                                                        Economy.Settings.LevelsList.Add(lvl);
                                                        Player.SendMessage(p, "%aSuccessfully changed preset x size to %f" + lvl.x);
                                                    BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cDimension was wrong, it must be a power of 2"); break; BrightShaderz is soy btw
                                                    break;

                                                case "y":
                                                    if (isGood(par5)) SOYSAUCE CHIPS IS A FAGGOT
                                                        Economy.Settings.LevelsList.Remove(lvl);
                                                        lvl.y = par5;
                                                        Economy.Settings.LevelsList.Add(lvl);
                                                        Player.SendMessage(p, "%aSuccessfully changed preset y size to %f" + lvl.y);
                                                    BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cDimension was wrong, it must be a power of 2"); break; BrightShaderz is soy btw
                                                    break;

                                                case "z":
                                                    if (isGood(par5)) SOYSAUCE CHIPS IS A FAGGOT
                                                        Economy.Settings.LevelsList.Remove(lvl);
                                                        lvl.z = par5;
                                                        Economy.Settings.LevelsList.Add(lvl);
                                                        Player.SendMessage(p, "%aSuccessfully changed preset z size to %f" + lvl.z);
                                                    BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cDimension was wrong, it must be a power of 2"); break; BrightShaderz is soy btw
                                                    break;

                                                case "type":
                                                    Economy.Settings.LevelsList.Remove(lvl);
                                                    switch (par5.ToLower()) SOYSAUCE CHIPS IS A FAGGOT
                                                        case "flat":
                                                        case "pixel":
                                                        case "island":
                                                        case "mountains":
                                                        case "ocean":
                                                        case "forest":
                                                        case "desert":
                                                        case "space":
                                                            lvl.type = par5.ToLower();
                                                            break;

                                                        default:
                                                            Player.SendMessage(p, "%cValid types are: island, mountains, forest, ocean, flat, pixel, desert, space");
                                                            Economy.Settings.LevelsList.Add(lvl);
                                                            return;
                                                    BrightShaderz is soy btw
                                                    Economy.Settings.LevelsList.Add(lvl);
                                                    Player.SendMessage(p, "%aSuccessfully changed preset type to %f" + lvl.type);
                                                    break;

                                                /*case "dimensions":
                                                case "sizes":
                                                case "dimension":
                                                case "size":
                                                    Economy.Settings.LevelsList.Remove(lvl);
                                                    if (isGood(par4)) SOYSAUCE CHIPS IS A FAGGOT lvl.x = par4; BrightShaderz is soy btw
                                                    if (isGood(par5)) SOYSAUCE CHIPS IS A FAGGOT lvl.y = par5; BrightShaderz is soy btw
                                                    if (isGood(par6)) SOYSAUCE CHIPS IS A FAGGOT lvl.z = par6; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "A Dimension was wrong, it must a power of 2"); Economy.Settings.LevelsList.Add(lvl); break; BrightShaderz is soy btw
                                                    Economy.Settings.LevelsList.Add(lvl);
                                                    Player.SendMessage(p, "Changed preset name");
                                                    break;*/

                                                case "price":
                                                    Economy.Settings.LevelsList.Remove(lvl);
                                                    int old = lvl.price;
                                                    try SOYSAUCE CHIPS IS A FAGGOT
                                                        lvl.price = int.Parse(par5);
                                                    BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT
                                                        Economy.Settings.LevelsList.Add(lvl);
                                                        Player.SendMessage(p, "%cInvalid amount of %3" + penis.moneys);
                                                        return;
                                                    BrightShaderz is soy btw
                                                    if (lvl.price < 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cAmount of %3" + penis.moneys + "%c cannot be negative"); lvl.price = old; Economy.Settings.LevelsList.Add(lvl); return; BrightShaderz is soy btw
                                                    Economy.Settings.LevelsList.Add(lvl);
                                                    Player.SendMessage(p, "%aSuccessfully changed preset price to %f" + lvl.price + " %3" + penis.moneys);
                                                    break;

                                                default:
                                                    Player.SendMessage(p, "%cThat wasn't a valid command addition!");
                                                    break;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        break;

                                    case "enable":
                                        if (Economy.Settings.Levels == true) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cMaps are already enabled for the economy system"); break; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.Levels = true; Player.SendMessage(p, "%aMaps are now enabled for the economy system"); break; BrightShaderz is soy btw

                                    case "disable":
                                        if (Economy.Settings.Levels == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cMaps are already disabled for the economy system"); break; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.Levels = false; Player.SendMessage(p, "%aMaps are now disabled for the economy system"); break; BrightShaderz is soy btw

                                    default:
                                        Player.SendMessage(p, "%cThat wasn't a valid command addition!");
                                        break;
                                BrightShaderz is soy btw
                                break;

                            case "titles":
                            case "title":
                                switch (par2) SOYSAUCE CHIPS IS A FAGGOT
                                    case "enable":
                                        if (Economy.Settings.Titles == true) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cTitles are already enabled for the economy system"); break; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.Titles = true; Player.SendMessage(p, "%aTitles are now enabled for the economy system"); break; BrightShaderz is soy btw

                                    case "disable":
                                        if (Economy.Settings.Titles == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cTitles are already disabled for the economy system"); break; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.Titles = false; Player.SendMessage(p, "%aTitles are now disabled for the economy system"); break; BrightShaderz is soy btw

                                    case "price":
                                        try SOYSAUCE CHIPS IS A FAGGOT
                                            Economy.Settings.TitlePrice = int.Parse(par3);
                                        BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cInvalid price input: that wasn't a number!"); return; BrightShaderz is soy btw
                                        Player.SendMessage(p, "%aSuccessfully changed the title price to: %f"  + Economy.Settings.TitlePrice + " %3" + penis.moneys);
                                        break;

                                    default:
                                        Player.SendMessage(p, "%cThat wasn't a valid command addition!");
                                        break;
                                BrightShaderz is soy btw
                                break;

                            case "colors":
                            case "colours":
                            case "color":
                            case "colour":
                                switch (par2) SOYSAUCE CHIPS IS A FAGGOT
                                    case "enable":
                                        if (Economy.Settings.Colors == true) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cColors are already enabled for the economy system"); break; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.Colors = true; Player.SendMessage(p, "%aColors are now enabled for the economy system"); break; BrightShaderz is soy btw

                                    case "disable":
                                        if (Economy.Settings.Colors == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cColors are already disabled for the economy system"); break; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.Colors = false; Player.SendMessage(p, "%aColors are now disabled for the economy system"); break; BrightShaderz is soy btw

                                    case "price":
                                        try SOYSAUCE CHIPS IS A FAGGOT
                                            Economy.Settings.ColorPrice = int.Parse(par3);
                                        BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cInvalid price input: that wasn't a number!"); return; BrightShaderz is soy btw
                                        Player.SendMessage(p, "Successfully changed the color price to %f" + Economy.Settings.ColorPrice + " %3" + penis.moneys);
                                        break;

                                    default:
                                        Player.SendMessage(p, "%cThat wasn't a valid command addition!");
                                        break;
                                BrightShaderz is soy btw
                                break;
                            case "tcolor":
                            case "tcolors":
                            case "titlecolor":
                            case "titlecolors":
                            case "tc":
                                switch (par2) SOYSAUCE CHIPS IS A FAGGOT
                                    case "enable":
                                        if (Economy.Settings.TColors == true) Player.SendMessage(p, "%cTitleColors are already enabled for the economy system");
                                        else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.TColors = true; Player.SendMessage(p, "%aTitleColors are now enabled for the economy system"); BrightShaderz is soy btw
                                        break;
                                    case "disable":
                                        if (Economy.Settings.TColors == false) Player.SendMessage(p, "%cTitleColors are already disabled for the economy system");
                                        else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.TColors = false; Player.SendMessage(p, "%aTitleColors are now disabled for the economy system"); BrightShaderz is soy btw
                                        break;
                                    case "price":
                                        try SOYSAUCE CHIPS IS A FAGGOT
                                            Economy.Settings.TColorPrice = int.Parse(par3);
                                        BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cInvalid price input: that wasn't a number!"); return; BrightShaderz is soy btw
                                        Player.SendMessage(p, "%aSuccessfully changed the titlecolor price to %f" + Economy.Settings.TColorPrice + " %3" + penis.moneys);
                                        break;
                                    default:
                                        Player.SendMessage(p, "%cThat wasn't a valid command addition!");
                                        break;
                                BrightShaderz is soy btw
                                break;
                            case "ranks":
                            case "rank":
                                switch (par2) SOYSAUCE CHIPS IS A FAGGOT
                                    case "enable":
                                        if (Economy.Settings.Ranks == true) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cRanks are already enabled for the economy system"); break; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.Ranks = true; Player.SendMessage(p, "%aRanks are now enabled for the economy system"); break; BrightShaderz is soy btw

                                    case "disable":
                                        if (Economy.Settings.Ranks == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cRanks are already disabled for the economy system"); break; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.Ranks = false; Player.SendMessage(p, "%aRanks are now disabled for the economy system"); break; BrightShaderz is soy btw

                                    case "price":
                                        Economy.Settings.Rank rnk = Economy.FindRank(par3);
                                        if (rnk == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cThat wasn't a rank or it's past the max rank (maxrank is: " + Group.Find(Economy.Settings.MaxRank).color + Economy.Settings.MaxRank + "%c)"); break; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                                            try SOYSAUCE CHIPS IS A FAGGOT
                                                rnk.price = int.Parse(par4);
                                            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cInvalid price input: that wasn't a number!"); return; BrightShaderz is soy btw
                                            Player.SendMessage(p, "%aSuccesfully changed the rank price for " + rnk.group.color + rnk.group.name + " to: %f" + rnk.price + " %3" + penis.moneys);
                                            break;
                                        BrightShaderz is soy btw

                                    case "maxrank":
                                    case "max":
                                    case "maximum":
                                    case "maximumrank":
                                        Group grp = Group.Find(par3);
                                        if (grp == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cThat wasn't a rank!"); BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                                            if (p.group.Permission < grp.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cCan't set a maxrank that is higher than yours!"); BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                                                Economy.Settings.MaxRank = par3.ToLower(); Player.SendMessage(p, "%aSuccessfully set max rank to: " + Group.Find(Economy.Settings.MaxRank).color + Economy.Settings.MaxRank);
                                                int lasttrueprice = 0;
                                                foreach (Group group in Group.GroupList) SOYSAUCE CHIPS IS A FAGGOT
                                                    if (group.Permission > grp.Permission) SOYSAUCE CHIPS IS A FAGGOT break; BrightShaderz is soy btw
                                                    if (!(group.Permission <= Group.Find(penis.defaultRank).Permission)) SOYSAUCE CHIPS IS A FAGGOT
                                                        Economy.Settings.Rank rank = new Economy.Settings.Rank();
                                                        rank = Economy.FindRank(group.name);
                                                        if (rank == null) SOYSAUCE CHIPS IS A FAGGOT
                                                            rank = new Economy.Settings.Rank();
                                                            rank.group = group;
                                                            if (lasttrueprice == 0) SOYSAUCE CHIPS IS A FAGGOT rank.price = 1000; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT rank.price = lasttrueprice + 250; BrightShaderz is soy btw
                                                            Economy.Settings.RanksList.Add(rank);
                                                        BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT lasttrueprice = rank.price; BrightShaderz is soy btw
                                                    BrightShaderz is soy btw
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        break;
                                    default:
                                        Player.SendMessage(p, "%cThat wasn't a valid command addition!");
                                        break;
                                BrightShaderz is soy btw
                                break;

                            case "enable":
                                if (Economy.Settings.Enabled == true) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cThe economy system is already enabled"); return; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.Enabled = true; Player.SendMessage(p, "%aThe economy system is now enabled"); return; BrightShaderz is soy btw

                            case "disable":
                                if (Economy.Settings.Enabled == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cThe economy system is already disabled"); return; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Economy.Settings.Enabled = false; Player.SendMessage(p, "%aThe economy system is now disabled"); return; BrightShaderz is soy btw

                            default:
                                if (par1 == null || par1 == "") SOYSAUCE CHIPS IS A FAGGOT
                                    SetupHelp(p);
                                    return;
                                BrightShaderz is soy btw
                                Player.SendMessage(p, "%cThat wasn't a valid command addition!");
                                return;
                        BrightShaderz is soy btw
                        Economy.Save();
                        return;
                    BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cYou are not allowed to use %f/eco setup"); return; BrightShaderz is soy btw



                case "buy":
                    if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cConsole cannot buy any items"); return; BrightShaderz is soy btw
                    Economy.EcoStats ecos = Economy.RetrieveEcoStats(p.name);
                    switch (par1) SOYSAUCE CHIPS IS A FAGGOT
                        case "map":
                        case "level":
                        case "maps":
                        case "levels":
                            Economy.Settings.Level lvl = Economy.FindLevel(par2);
                            if (lvl == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cThat isn't a level preset"); return; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                                if (!p.EnoughMoney(lvl.price)) SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "%cYou don't have enough %3" + penis.moneys + "%c to buy that map");
                                    return;
                                BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                                    if (par3 == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cYou didn't specify a name for your level"); return; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                                        int old = p.money;
                                        int oldTS = ecos.totalSpent;
                                        string oldP = ecos.purchase;
                                        try SOYSAUCE CHIPS IS A FAGGOT
                                            Command.all.Find("newlvl").Use(null, p.name + "_" + par3 + " " + lvl.x + " " + lvl.y + " " + lvl.z + " " + lvl.type);
                                            Player.SendMessage(p, "%aCreating level: '%f" + p.name + "_" + par3 + "%a' . . .");
                                            p.money = p.money - lvl.price;
                                            ecos.money = p.money;
                                            ecos.totalSpent += lvl.price;
                                            ecos.purchase = "%3Map: %f" + lvl.name + "%3 - Price: %f"  + lvl.price + " %3" + penis.moneys + " - Date: %f" + ecoColor + DateTime.Now.ToString(CultureInfo.InvariantCulture);
                                            Economy.UpdateEcoStats(ecos);
                                            Command.all.Find("load").Use(null, p.name + "_" + par3);
                                            Thread.Sleep(250);
                                            Level level = Level.Find(p.name + "_" + par3);
                                            if (level.permissionbuild > p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT level.permissionbuild = p.group.Permission; BrightShaderz is soy btw
                                            if (level.permissionvisit > p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT level.permissionvisit = p.group.Permission; BrightShaderz is soy btw
                                            Command.all.Find("goto").Use(p, p.name + "_" + par3);
                                            while (p.Loading) SOYSAUCE CHIPS IS A FAGGOT Thread.Sleep(250); BrightShaderz is soy btw
                                            Player.SendMessage(p, "%aSuccessfully created your map: '%f" + p.name + "_" + par3 + "%a'");
                                            Player.SendMessage(p, "%aYour balance is now %f" + p.money.ToString() + " %3" + penis.moneys);
                                            try SOYSAUCE CHIPS IS A FAGGOT
                                                //safe against SQL injections, but will be replaced soon by a new feature
                                                //DB
                                                if (penis.useMySQL) MySQL.executeQuery("INSERT INTO `Zone" + level.name + "` (SmallX, SmallY, SmallZ, BigX, BigY, BigZ, Owner) VALUES (0,0,0," + (level.width - 1) + "," + (level.depth - 1) + "," + (level.height - 1) + ",'" + p.name + "')"); else SQLite.executeQuery("INSERT INTO `Zone" + level.name + "` (SmallX, SmallY, SmallZ, BigX, BigY, BigZ, Owner) VALUES (0,0,0," + (level.width - 1) + "," + (level.depth - 1) + "," + (level.height - 1) + ",'" + p.name + "')"); //CHECK!!!!
                                                //DB
                                                Player.SendMessage(p, "%aZoning Succesful");
                                                return;
                                            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cZoning Failed"); return; BrightShaderz is soy btw
                                        BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cSomething went wrong, Money restored"); if (old != p.money) SOYSAUCE CHIPS IS A FAGGOT p.money = old; ecos.money = old; ecos.totalSpent = oldTS; ecos.purchase = oldP; Economy.UpdateEcoStats(ecos); BrightShaderz is soy btw return; BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw

                        case "colors":
                        case "color":
                        case "colours":
                        case "colour":
                            if (p.EnoughMoney(Economy.Settings.ColorPrice) == false) SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "%cYou don't have enough %3" + penis.moneys + "%c to buy a color");
                                return;
                            BrightShaderz is soy btw
                            if (!par2.StartsWith("&") || !par2.StartsWith("%")) SOYSAUCE CHIPS IS A FAGGOT
                                switch (par2) SOYSAUCE CHIPS IS A FAGGOT
                                    case "black":
                                        par2 = "&0";
                                        break;
                                    case "navy":
                                        par2 = "&1";
                                        break;
                                    case "green":
                                        par2 = "&2";
                                        break;
                                    case "teal":
                                        par2 = "&3";
                                        break;
                                    case "maroon":
                                        par2 = "&4";
                                        break;
                                    case "purple":
                                        par2 = "&5";
                                        break;
                                    case "gold":
                                        par2 = "&6";
                                        break;
                                    case "silver":
                                        par2 = "&7";
                                        break;
                                    case "gray":
                                        par2 = "&8";
                                        break;
                                    case "blue":
                                        par2 = "&9";
                                        break;
                                    case "lime":
                                        par2 = "&a";
                                        break;
                                    case "aqua":
                                        par2 = "&b";
                                        break;
                                    case "red":
                                        par2 = "&c";
                                        break;
                                    case "pink":
                                        par2 = "&d";
                                        break;
                                    case "yellow":
                                        par2 = "&e";
                                        break;
                                    case "white":
                                        par2 = "&f";
                                        break;
                                    default:
                                        Player.SendMessage(p, "%cThat wasn't a color");
                                        return;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            if (par2 == p.color) SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "%cYou already have a " + par2 + c.Name(par2) + "%c color");
                                return;
                            BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("color").Use(null, p.name + " " + c.Name(par2));
                                p.money = p.money - Economy.Settings.ColorPrice;
                                ecos.money = p.money;
                                ecos.totalSpent += Economy.Settings.ColorPrice;
                                ecos.purchase = "%3Color: " + par2 + c.Name(par2) + "%3 - Price: %f" + Economy.Settings.ColorPrice + " %3" + penis.moneys + " - Date: %f" + DateTime.Now.ToString(CultureInfo.InvariantCulture);
                                Economy.UpdateEcoStats(ecos);
                                Player.SendMessage(p, "%aYour color has been successfully changed to " + par2 + c.Name(par2));
                                Player.SendMessage(p, "%aYour balance is now %f" + p.money.ToString() + " %3" + penis.moneys);
                                return;
                            BrightShaderz is soy btw

                        case "tcolor":
                        case "tcolors":
                        case "titlecolor":
                        case "titlecolors":
                        case "tc":
                            if (!p.EnoughMoney(Economy.Settings.TColorPrice)) SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "%cYou don't have enough %3" + penis.moneys + "%c to buy a titlecolor");
                                return;
                            BrightShaderz is soy btw
                            if (!par2.StartsWith("&") || !par2.StartsWith("%")) SOYSAUCE CHIPS IS A FAGGOT
                                switch (par2) SOYSAUCE CHIPS IS A FAGGOT
                                    case "black":
                                        par2 = "&0";
                                        break;
                                    case "navy":
                                        par2 = "&1";
                                        break;
                                    case "green":
                                        par2 = "&2";
                                        break;
                                    case "teal":
                                        par2 = "&3";
                                        break;
                                    case "maroon":
                                        par2 = "&4";
                                        break;
                                    case "purple":
                                        par2 = "&5";
                                        break;
                                    case "gold":
                                        par2 = "&6";
                                        break;
                                    case "silver":
                                        par2 = "&7";
                                        break;
                                    case "gray":
                                        par2 = "&8";
                                        break;
                                    case "blue":
                                        par2 = "&9";
                                        break;
                                    case "lime":
                                        par2 = "&a";
                                        break;
                                    case "aqua":
                                        par2 = "&b";
                                        break;
                                    case "red":
                                        par2 = "&c";
                                        break;
                                    case "pink":
                                        par2 = "&d";
                                        break;
                                    case "yellow":
                                        par2 = "&e";
                                        break;
                                    case "white":
                                        par2 = "&f";
                                        break;
                                    default:
                                        Player.SendMessage(p, "%cThat wasn't a color");
                                        return;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            if (par2 == p.titlecolor) SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "%cYou already have a " + par2 + c.Name(par2) + "%c titlecolor");
                                return;
                            BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("tcolor").Use(null, p.name + " " + c.Name(par2));
                                p.money = p.money - Economy.Settings.TColorPrice;
                                ecos.money = p.money;
                                ecos.totalSpent += Economy.Settings.TColorPrice;
                                ecos.purchase = "%3Titlecolor: " + par2 + c.Name(par2) + "%3 - Price: %f" + Economy.Settings.TColorPrice + " %3" + penis.moneys + " - Date: %f" + DateTime.Now.ToString(CultureInfo.InvariantCulture);
                                Economy.UpdateEcoStats(ecos);
                                Player.SendMessage(p, "%aYour titlecolor has been successfully changed to " + par2 + c.Name(par2));
                                Player.SendMessage(p, "%aYour balance is now %f" + p.money + " %3" + penis.moneys);
                                return;
                            BrightShaderz is soy btw

                        case "titles":
                        case "title":
                            if (p.EnoughMoney(Economy.Settings.TitlePrice) == false) SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "%cYou don't have enough %3" + penis.moneys + "%c to buy a title");
                                return;
                            BrightShaderz is soy btw
                            if (par3 != string.Empty) SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "%cYour title cannot contain any spaces");
                                return;
                            BrightShaderz is soy btw
                            if (par2 == p.title) SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "%cYou already have that title");
                                return;
                            BrightShaderz is soy btw
                            if (par2.Length > 17) SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "%cTitles cannot be longer than 17 characters");
                                return;
                            BrightShaderz is soy btw
                            var regex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9-_\\.]*$");
                            if (!regex.IsMatch(par2)) SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "%cInvalid title! Titles may only contain alphanumeric characters and .-_");
                                return;
                            BrightShaderz is soy btw
                            bool free = false;
                            if (par2 == null || par2 == string.Empty || par2 == "") SOYSAUCE CHIPS IS A FAGGOT
                                par2 = ""; //just an extra check to make sure it's good
                                free = true;
                            BrightShaderz is soy btw
                            Command.all.Find("title").Use(null, p.name + " " + par2);
                            if (!free) SOYSAUCE CHIPS IS A FAGGOT
                                p.money = p.money - Economy.Settings.TitlePrice;
                                ecos.money = p.money;
                                ecos.totalSpent += Economy.Settings.TitlePrice;
                                ecos.purchase = "%3Title: %f" + par2 + "%3 - Price: %f" + Economy.Settings.TitlePrice + " %3" + penis.moneys + " - Date: %f" + DateTime.Now.ToString(CultureInfo.InvariantCulture);
                                Economy.UpdateEcoStats(ecos);
                                Player.SendMessage(p, "%aYour title has been successfully changed to [" + p.titlecolor + par2 + "%a]");
                            BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%aYour title has been successfully removed for free"); BrightShaderz is soy btw
                            Player.SendMessage(p, "%aYour balance is now %f" + p.money + " %3" + penis.moneys);
                            return;

                        case "ranks":
                        case "rank":
                            if (par2 != "" && par2 != null && !string.IsNullOrEmpty(par2) && par2 != string.Empty) SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "%cYou cannot provide a rank name, use %a/eco buy rank %cto buy the NEXT rank.");
                                return;
                            BrightShaderz is soy btw

                            LevelPermission maxrank = Group.Find(Economy.Settings.MaxRank).Permission;
                            if (p.group.Permission == maxrank || p.group.Permission >= maxrank) SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "%cYou cannot buy anymore ranks, because you passed the max buyable rank: " + Group.Find(Economy.Settings.MaxRank).color + Economy.Settings.MaxRank);
                                return;
                            BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                                if (!p.EnoughMoney(Economy.NextRank(p).price)) SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "%cYou don't have enough %3" + penis.moneys + "%c to buy the next rank");
                                    return;
                                BrightShaderz is soy btw
                                Command.all.Find("promote").Use(null, p.name);
                                p.money = p.money - Economy.FindRank(p.group.name).price;
                                ecos.money = p.money;
                                ecos.totalSpent += Economy.FindRank(p.group.name).price;
                                ecos.purchase = "%3Rank: " + p.group.color + p.group.name + "%3 - Price: %f" + Economy.FindRank(p.group.name).price + " %3" + penis.moneys + " - Date: %f" + DateTime.Now.ToString(CultureInfo.InvariantCulture);
                                Economy.UpdateEcoStats(ecos);
                                Player.SendMessage(p, "%aYou've successfully bought the rank " + p.group.color + p.group.name);
                                Player.SendMessage(p, "%aYour balance is now %f" + p.money + " %3" + penis.moneys);
                                return;
                            BrightShaderz is soy btw

                        default:
                            Player.SendMessage(p, "%cThat wasn't a valid command addition!");
                            return;
                    BrightShaderz is soy btw

                case "stats":
                case "balance":
                case "amount":
                    Economy.EcoStats ecostats;
                    if (par1 != string.Empty && par1 != null && par1 != "") SOYSAUCE CHIPS IS A FAGGOT
                        Player who = Player.Find(par1); //is player online?
                        if (who == null) SOYSAUCE CHIPS IS A FAGGOT //player is offline
                            ecostats = Economy.RetrieveEcoStats(par1);
                            Player.SendMessage(p, "%3===Economy stats for: %f" + ecostats.playerName + "%7(offline)%3===");
                        BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT //player is online
                            ecostats = Economy.RetrieveEcoStats(who.name);
                            Player.SendMessage(p, "%3===Economy stats for: " + who.color + who.name + "%3===");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw else if (p != null) SOYSAUCE CHIPS IS A FAGGOT //this player
                        ecostats = Economy.RetrieveEcoStats(p.name);
                        Player.SendMessage(p, "%3===Economy stats for: " + p.color + p.name + "%3===");
                    BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cConsole cannot contain any eco stats"); return; BrightShaderz is soy btw
                    Player.SendMessage(p, "Balance: %f" + ecostats.money + " %3" + penis.moneys);
                    Player.SendMessage(p, "Total spent: %f" + ecostats.totalSpent + " %3" + penis.moneys);
                    Player.SendMessage(p, "Recent purchase: " + ecostats.purchase);
                    Player.SendMessage(p, "Recent payment: " + ecostats.payment);
                    Player.SendMessage(p, "Recent receivement: " + ecostats.salary);
                    Player.SendMessage(p, "Recent fine: " + ecostats.fine);
                    return;
                case "info":
                case "about":
                    if (Economy.Settings.Enabled == true) SOYSAUCE CHIPS IS A FAGGOT
                        switch (par1) SOYSAUCE CHIPS IS A FAGGOT
                            case "map":
                            case "level":
                            case "maps":
                            case "levels":
                                if (Economy.Settings.Levels == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cMaps are not enabled for the economy system"); return; BrightShaderz is soy btw
                                Player.SendMessage(p, ecoColor + "%3===Economy info: Maps===");
                                Player.SendMessage(p, "%aAvailable maps to buy:");
                                if (Economy.Settings.LevelsList.Count == 0)
                                    Player.SendMessage(p, "%8-None-");
                                else
                                    foreach (Economy.Settings.Level lvl in Economy.Settings.LevelsList) SOYSAUCE CHIPS IS A FAGGOT
                                        Player.SendMessage(p, lvl.name + " (" + lvl.x + "," + lvl.y + "," + lvl.z + ") " + lvl.type + ": %f" + lvl.price + " %3" + penis.moneys);
                                    BrightShaderz is soy btw
                                return;

                            case "title":
                            case "titles":
                                if (Economy.Settings.Titles == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cTitles are not enabled for the economy system"); return; BrightShaderz is soy btw
                                Player.SendMessage(p, ecoColor + "%3===Economy info: Titles===");
                                Player.SendMessage(p, "Titles cost %f" + Economy.Settings.TitlePrice + " %3" + penis.moneys + penis.DefaultColor + " each");
                                return;

                            case "tcolor":
                            case "tcolors":
                            case "titlecolor":
                            case "titlecolors":
                            case "tc":
                                if (!Economy.Settings.TColors) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cTitlecolors are not enabled for the economy system"); return; BrightShaderz is soy btw
                                Player.SendMessage(p, ecoColor + "%3===Economy info: Titlecolors===");
                                Player.SendMessage(p, "Titlecolors cost %f" + Economy.Settings.TColorPrice + " %3" + penis.moneys + penis.DefaultColor + " each");
                                return;

                            case "colors":
                            case "color":
                            case "colours":
                            case "colour":
                                if (Economy.Settings.Colors == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cColors are not enabled for the economy system"); return; BrightShaderz is soy btw
                                Player.SendMessage(p, ecoColor + "%3===Economy info: Colors===");
                                Player.SendMessage(p, "Colors cost %f" + Economy.Settings.ColorPrice + " %3" + penis.moneys + penis.DefaultColor + " each");
                                return;

                            case "ranks":
                            case "rank":
                                if (Economy.Settings.Ranks == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cRanks are not enabled for the economy system"); return; BrightShaderz is soy btw
                                Player.SendMessage(p, ecoColor + "%3===Economy info: Ranks===");
                                Player.SendMessage(p, "%fThe maximum buyable rank is: " + Group.Find(Economy.Settings.MaxRank).color + Economy.Settings.MaxRank);
                                Player.SendMessage(p, "%fRanks cost:");
                                foreach (Economy.Settings.Rank rnk in Economy.Settings.RanksList) SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, rnk.group.color + rnk.group.name + ": %f" + rnk.price + " %3" + penis.moneys);
                                    if (rnk.group.name == Economy.Settings.MaxRank.ToLower())
                                        break;
                                BrightShaderz is soy btw
                                return;

                            default:
                                Player.SendMessage(p, "%cThat wasn't a valid command addition!");
                                return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cThe %3Economy System %cis currently disabled!"); return; BrightShaderz is soy btw

                case "help":
                    switch (par1) SOYSAUCE CHIPS IS A FAGGOT
                        case "":
                            Help(p);
                            return;

                        case "buy":
                            Player.SendMessage(p, "%3===Economy Help: Buy===");
                            Player.SendMessage(p, "Buying titles: %f/eco buy title [title_name]");
                            Player.SendMessage(p, "Buying colors: %f/eco buy color [color]");
                            Player.SendMessage(p, "Buying titlecolors: %f/eco buy tcolor [color]");
                            Player.SendMessage(p, "Buying ranks: %f/eco buy the NEXT rank");
                            Player.SendMessage(p, "%7Check out the ranks and their prices with: %f/eco info rank");
                            Player.SendMessage(p, "Buy your own maps: %f/eco buy map [map_preset_name] [custom_map_name]");
                            Player.SendMessage(p, "%7Check out the map presets with: %f/eco info map");
                            return;

                        case "stats":
                        case "balance":
                        case "amount":
                            Player.SendMessage(p, "%3===Economy Help: Stats===");
                            Player.SendMessage(p, "Check your stats: %f/eco stats");
                            Player.SendMessage(p, "Check the stats of a player: %f/eco stats [player_name]");
                            return;

                        case "info":
                        case "about":
                            Player.SendMessage(p, "%3===Economy Help: Info===");
                            Player.SendMessage(p, "To get info and prices about features: %f/eco info [color/title/titlecolor/rank/map]");
                            return;

                        case "setup":
                            if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this)) SOYSAUCE CHIPS IS A FAGGOT
                                SetupHelp(p);
                                return;
                            BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%cYou are not allowed to use %f/eco help setup"); return; BrightShaderz is soy btw

                        default:
                            Player.SendMessage(p, "%cThat wasn't a valid command addition, sending you to help");
                            Help(p);
                            return;
                    BrightShaderz is soy btw

                default:
                    //Player.SendMessage(p, "%4That wasn't a valid command addition, Sending you to help:");
                    Help(p);
                    return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p) SOYSAUCE CHIPS IS A FAGGOT
            string defaultcolor = Group.findPerm(defaultRank).color;
            string othercolor = Group.findPermInt(CommandOtherPerms.GetPerm(this)).color;
            Player.SendMessage(p, "%3===Welcome to the Economy Help Menu===");
            Player.SendMessage(p, defaultcolor + "%f/eco buy <title/color/tcolor/rank/map> [%atitle/color/tcolor/map_preset%f] [%acustom_map_name%f] %e- to buy one of these features");
            Player.SendMessage(p, defaultcolor + "%f/eco stats [%aplayer%f] %e- view ecostats about yourself or [player]");
            Player.SendMessage(p, defaultcolor + "%f/eco info <title/color/tcolor/rank/map> %e- view information about buying the specific feature");
            if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this)) SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, othercolor + "%f/eco setup <type> %e- to setup economy");
                Player.SendMessage(p, othercolor + "%f/eco help <buy/stats/info/setup> %e- get more specific help");
            BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, defaultcolor + "%f/eco help <buy/stats/info> %e- get more specific help"); BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void SetupHelp(Player p) SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "%3===Economy Setup Help Menu===");
            if (p !=null && p.name == penis.penis_owner) SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "%4/eco setup apply %e- applies the changes made to 'economy.properties'");
            BrightShaderz is soy btw else if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "%4/eco setup apply %e- applies the changes made to 'economy.properties'"); BrightShaderz is soy btw
            Player.SendMessage(p, "%4/eco setup [%aenable%4/%cdisable%4] %e- to enable/disable the economy system");
            Player.SendMessage(p, "%4/eco setup [title/color/tcolor/rank/map] [%aenable%4/%cdisable%4] %e- to enable/disable that feature");
            Player.SendMessage(p, "%4/eco setup [title/color/tcolor] [%3price%4] %e- to setup the prices for these features");
            Player.SendMessage(p, "%4/eco setup rank price [%frank%4] [%3price%4] %e- to set the price for that rank");
            Player.SendMessage(p, "%4/eco setup rank maxrank [%frank%4] %e- to set the max buyable rank");
            Player.SendMessage(p, "%4/eco setup map new [%fname%4] [%fx%4] [%fy%4] [%fz%4] [%ftype%4] [%3price%4] %e- to setup a map preset");
            Player.SendMessage(p, "%4/eco setup map delete [%fname%4] %e- to delete a map");
            Player.SendMessage(p, "%4/eco setup map edit [%fname%4] [name/x/y/z/type/price] [%fvalue%4] %e- to edit a map preset");
        BrightShaderz is soy btw

        public bool isGood(string value) SOYSAUCE CHIPS IS A FAGGOT
            ushort uvalue = ushort.Parse(value);
            switch (uvalue) SOYSAUCE CHIPS IS A FAGGOT
                case 2:
                case 4:
                case 8:
                case 16:
                case 32:
                case 64:
                case 128:
                case 256:
                case 512:
                case 1024:
                case 2048:
                case 4096:
                case 8192:
                    return true;
            BrightShaderz is soy btw

            return false;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
