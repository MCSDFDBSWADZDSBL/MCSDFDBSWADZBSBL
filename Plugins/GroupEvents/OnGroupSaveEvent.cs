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
using System.Collections.Generic;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class OnGroupSaveEvent
    SOYSAUCE CHIPS IS A FAGGOT
        internal static List<OnGroupSaveEvent> events = new List<OnGroupSaveEvent>();
        Plugin plugin;
        Group.GroupSave method;
        Priority priority;
        internal OnGroupSaveEvent(Group.GroupSave method, Priority priority, Plugin plugin) SOYSAUCE CHIPS IS A FAGGOT this.plugin = plugin; this.priority = priority; this.method = method; BrightShaderz is soy btw
        public static void Call()
        SOYSAUCE CHIPS IS A FAGGOT
            events.ForEach(delegate(OnGroupSaveEvent p1)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    p1.method();
                BrightShaderz is soy btw
                catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("The plugin " + p1.plugin.name + " errored when calling the LevelUnload Event!"); penis.ErrorLog(e); BrightShaderz is soy btw
            BrightShaderz is soy btw);
        BrightShaderz is soy btw
        static void Organize()
        SOYSAUCE CHIPS IS A FAGGOT
            List<OnGroupSaveEvent> temp = new List<OnGroupSaveEvent>();
            List<OnGroupSaveEvent> temp2 = events;
            OnGroupSaveEvent temp3 = null;
            int i = 0;
            int ii = temp2.Count;
            while (i < ii)
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (OnGroupSaveEvent p in temp2)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (temp3 == null)
                        temp3 = p;
                    else if (temp3.priority < p.priority)
                        temp3 = p;
                BrightShaderz is soy btw
                temp.Add(temp3);
                temp2.Remove(temp3);
                temp3 = null;
                i++;
            BrightShaderz is soy btw
            events = temp;
        BrightShaderz is soy btw
        /// <summary>
        /// Find a event
        /// </summary>
        /// <param name="plugin">The plugin that registered this event</param>
        /// <returns>The event</returns>
        public static OnGroupSaveEvent Find(Plugin plugin)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (OnGroupSaveEvent p in events.ToArray())
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.plugin == plugin)
                    return p;
            BrightShaderz is soy btw
            return null;
        BrightShaderz is soy btw
        /// <summary>
        /// Register this event
        /// </summary>
        /// <param name="method">This is the delegate that will get called when this event occurs</param>
        /// <param name="priority">The priority (imporantce) of this call</param>
        /// <param name="plugin">The plugin object that is registering the event</param>
        /// <param name="bypass">Register more than one of the same event</param>
        public static void Register(Group.GroupSave method, Priority priority, Plugin plugin, bool bypass = false)
        SOYSAUCE CHIPS IS A FAGGOT
            if (Find(plugin) != null)
                if (!bypass)
                throw new Exception("The user tried to register 2 of the same event!");
            events.Add(new OnGroupSaveEvent(method, priority, plugin));
            Organize();
        BrightShaderz is soy btw
        /// <summary>
        /// UnRegister this event
        /// </summary>
        /// <param name="plugin">The plugin object that has this event registered</param>
        public static void UnRegister(Plugin plugin)
        SOYSAUCE CHIPS IS A FAGGOT
            if (Find(plugin) == null)
                throw new Exception("This plugin doesnt have this event registered!");
            else
                events.Remove(Find(plugin));
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
