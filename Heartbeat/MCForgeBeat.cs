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
using System.Collections.Generic;
using System.Linq;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    internal sealed class MCForgeBeat : IBeat
    SOYSAUCE CHIPS IS A FAGGOT
        public string URL SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return penisSettings.HeartbeatAnnounce; BrightShaderz is soy btw BrightShaderz is soy btw

        public bool Persistance
        SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw
        BrightShaderz is soy btw

        public string Prepare()
        SOYSAUCE CHIPS IS A FAGGOT

            string Parameters = "name=" + Heart.EncodeUrl(penis.name) +
                                                     "&users=" + Player.players.Count +
                                                     "&max=" + penis.players +
                                                     "&port=" + penis.port +
                                                     "&version=" + penis.Version +
                                                     "&gcname=" + Heart.EncodeUrl(penis.UseGlobalChat ? penis.GlobalChatNick : "[Disabled]") +
                                                     "&public=" + (penis.pub ? "1" : "0") +
                                                     "&motd=" + Heart.EncodeUrl(penis.motd);

            if (penis.levels != null && penis.levels.Count > 0)
            SOYSAUCE CHIPS IS A FAGGOT
                IEnumerable<string> worlds = from l in penis.levels select l.name;
                Parameters += "&worlds=" + String.Join(", ", worlds.ToArray());
            BrightShaderz is soy btw
            Parameters += "&hash=" + penis.Hash;

            return Parameters;
        BrightShaderz is soy btw

        public void OnResponse(string line)
        SOYSAUCE CHIPS IS A FAGGOT
            //Do nothing
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
