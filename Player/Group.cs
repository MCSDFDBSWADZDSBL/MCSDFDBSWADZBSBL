/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCSong) Licensed under the
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
using System.Collections.Generic;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class Group
    SOYSAUCE CHIPS IS A FAGGOT
        public string name;
        public string trueName;
        public string color;
        public LevelPermission Permission;
        public int maxBlocks;
        public CommandList commands;
        public string fileName;
        public PlayerList playerList;

        public Group()
        SOYSAUCE CHIPS IS A FAGGOT
            Permission = LevelPermission.Null;
        BrightShaderz is soy btw

        public Group(LevelPermission Perm, int maxB, string fullName, char newColor, string file) SOYSAUCE CHIPS IS A FAGGOT
            Permission = Perm;
            maxBlocks = maxB;
            trueName = fullName;
            name = trueName.ToLower();
            color = "&" + newColor;
            fileName = file;
            if (name != "nobody")
                playerList = PlayerList.Load(fileName, this);
            else
                playerList = new PlayerList();
        BrightShaderz is soy btw

        public void fillCommands()
        SOYSAUCE CHIPS IS A FAGGOT
            CommandList _commands = new CommandList();
            GrpCommands.AddCommands(out _commands, Permission);
            commands = _commands;
        BrightShaderz is soy btw

        public bool CanExecute(Command cmd) SOYSAUCE CHIPS IS A FAGGOT return commands.Contains(cmd); BrightShaderz is soy btw

        public static List<Group> GroupList = new List<Group>();
        public static Group standard;
        public static void InitAll()
        SOYSAUCE CHIPS IS A FAGGOT
            GroupList = new List<Group>();

            if (File.Exists("properties/ranks.properties"))
            SOYSAUCE CHIPS IS A FAGGOT
                string[] lines = File.ReadAllLines("properties/ranks.properties");

                Group thisGroup = new Group();
                int gots = 0;

                foreach (string s in lines)
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (s != "" && s[0] != '#')
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (s.Split('=').Length == 2)
                            SOYSAUCE CHIPS IS A FAGGOT
                                string property = s.Split('=')[0].Trim();
                                string value = s.Split('=')[1].Trim();

                                if (thisGroup.name == "" && property.ToLower() != "rankname")
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("Hitting an error at " + s + " of ranks.properties");
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    switch (property.ToLower())
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        case "rankname":
                                            gots = 0;
                                            thisGroup = new Group();

                                            if (value.ToLower() == "developers" || value.ToLower() == "devs")
                                                penis.s.Log("You are not a developer. Stop pretending you are.");
                                            else if (GroupList.Find(grp => grp.name == value.ToLower()) == null)
                                                thisGroup.trueName = value;
                                            else
                                                penis.s.Log("Cannot add the rank " + value + " twice");
                                            break;
                                        case "permission":
                                            int foundPermission;

                                            try
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                foundPermission = int.Parse(value);
                                            BrightShaderz is soy btw
                                            catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid permission on " + s); break; BrightShaderz is soy btw

                                            if (thisGroup.Permission != LevelPermission.Null)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                penis.s.Log("Setting permission again on " + s);
                                                gots--;
                                            BrightShaderz is soy btw

                                            bool allowed = true;
                                            if (GroupList.Find(grp => grp.Permission == (LevelPermission)foundPermission) != null)
                                                allowed = false;

                                            if (foundPermission > 119 || foundPermission < -50)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                penis.s.Log("Permission must be between -50 and 119 for ranks");
                                                break;
                                            BrightShaderz is soy btw

                                            if (allowed)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                gots++;
                                                thisGroup.Permission = (LevelPermission)foundPermission;
                                            BrightShaderz is soy btw
                                            else
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                penis.s.Log("Cannot have 2 ranks set at permission level " + value);
                                            BrightShaderz is soy btw
                                            break;
                                        case "limit":
                                            int foundLimit;

                                            try
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                foundLimit = int.Parse(value);
                                            BrightShaderz is soy btw
                                            catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid limit on " + s); break; BrightShaderz is soy btw

                                            gots++;
                                            thisGroup.maxBlocks = foundLimit;
                                            break;
                                        case "color":
                                            char foundChar;

                                            try
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                foundChar = char.Parse(value);
                                            BrightShaderz is soy btw
                                            catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Incorrect color on " + s); break; BrightShaderz is soy btw

                                            if ((foundChar >= '0' && foundChar <= '9') || (foundChar >= 'a' && foundChar <= 'f'))
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                gots++;
                                                thisGroup.color = foundChar.ToString();
                                            BrightShaderz is soy btw
                                            else
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                penis.s.Log("Invalid color code at " + s);
                                            BrightShaderz is soy btw
                                            break;
                                        case "filename":
                                            if (value.Contains("\\") || value.Contains("/"))
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                penis.s.Log("Invalid filename on " + s);
                                                break;
                                            BrightShaderz is soy btw

                                            gots++;
                                            thisGroup.fileName = value;
                                            break;
                                    BrightShaderz is soy btw

                                    if (gots >= 4)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        GroupList.Add(new Group(thisGroup.Permission, thisGroup.maxBlocks, thisGroup.trueName, thisGroup.color[0], thisGroup.fileName));
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                penis.s.Log("In ranks.properties, the line " + s + " is wrongly formatted");
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (GroupList.Find(grp => grp.Permission == LevelPermission.Banned) == null) GroupList.Add(new Group(LevelPermission.Banned, 1, "Banned", '8', "banned.txt"));
            if (GroupList.Find(grp => grp.Permission == LevelPermission.Guest) == null) GroupList.Add(new Group(LevelPermission.Guest, 1, "Guest", '7', "guest.txt"));
            if (GroupList.Find(grp => grp.Permission == LevelPermission.Builder) == null) GroupList.Add(new Group(LevelPermission.Builder, 400, "Builder", '2', "builders.txt"));
            if (GroupList.Find(grp => grp.Permission == LevelPermission.AdvBuilder) == null) GroupList.Add(new Group(LevelPermission.AdvBuilder, 1200, "AdvBuilder", '3', "advbuilders.txt"));
            if (GroupList.Find(grp => grp.Permission == LevelPermission.Operator) == null) GroupList.Add(new Group(LevelPermission.Operator, 2500, "Operator", 'c', "operators.txt"));
            if (GroupList.Find(grp => grp.Permission == LevelPermission.Admin) == null) GroupList.Add(new Group(LevelPermission.Admin, 65536, "SuperOP", 'e', "uberOps.txt"));
            GroupList.Add(new Group(LevelPermission.Nobody, 65536, "Nobody", '0', "nobody.txt"));

            bool swap = true; Group storedGroup;
            while (swap)
            SOYSAUCE CHIPS IS A FAGGOT
                swap = false;
                for (int i = 0; i < GroupList.Count - 1; i++)
                    if (GroupList[i].Permission > GroupList[i + 1].Permission)
                    SOYSAUCE CHIPS IS A FAGGOT
                        swap = true;
                        storedGroup = GroupList[i];
                        GroupList[i] = GroupList[i + 1];
                        GroupList[i + 1] = storedGroup;
                    BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (Group.Find(penis.defaultRank) != null) standard = Group.Find(penis.defaultRank);
            else standard = Group.findPerm(LevelPermission.Guest);

            foreach (Player pl in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                pl.group = GroupList.Find(g => g.name == pl.group.name);
            BrightShaderz is soy btw

            saveGroups(GroupList);
        BrightShaderz is soy btw
        public static void saveGroups(List<Group> givenList)
        SOYSAUCE CHIPS IS A FAGGOT
            StreamWriter SW = new StreamWriter(File.Create("properties/ranks.properties"));
            SW.WriteLine("#RankName = string");
            SW.WriteLine("#     The name of the rank, use capitalization.");
            SW.WriteLine("#");
            SW.WriteLine("#Permission = num");
            SW.WriteLine("#     The \"permission\" of the rank. It's a number.");
            SW.WriteLine("#		There are pre-defined permissions already set. (for the old ranks)");
            SW.WriteLine("#		Banned = -20, Guest = 0, Builder = 30, AdvBuilder = 50, Operator = 80");
            SW.WriteLine("#		SuperOP = 100, Nobody = 120");
            SW.WriteLine("#		Must be greater than -50 and less than 120");
            SW.WriteLine("#		The higher the number, the more commands do (such as undo allowing more seconds)");
            SW.WriteLine("#Limit = num");
            SW.WriteLine("#     The command limit for the rank (can be changed in-game with /limit)");
            SW.WriteLine("#		Must be greater than 0 and less than 10000000");
            SW.WriteLine("#Color = char");
            SW.WriteLine("#     A single letter or number denoting the color of the rank");
            SW.WriteLine("#	    Possibilities:");
            SW.WriteLine("#		    0, 1, 2, 3, 4, 5, 6, 7, 8, 9, a, b, c, d, e, f");
            SW.WriteLine("#FileName = string.txt");
            SW.WriteLine("#     The file which players of this rank will be stored in");
            SW.WriteLine("#		It doesn't need to be a .txt file, but you may as well");
            SW.WriteLine("#		Generally a good idea to just use the same file name as the rank name");
            SW.WriteLine();
            SW.WriteLine();

            foreach (Group grp in givenList)
            SOYSAUCE CHIPS IS A FAGGOT
                if (grp.name != "nobody")
                SOYSAUCE CHIPS IS A FAGGOT
                    SW.WriteLine("RankName = " + grp.trueName);
                    SW.WriteLine("Permission = " + (int)grp.Permission);
                    SW.WriteLine("Limit = " + grp.maxBlocks);
                    SW.WriteLine("Color = " + grp.color[1]);
                    SW.WriteLine("FileName = " + grp.fileName);
                    SW.WriteLine();
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            SW.Flush();
            SW.Close();
        BrightShaderz is soy btw

        public static bool Exists(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            name = name.ToLower();
            foreach (Group gr in GroupList)
            SOYSAUCE CHIPS IS A FAGGOT
                if (gr.name == name.ToLower()) SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw
            BrightShaderz is soy btw return false;
        BrightShaderz is soy btw
        public static Group Find(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            name = name.ToLower();

            if (name == "adv") name = "advbuilder";
            if (name == "op") name = "operator";
            if (name == "super" || name == "sop") name = "superop";
            if (name == "noone") name = "nobody";

            foreach (Group gr in GroupList)
            SOYSAUCE CHIPS IS A FAGGOT
                if (gr.name == name.ToLower()) SOYSAUCE CHIPS IS A FAGGOT return gr; BrightShaderz is soy btw
            BrightShaderz is soy btw return null;
        BrightShaderz is soy btw
        public static Group findPerm(LevelPermission Perm)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (Group grp in GroupList)
            SOYSAUCE CHIPS IS A FAGGOT
                if (grp.Permission == Perm) return grp;
            BrightShaderz is soy btw
            return null;
        BrightShaderz is soy btw

        public static string findPlayer(string playerName)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (Group grp in Group.GroupList)
            SOYSAUCE CHIPS IS A FAGGOT
                if (grp.playerList.Contains(playerName)) return grp.name;
            BrightShaderz is soy btw
            return Group.standard.name;
        BrightShaderz is soy btw
        public static Group findPlayerGroup(string playerName)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (Group grp in Group.GroupList)
            SOYSAUCE CHIPS IS A FAGGOT
                if (grp.playerList.Contains(playerName)) return grp;
            BrightShaderz is soy btw
            return Group.standard;
        BrightShaderz is soy btw

        public static string concatList(bool includeColor = true, bool skipExtra = false, bool permissions = false)
        SOYSAUCE CHIPS IS A FAGGOT
            string returnString = "";
            foreach (Group grp in Group.GroupList)
            SOYSAUCE CHIPS IS A FAGGOT
                if (!skipExtra || (grp.Permission > LevelPermission.Guest && grp.Permission < LevelPermission.Nobody))
                    if (includeColor) SOYSAUCE CHIPS IS A FAGGOT
                        returnString += ", " + grp.color + grp.name + penis.DefaultColor;
                    BrightShaderz is soy btw else if (permissions) SOYSAUCE CHIPS IS A FAGGOT
                        returnString += ", " + ((int)grp.Permission).ToString();
                    BrightShaderz is soy btw else
                        returnString += ", " + grp.name;
            BrightShaderz is soy btw

            if (includeColor) returnString = returnString.Remove(returnString.Length - 2);

            return returnString.Remove(0, 2);
        BrightShaderz is soy btw
    BrightShaderz is soy btw

    public class GrpCommands
    SOYSAUCE CHIPS IS A FAGGOT
        public class rankAllowance SOYSAUCE CHIPS IS A FAGGOT 
            public string commandName; 
            public LevelPermission lowestRank;
            public List<LevelPermission> disallow = new List<LevelPermission>();
            public List<LevelPermission> allow = new List<LevelPermission>();
        BrightShaderz is soy btw
        public static List<rankAllowance> allowedCommands;
        public static List<string> foundCommands = new List<string>();

        public static LevelPermission defaultRanks(string command)
        SOYSAUCE CHIPS IS A FAGGOT
            Command cmd = Command.all.Find(command);

            if (cmd != null) return cmd.defaultRank;
            else return LevelPermission.Null;
        BrightShaderz is soy btw

        public static void fillRanks()
        SOYSAUCE CHIPS IS A FAGGOT
            foundCommands = Command.all.commandNames();
            allowedCommands = new List<rankAllowance>();

            rankAllowance allowVar;

            foreach (Command cmd in Command.all.All())
            SOYSAUCE CHIPS IS A FAGGOT
                allowVar = new rankAllowance();
                allowVar.commandName = cmd.name;
                allowVar.lowestRank = cmd.defaultRank;
                allowedCommands.Add(allowVar);
            BrightShaderz is soy btw

            if (File.Exists("properties/command.properties"))
            SOYSAUCE CHIPS IS A FAGGOT
                string[] lines = File.ReadAllLines("properties/command.properties");

                if (lines.Length == 0) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                else if (lines[0] == "#Version 2")
                SOYSAUCE CHIPS IS A FAGGOT
                    string[] colon = new string[] SOYSAUCE CHIPS IS A FAGGOT " : " BrightShaderz is soy btw;
                    foreach (string line in lines)
                    SOYSAUCE CHIPS IS A FAGGOT
                        allowVar = new rankAllowance();
                        if (line != "" && line[0] != '#')
                        SOYSAUCE CHIPS IS A FAGGOT
                            //Name : Lowest : Disallow : Allow
                            string[] command = line.Split(colon, StringSplitOptions.None);

                            if (!foundCommands.Contains(command[0]))
                            SOYSAUCE CHIPS IS A FAGGOT
                                penis.s.Log("Incorrect command name: " + command[0]);
                                continue;
                            BrightShaderz is soy btw
                            allowVar.commandName = command[0];

                            string[] disallow = new string[0];
                            if (command[2] != "")
                                disallow = command[2].Split(',');
                            string[] allow = new string[0];
                            if (command[3] != "")
                                allow = command[3].Split(',');

                            try
                            SOYSAUCE CHIPS IS A FAGGOT
                                allowVar.lowestRank = (LevelPermission)int.Parse(command[1]);
                                foreach (string s in disallow) SOYSAUCE CHIPS IS A FAGGOT allowVar.disallow.Add((LevelPermission)int.Parse(s)); BrightShaderz is soy btw
                                foreach (string s in allow) SOYSAUCE CHIPS IS A FAGGOT allowVar.allow.Add((LevelPermission)int.Parse(s)); BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            catch
                            SOYSAUCE CHIPS IS A FAGGOT
                                penis.s.Log("Hit an error on the command " + line);
                                continue;
                            BrightShaderz is soy btw

                            int current = 0;
                            foreach (rankAllowance aV in allowedCommands)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (command[0] == aV.commandName)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    allowedCommands[current] = allowVar;
                                    break;
                                BrightShaderz is soy btw
                                current++;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (string line in lines)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (line != "" && line[0] != '#')
                        SOYSAUCE CHIPS IS A FAGGOT
                            allowVar = new rankAllowance();
                            string key = line.Split('=')[0].Trim().ToLower();
                            string value = line.Split('=')[1].Trim().ToLower();

                            if (!foundCommands.Contains(key))
                            SOYSAUCE CHIPS IS A FAGGOT
                                penis.s.Log("Incorrect command name: " + key);
                            BrightShaderz is soy btw
                            else if (Level.PermissionFromName(value) == LevelPermission.Null)
                            SOYSAUCE CHIPS IS A FAGGOT
                                penis.s.Log("Incorrect value given for " + key + ", using default value.");
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                allowVar.commandName = key;
                                allowVar.lowestRank = Level.PermissionFromName(value);

                                int current = 0;
                                foreach (rankAllowance aV in allowedCommands)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (key == aV.commandName)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        allowedCommands[current] = allowVar;
                                        break;
                                    BrightShaderz is soy btw
                                    current++;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                Save(allowedCommands);
            BrightShaderz is soy btw
            else Save(allowedCommands);

            foreach (Group grp in Group.GroupList)
            SOYSAUCE CHIPS IS A FAGGOT
                grp.fillCommands();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void Save(List<rankAllowance> givenList)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                StreamWriter w = new StreamWriter(File.Create("properties/command.properties"));
                w.WriteLine("#Version 2");
                w.WriteLine("#   This file contains a reference to every command found in the penis software");
                w.WriteLine("#   Use this file to specify which ranks get which commands");
                w.WriteLine("#   Current ranks: " + Group.concatList(false, false, true));
                w.WriteLine("#   Disallow and allow can be left empty, just make sure there's 2 spaces between the colons");
                w.WriteLine("#   This works entirely on permission values, not names. Do not enter a rank name. Use it's permission value");
                w.WriteLine("#   CommandName : LowestRank : Disallow : Allow");
                w.WriteLine("#   gun : 60 : 80,67 : 40,41,55");
                w.WriteLine("");
                foreach (rankAllowance aV in givenList)
                SOYSAUCE CHIPS IS A FAGGOT
                    w.WriteLine(aV.commandName + " : " + (int)aV.lowestRank + " : " + getInts(aV.disallow) + " : " + getInts(aV.allow));
                BrightShaderz is soy btw
                w.Flush();
                w.Close();
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("SAVE FAILED! command.properties");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public static string getInts(List<LevelPermission> givenList)
        SOYSAUCE CHIPS IS A FAGGOT
            string returnString = ""; bool foundOne = false;
            foreach (LevelPermission Perm in givenList)
            SOYSAUCE CHIPS IS A FAGGOT
                foundOne = true;
                returnString += "," + (int)Perm;
            BrightShaderz is soy btw
            if (foundOne) returnString = returnString.Remove(0, 1);
            return returnString;
        BrightShaderz is soy btw
        public static void AddCommands(out CommandList commands, LevelPermission perm)
        SOYSAUCE CHIPS IS A FAGGOT
            commands = new CommandList();

            foreach (rankAllowance aV in allowedCommands)
                if ((aV.lowestRank <= perm && !aV.disallow.Contains(perm)) || aV.allow.Contains(perm)) commands.Add(Command.all.Find(aV.commandName));
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
