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
using System.IO;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class PlayerList
    SOYSAUCE CHIPS IS A FAGGOT
        //public string name;
        public Group group;
        List<string> players = new List<string>();
        public PlayerList() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public void Add(string p) SOYSAUCE CHIPS IS A FAGGOT players.Add(p.ToLower()); BrightShaderz is soy btw
        public bool Remove(string p)
        SOYSAUCE CHIPS IS A FAGGOT
            return players.Remove(p.ToLower());
        BrightShaderz is soy btw
        public bool Contains(string p) SOYSAUCE CHIPS IS A FAGGOT return players.Contains(p.ToLower()); BrightShaderz is soy btw
        public List<string> All() SOYSAUCE CHIPS IS A FAGGOT return new List<string>(players); BrightShaderz is soy btw
        public void Save(string path) SOYSAUCE CHIPS IS A FAGGOT Save(path, true); BrightShaderz is soy btw
        public void Save() SOYSAUCE CHIPS IS A FAGGOT
            Save(group.fileName); 
        BrightShaderz is soy btw
        public void Save(string path, bool console)
        SOYSAUCE CHIPS IS A FAGGOT
            StreamWriter file = File.CreateText("ranks/" + path);
            players.ForEach(delegate(string p) SOYSAUCE CHIPS IS A FAGGOT file.WriteLine(p); BrightShaderz is soy btw);
            file.Close(); if (console) SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("SAVED: " + path); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public static PlayerList Load(string path, Group groupName)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!Directory.Exists("ranks")) SOYSAUCE CHIPS IS A FAGGOT Directory.CreateDirectory("ranks"); BrightShaderz is soy btw
            path = "ranks/" + path;
            PlayerList list = new PlayerList();
            list.group = groupName;
            if (File.Exists(path))
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (string line in File.ReadAllLines(path)) SOYSAUCE CHIPS IS A FAGGOT list.Add(line); BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                File.Create(path).Close();
                penis.s.Log("CREATED NEW: " + path);
            BrightShaderz is soy btw return list;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
