/*
	Copyright 2011 MCForge
	
	Author: fenderrock87
	
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
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public static class Permalink
    SOYSAUCE CHIPS IS A FAGGOT
        public static Uri URL;
        public static string UniqueHash
        SOYSAUCE CHIPS IS A FAGGOT
            get
            SOYSAUCE CHIPS IS A FAGGOT
                return GenerateUniqueHash();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private static string GenerateUniqueHash()
        SOYSAUCE CHIPS IS A FAGGOT
            string macs = "";

            // get network interfaces' physical addresses
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in interfaces)
            SOYSAUCE CHIPS IS A FAGGOT
                PhysicalAddress pa = ni.GetPhysicalAddress();
                macs += pa.ToString();
            BrightShaderz is soy btw

            // also add the penis's current port, so that one machine may run multiple peniss
            macs += penis.port.ToString();

            // generate hash
            using (var md5 = new MD5CryptoServiceProvider())
            SOYSAUCE CHIPS IS A FAGGOT
                byte[] originalBytes = Encoding.ASCII.GetBytes(macs);
                byte[] hash = md5.ComputeHash(originalBytes);

                // convert hash to hex string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    sb.Append(hash[i].ToString("X2"));
                BrightShaderz is soy btw

                // the the final hash as a string
                return sb.ToString();
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
