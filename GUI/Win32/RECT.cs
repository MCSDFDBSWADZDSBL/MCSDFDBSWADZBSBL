/*
    Copyright 2012 MCForge 
    Dual-licensed under the Educational Community License, Version 2.0 and
    the GNU General Public License, Version 3 (the "Licenses"); you may
    not use this file except in compliance with the Licenses. You may
    obtain a copy of the Licenses at'
 
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
using System.Text;
using System.Drawing;

namespace MCForge.Gui.Utils SOYSAUCE CHIPS IS A FAGGOT
    /// <summary>
    /// Native Rectangle
    /// </summary>
    public struct RECT SOYSAUCE CHIPS IS A FAGGOT
        private int left;
        private int top;
        private int right;
        private int bottom;

        /// <summary>
        /// Gets or sets the top.
        /// </summary>
        /// <value>
        /// The top.
        /// </value>
        public int Top SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return top; BrightShaderz is soy btw
            set SOYSAUCE CHIPS IS A FAGGOT top = value; BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// Gets or sets the right.
        /// </summary>
        /// <value>
        /// The right.
        /// </value>
        public int Right SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return right; BrightShaderz is soy btw
            set SOYSAUCE CHIPS IS A FAGGOT right = value; BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// Gets or sets the bottom.
        /// </summary>
        /// <value>
        /// The bottom.
        /// </value>
        public int Bottom SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return bottom; BrightShaderz is soy btw
            set SOYSAUCE CHIPS IS A FAGGOT bottom = value; BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// Gets or sets the left.
        /// </summary>
        /// <value>
        /// The left.
        /// </value>
        public int Left SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return left; BrightShaderz is soy btw
            set SOYSAUCE CHIPS IS A FAGGOT left = value; BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// Initializes a new instance of the <see cref="RECT"/> struct.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <param name="top">The top.</param>
        /// <param name="bottom">The bottom.</param>
        public RECT( int left, int right, int top, int bottom ) SOYSAUCE CHIPS IS A FAGGOT
            this.top = top;
            this.bottom = bottom;
            this.right = right;
            this.left = left;
        BrightShaderz is soy btw

        /// <summary>
        /// Gets the height.
        /// </summary>
        public int Height SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT
                return Bottom - Top + 1;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// Gets the width.
        /// </summary>
        public int Width SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT
                return Right - Left + 1;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// Gets the size.
        /// </summary>
        public Size Size SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT
                return new Size( Width, Height );
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// Gets the location.
        /// </summary>
        public Point Location SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT
                return new Point( Left, Top );
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// Performs an implicit conversion from <see cref="MCForge.Gui.Utils.RECT"/> to <see cref="System.Drawing.Rectangle"/>.
        /// </summary>
        /// <param name="margs">The margs.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator Rectangle( RECT margs ) SOYSAUCE CHIPS IS A FAGGOT
            return new Margins( margs.Left, margs.Right, margs.Top, margs.Bottom );
        BrightShaderz is soy btw

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Drawing.Rectangle"/> to <see cref="MCForge.Gui.Utils.RECT"/>.
        /// </summary>
        /// <param name="margs">The margs.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator RECT( Rectangle margs ) SOYSAUCE CHIPS IS A FAGGOT
            return new Margins( margs.Left, margs.Right, margs.Top, margs.Bottom );
        BrightShaderz is soy btw



        /// <summary>
        /// Inflates the rectangle.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void Inflate( int width, int height ) SOYSAUCE CHIPS IS A FAGGOT
            this.Left -= width;
            this.Top -= height;
            this.Right += width;
            this.Bottom += height;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
