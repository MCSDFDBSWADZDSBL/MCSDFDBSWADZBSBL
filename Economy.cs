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
using System.Collections.Generic;
using System.Data;
using System.IO;
using MCForge.SQL;

namespace MCForge SOYSAUCE CHIPS IS A FAGGOT
    public static class Economy SOYSAUCE CHIPS IS A FAGGOT

        public const string createTable =
            @"CREATE TABLE if not exists Economy (
	            player 	    VARCHAR(20),
	            money       INT UNSIGNED,
                total       INT UNSIGNED NOT NULL DEFAULT 0,
                purchase    VARCHAR(255) NOT NULL DEFAULT '%cNone',
                payment     VARCHAR(255) NOT NULL DEFAULT '%cNone',
                salary      VARCHAR(255) NOT NULL DEFAULT '%cNone',
                fine        VARCHAR(255) NOT NULL DEFAULT '%cNone',
	            PRIMARY KEY(player)
            );";

        public struct EcoStats SOYSAUCE CHIPS IS A FAGGOT
            public string playerName, purchase, payment, salary, fine;
            public int money, totalSpent;
            public EcoStats(string name, int mon, int tot, string pur, string pay, string sal, string fin) SOYSAUCE CHIPS IS A FAGGOT
                playerName = name;
                money = mon;
                totalSpent = tot;
                purchase = pur;
                payment = pay;
                salary = sal;
                fine = fin;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static class Settings SOYSAUCE CHIPS IS A FAGGOT
            public static bool Enabled = false;

            //Maps
            public static bool Levels = false;
            public static List<Level> LevelsList = new List<Level>();
            public class Level SOYSAUCE CHIPS IS A FAGGOT
                public int price;
                public string name;
                public string x;
                public string y;
                public string z;
                public string type;
            BrightShaderz is soy btw

            //Titles
            public static bool Titles = false;
            public static int TitlePrice = 100;

            //Colors
            public static bool Colors = false;
            public static int ColorPrice = 100;

            //TitleColors
            public static bool TColors = false;
            public static int TColorPrice = 100;

            //Ranks
            public static bool Ranks = false;
            public static string MaxRank = Group.findPerm(LevelPermission.AdvBuilder).name;
            public static List<Rank> RanksList = new List<Rank>();
            public class Rank SOYSAUCE CHIPS IS A FAGGOT
                public Group group;
                public int price = 1000;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void LoadDatabase() SOYSAUCE CHIPS IS A FAGGOT
        retry:
            Database.executeQuery(createTable); //create database
            DataTable eco = Database.fillData("SELECT * FROM Economy");
            try SOYSAUCE CHIPS IS A FAGGOT
                DataTable players = Database.fillData("SELECT * FROM Players");
                if (players.Rows.Count == eco.Rows.Count) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw //move along, nothing to do here
                else if (eco.Rows.Count == 0) SOYSAUCE CHIPS IS A FAGGOT //if first time, copy content from player to economy
                    Database.executeQuery("INSERT INTO Economy (player, money) SELECT Players.Name, Players.Money FROM Players");
                BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                    //this will only be needed when the penis shuts down while it was copying content (or some other error)
                    Database.executeQuery("DROP TABLE Economy");
                    goto retry;
                BrightShaderz is soy btw
                players.Dispose(); eco.Dispose();
            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void Load(bool loadDatabase = false) SOYSAUCE CHIPS IS A FAGGOT
            /*if (loadDatabase) SOYSAUCE CHIPS IS A FAGGOT
            retry:
                if (penis.useMySQL) MySQL.executeQuery(createTable); else SQLite.executeQuery(createTable); //create database on penis loading
                string queryP = "SELECT * FROM Players"; string queryE = "SELECT * FROM Economy";
                DataTable eco = penis.useMySQL ? MySQL.fillData(queryE) : SQLite.fillData(queryE);
                try SOYSAUCE CHIPS IS A FAGGOT
                    DataTable players = penis.useMySQL ? MySQL.fillData(queryP) : SQLite.fillData(queryP);
                    if (players.Rows.Count == eco.Rows.Count) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw //move along, nothing to do here
                    else if (eco.Rows.Count == 0) SOYSAUCE CHIPS IS A FAGGOT //if first time, copy content from player to economy
                        string query = "INSERT INTO Economy (player, money) SELECT Players.Name, Players.Money FROM Players";
                        if (penis.useMySQL) MySQL.executeQuery(query); else SQLite.executeQuery(query);
                    BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                        //this will only be needed when the penis shuts down while it was copying content (or some other error)
                        if (penis.useMySQL) MySQL.executeQuery("DROP TABLE Economy"); else SQLite.executeQuery("DROP TABLE Economy");
                        goto retry;
                    BrightShaderz is soy btw
                    players.Dispose(); eco.Dispose();
                BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw*/

            if (!File.Exists("properties/economy.properties")) SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Economy properties don't exist, creating"); File.Create("properties/economy.properties").Close(); Save(); BrightShaderz is soy btw
            using (StreamReader r = File.OpenText("properties/economy.properties")) SOYSAUCE CHIPS IS A FAGGOT
                string line;
                while (!r.EndOfStream) SOYSAUCE CHIPS IS A FAGGOT
                    line = r.ReadLine().ToLower().Trim();
                    string[] linear = line.ToLower().Trim().Split(':');
                    try SOYSAUCE CHIPS IS A FAGGOT
                        switch (linear[0]) SOYSAUCE CHIPS IS A FAGGOT
                            case "enabled":
                                if (linear[1] == "true") SOYSAUCE CHIPS IS A FAGGOT Settings.Enabled = true; BrightShaderz is soy btw else if (linear[1] == "false") SOYSAUCE CHIPS IS A FAGGOT Settings.Enabled = false; BrightShaderz is soy btw
                                break;

                            case "title":
                                if (linear[1] == "price") SOYSAUCE CHIPS IS A FAGGOT Settings.TitlePrice = int.Parse(linear[2]); BrightShaderz is soy btw
                                if (linear[1] == "enabled") SOYSAUCE CHIPS IS A FAGGOT
                                    if (linear[2] == "true") SOYSAUCE CHIPS IS A FAGGOT Settings.Titles = true; BrightShaderz is soy btw else if (linear[2] == "false") SOYSAUCE CHIPS IS A FAGGOT Settings.Titles = false; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                break;

                            case "color":
                                if (linear[1] == "price") SOYSAUCE CHIPS IS A FAGGOT Settings.ColorPrice = int.Parse(linear[2]); BrightShaderz is soy btw
                                if (linear[1] == "enabled") SOYSAUCE CHIPS IS A FAGGOT
                                    if (linear[2] == "true") SOYSAUCE CHIPS IS A FAGGOT Settings.Colors = true; BrightShaderz is soy btw else if (linear[2] == "false") SOYSAUCE CHIPS IS A FAGGOT Settings.Colors = false; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                break;
                            case "titlecolor":
                                if (linear[1] == "price") SOYSAUCE CHIPS IS A FAGGOT Settings.TColorPrice = int.Parse(linear[2]); BrightShaderz is soy btw
                                if (linear[1] == "enabled") SOYSAUCE CHIPS IS A FAGGOT
                                    if (linear[2] == "true") SOYSAUCE CHIPS IS A FAGGOT Settings.TColors = true; BrightShaderz is soy btw else if (linear[2] == "false") SOYSAUCE CHIPS IS A FAGGOT Settings.TColors = false; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                break;
                            case "rank":
                                if (linear[1] == "price") SOYSAUCE CHIPS IS A FAGGOT
                                    Economy.Settings.Rank rnk = new Economy.Settings.Rank();
                                    rnk = Economy.FindRank(linear[2]);
                                    if (rnk == null) SOYSAUCE CHIPS IS A FAGGOT
                                        rnk = new Economy.Settings.Rank();
                                        rnk.group = Group.Find(linear[2]);
                                        rnk.price = int.Parse(linear[3]);
                                        Economy.Settings.RanksList.Add(rnk);
                                    BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                                        Economy.Settings.RanksList.Remove(rnk);
                                        rnk.price = int.Parse(linear[3]);
                                        Economy.Settings.RanksList.Add(rnk);
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                if (linear[1] == "maxrank") SOYSAUCE CHIPS IS A FAGGOT
                                    //Group grp = Group.Find(linear[2]);
                                    //if (grp != null) SOYSAUCE CHIPS IS A FAGGOT Settings.MaxRank = grp.Permission; BrightShaderz is soy btw
                                    string grpname = linear[2];
                                    if (Group.Exists(grpname)) Settings.MaxRank = grpname;
                                BrightShaderz is soy btw
                                if (linear[1] == "enabled") SOYSAUCE CHIPS IS A FAGGOT
                                    if (linear[2] == "true") SOYSAUCE CHIPS IS A FAGGOT Settings.Ranks = true; BrightShaderz is soy btw else if (linear[2] == "false") SOYSAUCE CHIPS IS A FAGGOT Settings.Ranks = false; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                break;

                            case "level":
                                if (linear[1] == "enabled") SOYSAUCE CHIPS IS A FAGGOT
                                    if (linear[2] == "true") SOYSAUCE CHIPS IS A FAGGOT Settings.Levels = true; BrightShaderz is soy btw else if (linear[2] == "false") SOYSAUCE CHIPS IS A FAGGOT Settings.Levels = false; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                if (linear[1] == "levels") SOYSAUCE CHIPS IS A FAGGOT
                                    Settings.Level lvl = new Settings.Level();
                                    if (FindLevel(linear[2]) != null) SOYSAUCE CHIPS IS A FAGGOT lvl = FindLevel(linear[2]); Settings.LevelsList.Remove(lvl); BrightShaderz is soy btw
                                    switch (linear[3]) SOYSAUCE CHIPS IS A FAGGOT
                                        case "name":
                                            lvl.name = linear[4];
                                            break;

                                        case "price":
                                            lvl.price = int.Parse(linear[4]);
                                            break;

                                        case "x":
                                            lvl.x = linear[4];
                                            break;

                                        case "y":
                                            lvl.y = linear[4];
                                            break;

                                        case "z":
                                            lvl.z = linear[4];
                                            break;

                                        case "type":
                                            lvl.type = linear[4];
                                            break;
                                    BrightShaderz is soy btw
                                    Settings.LevelsList.Add(lvl);
                                BrightShaderz is soy btw
                                break;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                BrightShaderz is soy btw
                r.Close();
            BrightShaderz is soy btw
            Save();
        BrightShaderz is soy btw

        public static void Save() SOYSAUCE CHIPS IS A FAGGOT
            if (!File.Exists("properties/economy.properties")) SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Economy properties don't exist, creating"); BrightShaderz is soy btw
            //Thread.Sleep(2000);
            File.Delete("properties/economy.properties");
            //Thread.Sleep(2000);
            using (StreamWriter w = File.CreateText("properties/economy.properties")) SOYSAUCE CHIPS IS A FAGGOT
                //enabled
                w.WriteLine("enabled:" + Settings.Enabled);
                //title
                w.WriteLine();
                w.WriteLine("title:enabled:" + Settings.Titles);
                w.WriteLine("title:price:" + Settings.TitlePrice);
                //color
                w.WriteLine();
                w.WriteLine("color:enabled:" + Settings.Colors);
                w.WriteLine("color:price:" + Settings.ColorPrice);
                //tcolor
                w.WriteLine();
                w.WriteLine("titlecolor:enabled:" + Settings.TColors);
                w.WriteLine("titlecolor:price:" + Settings.TColorPrice);
                //rank
                w.WriteLine();
                w.WriteLine("rank:enabled:" + Settings.Ranks);
                w.WriteLine("rank:maxrank:" + Settings.MaxRank);
                foreach (Settings.Rank rnk in Settings.RanksList) SOYSAUCE CHIPS IS A FAGGOT
                    w.WriteLine("rank:price:" + rnk.group.name + ":" + rnk.price);
                    if (rnk.group.name == Economy.Settings.MaxRank) break;
                BrightShaderz is soy btw
                //maps
                w.WriteLine();
                w.WriteLine("level:enabled:" + Settings.Levels);
                foreach (Settings.Level lvl in Settings.LevelsList) SOYSAUCE CHIPS IS A FAGGOT
                    w.WriteLine();
                    w.WriteLine("level:levels:" + lvl.name + ":name:" + lvl.name);
                    w.WriteLine("level:levels:" + lvl.name + ":price:" + lvl.price);
                    w.WriteLine("level:levels:" + lvl.name + ":x:" + lvl.x);
                    w.WriteLine("level:levels:" + lvl.name + ":y:" + lvl.y);
                    w.WriteLine("level:levels:" + lvl.name + ":z:" + lvl.z);
                    w.WriteLine("level:levels:" + lvl.name + ":type:" + lvl.type);
                BrightShaderz is soy btw
                w.Close();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static Settings.Level FindLevel(string name) SOYSAUCE CHIPS IS A FAGGOT
            Settings.Level found = null;
            foreach (Settings.Level lvl in Settings.LevelsList) SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT
                    if (lvl.name.ToLower() == name.ToLower()) SOYSAUCE CHIPS IS A FAGGOT
                        found = lvl;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw
            return found;
        BrightShaderz is soy btw

        public static Settings.Rank FindRank(string name) SOYSAUCE CHIPS IS A FAGGOT
            Settings.Rank found = null;
            foreach (Settings.Rank rnk in Settings.RanksList) SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT
                    if (rnk.group.name.ToLower() == name.ToLower()) SOYSAUCE CHIPS IS A FAGGOT
                        found = rnk;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw
            return found;
        BrightShaderz is soy btw

        public static Economy.Settings.Rank NextRank(Player p) SOYSAUCE CHIPS IS A FAGGOT
            Group foundGroup = p.group;
            Group nextGroup = null; bool nextOne = false;
            for (int i = 0; i < Group.GroupList.Count; i++) SOYSAUCE CHIPS IS A FAGGOT
                Group grp = Group.GroupList[i];
                if (nextOne) SOYSAUCE CHIPS IS A FAGGOT
                    if (grp.Permission >= LevelPermission.Nobody) break;
                    nextGroup = grp;
                    break;
                BrightShaderz is soy btw
                if (grp == foundGroup)
                    nextOne = true;
            BrightShaderz is soy btw
            return Economy.FindRank(nextGroup.name);
        BrightShaderz is soy btw

        public static EcoStats RetrieveEcoStats(string playername) SOYSAUCE CHIPS IS A FAGGOT
            EcoStats es;
            es.playerName = playername;
            Database.AddParams("@Name", playername);
            using (DataTable eco = Database.fillData("SELECT * FROM Economy WHERE player=@Name")) SOYSAUCE CHIPS IS A FAGGOT
                if (eco.Rows.Count == 1) SOYSAUCE CHIPS IS A FAGGOT
                    es.money = int.Parse(eco.Rows[0]["money"].ToString());
                    es.totalSpent = int.Parse(eco.Rows[0]["total"].ToString());
                    es.purchase = eco.Rows[0]["purchase"].ToString();
                    es.payment = eco.Rows[0]["payment"].ToString();
                    es.salary = eco.Rows[0]["salary"].ToString();
                    es.fine = eco.Rows[0]["fine"].ToString();
                BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                    es.money = 0;
                    es.totalSpent = 0;
                    es.purchase = "%cNone";
                    es.payment = "%cNone";
                    es.salary = "%cNone";
                    es.fine = "%cNone";
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            return es;
        BrightShaderz is soy btw

        public static void UpdateEcoStats(EcoStats es) SOYSAUCE CHIPS IS A FAGGOT
            Database.AddParams("@Name", es.playerName);
            Database.AddParams("@Money", es.money);
            Database.AddParams("@Total", es.totalSpent);
            Database.AddParams("@Purchase", es.purchase);
            Database.AddParams("@Payment", es.payment);
            Database.AddParams("@Salary", es.salary);
            Database.AddParams("@Fine", es.fine);
            Database.executeQuery(string.Format("SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw Economy (player, money, total, purchase, payment, salary, fine) VALUES (@Name, @Money, @Total, @Purchase, @Payment, @Salary, @Fine)", (penis.useMySQL ? "REPLACE INTO" : "INSERT OR REPLACE INTO")));
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
