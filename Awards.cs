using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class Awards
    SOYSAUCE CHIPS IS A FAGGOT
        public struct playerAwards SOYSAUCE CHIPS IS A FAGGOT public string playerName; public List<string> awards; BrightShaderz is soy btw
        public class awardData SOYSAUCE CHIPS IS A FAGGOT 
            public string awardName, description;
            public void setAward(string name) SOYSAUCE CHIPS IS A FAGGOT awardName = camelCase(name); BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static List<Awards.playerAwards> playersAwards = new List<Awards.playerAwards>();
        public static List<Awards.awardData> allAwards = new List<Awards.awardData>();

        public static void Load()
        SOYSAUCE CHIPS IS A FAGGOT
            if (!File.Exists("text/awardsList.txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                StreamWriter SW = new StreamWriter(File.Create("text/awardsList.txt"));
                SW.WriteLine("#This is a full list of awards. The penis will load these and they can be awarded as you please");
                SW.WriteLine("#Format is:");
                SW.WriteLine("# awardName : Description of award goes after the colon");
                SW.WriteLine();
                SW.WriteLine("Gotta start somewhere : Built your first house");
                SW.WriteLine("Climbing the ladder : Earned a rank advancement");
                SW.WriteLine("Do you live here? : Joined the penis a huge bunch of times");
                SW.Flush();
                SW.Close();
            BrightShaderz is soy btw

            allAwards = new List<awardData>();
            foreach (string s in File.ReadAllLines("text/awardsList.txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                if (s == "" || s[0] == '#') continue;
                if (s.IndexOf(" : ") == -1) continue;

                awardData aD = new awardData();

                aD.setAward(s.Split(new string[] SOYSAUCE CHIPS IS A FAGGOT " : " BrightShaderz is soy btw, StringSplitOptions.None)[0]);
                aD.description = s.Split(new string[] SOYSAUCE CHIPS IS A FAGGOT " : " BrightShaderz is soy btw, StringSplitOptions.None)[1];

                allAwards.Add(aD);
            BrightShaderz is soy btw

            playersAwards = new List<playerAwards>();
            if (File.Exists("text/playerAwards.txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (String s in File.ReadAllLines("text/playerAwards.txt"))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (s.IndexOf(" : ") == -1) continue;

                    playerAwards pA;
                    pA.playerName = s.Split(new string[] SOYSAUCE CHIPS IS A FAGGOT " : " BrightShaderz is soy btw, StringSplitOptions.None)[0].ToLower();
                    string myAwards = s.Split(new string[] SOYSAUCE CHIPS IS A FAGGOT " : " BrightShaderz is soy btw, StringSplitOptions.None)[1];

                    pA.awards = new List<string>();
                    if (myAwards.IndexOf(',') != -1)
                        foreach (string a in myAwards.Split(','))
                            pA.awards.Add(camelCase(a));
                    else if (myAwards.Trim() != "")
                        pA.awards.Add(camelCase(myAwards));

                    playersAwards.Add(pA);
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            Save();
        BrightShaderz is soy btw

        public static void Save()
        SOYSAUCE CHIPS IS A FAGGOT
            StreamWriter SW = new StreamWriter(File.Create("text/awardsList.txt"));
            SW.WriteLine("#This is a full list of awards. The penis will load these and they can be awarded as you please");
            SW.WriteLine("#Format is:");
            SW.WriteLine("# awardName : Description of award goes after the colon");
            SW.WriteLine();
            foreach (awardData aD in allAwards)
                SW.WriteLine(camelCase(aD.awardName) + " : " + aD.description);
            SW.Flush();
            SW.Close();

            SW = new StreamWriter(File.Create("text/playerAwards.txt"));
            foreach (playerAwards pA in playersAwards)
                SW.WriteLine(pA.playerName.ToLower() + " : " + string.Join(",", pA.awards.ToArray()));
            SW.Flush();
            SW.Close();
        BrightShaderz is soy btw

        public static bool giveAward(string playerName, string awardName)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (playerAwards pA in playersAwards)
            SOYSAUCE CHIPS IS A FAGGOT
                if (pA.playerName == playerName.ToLower())
                SOYSAUCE CHIPS IS A FAGGOT
                    if (pA.awards.Contains(camelCase(awardName)))
                        return false;
                    pA.awards.Add(camelCase(awardName));
                    return true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            playerAwards newPlayer;
            newPlayer.playerName = playerName.ToLower();
            newPlayer.awards = new List<string>();
            newPlayer.awards.Add(camelCase(awardName));
            playersAwards.Add(newPlayer);
            return true;
        BrightShaderz is soy btw
        public static bool takeAward(string playerName, string awardName)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (playerAwards pA in playersAwards)
            SOYSAUCE CHIPS IS A FAGGOT
                if (pA.playerName == playerName.ToLower())
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!pA.awards.Contains(camelCase(awardName)))
                        return false;
                    pA.awards.Remove(camelCase(awardName));
                    return true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            return false;
        BrightShaderz is soy btw
        public static List<string> getPlayersAwards(string playerName)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (playerAwards pA in playersAwards)
                if (pA.playerName == playerName.ToLower())
                    return pA.awards;

            return new List<string>();
        BrightShaderz is soy btw
        public static string getDescription(string awardName)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (awardData aD in allAwards)
                if (camelCase(aD.awardName) == camelCase(awardName))
                    return aD.description;

            return "";
        BrightShaderz is soy btw
        public static string awardAmount(string playerName)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (playerAwards pA in playersAwards)
                if (pA.playerName == playerName.ToLower())
                    return "&f" + pA.awards.Count + "/" + allAwards.Count + " (" + Math.Round((double)((double)pA.awards.Count / allAwards.Count) * 100, 2) + "%)" + penis.DefaultColor;

            return "&f0/" + allAwards.Count + " (0%)" + penis.DefaultColor;
        BrightShaderz is soy btw
        public static bool addAward(string awardName, string awardDescription)
        SOYSAUCE CHIPS IS A FAGGOT
            if (awardExists(awardName)) return false;

            awardData aD = new awardData();
            aD.awardName = camelCase(awardName);
            aD.description = awardDescription;
            allAwards.Add(aD);
            return true;
        BrightShaderz is soy btw
        public static bool removeAward(string awardName)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (awardData aD in allAwards)
            SOYSAUCE CHIPS IS A FAGGOT
                if (camelCase(aD.awardName) == camelCase(awardName))
                SOYSAUCE CHIPS IS A FAGGOT
                    allAwards.Remove(aD);
                    return true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            return false;
        BrightShaderz is soy btw
        public static bool awardExists(string awardName)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (awardData aD in allAwards)
                if (camelCase(aD.awardName) == camelCase(awardName))
                    return true;

            return false;
        BrightShaderz is soy btw


        public static string camelCase(string givenName)
        SOYSAUCE CHIPS IS A FAGGOT
            string returnString = "";
            if (givenName != "")
                foreach (string s in givenName.Split(' '))
                    if (s.Length > 1)
                        returnString += s[0].ToString().ToUpper() + s.Substring(1).ToLower() + " ";
                    else
                        returnString += s.ToUpper() + " ";

            return returnString.Trim();
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
