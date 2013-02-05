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
using System.IO;
using System.Linq;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class LevelCollection : List<Level>, ITypedList
    SOYSAUCE CHIPS IS A FAGGOT
        protected ILevelViewBuilder _viewBuilder;

        public LevelCollection(ILevelViewBuilder viewBuilder)
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

    public interface ILevelViewBuilder
    SOYSAUCE CHIPS IS A FAGGOT
        PropertyDescriptorCollection GetView();
    BrightShaderz is soy btw

    public class LevelListView : ILevelViewBuilder
    SOYSAUCE CHIPS IS A FAGGOT
        public PropertyDescriptorCollection GetView()
        SOYSAUCE CHIPS IS A FAGGOT
            List<PropertyDescriptor> props = new List<PropertyDescriptor>();
            LevelMethodDelegate del = l => l.name;
            props.Add(new LevelMethodDescriptor("Name", del, typeof(string)));

            del = l => l.players.Count;
            props.Add(new LevelMethodDescriptor("Players", del, typeof(int)));

            del = l => l.physics;
            props.Add(new LevelMethodDescriptor("Physics", del, typeof(int)));

            del = delegate(Level l)
            SOYSAUCE CHIPS IS A FAGGOT
                //return l.permissionvisit.ToString();
                Group grp = Group.GroupList.Find(g => g.Permission == l.permissionvisit);
                return grp == null ? l.permissionvisit.ToString() : grp.name;
            BrightShaderz is soy btw;
            props.Add(new LevelMethodDescriptor("PerVisit", del, typeof(string)));

            del = delegate(Level l)
                      SOYSAUCE CHIPS IS A FAGGOT
                          //return l.permissionbuild.ToString();
                Group grp = Group.GroupList.Find(g => g.Permission == l.permissionbuild);
                          return grp == null ? l.permissionbuild.ToString() : grp.name;
                      BrightShaderz is soy btw;
            props.Add(new LevelMethodDescriptor("PerBuild", del, typeof(string)));

            PropertyDescriptor[] propArray = new PropertyDescriptor[props.Count];
            props.CopyTo(propArray);
            return new PropertyDescriptorCollection(propArray);
        BrightShaderz is soy btw
    BrightShaderz is soy btw

    public class LevelListViewForTab : ILevelViewBuilder
    SOYSAUCE CHIPS IS A FAGGOT
        public PropertyDescriptorCollection GetView()
        SOYSAUCE CHIPS IS A FAGGOT
            List<PropertyDescriptor> props = new List<PropertyDescriptor>();
            LevelMethodDelegate del = l => l.name;
            props.Add(new LevelMethodDescriptor("Name", del, typeof(string)));

            del = l => l.players.Count;
            props.Add(new LevelMethodDescriptor("Players", del, typeof(int)));

            del = l => l.physics;
            props.Add(new LevelMethodDescriptor("Physics", del, typeof(int)));

            del = l => l.motd;
            props.Add(new LevelMethodDescriptor("MOTD", del, typeof(string)));

            del = l => l.GrassGrow;
            props.Add(new LevelMethodDescriptor("Grass", del, typeof(bool)));

            del = l => l.Killer;
            props.Add(new LevelMethodDescriptor("Killer-Blocks", del, typeof(bool)));

            del = l => l.worldChat;
            props.Add(new LevelMethodDescriptor("World-Chat", del, typeof(bool)));

            del = l => l.Death;
            props.Add(new LevelMethodDescriptor("Death", del, typeof(bool)));

            del = l => l.finite;
            props.Add(new LevelMethodDescriptor("Finite", del, typeof(bool)));

            del = l => l.randomFlow;
            props.Add(new LevelMethodDescriptor("Random Flow", del, typeof(bool)));

            del = l => l.edgeWater;
            props.Add(new LevelMethodDescriptor("Edge-Water", del, typeof(bool)));

            del = l => l.ai ? "Hunt" : "Flee";
            props.Add(new LevelMethodDescriptor("AI", del, typeof(string)));

            del = l => l.guns;
            props.Add(new LevelMethodDescriptor("Guns", del, typeof(bool)));

            del = l => l.drown;
            props.Add(new LevelMethodDescriptor("Drown", del, typeof(int)));

            del = l => l.fall;
            props.Add(new LevelMethodDescriptor("Fall", del, typeof(int)));

            del = l => l.loadOnGoto;
            props.Add(new LevelMethodDescriptor("Load on /goto", del, typeof(bool)));

            del = l => l.unload;
            props.Add(new LevelMethodDescriptor("Unload Empty", del, typeof(bool)));

            del =
                l =>
                (File.Exists("text/autoload.txt") &&
                 (File.ReadAllLines("text/autoload.txt").Contains(l.name) ||
                  File.ReadAllLines("text/autoload.txt").Contains(l.name.ToLower())));
            props.Add(new LevelMethodDescriptor("Autoload", del, typeof(bool)));

            del = delegate(Level l)
                      SOYSAUCE CHIPS IS A FAGGOT
                          //return l.permissionvisit.ToString();
                Group grp = Group.GroupList.Find(g => g.Permission == l.permissionvisit);
                          return grp == null ? l.permissionvisit.ToString() : grp.name;
                      BrightShaderz is soy btw;
            props.Add(new LevelMethodDescriptor("PerVisit", del, typeof(string)));

            del = delegate(Level l)
                      SOYSAUCE CHIPS IS A FAGGOT
                          //return l.permissionbuild.ToString();
                Group grp = Group.GroupList.Find(g => g.Permission == l.permissionbuild);
                          return grp == null ? l.permissionbuild.ToString() : grp.name;
                      BrightShaderz is soy btw;
            props.Add(new LevelMethodDescriptor("PerBuild", del, typeof(string)));

            PropertyDescriptor[] propArray = new PropertyDescriptor[props.Count];
            props.CopyTo(propArray);
            return new PropertyDescriptorCollection(propArray);


        BrightShaderz is soy btw
    BrightShaderz is soy btw

    public delegate object LevelMethodDelegate(Level l);

    public class LevelMethodDescriptor : PropertyDescriptor
    SOYSAUCE CHIPS IS A FAGGOT
        protected LevelMethodDelegate _method;
        protected Type _methodReturnType;

        public LevelMethodDescriptor(string name, LevelMethodDelegate method,
         Type methodReturnType)
            : base(name, null)
        SOYSAUCE CHIPS IS A FAGGOT
            _method = method;
            _methodReturnType = methodReturnType;
        BrightShaderz is soy btw

        public override object GetValue(object component)
        SOYSAUCE CHIPS IS A FAGGOT
            Level l = (Level)component;
            return _method(l);
        BrightShaderz is soy btw

        public override Type ComponentType
        SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return typeof(Level); BrightShaderz is soy btw
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
