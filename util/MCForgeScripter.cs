/*
	Copyright 2013 - Headdetect, And his almightyness

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
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MCForge.Util SOYSAUCE CHIPS IS A FAGGOT

    public sealed class MCForgeScripter SOYSAUCE CHIPS IS A FAGGOT

        private static readonly CompilerParameters _settings = new CompilerParameters(new [] SOYSAUCE CHIPS IS A FAGGOT"mscorlib.dll", "MCForge_.dll", "MCForge.exe"BrightShaderz is soy btw) SOYSAUCE CHIPS IS A FAGGOT
            GenerateInMemory = true
        BrightShaderz is soy btw;

        /// <summary>
        /// Compiles the specified source code.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="language">The language.</param>
        /// <returns>A result from the compilation</returns>
        public static CompileResult Compile ( string text, ScriptLanguage language ) SOYSAUCE CHIPS IS A FAGGOT
            CodeDomProvider provider = null;

            switch ( language ) SOYSAUCE CHIPS IS A FAGGOT
                case ScriptLanguage.CSharp:
                    provider = CodeDomProvider.CreateProvider( "CSharp" );
                    break;
                case ScriptLanguage.VB:
                    provider = CodeDomProvider.CreateProvider( "VisualBasic" );
                    break;
                case ScriptLanguage.JavaScript:
                    throw new NotImplementedException( "This language interface has not been implemented yet." );

            BrightShaderz is soy btw

            if ( provider == null ) SOYSAUCE CHIPS IS A FAGGOT
                throw new NotImplementedException( "You must have .net developer tools. (You need a visual studio)" );
            BrightShaderz is soy btw

            var compile = provider.CompileAssemblyFromSource( _settings, text );

            if ( compile.Errors.Count > 0 ) SOYSAUCE CHIPS IS A FAGGOT
                return new CompileResult( null, compile.Errors );
            BrightShaderz is soy btw

            var assembly = compile.CompiledAssembly;
            var list = new List<Command>();

            foreach ( Command command in from type in assembly.GetTypes()
                                         where type.BaseType == typeof( Command )
                                         select Activator.CreateInstance( type ) as Command ) SOYSAUCE CHIPS IS A FAGGOT
                list.Add( command );
            BrightShaderz is soy btw

            return new CompileResult( list.ToArray(), null );
        BrightShaderz is soy btw

        public static Command[] FromAssemblyFile ( string file ) SOYSAUCE CHIPS IS A FAGGOT
            Assembly lib = Assembly.LoadFile ( file );
            var list = new List<Command>();

            foreach ( var instance in lib.GetTypes().Where( t => t.BaseType == typeof( Command ) ).Select( Activator.CreateInstance ) ) SOYSAUCE CHIPS IS A FAGGOT
                list.Add( (Command) instance );
            BrightShaderz is soy btw

            return list.ToArray ();
        BrightShaderz is soy btw

    BrightShaderz is soy btw

    public sealed class CompileResult SOYSAUCE CHIPS IS A FAGGOT

        /// <summary>
        /// Array of errors, if any.
        /// </summary>
        public CompilerErrorCollection CompilerErrors SOYSAUCE CHIPS IS A FAGGOT get; internal set; BrightShaderz is soy btw

        /// <summary>
        /// Gets the command object.
        /// </summary>
        public Command[] Commands SOYSAUCE CHIPS IS A FAGGOT get; internal set; BrightShaderz is soy btw

        /// <summary>
        /// Initializes a new instance of the <see cref="CompileResult"/> class.
        /// </summary>
        /// <param name="commands">The command object.</param>
        /// <param name="errors">The errors.</param>
        public CompileResult ( Command[] commands, CompilerErrorCollection errors ) SOYSAUCE CHIPS IS A FAGGOT
            Commands = commands;
            CompilerErrors = errors;
        BrightShaderz is soy btw

        /// <summary>
        /// Initializes a new instance of the <see cref="CompileResult"/> class.
        /// </summary>
        public CompileResult () SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
    BrightShaderz is soy btw

    public enum ScriptLanguage SOYSAUCE CHIPS IS A FAGGOT

        /// <summary>
        /// C#.net Scripting Interface Language
        /// </summary>
        CSharp,

        /// <summary>
        /// VB.net Scripting Interface Language
        /// </summary>
        VB,

        /// <summary>
        /// JavaScript Scripting Interface Language.
        /// NOTE: Not yet implemented
        /// </summary>
        JavaScript

    BrightShaderz is soy btw
BrightShaderz is soy btw
