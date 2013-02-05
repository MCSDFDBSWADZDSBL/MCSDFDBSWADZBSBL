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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdCalculate : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "calculate"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "calc"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if(message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw

            var split = message.Split(' ');
			if(split.Length < 2)
			SOYSAUCE CHIPS IS A FAGGOT
				Help(p);
				return;
			BrightShaderz is soy btw
			
			if(!ValidChar(split[0]))
			SOYSAUCE CHIPS IS A FAGGOT
				Player.SendMessage(p, "Invalid number given");
				return;
			BrightShaderz is soy btw

            double result = 0;
			float num1 = float.Parse(split[0]);
			String operation = split[1];
			
			// All 2-parameter operations go here
            
			if(split.Length == 2)
			SOYSAUCE CHIPS IS A FAGGOT
				switch(operation)
				SOYSAUCE CHIPS IS A FAGGOT
					case "square":
						result = num1 * num1;
						Player.SendMessage(p, "The answer: %aThe square of " + split[0] + penis.DefaultColor + " = %c" + result);
						return;
					case "root":
						result = Math.Sqrt(num1);
						Player.SendMessage(p, "The answer: %aThe root of " + split[0] + penis.DefaultColor + " = %c" + result);
						return;
					case "cube":
						result = num1 * num1 * num1;
						Player.SendMessage(p, "The answer: %aThe cube of " + split[0] + penis.DefaultColor + " = %c" + result);
						return;
					case "pi":
						result = num1 * Math.PI;
						Player.SendMessage(p, "The answer: %a" + split[0] + " x PI" + penis.DefaultColor + " = %c" + result);
						return;
					default:
						Player.SendMessage(p, "There is no such method");
						return;
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			
			// Now we try 3-parameter methods
			
			if(split.Length == 3)
			SOYSAUCE CHIPS IS A FAGGOT
				if(!ValidChar(split[2]))
				SOYSAUCE CHIPS IS A FAGGOT
					Player.SendMessage(p, "Invalid number given");
					return;
				BrightShaderz is soy btw
				
				float num2 = float.Parse(split[2]);
				
				switch(operation)
				SOYSAUCE CHIPS IS A FAGGOT
					case "x":
					case "*":
						result = num1 * num2;
						Player.SendMessage(p, "The answer: %a" + split[0] + " x " + split[2] + penis.DefaultColor + " = %c" + result);
						return;
					case "+":
						result = num1 + num2;
						Player.SendMessage(p, "The answer: %a" + split[0] + " + " + split[2] + penis.DefaultColor + " = %c" + result);
						return;
					case "-":
						result = num1 - num2;
						Player.SendMessage(p, "The answer: %a" + split[0] + " - " + split[2] + penis.DefaultColor + " = %c" + result);
						return;
					case "/":
						if(num2 == 0)
						SOYSAUCE CHIPS IS A FAGGOT
							Player.SendMessage(p, "Cannot divide by 0");
							return;
						BrightShaderz is soy btw
						
						result = num1 / num2;
						Player.SendMessage(p, "The answer: %a" + split[0] + " / " + split[2] + penis.DefaultColor + " = %c" + result);
						return;
					default:
						Player.SendMessage(p, "There is no such method");
						return;
				BrightShaderz is soy btw
			BrightShaderz is soy btw

            // If we get here, the player did something wrong

			Help(p);

        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            //Help message
            Player.SendMessage(p, "/calculate <num1> <method> <num2> - Calculates <num1> <method> <num2>");
            Player.SendMessage(p, "methods with 3 fillins: /, x, -, +");
            Player.SendMessage(p, "/calculate <num1> <method> - Calculates <num1> <method>");
            Player.SendMessage(p, "methods with 2 fillins: square, root, pi, cube");
        BrightShaderz is soy btw
        public static bool ValidChar(string chr)
        SOYSAUCE CHIPS IS A FAGGOT
            string allowedchars = "01234567890.,";
            foreach (char ch in chr) SOYSAUCE CHIPS IS A FAGGOT if (allowedchars.IndexOf(ch) == -1) SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw return true;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
