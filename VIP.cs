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
using System.IO;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public static class VIP
    SOYSAUCE CHIPS IS A FAGGOT
        public static readonly string file = "text/vips.txt"; //this file is never even created anywhere..

        public static void Add(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!File.Exists(file)) return;
            name = name.Trim().ToLower();
            List<string> list = new List<string>(File.ReadAllLines(file));
            list.Add(name);
            File.WriteAllLines(file, list.ToArray());
        BrightShaderz is soy btw
        /// <summary>
        /// Adds a Player to VIP's
        /// </summary>
        /// <param name="p">the Player to add</param>
        public static void Add(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Add(p.name);
        BrightShaderz is soy btw

        public static void Remove(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!File.Exists(file)) return;
            name = name.Trim().ToLower();
            List<string> list = new List<string>();
            foreach (string line in File.ReadAllLines(file))
                if (line.Trim().ToLower() != name)
                    list.Add(line);
            File.WriteAllLines(file, list.ToArray());
        BrightShaderz is soy btw
        public static void Remove(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Remove(p.name);
        BrightShaderz is soy btw

        public static bool Find(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!File.Exists(file)) return false;
            name = name.Trim().ToLower();
            foreach (string line in File.ReadAllLines(file))
                if (line.Trim().ToLower() == name)
                    return true;
            return false;
        BrightShaderz is soy btw
        public static bool Find(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            return Find(p.name);
        BrightShaderz is soy btw

        public static List<string> GetAll()
        SOYSAUCE CHIPS IS A FAGGOT
            if (File.Exists(file))
                return new List<string>(File.ReadAllLines(file));
            return new List<string>();
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
