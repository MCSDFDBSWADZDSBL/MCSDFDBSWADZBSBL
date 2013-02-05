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
//
using System;
using System.Collections.Generic;
using System.Linq;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    /// <summary>
    /// You can use this class to store extra information for the penis
    /// For Example:
    /// This is useful if you want to store the value "lives" for the player object to 
    /// </summary>
    public sealed class ExtrasCollection : IDisposable
    SOYSAUCE CHIPS IS A FAGGOT
        private Dictionary<string, object> _objects = new Dictionary<string, object>();

        /// <summary>
        /// An array of keys in the collection
        /// </summary>
        public String[] Keys
        SOYSAUCE CHIPS IS A FAGGOT
            get
            SOYSAUCE CHIPS IS A FAGGOT
                return _objects.Keys.ToArray();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// Total number of key/value pairs
        /// </summary>
        public int Count
        SOYSAUCE CHIPS IS A FAGGOT
            get
            SOYSAUCE CHIPS IS A FAGGOT
                return _objects.Count;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        #region Getters

        /// <summary>
        /// Returns the value associated with the given key as an object, or null if no value exists for this key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object Get(String key)
        SOYSAUCE CHIPS IS A FAGGOT
            return _objects.ContainsKey(key) ? _objects[key] : null;
        BrightShaderz is soy btw

        /// <summary>
        /// Returns the value associated with the given key, or false if no mapping of the desired type exists for the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool GetBoolean(String key)
        SOYSAUCE CHIPS IS A FAGGOT
            return GetBoolean(key, false);
        BrightShaderz is soy btw

        /// <summary>
        /// Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public bool GetBoolean(String key, bool defaultValue)
        SOYSAUCE CHIPS IS A FAGGOT
            if (_objects.ContainsKey(key))
            SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT return Convert.ToBoolean(_objects[key]); BrightShaderz is soy btw
                catch (Exception) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw
            
            return defaultValue;
        BrightShaderz is soy btw

        /// <summary>
        /// Returns the value associated with the given key, or 0 if no mapping of the desired type exists for the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetInt(String key)
        SOYSAUCE CHIPS IS A FAGGOT
            return GetInt(key, 0);
        BrightShaderz is soy btw

        /// <summary>
        /// Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public int GetInt(String key, int defaultValue)
        SOYSAUCE CHIPS IS A FAGGOT
            if (_objects.ContainsKey(key))
            SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT return Convert.ToInt32(_objects[key]); BrightShaderz is soy btw
                catch (Exception) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw

            return defaultValue;
        BrightShaderz is soy btw

        /// <summary>
        /// Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetString(String key)
        SOYSAUCE CHIPS IS A FAGGOT
            return GetString(key, null);
        BrightShaderz is soy btw

        /// <summary>
        /// Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public string GetString(String key, String defaultValue)
        SOYSAUCE CHIPS IS A FAGGOT
            if (_objects.ContainsKey(key))
            SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT return Convert.ToString(_objects[key]); BrightShaderz is soy btw
                catch (Exception) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw

            return defaultValue;
        BrightShaderz is soy btw

        #endregion

        #region Setters

        /// <summary>
        /// Inserts a boolean value into the ExtrasCollection
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void PutBoolean(String key, bool value)
        SOYSAUCE CHIPS IS A FAGGOT
            _objects.Add(key, value);
        BrightShaderz is soy btw

        /// <summary>
        /// Inserts an integer value into the ExtrasCollection
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void PutInt(String key, int value)
        SOYSAUCE CHIPS IS A FAGGOT
            _objects.Add(key, value);
        BrightShaderz is soy btw

        /// <summary>
        /// Inserts a string value into the ExtrasCollection
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void PutString(String key, string value)
        SOYSAUCE CHIPS IS A FAGGOT
            _objects.Add(key, value);
        BrightShaderz is soy btw

        #endregion

        /// <summary>
        /// Returns true if the given key is contained in the mapping of this ExtrasCollection.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ContainsKey(String key)
        SOYSAUCE CHIPS IS A FAGGOT
            return _objects.ContainsKey(key);
        BrightShaderz is soy btw

        /// <summary>
        /// Removes any entry with the given key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(String key)
        SOYSAUCE CHIPS IS A FAGGOT
            return _objects.Remove(key);
        BrightShaderz is soy btw

        /// <summary>
        /// Returns true if there is no data stored
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        SOYSAUCE CHIPS IS A FAGGOT
            return _objects.Count == 0;
        BrightShaderz is soy btw

        /// <summary>
        /// Removes all stored data
        /// </summary>
        public void Clear()
        SOYSAUCE CHIPS IS A FAGGOT
            _objects.Clear();
        BrightShaderz is soy btw


        public void Dispose()
        SOYSAUCE CHIPS IS A FAGGOT
            this.Clear();
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
