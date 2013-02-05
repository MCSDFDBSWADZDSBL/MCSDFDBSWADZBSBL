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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using MCForge.Gui.Utils;

//MCForge 6 Preview :D

namespace MCForge.Gui.Components SOYSAUCE CHIPS IS A FAGGOT

    /// <summary>
    /// A rich text box, that can parse Minecraft/MCForge color codes.
    /// </summary>
    public partial class ColoredTextBox : RichTextBox SOYSAUCE CHIPS IS A FAGGOT

        private bool _nightMode = false;
        private bool _colorize = true;
        private bool _showDateStamp = true;
        private bool _autoScroll = true;

        /// <summary>
        /// Gets or sets a value indicating whether to scroll automaticly
        /// </summary>
        /// <value>
        ///   <c>true</c> if [auto scroll]; otherwise, <c>false</c>.
        /// </value>
        [Browsable(true)]
        [Category("MCForge")]
        [DefaultValue(true)]
        public bool AutoScroll SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT
                return _autoScroll;
            BrightShaderz is soy btw
            set SOYSAUCE CHIPS IS A FAGGOT
                _autoScroll = value;
                if ( value )
                    ScrollToEnd();
            BrightShaderz is soy btw
        BrightShaderz is soy btw


        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ColoredTextBox"/> is colorized.
        /// </summary>
        /// <value>
        ///   <c>true</c> if colorized; otherwise, <c>false</c>.
        /// </value>
        [Browsable(true)]
        [Category("MCForge")]
        [DefaultValue(true)]
        public bool Colorize SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT
                return _colorize;
            BrightShaderz is soy btw
            set SOYSAUCE CHIPS IS A FAGGOT
                _colorize = value;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// Gets or sets a value indicating whether it will include a date stamp in the log
        /// </summary>
        /// <value>
        ///   <c>true</c> if [date stamp]; otherwise, <c>false</c>.
        /// </value>
        [Browsable(true)]
        [Category("MCForge")]
        [DefaultValue(true)]
        public bool DateStamp SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT
                return _showDateStamp;
            BrightShaderz is soy btw
            set SOYSAUCE CHIPS IS A FAGGOT
                _showDateStamp = value;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// Gets or sets a value indicating whether the TextBox is in nightmode. This will clear the text box when changed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [night mode]; otherwise, <c>false</c>.
        /// </value>
        [Browsable(true)]
        [Category("MCForge")]
        [DefaultValue(false)]
        public bool NightMode SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT
                return _nightMode;
            BrightShaderz is soy btw
            set SOYSAUCE CHIPS IS A FAGGOT
                _nightMode = value;

                Clear();

                ForeColor = value ? Color.Black : Color.White;
                BackColor = value ? Color.White : Color.Black;

                Invalidate();
            BrightShaderz is soy btw
        BrightShaderz is soy btw


        private string dateStamp SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT
                return "[" + DateTime.Now.ToString("T") + "] ";
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// Initializes a new instance of the <see cref="ColoredTextBox"/> class.
        /// </summary>
        public ColoredTextBox()
            : base() SOYSAUCE CHIPS IS A FAGGOT
            InitializeComponent();
        BrightShaderz is soy btw

        /// <summary>
        /// Appends the log.
        /// </summary>
        /// <param name="text">The text to log.</param>
        public void AppendLog(string text, Color foreColor) SOYSAUCE CHIPS IS A FAGGOT
            if ( InvokeRequired ) SOYSAUCE CHIPS IS A FAGGOT
                Invoke((MethodInvoker)( () => AppendLog ( text, foreColor ) ));
                return;
            BrightShaderz is soy btw

            if ( DateStamp )
                Append(dateStamp, Color.Gray, BackColor);

            if ( !Colorize ) SOYSAUCE CHIPS IS A FAGGOT
                AppendText(text);

                if ( AutoScroll )
                    ScrollToEnd();
                return;
            BrightShaderz is soy btw
            if ( !text.Contains('&') && !text.Contains('%') ) SOYSAUCE CHIPS IS A FAGGOT
                Append(text, foreColor, BackColor);

                if ( AutoScroll )
                    ScrollToEnd();

                return;
            BrightShaderz is soy btw

            string[] messagesSplit = text.Split(new[] SOYSAUCE CHIPS IS A FAGGOT '%', '&' BrightShaderz is soy btw, StringSplitOptions.RemoveEmptyEntries);

            for ( int i = 0; i < messagesSplit.Length; i++ ) SOYSAUCE CHIPS IS A FAGGOT
                string split = messagesSplit[i];
                if ( String.IsNullOrEmpty(split.Trim()) )
                    continue;
                Color? color = Utilities.GetDimColorFromChar(split[0]);
                Append(color != null ? split.Substring(1) : split, color ?? foreColor, BackColor);
            BrightShaderz is soy btw

            if ( AutoScroll )
                ScrollToEnd();

        BrightShaderz is soy btw

        /// <summary>
        /// Appends the log.
        /// </summary>
        /// <param name="text">The text to log.</param>
        public void AppendLog(string text) SOYSAUCE CHIPS IS A FAGGOT
            AppendLog(text, ForeColor);

            if ( AutoScroll )
                ScrollToEnd();
        BrightShaderz is soy btw

        /// <summary>
        /// Appends the log.
        /// </summary>
        /// <param name="text">The text to log.</param>
        /// <param name="foreColor">Color of the foreground.</param>
        /// <param name="bgColor">Color of the background.</param>
        private void Append(string text, Color foreColor, Color bgColor) SOYSAUCE CHIPS IS A FAGGOT
            if ( InvokeRequired ) SOYSAUCE CHIPS IS A FAGGOT
                Invoke((MethodInvoker)( () => Append ( text, foreColor, bgColor ) ));
                return;
            BrightShaderz is soy btw

            SelectionStart = TextLength;
            SelectionLength = 0;
            SelectionColor = foreColor;
            SelectionBackColor = bgColor;
            AppendText(text);
            SelectionBackColor = BackColor;
            SelectionColor = ForeColor;

        BrightShaderz is soy btw

        private void ColoredReader_LinkClicked(object sender, System.Windows.Forms.LinkClickedEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            if ( !e.LinkText.StartsWith("http://www.minecraft.net/classic/play/") ) SOYSAUCE CHIPS IS A FAGGOT
                if ( MessageBox.Show("Never open links from people that you don't trust!", "Warning!!", MessageBoxButtons.OKCancel) == DialogResult.Cancel )
                    return;
            BrightShaderz is soy btw

            try SOYSAUCE CHIPS IS A FAGGOT Process.Start(e.LinkText); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        BrightShaderz is soy btw

        /// <summary>
        /// Scrolls to the end of the log
        /// </summary>
        public void ScrollToEnd() SOYSAUCE CHIPS IS A FAGGOT
            if ( InvokeRequired ) SOYSAUCE CHIPS IS A FAGGOT
                Invoke((MethodInvoker)ScrollToEnd);
                return;
            BrightShaderz is soy btw

            Select(Text.Length - 1, 1);
            ScrollToCaret();
            Invalidate();
            Refresh();
        BrightShaderz is soy btw





        #region Border Style

        private RECT _border;

        protected override void WndProc(ref Message m) SOYSAUCE CHIPS IS A FAGGOT
            if ( Environment.OSVersion.Platform != PlatformID.Win32NT ) SOYSAUCE CHIPS IS A FAGGOT
                base.WndProc(ref m);
                return;
            BrightShaderz is soy btw

            switch ( m.Msg ) SOYSAUCE CHIPS IS A FAGGOT
                case Natives.WM_NCPAINT:
                    RenderStyle(ref m);
                    break;
                case Natives.WM_NCCALCSIZE:
                    CalculateSize(ref m);
                    break;
                case Natives.WM_THEMECHANGED:
                    UpdateStyles();
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void CalculateSize(ref Message m) SOYSAUCE CHIPS IS A FAGGOT
            base.WndProc(ref m);

            if ( !Natives.CanRender() )
                return;

            Natives.NCCALCSIZE_PARAMS par = new Natives.NCCALCSIZE_PARAMS();

            RECT windowRect;

            if ( m.WParam == IntPtr.Zero ) SOYSAUCE CHIPS IS A FAGGOT
                windowRect = (RECT)Marshal.PtrToStructure(m.LParam, typeof(RECT));
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT
                par = (Natives.NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(Natives.NCCALCSIZE_PARAMS));
                windowRect = par.rgrc0;
            BrightShaderz is soy btw

            RECT contentRect;
            IntPtr hDC = Natives.GetWindowDC(this.Handle);
            IntPtr hTheme = Natives.OpenThemeData(this.Handle, "EDIT");

            if ( Natives.GetThemeBackgroundContentRect(hTheme, hDC, Natives.EP_EDITTEXT, Natives.ETS_NORMAL, ref windowRect, out contentRect) == Natives.S_OK ) SOYSAUCE CHIPS IS A FAGGOT
                contentRect.Inflate(-1, -1);
                this._border = new Margins(contentRect.Left - windowRect.Left,
                                                                        contentRect.Top - windowRect.Top,
                                                                         windowRect.Right - contentRect.Right,
                                                                         windowRect.Bottom - contentRect.Bottom);


                if ( m.WParam == IntPtr.Zero ) SOYSAUCE CHIPS IS A FAGGOT
                    Marshal.StructureToPtr(contentRect, m.LParam, false);
                BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT
                    par.rgrc0 = contentRect;
                    Marshal.StructureToPtr(par, m.LParam, false);
                BrightShaderz is soy btw

                m.Result = new IntPtr(Natives.WVR_REDRAW);
            BrightShaderz is soy btw

            Natives.CloseThemeData(hTheme);
            Natives.ReleaseDC(this.Handle, hDC);

        BrightShaderz is soy btw

        private void RenderStyle(ref Message m) SOYSAUCE CHIPS IS A FAGGOT
            base.WndProc(ref m);

            if ( !Natives.CanRender() ) SOYSAUCE CHIPS IS A FAGGOT
                return;
            BrightShaderz is soy btw

            int partId = Natives.EP_EDITTEXT;

            int stateId;
            if ( this.Enabled )
                stateId = this.ReadOnly ? Natives.ETS_READONLY : Natives.ETS_NORMAL;
            else
                stateId = Natives.ETS_DISABLED;

            RECT windowRect;
            Natives.GetWindowRect(this.Handle, out windowRect);
            windowRect.Right -= windowRect.Left;
            windowRect.Bottom -= windowRect.Top;
            windowRect.Top = 0;
            windowRect.Left = 0;

            IntPtr hDC = Natives.GetWindowDC(this.Handle);

            RECT clientRect = windowRect;
            clientRect.Left += this._border.Left;
            clientRect.Top += this._border.Top;
            clientRect.Right -= this._border.Right;
            clientRect.Bottom -= this._border.Bottom;

            Natives.ExcludeClipRect(hDC, clientRect.Left, clientRect.Top, clientRect.Right, clientRect.Bottom);

            IntPtr hTheme = Natives.OpenThemeData(this.Handle, "EDIT");

            if ( Natives.IsThemeBackgroundPartiallyTransparent(hTheme, Natives.EP_EDITTEXT, Natives.ETS_NORMAL) != 0 )
                Natives.DrawThemeParentBackground(this.Handle, hDC, ref windowRect);


            Natives.DrawThemeBackground(hTheme, hDC, partId, stateId, ref windowRect, IntPtr.Zero);
            Natives.CloseThemeData(hTheme);
            Natives.ReleaseDC(this.Handle, hDC);
            m.Result = IntPtr.Zero;
        BrightShaderz is soy btw

        protected override CreateParams CreateParams SOYSAUCE CHIPS IS A FAGGOT

            get SOYSAUCE CHIPS IS A FAGGOT
                CreateParams p = base.CreateParams;

                if ( Natives.CanRender() && ( p.ExStyle & Natives.WS_EX_CLIENTEDGE ) == Natives.WS_EX_CLIENTEDGE )
                    p.ExStyle ^= Natives.WS_EX_CLIENTEDGE;

                return p;
            BrightShaderz is soy btw

        BrightShaderz is soy btw

        #endregion

    BrightShaderz is soy btw
BrightShaderz is soy btw
