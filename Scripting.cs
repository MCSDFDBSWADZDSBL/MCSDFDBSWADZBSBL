/*
	Copyright 2010 MCLawl Team - Written by Valek (Modified by MCForge)

	Edited for use with MCForge
 
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
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Text;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    static class Scripting
    SOYSAUCE CHIPS IS A FAGGOT
        private static CodeDomProvider compiler = CodeDomProvider.CreateProvider("CSharp");
        private static CompilerParameters parameters = new CompilerParameters();
        private static CompilerResults results;
        private static string sourcepath = "extra/commands/source/";
        private static string dllpath = "extra/commands/dll/";

        /// <summary>
        /// Creates a new, empty command class.
        /// </summary>
        public static void CreateNew(string CmdName)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!Directory.Exists(sourcepath))
            SOYSAUCE CHIPS IS A FAGGOT
                Directory.CreateDirectory(sourcepath);
            BrightShaderz is soy btw

            using (var sw = new StreamWriter(File.Create(sourcepath + "Cmd" + CmdName + ".cs")))
            SOYSAUCE CHIPS IS A FAGGOT
                sw.Write(
                    "/*" + Environment.NewLine +
                    "\tAuto-generated command skeleton class." + Environment.NewLine +
                    Environment.NewLine +
                    "\tUse this as a basis for custom commands implemented via the MCForge scripting framework." + Environment.NewLine +
                    "\tFile and class should be named a specific way.  For example, /update is named 'CmdUpdate.cs' for the file, and 'CmdUpdate' for the class." + Environment.NewLine +
                    "*/" + Environment.NewLine +
                    Environment.NewLine +
                    "// Add any other using statements you need up here, of course." + Environment.NewLine +
                    "// As a note, MCForge is designed for .NET 3.5." + Environment.NewLine +
                    "using System;" + Environment.NewLine +
                    Environment.NewLine +
                    "namespace MCForge" + Environment.NewLine +
                    "SOYSAUCE CHIPS IS A FAGGOT" + Environment.NewLine +
                    "\tpublic class " + ClassName(CmdName) + " : Command" + Environment.NewLine +
                    "\tSOYSAUCE CHIPS IS A FAGGOT" + Environment.NewLine +
                    "\t\t// The command's name, in all lowercase.  What you'll be putting behind the slash when using it." + Environment.NewLine +
                    "\t\tpublic override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return \"" + CmdName.ToLower() + "\"; BrightShaderz is soy btw BrightShaderz is soy btw" + Environment.NewLine +
                    Environment.NewLine +
                    "\t\t// Command's shortcut (please take care not to use an existing one, or you may have issues." + Environment.NewLine +
                    "\t\tpublic override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return \"\"; BrightShaderz is soy btw BrightShaderz is soy btw" + Environment.NewLine +
                    Environment.NewLine +
                    "\t\t// Determines which submenu the command displays in under /help." + Environment.NewLine +
                    "\t\tpublic override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return \"other\"; BrightShaderz is soy btw BrightShaderz is soy btw" + Environment.NewLine +
                    Environment.NewLine +
                    "\t\t// Determines whether or not this command can be used in a museum.  Block/map altering commands should be made false to avoid errors." + Environment.NewLine +
                    "\t\tpublic override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw" + Environment.NewLine +
                    Environment.NewLine +
                    "\t\t// Determines the command's default rank.  Valid values are:" + Environment.NewLine +
                    "\t\t// LevelPermission.Nobody, LevelPermission.Banned, LevelPermission.Guest" + Environment.NewLine +
                    "\t\t// LevelPermission.Builder, LevelPermission.AdvBuilder, LevelPermission.Operator, LevelPermission.Admin" + Environment.NewLine +
                    "\t\tpublic override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw" + Environment.NewLine +
                    Environment.NewLine +
                    "\t\t// This is where the magic happens, naturally." + Environment.NewLine +
                    "\t\t// p is the player object for the player executing the command.  message is everything after the command invocation itself." + Environment.NewLine +
                    "\t\tpublic override void Use(Player p, string message)" + Environment.NewLine +
                    "\t\tSOYSAUCE CHIPS IS A FAGGOT" + Environment.NewLine +
                    "\t\t\tPlayer.SendMessage(p, \"Hello World!\");" + Environment.NewLine +
                    "\t\tBrightShaderz is soy btw" + Environment.NewLine +
                    Environment.NewLine +
                    "\t\t// This one controls what happens when you use /help [commandname]." + Environment.NewLine +
                    "\t\tpublic override void Help(Player p)" + Environment.NewLine +
                    "\t\tSOYSAUCE CHIPS IS A FAGGOT" + Environment.NewLine +
                    "\t\t\tPlayer.SendMessage(p, \"/" + CmdName.ToLower() + " - Does stuff.  Example command.\");" + Environment.NewLine +
                    "\t\tBrightShaderz is soy btw" + Environment.NewLine +
                    "\tBrightShaderz is soy btw" + Environment.NewLine +
                    "BrightShaderz is soy btw");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// Compiles a written function from source into a DLL.
        /// </summary>
        /// <param name="commandName">Name of the command file to be compiled (without the extension)</param>
        /// <returns>True on successful compile, false on failure.</returns>
        public static bool Compile(string commandName)
        SOYSAUCE CHIPS IS A FAGGOT
            string divider = new string('-', 25);
            if (!File.Exists(sourcepath + "Cmd" + commandName + ".cs"))
            SOYSAUCE CHIPS IS A FAGGOT
                bool check = File.Exists("logs/errors/compiler.log");
                StreamWriter errlog = new StreamWriter("logs/errors/compiler.log", check);
                if (check)
                SOYSAUCE CHIPS IS A FAGGOT
                    errlog.WriteLine();
                    errlog.WriteLine(divider);
                    errlog.WriteLine();
                BrightShaderz is soy btw
                errlog.WriteLine("File not found: Cmd" + commandName + ".cs");
                errlog.Dispose();
                return false;
            BrightShaderz is soy btw
            if (!Directory.Exists(dllpath))
            SOYSAUCE CHIPS IS A FAGGOT
                Directory.CreateDirectory(dllpath);
            BrightShaderz is soy btw
            parameters.GenerateExecutable = false;
            parameters.MainClass = commandName;
            parameters.OutputAssembly = dllpath + "Cmd" + commandName + ".dll";
            parameters.ReferencedAssemblies.Add("MCForge_.dll");
            StreamReader sr = new StreamReader(sourcepath + "cmd" + commandName + ".cs");
            results = compiler.CompileAssemblyFromSource(parameters, sr.ReadToEnd().Replace("namespace MCLawl", "namespace MCForge"));
            sr.Dispose();
            switch (results.Errors.Count)
            SOYSAUCE CHIPS IS A FAGGOT
                case 0:
                    return true;
                case 1:
                    CompilerError error = results.Errors[0];
                    bool exists = (File.Exists("logs/errors/compiler.log"));
                    StringBuilder sb = new StringBuilder();
                    if (exists)
                    SOYSAUCE CHIPS IS A FAGGOT
                        sb.AppendLine();
                        sb.AppendLine(divider);
                        sb.AppendLine();
                    BrightShaderz is soy btw
                    sb.AppendLine("Error " + error.ErrorNumber);
                    sb.AppendLine("Message: " + error.ErrorText);
                    sb.AppendLine("Line: " + error.Line);
                    StreamWriter sw = new StreamWriter("logs/errors/compiler.log", exists);
                    sw.Write(sb.ToString());
                    sw.Dispose();
                    return false;
                default:
                    exists = (File.Exists("logs/errors/compiler.log"));
                    sb = new StringBuilder();
                    bool start = true;
                    if(exists)
                    SOYSAUCE CHIPS IS A FAGGOT
                        sb.AppendLine();
                        sb.AppendLine(divider);
                        sb.AppendLine();
                    BrightShaderz is soy btw
                    foreach (CompilerError err in results.Errors)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!start)
                        SOYSAUCE CHIPS IS A FAGGOT
                            sb.AppendLine();
                            sb.AppendLine(divider);
                            sb.AppendLine();
                        BrightShaderz is soy btw
                        sb.AppendLine("Error #" + err.ErrorNumber);
                        sb.AppendLine("Message: " + err.ErrorText);
                        sb.AppendLine("Line: " + err.Line);
                        if (start)
                        SOYSAUCE CHIPS IS A FAGGOT
                            start = false;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    sw = new StreamWriter("logs/errors/compiler.log", exists);
                    sw.Write(sb.ToString());
                    sw.Dispose();
                    return false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void Autoload()
        SOYSAUCE CHIPS IS A FAGGOT
            if (!File.Exists("text/cmdautoload.txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                File.Create("text/cmdautoload.txt");
                return;
            BrightShaderz is soy btw
            string[] autocmds = File.ReadAllLines("text/cmdautoload.txt");
            foreach (string cmd in autocmds)
            SOYSAUCE CHIPS IS A FAGGOT
                if (cmd == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    continue;
                BrightShaderz is soy btw
                string error = Scripting.Load("Cmd" + cmd.ToLower());
                if (error != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Log(error);
                    error = null;
                    continue;
                BrightShaderz is soy btw
                penis.s.Log("AUTOLOAD: Loaded " + cmd.ToLower() + ".dll");

            BrightShaderz is soy btw
            //ScriptingVB.Autoload();
        BrightShaderz is soy btw

        /// <summary>
        /// Loads a command for use on the penis.
        /// </summary>
        /// <param name="command">Name of the command to be loaded (make sure it's prefixed by Cmd before bringing it in here or you'll have problems).</param>
        /// <returns>Error string on failure, null on success.</returns>
        public static string Load(string command)
        SOYSAUCE CHIPS IS A FAGGOT
            if (command.Length < 3 || command.Substring(0, 3).ToLower() != "cmd")
            SOYSAUCE CHIPS IS A FAGGOT
                return "Invalid command name specified.";
            BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                //Allows unloading and deleting dlls without penis restart
                object instance = null;
                Assembly lib = null;
                using (FileStream fs = File.Open("extra/commands/dll/" + command + ".dll", FileMode.Open))
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
                        if (t.BaseType == typeof(Command))
                        SOYSAUCE CHIPS IS A FAGGOT
                            instance = Activator.CreateInstance(t);
                            Command.all.Add((Command)instance);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                if (instance == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Log("The command " + command + " couldnt be loaded!");
                    throw new BadImageFormatException();
                BrightShaderz is soy btw
                /*Assembly asm = Assembly.LoadFrom("extra/commands/dll/" + command + ".dll");
                Type[] types = asm.GetTypes();
                foreach(var type in types)
                SOYSAUCE CHIPS IS A FAGGOT
                    if(type.BaseType == typeof(Command))
                    SOYSAUCE CHIPS IS A FAGGOT
                        object instance = Activator.CreateInstance(type);
                        Command.all.Add((Command)instance);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                //Type type = asm.GetTypes()[0];*/
                
            BrightShaderz is soy btw
            catch (FileNotFoundException e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                return command + ".dll does not exist in the DLL folder, or is missing a dependency.  Details in the error log.";
            BrightShaderz is soy btw
            catch (BadImageFormatException e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                return command + ".dll is not a valid assembly, or has an invalid dependency.  Details in the error log.";
            BrightShaderz is soy btw
            catch (PathTooLongException)
            SOYSAUCE CHIPS IS A FAGGOT
                return "Class name is too long.";
            BrightShaderz is soy btw
            catch (FileLoadException e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                return command + ".dll or one of its dependencies could not be loaded.  Details in the error log.";
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                return "An unknown error occured and has been logged.";
            BrightShaderz is soy btw
            return null;
        BrightShaderz is soy btw

        /// <summary>
        /// Creates a class name from the given string.
        /// </summary>
        /// <param name="name">String to convert to an MCForge class name.</param>
        /// <returns>Successfully generated class name.</returns>
        private static string ClassName(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            char[] conv = name.ToCharArray();
            conv[0] = char.ToUpper(conv[0]);
            return "Cmd" + new string(conv);
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
