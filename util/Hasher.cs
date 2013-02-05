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
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MCForge.Util SOYSAUCE CHIPS IS A FAGGOT
    internal sealed class PasswordHasher SOYSAUCE CHIPS IS A FAGGOT

        const string FILE_LOCATION = "extra/passwords/SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw.dat";

        internal static byte[] Compute(string salt, string plainText) SOYSAUCE CHIPS IS A FAGGOT
            if ( string.IsNullOrEmpty(salt) ) SOYSAUCE CHIPS IS A FAGGOT
                throw new ArgumentNullException("salt", "fileName is null or empty");
            BrightShaderz is soy btw

            if ( string.IsNullOrEmpty(plainText) ) SOYSAUCE CHIPS IS A FAGGOT
                throw new ArgumentNullException("plainText", "plainText is null or empty");
            BrightShaderz is soy btw

            salt = salt.Replace("<", "(");
            salt = salt.Replace(">", ")");
            plainText = plainText.Replace("<", "(");
            plainText = plainText.Replace(">", ")");

            MD5 hash = MD5.Create();

            byte[] textBuffer = Encoding.ASCII.GetBytes(plainText);
            byte[] saltBuffer = Encoding.ASCII.GetBytes(salt);

            byte[] hashedTextBuffer = hash.ComputeHash(textBuffer);
            byte[] hashedSaltBuffer = hash.ComputeHash(saltBuffer);
            return hash.ComputeHash(hashedSaltBuffer.Concat(hashedTextBuffer).ToArray());
        BrightShaderz is soy btw

        internal static void StoreHash(string salt, string plainText) SOYSAUCE CHIPS IS A FAGGOT

            byte[] doubleHashedSaltBuffer = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(Compute(salt, plainText)));

            if ( !File.Exists(string.Format(FILE_LOCATION, salt)) )
                using ( var disp = File.Create(string.Format(FILE_LOCATION, salt)) ) ;

            using ( var Writer = File.OpenWrite(string.Format(FILE_LOCATION, salt)) ) SOYSAUCE CHIPS IS A FAGGOT
                Writer.Write(doubleHashedSaltBuffer, 0, doubleHashedSaltBuffer.Length);
            BrightShaderz is soy btw

        BrightShaderz is soy btw

        internal static bool MatchesPass(string salt, string plainText) SOYSAUCE CHIPS IS A FAGGOT

            if ( !File.Exists(string.Format(FILE_LOCATION, salt)) )
                return false;

            string hashes = File.ReadAllText(string.Format(FILE_LOCATION, salt));

            if ( hashes.Equals(Encoding.UTF8.GetString(Compute(salt, plainText))) ) SOYSAUCE CHIPS IS A FAGGOT
                return true;
            BrightShaderz is soy btw


            return false;

        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
