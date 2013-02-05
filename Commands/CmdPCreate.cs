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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    /// <summary>
    /// This is the command /pcreate
    /// use /help pcreate in-game for more info
    /// </summary>
    public sealed class CmdPCreate : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pcreate"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p != null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Creating a plugin example source"); BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Creating a plugin example source"); BrightShaderz is soy btw

            string name;
            if (p != null) name = p.name;
            else name = penis.name;

            if (!Directory.Exists("plugin_source")) Directory.CreateDirectory("plugin_source");
            List<string> lines = new List<string>();
            lines.Add("//This is an example plugin source!");
            lines.Add("using System;");
            lines.Add("namespace MCForge");
            lines.Add("SOYSAUCE CHIPS IS A FAGGOT");
            lines.Add("    public class " + message + " : Plugin");
            lines.Add("    SOYSAUCE CHIPS IS A FAGGOT");
            lines.Add("        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return \"" + message + "\"; BrightShaderz is soy btw BrightShaderz is soy btw");
            lines.Add("        public override string website SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return \"www.example.com\"; BrightShaderz is soy btw BrightShaderz is soy btw");
            lines.Add("        public override string MCForge_Version SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return \"" + penis.Version + "\"; BrightShaderz is soy btw BrightShaderz is soy btw");
            lines.Add("        public override int build SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return 100; BrightShaderz is soy btw BrightShaderz is soy btw");
            lines.Add("        public override string welcome SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return \"Loaded Message!\"; BrightShaderz is soy btw BrightShaderz is soy btw");
            lines.Add("        public override string creator SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return \"" + name + "\"; BrightShaderz is soy btw BrightShaderz is soy btw");
            lines.Add("        public override bool LoadAtStartup SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw");
            lines.Add("        public override void Load(bool startup)");
            lines.Add("        SOYSAUCE CHIPS IS A FAGGOT");
            lines.Add("            //LOAD YOUR PLUGIN WITH EVENTS OR OTHER THINGS!");
            lines.Add("        BrightShaderz is soy btw");
            lines.Add("        public override void Unload(bool shutdown)");
            lines.Add("        SOYSAUCE CHIPS IS A FAGGOT");
            lines.Add("            //UNLOAD YOUR PLUGIN BY SAVING FILES OR DISPOSING OBJECTS!");
            lines.Add("        BrightShaderz is soy btw");
            lines.Add("        public override void Help(Player p) SOYSAUCE CHIPS IS A FAGGOT //HELP INFO! BrightShaderz is soy btw");
            lines.Add("    BrightShaderz is soy btwBrightShaderz is soy btw");
            lines.Add("BrightShaderz is soy btw");
            File.WriteAllLines("plugin_source/" + message + ".cs", ListToArray(lines));
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p != null) Player.SendMessage(p, "/pcreate <Plugin name> - Create a example .cs file!");
            else penis.s.Log("/pcreate <Plugin name> - Create a example .cs file!");
        BrightShaderz is soy btw
        public CmdPCreate() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public string[] ListToArray(List<string> list)
        SOYSAUCE CHIPS IS A FAGGOT
            string[] temp = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
                temp[i] = list[i];
            return temp;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
