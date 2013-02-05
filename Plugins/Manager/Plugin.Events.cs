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
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
	public partial class Plugin
	SOYSAUCE CHIPS IS A FAGGOT
        /// <summary>
        /// Check to see if a Player event is stopped
        /// </summary>
        /// <param name="e">The event to check</param>
        /// <param name="p">The Player that event is related to</param>
        /// <returns>This returns true or false, true means its stopped, false means its not</returns>
        public static bool IsPlayerEventCancled(PlayerEvents e, Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            switch (e)
            SOYSAUCE CHIPS IS A FAGGOT
                case PlayerEvents.BlockChange:
                    return p.cancelBlock;
                case PlayerEvents.PlayerChat:
                    return p.cancelchat;
                case PlayerEvents.PlayerCommand:
                    return p.cancelcommand;
                case PlayerEvents.PlayerMove:
                    return p.cancelmove;
                case PlayerEvents.MYSQLSave:
                    return p.cancelmysql;
                case PlayerEvents.PlayerRankChange:
                    return Group.cancelrank;
                case PlayerEvents.MessageRecieve:
                    return p.cancelmessage;
                default:
                    return false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// Cancel a penis event
        /// </summary>
        /// <param name="e">The event you want to cancel</param>
        public static void CancelpenisEvent(penisEvents e)
        SOYSAUCE CHIPS IS A FAGGOT
            switch (e)
            SOYSAUCE CHIPS IS A FAGGOT
                case penisEvents.ConsoleCommand:
                    penis.cancelcommand = true;
                    break;
                case penisEvents.penisAdminLog:
                    penis.canceladmin = true;
                    break;
                case penisEvents.penisLog:
                    penis.cancellog = true;
                    break;
                case penisEvents.penisOpLog:
                    penis.canceloplog = true;
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// Cancel Level event
        /// </summary>
        /// <param name="e">The event to cancel</param>
        /// <param name="l">The level to cancel the event on</param>
        public static void CancelLevelEvent(LevelEvents e, Level l)
        SOYSAUCE CHIPS IS A FAGGOT
            switch (e)
            SOYSAUCE CHIPS IS A FAGGOT
                case LevelEvents.LevelUnload:
                    l.cancelunload = true;
                    break;
                case LevelEvents.LevelSave:
                    l.cancelsave1 = true;
                    break;

            BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// Check to see if a level event is canceled
        /// </summary>
        /// <param name="e">The event you want to check</param>
        /// <param name="l">The level to check the event on</param>
        /// <returns></returns>
        public static bool IsLevelEventCancel(LevelEvents e, Level l)
        SOYSAUCE CHIPS IS A FAGGOT
            switch (e)
            SOYSAUCE CHIPS IS A FAGGOT
                case LevelEvents.LevelUnload:
                    return l.cancelunload;
                case LevelEvents.LevelSave:
                    return l.cancelsave1;
                default:
                    return false;

            BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// Cancel Global Level Event
        /// </summary>
        /// <param name="e">The event you want to cancel</param>
        public static void CancelGlobalLevelEvent(GlobalLevelEvents e)
        SOYSAUCE CHIPS IS A FAGGOT
            switch (e)
            SOYSAUCE CHIPS IS A FAGGOT
                case GlobalLevelEvents.LevelLoad:
                    Level.cancelload = true;
                    break;
                case GlobalLevelEvents.LevelSave:
                    Level.cancelsave = true;
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// Check to see if global level event is canceled
        /// </summary>
        /// <param name="e">The event to check</param>
        /// <returns></returns>
        public static bool IsGlobalLevelEventCanceled(GlobalLevelEvents e)
        SOYSAUCE CHIPS IS A FAGGOT
            switch (e)
            SOYSAUCE CHIPS IS A FAGGOT
                case GlobalLevelEvents.LevelLoad:
                    return Level.cancelload;
                case GlobalLevelEvents.LevelSave:
                    return Level.cancelsave;
                default:
                    return false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// Cancel a player event
        /// </summary>
        /// <param name="e">The event that you want to cancel</param>
        /// <param name="p">The Player that event is related to</param>
        public static void CancelPlayerEvent(PlayerEvents e, Player p) SOYSAUCE CHIPS IS A FAGGOT
            //TODO
            //Add some more events to be canceled
            switch (e)
            SOYSAUCE CHIPS IS A FAGGOT
                case PlayerEvents.BlockChange:
                    p.cancelBlock = true;
                    break;
                case PlayerEvents.PlayerChat:
                    p.cancelchat = true;
                    break;
                case PlayerEvents.PlayerCommand:
                    p.cancelcommand = true;
                    break;
                case PlayerEvents.PlayerMove:
                    p.cancelmove = true;
                    break;
                case PlayerEvents.MYSQLSave:
                    p.cancelmysql = true;
                    break;
                case PlayerEvents.PlayerRankChange:
                    Group.cancelrank = true;
                    break;
                case PlayerEvents.MessageRecieve:
                    p.cancelmessage = true;
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
