namespace MCSong.GUI
{
    partial class TextWindow
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
            this.components = new System.ComponentModel.Container();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.cmbFile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(12, 39);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditor.Size = new System.Drawing.Size(357, 418);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.Text = "Choose a text file above and click the Load button to edit it.";
            // 
            // cmbFile
            // 
            this.cmbFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFile.FormattingEnabled = true;
            this.cmbFile.Location = new System.Drawing.Point(190, 12);
            this.cmbFile.Name = "cmbFile";
            this.cmbFile.Size = new System.Drawing.Size(131, 21);
            this.cmbFile.TabIndex = 1;
            this.cmbFile.SelectedIndexChanged += new System.EventHandler(this.cmbFile_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a File:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(327, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(42, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(62, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loaded File:";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(83, 463);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(286, 20);
            this.txtFile.TabIndex = 7;
            this.txtFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 10);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 505);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Create New:";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(93, 507);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(151, 20);
            this.txtNew.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(276, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Loaded";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 507);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(21, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = ".txt";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 535);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFile);
            this.Controls.Add(this.txtEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextWindow";
            this.ShowInTaskbar = false;
            this.Text = "Edit Text Files";
            this.Load += new System.EventHandler(this.TextWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.ComboBox cmbFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox2;
    }
}