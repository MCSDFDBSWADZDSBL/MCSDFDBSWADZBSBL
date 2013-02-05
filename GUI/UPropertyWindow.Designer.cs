namespace MCSong.GUI
{
    partial class UPropertyWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUpdaterCountdown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.chkNotify = new System.Windows.Forms.CheckBox();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDiscard);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 127);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUpdaterCountdown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkAutoUpdate);
            this.groupBox1.Controls.Add(this.chkNotify);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txtUpdaterCountdown
            // 
            this.txtUpdaterCountdown.Location = new System.Drawing.Point(173, 64);
            this.txtUpdaterCountdown.MaxLength = 3;
            this.txtUpdaterCountdown.Name = "txtUpdaterCountdown";
            this.txtUpdaterCountdown.Size = new System.Drawing.Size(58, 20);
            this.txtUpdaterCountdown.TabIndex = 12;
            this.txtUpdaterCountdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Restart Countdown (In Seconds):";
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAutoUpdate.AutoSize = true;
            this.chkAutoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoUpdate.Location = new System.Drawing.Point(9, 15);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(117, 36);
            this.chkAutoUpdate.TabIndex = 10;
            this.chkAutoUpdate.Text = "Automatically Update\r\nto Latest Version";
            this.chkAutoUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // chkNotify
            // 
            this.chkNotify.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNotify.AutoSize = true;
            this.chkNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotify.Location = new System.Drawing.Point(135, 15);
            this.chkNotify.Name = "chkNotify";
            this.chkNotify.Size = new System.Drawing.Size(96, 36);
            this.chkNotify.TabIndex = 9;
            this.chkNotify.Text = "Notify Players of \r\nRestart In-game";
            this.chkNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNotify.UseVisualStyleBackColor = true;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(3, 99);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(58, 23);
            this.btnDiscard.TabIndex = 5;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(121, 99);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(58, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UPropertyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 127);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UPropertyWindow";
            this.ShowInTaskbar = false;
            this.Text = "Updater Properties";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UPropertyWindow_FormClosed);
            this.Load += new System.EventHandler(this.UPropertyWindow_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUpdaterCountdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
        private System.Windows.Forms.CheckBox chkNotify;

    }
}