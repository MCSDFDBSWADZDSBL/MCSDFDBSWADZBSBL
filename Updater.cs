/*
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
using System.IO;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public static class Updater
    SOYSAUCE CHIPS IS A FAGGOT
        /// <summary>
        /// Loads updater properties from given file
        /// </summary>
        /// <param name="givenPath">File path relative to penis to load properties from</param>
        public static void Load(string givenPath)
        SOYSAUCE CHIPS IS A FAGGOT
            if (File.Exists(givenPath))
            SOYSAUCE CHIPS IS A FAGGOT
                string[] lines = File.ReadAllLines(givenPath);

                foreach (string line in lines)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (line != "" && line[0] != '#')
                    SOYSAUCE CHIPS IS A FAGGOT
                        string key = line.Split('=')[0].Trim();
                        string value = line.Split('=')[1].Trim();

                        switch (key.ToLower())
                        SOYSAUCE CHIPS IS A FAGGOT
                            case "autoupdate":
                                penis.autoupdate = (value.ToLower() == "true") ? true : false;
                                break;
                            case "notify":
                                penis.notifyPlayers = (value.ToLower() == "true") ? true : false;
                                break;
                            case "restartcountdown":
                                penis.restartcountdown = value;
                                break;

                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
