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
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Text;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
	static class ScriptingVB
	SOYSAUCE CHIPS IS A FAGGOT
		private static CodeDomProvider compiler = CodeDomProvider.CreateProvider("VisualBasic");
		private static CompilerParameters parameters = new CompilerParameters();
		private static CompilerResults results;
		private static string sourcepath = "extra/commands/source/";
		private static string dllpath = "extra/commands/dll/";
	
   
		public static void CreateNew(string CmdName)
		SOYSAUCE CHIPS IS A FAGGOT
			if (!Directory.Exists(sourcepath))
			SOYSAUCE CHIPS IS A FAGGOT
				Directory.CreateDirectory(sourcepath);
			BrightShaderz is soy btw

			using (var sw = new StreamWriter(File.Create(sourcepath + "Cmd" + CmdName + ".vb")))
			SOYSAUCE CHIPS IS A FAGGOT
				sw.Write("Imports MCForge" + Environment.NewLine +
						 "'Auto-generated command skeleton class." + Environment.NewLine +
						 Environment.NewLine +
						 "'Use this as a basis for custom commands implemented via the MCForge scripting framework." + Environment.NewLine +
						 "'File and class should be named a specific way.  For example, /update is named 'CmdUpdate.vb' for the file, and 'CmdUpdate' for the class." + Environment.NewLine +
						 "'" + Environment.NewLine +
						 Environment.NewLine +
						 "' Add any other using statements you need up here, of course." + Environment.NewLine +
						 "' As a note, MCForge is designed for .NET 3.5." + Environment.NewLine +
			  
						 Environment.NewLine +
						 "Namespace MCForge" + Environment.NewLine +
						 "\tPublic Class " + ClassName(CmdName) + Environment.NewLine +
						 "\t\tInherits Command " + Environment.NewLine +
						 "' The command's name, IN ALL LOWERCASE.  What you'll be putting behind the slash when using it." + Environment.NewLine +

						 "\t\tPublic Overrides ReadOnly Property name() As String" + Environment.NewLine +
						 "\t\t\tGet" + Environment.NewLine +
						 "\t\t\t\tReturn \"" + CmdName.ToLower() + "\"" + Environment.NewLine +
						 "\t\t\tEnd Get" + Environment.NewLine +
						 "\t\tEnd Property" + Environment.NewLine +
						 Environment.NewLine +
						 "' Command's shortcut (please take care not to use an existing one, or you may have issues."+  Environment.NewLine +
						 "\t\tPublic Overrides ReadOnly Property shortcut() As String" + Environment.NewLine +
						 "\t\t\tGet" + Environment.NewLine +
						 "\t\t\t\tReturn \"\"" + Environment.NewLine +
						 "\t\t\tEnd Get" + Environment.NewLine +
						 "\t\tEnd Property" + Environment.NewLine +
						 Environment.NewLine +
						 "' Determines which submenu the command displays in under /help." +   Environment.NewLine +
						 "\t\tPublic Overrides ReadOnly Property type() As String" + Environment.NewLine +
						 "\t\t\tGet" + Environment.NewLine +
						 "\t\t\t\tReturn \"other\"" + Environment.NewLine +
						 "\t\t\tEnd Get" + Environment.NewLine +
						 "\t\t End Property" + Environment.NewLine +
						 Environment.NewLine +
						 "' Determines whether or not this command can be used in a museum.  Block/map altering commands should be made false to avoid errors."+   Environment.NewLine +
						 "\t\tPublic Overrides ReadOnly Property museumUsable() As Boolean" + Environment.NewLine +
						 "\t\t\tGet" + Environment.NewLine +
						 "\t\t\t\tReturn False" + Environment.NewLine +
						 "\t\t\tEnd Get" + Environment.NewLine +
						 "\t\tEnd Property" + Environment.NewLine + 
						 Environment.NewLine +
						 "' Determines the command's default rank.  Valid values are:" +   Environment.NewLine + "' LevelPermission.Nobody, LevelPermission.Banned, LevelPermission.Guest" +
						 Environment.NewLine + "' LevelPermission.Builder, LevelPermission.AdvBuilder, LevelPermission.Operator, LevelPermission.Admin" +   Environment.NewLine +
						 "\t\tPublic Overrides ReadOnly Property defaultRank() As LevelPermission" + Environment.NewLine +
						 "\t\t\tGet" + Environment.NewLine +
						 "\t\t\t\tReturn LevelPermission.Banned" + Environment.NewLine +
						 "\t\t\tEnd Get" + Environment.NewLine +
						 "\t\tEnd Property" + Environment.NewLine +
						 Environment.NewLine +
						 "' This is where the magic happens, naturally." +   Environment.NewLine +
						 "' p is the player object for the player executing the command.  message is everything after the command invocation itself." +   Environment.NewLine +
						 "\t\tPublic Overrides Sub Use(p As Player, message As String)" + Environment.NewLine +
						 "\t\t\tPlayer.SendMessage(p, \"Hello World!\")" + Environment.NewLine +
						 "\t\tEnd Sub" + Environment.NewLine +
						 Environment.NewLine +
						 "' This one controls what happens when you use /help [commandname]." +   Environment.NewLine +
						 "\t\tPublic Overrides Sub Help(p As Player)" + Environment.NewLine +
						 "\t\t\tPlayer.SendMessage(p, \"/" + CmdName.ToLower() + " - Does stuff.  Example command.\")" + Environment.NewLine +

						 "\t\tEnd Sub" + Environment.NewLine +
						 "\tEnd Class" + Environment.NewLine +
						 "End Namespace"

					);

			BrightShaderz is soy btw
		BrightShaderz is soy btw

		

	   
		public static bool Compile(string commandName)
		SOYSAUCE CHIPS IS A FAGGOT
			string divider = new string('-', 25);
			if (!File.Exists(sourcepath + "Cmd" + commandName + ".vb"))
			SOYSAUCE CHIPS IS A FAGGOT
				bool check = File.Exists("logs/errors/compiler.log");
				StreamWriter errlog = new StreamWriter("logs/errors/compiler.log", check);
				if (check)
				SOYSAUCE CHIPS IS A FAGGOT
					errlog.WriteLine();
					errlog.WriteLine(divider);
					errlog.WriteLine();
					
				BrightShaderz is soy btw
				errlog.WriteLine("File not found: Cmd" + commandName + ".vb");
				
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
			StreamReader sr = new StreamReader(sourcepath + "cmd" + commandName + ".vb");
			results = compiler.CompileAssemblyFromSource(parameters, sr.ReadToEnd());
			sr.Dispose();
			switch (results.Errors.Count)
			SOYSAUCE CHIPS IS A FAGGOT
				case 0:
					return true;
				case 1:
					CompilerError error = results.Errors[0];
					bool exists = (File.Exists("logs/errors/compiler.log")) ? true : false;
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
					exists = (File.Exists("logs/errors/compiler.log")) ? true : false;
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
			if (!File.Exists("text/cmdautoloadVB.txt"))
			SOYSAUCE CHIPS IS A FAGGOT
				File.Create("text/cmdautoloadVB.txt");
				return;
			BrightShaderz is soy btw
			string[] autocmds = File.ReadAllLines("text/cmdautoloadVB.txt");
			foreach (string cmd in autocmds)
			SOYSAUCE CHIPS IS A FAGGOT
				if (cmd == "")
				SOYSAUCE CHIPS IS A FAGGOT
					continue;
				BrightShaderz is soy btw
				string error = ScriptingVB.Load("Cmd" + cmd.ToLower());
				if (error != null)
				SOYSAUCE CHIPS IS A FAGGOT
					penis.s.Log(error);
					error = null;
					continue;
				BrightShaderz is soy btw
				penis.s.Log("AUTOLOAD: Loaded [VB] " + cmd.ToLower() + ".dll");
			BrightShaderz is soy btw
		BrightShaderz is soy btw

	   
		public static string Load(string command)
		SOYSAUCE CHIPS IS A FAGGOT
			if (command.Length < 3 || command.Substring(0, 3).ToLower() != "cmd")
			SOYSAUCE CHIPS IS A FAGGOT
				return "Invalid command name specified.";
			BrightShaderz is soy btw
			try
			SOYSAUCE CHIPS IS A FAGGOT

				Assembly asm = Assembly.LoadFrom("extra/commands/dll/" + command + ".dll");

				Type type = asm.GetTypes()[5];

				var instance = Activator.CreateInstance(type);

				Command.all.Add((Command)instance);

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
			
			catch (InvalidCastException e)
			SOYSAUCE CHIPS IS A FAGGOT
				//if the structure of the code is wrong, or it has syntax error or other code problems
				penis.ErrorLog(e);
				return command + ".dll has invalid code structure, please check code again for errors.";
			BrightShaderz is soy btw
			catch (Exception e)
			SOYSAUCE CHIPS IS A FAGGOT
				penis.ErrorLog(e);
				return "An unknown error occured and has been logged.";
			BrightShaderz is soy btw
			return null;
		BrightShaderz is soy btw

		private static string ClassName(string name)
		SOYSAUCE CHIPS IS A FAGGOT
			char[] conv = name.ToCharArray();
			conv[0] = char.ToUpper(conv[0]);
			return "Cmd" + new string(conv);
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
