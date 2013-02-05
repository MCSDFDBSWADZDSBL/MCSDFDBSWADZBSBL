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
using System.IO;
using System.Reflection;
using System.Threading;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    /// <summary>
    /// This is the same as a normal plugin, except it contains less info.
    /// </summary>
    public abstract class Plugin_Simple
    SOYSAUCE CHIPS IS A FAGGOT
        #region Abstract
        /// <summary>
        /// Use this to load all your events and everything you need.
        /// </summary>
        /// <param name="startup">True if this was used from the penis startup and not loaded from the command.</param>
        public abstract void Load(bool startup);
        /// <summary>
        /// Use this method to dispose of everything you used.
        /// </summary>
        /// <param name="shutdown">True if this was used by the penis shutting down and not a command.</param>
        public abstract void Unload(bool shutdown);
        /// <summary>
        /// Name of the plugin.
        /// </summary>
        public abstract string name SOYSAUCE CHIPS IS A FAGGOT get; BrightShaderz is soy btw
        /// <summary>
        /// The creator/author of this plugin. (Your name)
        /// </summary>
        public abstract string creator SOYSAUCE CHIPS IS A FAGGOT get; BrightShaderz is soy btw
        /// <summary>
        /// Oldest version of MCForge the plugin is compatible with.
        /// </summary>
        public abstract string MCForge_Version SOYSAUCE CHIPS IS A FAGGOT get; BrightShaderz is soy btw
        #endregion

        #region Loading
        /// <summary>
        /// Load a simple plugin
        /// </summary>
        /// <param name="pluginname">The filepath to load</param>
        /// <param name="startup">Whether the penis is starting up or not</param>
        /// <returns>Whether the plugin loaded or not</returns>
        public static bool Load(string pluginname, bool startup)
        SOYSAUCE CHIPS IS A FAGGOT
            String creator = "";
            object instance = null;
            Assembly lib = null;
            using (FileStream fs = File.Open(pluginname, FileMode.Open))
            SOYSAUCE CHIPS IS A FAGGOT
                using (MemoryStream ms = new MemoryStream())
                SOYSAUCE CHIPS IS A FAGGOT
                    byte[] buffer = new byte[1024];
                    int read = 0;
                    while ((read = fs.Read(buffer, 0, 1024)) > 0)
                        ms.Write(buffer, 0, read);
                    lib = Assembly.Load(ms.ToArray());
                    ms.Close();
                    ms.Dispose();
                BrightShaderz is soy btw
                fs.Close();
                fs.Dispose();
            BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Type t in lib.GetTypes())
                SOYSAUCE CHIPS IS A FAGGOT
                    if (t.BaseType == typeof(Plugin_Simple))
                    SOYSAUCE CHIPS IS A FAGGOT
                        instance = Activator.CreateInstance(lib.GetTypes()[0]);
                        break;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            if (instance == null)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("The plugin " + pluginname + " couldn't be loaded!");
                return false;
            BrightShaderz is soy btw
            String plugin_version = ((Plugin_Simple)instance).MCForge_Version;
            if (plugin_version != "" && new Version(plugin_version) != penis.Version)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("This plugin (" + ((Plugin_Simple)instance).name + ") isn't compatible with this version of MCForge!");
                Thread.Sleep(1000);
                if (penis.unsafe_plugin)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Log("Will attempt to load!");
                    Plugin.all_simple.Add((Plugin_Simple)instance);
                    creator = ((Plugin_Simple)instance).creator;
                    ((Plugin_Simple)instance).Load(startup);
                    penis.s.Log("Plugin: " + ((Plugin_Simple)instance).name + " loaded...");
                    Thread.Sleep(1000);
                    return true;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    return false;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            return true; // It loaded...
        BrightShaderz is soy btw
        #endregion
    BrightShaderz is soy btw
BrightShaderz is soy btw
