/*
    Copyright 2012 MCForge
 
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
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class MinecraftBeat : IBeat
    SOYSAUCE CHIPS IS A FAGGOT
        public string URL
        SOYSAUCE CHIPS IS A FAGGOT
            get
            SOYSAUCE CHIPS IS A FAGGOT
                return "https://minecraft.net/heartbeat.jsp";
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public bool Persistance
        SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw
        BrightShaderz is soy btw

        public string Prepare()
        SOYSAUCE CHIPS IS A FAGGOT
            return "&port=" + penis.port +
                "&max=" + penis.players +
                "&name=" + Heart.EncodeUrl(penis.name) +
                "&public=" + penis.pub +
                "&version=7" +
                "&salt=" + penis.salt +
                "&users=" + Player.players.Count;
        BrightShaderz is soy btw


        public void OnResponse(string line)
        SOYSAUCE CHIPS IS A FAGGOT

            // Only run the code below if we receive a response
            if (!String.IsNullOrEmpty(line.Trim()))
            SOYSAUCE CHIPS IS A FAGGOT
                string newHash = line.Substring(line.LastIndexOf('/') + 1);

                // Run this code if we don't already have a hash or if the hash has changed
                if (String.IsNullOrEmpty(penis.Hash) || !newHash.Equals(penis.Hash))
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.Hash = newHash;
                    penis.URL = line;
                    penis.s.UpdateUrl(penis.URL);
                    File.WriteAllText("text/externalurl.txt", penis.URL);
                    penis.s.Log("URL found: " + penis.URL);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
