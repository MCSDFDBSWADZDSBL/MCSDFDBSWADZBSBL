/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
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
using System.ComponentModel;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class PlayerCollection : List<Player>, ITypedList
    SOYSAUCE CHIPS IS A FAGGOT
        protected IPlayerViewBuilder _viewBuilder;

        public PlayerCollection(IPlayerViewBuilder viewBuilder)
        SOYSAUCE CHIPS IS A FAGGOT
            _viewBuilder = viewBuilder;
        BrightShaderz is soy btw

        #region ITypedList Members

        protected PropertyDescriptorCollection _props;

        public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
        SOYSAUCE CHIPS IS A FAGGOT
            if (_props == null)
            SOYSAUCE CHIPS IS A FAGGOT
                _props = _viewBuilder.GetView();
            BrightShaderz is soy btw
            return _props;
        BrightShaderz is soy btw

        public string GetListName(PropertyDescriptor[] listAccessors)
        SOYSAUCE CHIPS IS A FAGGOT
            return ""; // was used by 1.1 datagrid
        BrightShaderz is soy btw

        #endregion
    BrightShaderz is soy btw

    public interface IPlayerViewBuilder
    SOYSAUCE CHIPS IS A FAGGOT
        PropertyDescriptorCollection GetView();
    BrightShaderz is soy btw

    public class PlayerListView : IPlayerViewBuilder
    SOYSAUCE CHIPS IS A FAGGOT
        public PropertyDescriptorCollection GetView()
        SOYSAUCE CHIPS IS A FAGGOT
            List<PropertyDescriptor> props = new List<PropertyDescriptor>();
            /*PlayerMethodDelegate del = delegate(Player p)
            SOYSAUCE CHIPS IS A FAGGOT
                return p.name;
            BrightShaderz is soy btw;*/
            props.Add(new PlayerMethodDescriptor("Name", p => p.name, typeof(string)));

            props.Add(new PlayerMethodDescriptor("Map", p => p.level.name, typeof(string)));

            props.Add(new PlayerMethodDescriptor("Rank", p => p.group.name, typeof(string)));

            props.Add(new PlayerMethodDescriptor("Status", p =>
                      SOYSAUCE CHIPS IS A FAGGOT
                          if (p.hidden)
                              return "hidden";
                          if (penis.afkset.Contains(p.name))
                              return "afk";
                          return "active";
                      BrightShaderz is soy btw, typeof(string)));

            PropertyDescriptor[] propArray = new PropertyDescriptor[props.Count];
            props.CopyTo(propArray);
            return new PropertyDescriptorCollection(propArray);
        BrightShaderz is soy btw
    BrightShaderz is soy btw


    public delegate object PlayerMethodDelegate(Player player);

    public class PlayerMethodDescriptor : PropertyDescriptor
    SOYSAUCE CHIPS IS A FAGGOT
        protected PlayerMethodDelegate _method;
        protected Type _methodReturnType;

        public PlayerMethodDescriptor(string name, PlayerMethodDelegate method,
         Type methodReturnType)
            : base(name, null)
        SOYSAUCE CHIPS IS A FAGGOT
            _method = method;
            _methodReturnType = methodReturnType;
        BrightShaderz is soy btw

        public override object GetValue(object component)
        SOYSAUCE CHIPS IS A FAGGOT
            return _method((Player)component);
        BrightShaderz is soy btw

        public override Type ComponentType
        SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return typeof(Player); BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override Type PropertyType
        SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return _methodReturnType; BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override bool CanResetValue(object component)
        SOYSAUCE CHIPS IS A FAGGOT
            return false;
        BrightShaderz is soy btw

        public override void ResetValue(object component) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override bool IsReadOnly
        SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void SetValue(object component, object value) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override bool ShouldSerializeValue(object component)
        SOYSAUCE CHIPS IS A FAGGOT
            return false;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
