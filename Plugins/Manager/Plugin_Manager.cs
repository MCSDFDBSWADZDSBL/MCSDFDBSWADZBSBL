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
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    /// <summary>
    /// This class provides for more advanced modification to MCForge
    /// </summary>
    public abstract partial class Plugin
    SOYSAUCE CHIPS IS A FAGGOT
        #region Static Variables
        /// <summary>
        /// List of all plugins.
        /// </summary>
        public static List<Plugin> all = new List<Plugin>();
        /// <summary>
        /// List of all simple plugins.
        /// </summary>
        public static List<Plugin_Simple> all_simple = new List<Plugin_Simple>();
        #endregion

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
        /// This method is runned when a player does /help <pluginame>
        /// Use it to show player's what this command is about.
        /// </summary>
        /// <param name="p">Player who runned this command.</param>
        public abstract void Help(Player p);
        /// <summary>
        /// Name of the plugin.
        /// </summary>
        public abstract string name SOYSAUCE CHIPS IS A FAGGOT get; BrightShaderz is soy btw
        /// <summary>
        /// Your website.
        /// </summary>
        public abstract string website SOYSAUCE CHIPS IS A FAGGOT get; BrightShaderz is soy btw
        /// <summary>
        /// Oldest version of MCForge the plugin is compatible with.
        /// </summary>
        public abstract string MCForge_Version SOYSAUCE CHIPS IS A FAGGOT get; BrightShaderz is soy btw
        /// <summary>
        /// Version of your plugin.
        /// </summary>
        public abstract int build SOYSAUCE CHIPS IS A FAGGOT get; BrightShaderz is soy btw
        /// <summary>
        /// Message to display once plugin is loaded.
        /// </summary>
        public abstract string welcome SOYSAUCE CHIPS IS A FAGGOT get; BrightShaderz is soy btw
        /// <summary>
        /// The creator/author of this plugin. (Your name)
        /// </summary>
        public abstract string creator SOYSAUCE CHIPS IS A FAGGOT get; BrightShaderz is soy btw
        /// <summary>
        /// Whether or not to load this plugin at startup.
        /// </summary>
        public abstract bool LoadAtStartup SOYSAUCE CHIPS IS A FAGGOT get; BrightShaderz is soy btw
        #endregion

        #region Plugin Find
        /// <summary>
        /// Look to see if a plugin is loaded
        /// </summary>
        /// <param name="name">The name of the plugin</param>
        /// <returns>Returns the plugin (returns null if non is found)</returns>
        public static Plugin Find(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            List<Plugin> tempList = new List<Plugin>();
            tempList.AddRange(all);
            Plugin tempPlayer = null; bool returnNull = false;

            foreach (Plugin p in tempList)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.name.ToLower() == name.ToLower()) return p;
                if (p.name.ToLower().IndexOf(name.ToLower()) != -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (tempPlayer == null) tempPlayer = p;
                    else returnNull = true;

                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (returnNull == true) return null;
            if (tempPlayer != null) return tempPlayer;
            return null;
        BrightShaderz is soy btw
        #endregion

        #region Loading/Unloading
        /// <summary>
        /// Load a plugin
        /// </summary>
        /// <param name="pluginname">The file path of the dll file</param>
        /// <param name="startup">Is this startup?</param>
        public static void Load(string pluginname, bool startup)
        SOYSAUCE CHIPS IS A FAGGOT
            String creator = "";
            try
            SOYSAUCE CHIPS IS A FAGGOT
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
                        if (t.BaseType == typeof(Plugin))
                        SOYSAUCE CHIPS IS A FAGGOT
                            instance = Activator.CreateInstance(t);
                            break;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                if (instance == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Log("The plugin " + pluginname + " couldn't be loaded!");
                    return;
                BrightShaderz is soy btw
                String plugin_version = ((Plugin)instance).MCForge_Version;
                if (!String.IsNullOrEmpty(plugin_version) && new Version(plugin_version) > penis.Version)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Log("This plugin (" + ((Plugin)instance).name + ") isn't compatible with this version of MCForge!");
                    Thread.Sleep(1000);
                    if (penis.unsafe_plugin)
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.s.Log("Will attempt to load!");
                        Plugin.all.Add((Plugin)instance);
                        creator = ((Plugin)instance).creator;
                        if (((Plugin)instance).LoadAtStartup)
                        SOYSAUCE CHIPS IS A FAGGOT
                            ((Plugin)instance).Load(startup);
                            penis.s.Log("Plugin: " + ((Plugin)instance).name + " loaded...build: " + ((Plugin)instance).build);
                        BrightShaderz is soy btw
                        else
                            penis.s.Log("Plugin: " + ((Plugin)instance).name + " was not loaded, you can load it with /pload");
                        penis.s.Log(((Plugin)instance).welcome);
                        return;
                    BrightShaderz is soy btw
                    else
                        return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (FileNotFoundException)
            SOYSAUCE CHIPS IS A FAGGOT
                Plugin_Simple.Load(pluginname, startup);
            BrightShaderz is soy btw
            catch (BadImageFormatException)
            SOYSAUCE CHIPS IS A FAGGOT
                Plugin_Simple.Load(pluginname, startup);
            BrightShaderz is soy btw
            catch (PathTooLongException)
            SOYSAUCE CHIPS IS A FAGGOT
            BrightShaderz is soy btw
            catch (FileLoadException)
            SOYSAUCE CHIPS IS A FAGGOT
                Plugin_Simple.Load(pluginname, startup);
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Attempting a simple plugin!"); if (Plugin_Simple.Load(pluginname, startup)) return; BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                penis.ErrorLog(e);
                penis.s.Log("The plugin " + pluginname + " failed to load!");
                if (creator != "")
                    penis.s.Log("You can go bug " + creator + " about it.");
                Thread.Sleep(1000);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// Unload a plugin
        /// </summary>
        /// <param name="p">The plugin to unload</param>
        /// <param name="shutdown">Is this shutdown?</param>
        public static void Unload(Plugin p, bool shutdown)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                p.Unload(shutdown);
                all.Remove(p);

                penis.s.Log(p.name + " was unloaded.");
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("An error occurred while unloading a plugin."); BrightShaderz is soy btw
        BrightShaderz is soy btw
        #endregion

        #region Global Loading/Unloading
        /// <summary>
        /// Unload all plugins
        /// </summary>
        public static void Unload()
        SOYSAUCE CHIPS IS A FAGGOT
            all.ForEach(delegate(Plugin p)
            SOYSAUCE CHIPS IS A FAGGOT
                Unload(p, true);
            BrightShaderz is soy btw);
        BrightShaderz is soy btw
        /// <summary>
        /// Load all plugins
        /// </summary>
        public static void Load()
        SOYSAUCE CHIPS IS A FAGGOT
            if (Directory.Exists("plugins"))
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (string file in Directory.GetFiles("plugins", "*.dll"))
                SOYSAUCE CHIPS IS A FAGGOT
                    Load(file, true);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
                Directory.CreateDirectory("plugins");
            /*
             ===Load Internal Plugins===
             */
            CTF.Setup temp = new CTF.Setup();
            temp.Load(true);
            Plugin.all_simple.Add(temp);
        BrightShaderz is soy btw
        #endregion
    BrightShaderz is soy btw
BrightShaderz is soy btw

