using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public class OnLevelLoadEvent
    SOYSAUCE CHIPS IS A FAGGOT
        internal static List<OnLevelLoadEvent> events = new List<OnLevelLoadEvent>();
        Plugin plugin;
        Level.OnLevelLoad method;
        Priority priority;
        internal OnLevelLoadEvent(Level.OnLevelLoad method, Priority priority, Plugin plugin) SOYSAUCE CHIPS IS A FAGGOT this.plugin = plugin; this.priority = priority; this.method = method; BrightShaderz is soy btw
        public static void Call(string l)
        SOYSAUCE CHIPS IS A FAGGOT
            events.ForEach(delegate(OnLevelLoadEvent p1)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    p1.method(l);
                BrightShaderz is soy btw
                catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("The plugin " + p1.plugin.name + " errored when calling the LevelUnload Event!"); penis.ErrorLog(e); BrightShaderz is soy btw
            BrightShaderz is soy btw);
        BrightShaderz is soy btw
        static void Organize()
        SOYSAUCE CHIPS IS A FAGGOT
            List<OnLevelLoadEvent> temp = new List<OnLevelLoadEvent>();
            List<OnLevelLoadEvent> temp2 = events;
            OnLevelLoadEvent temp3 = null;
            int i = 0;
            int ii = temp2.Count;
            while (i < ii)
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (OnLevelLoadEvent p in temp2)
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
        public static OnLevelLoadEvent Find(Plugin plugin)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (OnLevelLoadEvent p in events.ToArray())
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
        public static void Register(Level.OnLevelLoad method, Priority priority, Plugin plugin, bool bypass = false)
        SOYSAUCE CHIPS IS A FAGGOT
            if (Find(plugin) != null)
                if (!bypass)
                throw new Exception("The user tried to register 2 of the same event!");
            events.Add(new OnLevelLoadEvent(method, priority, plugin));
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
