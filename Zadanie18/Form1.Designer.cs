namespace Zadanie18
{
    partial class Form1
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
            this.dudPassLen = new System.Windows.Forms.DomainUpDown();
            this.lblPassLen = new System.Windows.Forms.Label();
            this.lblPassCount = new System.Windows.Forms.Label();
            this.dudPassCount = new System.Windows.Forms.DomainUpDown();
            this.gbTypes = new System.Windows.Forms.GroupBox();
            this.rbDigits = new System.Windows.Forms.RadioButton();
            this.rbDigChar = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.lbGeneratedPass = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gbTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dudPassLen
            // 
            this.dudPassLen.Items.Add("1");
            this.dudPassLen.Items.Add("5");
            this.dudPassLen.Items.Add("10");
            this.dudPassLen.Items.Add("15");
            this.dudPassLen.Items.Add("20");
            this.dudPassLen.Location = new System.Drawing.Point(123, 24);
            this.dudPassLen.Name = "dudPassLen";
            this.dudPassLen.Size = new System.Drawing.Size(62, 20);
            this.dudPassLen.TabIndex = 0;
            this.dudPassLen.Text = "1";
            this.dudPassLen.SelectedItemChanged += new System.EventHandler(this.dudPassLen_SelectedItemChanged);
            // 
            // lblPassLen
            // 
            this.lblPassLen.AutoSize = true;
            this.lblPassLen.Location = new System.Drawing.Point(36, 26);
            this.lblPassLen.Name = "lblPassLen";
            this.lblPassLen.Size = new System.Drawing.Size(81, 13);
            this.lblPassLen.TabIndex = 1;
            this.lblPassLen.Text = "Długość hasła:";
            // 
            // lblPassCount
            // 
            this.lblPassCount.AutoSize = true;
            this.lblPassCount.Location = new System.Drawing.Point(220, 26);
            this.lblPassCount.Name = "lblPassCount";
            this.lblPassCount.Size = new System.Drawing.Size(71, 13);
            this.lblPassCount.TabIndex = 3;
            this.lblPassCount.Text = "Liczba haseł:";
            // 
            // dudPassCount
            // 
            this.dudPassCount.Items.Add("1");
            this.dudPassCount.Items.Add("5");
            this.dudPassCount.Items.Add("10");
            this.dudPassCount.Items.Add("15");
            this.dudPassCount.Items.Add("20");
            this.dudPassCount.Location = new System.Drawing.Point(297, 24);
            this.dudPassCount.Name = "dudPassCount";
            this.dudPassCount.Size = new System.Drawing.Size(62, 20);
            this.dudPassCount.TabIndex = 2;
            this.dudPassCount.Text = "1";
            this.dudPassCount.SelectedItemChanged += new System.EventHandler(this.dudPassCount_SelectedItemChanged);
            // 
            // gbTypes
            // 
            this.gbTypes.Controls.Add(this.rbDigits);
            this.gbTypes.Controls.Add(this.rbDigChar);
            this.gbTypes.Controls.Add(this.rbAll);
            this.gbTypes.Location = new System.Drawing.Point(39, 60);
            this.gbTypes.Name = "gbTypes";
            this.gbTypes.Size = new System.Drawing.Size(320, 110);
            this.gbTypes.TabIndex = 4;
            this.gbTypes.TabStop = false;
            this.gbTypes.Text = "Typ hasła";
            // 
            // rbDigits
            // 
            this.rbDigits.AutoSize = true;
            this.rbDigits.Checked = true;
            this.rbDigits.Location = new System.Drawing.Point(23, 29);
            this.rbDigits.Name = "rbDigits";
            this.rbDigits.Size = new System.Drawing.Size(76, 17);
            this.rbDigits.TabIndex = 0;
            this.rbDigits.TabStop = true;
            this.rbDigits.Text = "Tylko cyfry";
            this.rbDigits.UseVisualStyleBackColor = true;
            // 
            // rbDigChar
            // 
            this.rbDigChar.AutoSize = true;
            this.rbDigChar.Location = new System.Drawing.Point(23, 52);
            this.rbDigChar.Name = "rbDigChar";
            this.rbDigChar.Size = new System.Drawing.Size(77, 17);
            this.rbDigChar.TabIndex = 1;
            this.rbDigChar.Text = "Cyfry i litery";
            this.rbDigChar.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(23, 75);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(143, 17);
            this.rbAll.TabIndex = 2;
            this.rbAll.Text = "Cyfry, litery, zn. specjalne";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // lbGeneratedPass
            // 
            this.lbGeneratedPass.FormattingEnabled = true;
            this.lbGeneratedPass.Location = new System.Drawing.Point(39, 179);
            this.lbGeneratedPass.Name = "lbGeneratedPass";
            this.lbGeneratedPass.Size = new System.Drawing.Size(472, 199);
            this.lbGeneratedPass.TabIndex = 5;
            this.lbGeneratedPass.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbGeneratedPass_MouseDoubleClick);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(411, 93);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 36);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generuj";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 407);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lbGeneratedPass);
            this.Controls.Add(this.gbTypes);
            this.Controls.Add(this.lblPassCount);
            this.Controls.Add(this.dudPassCount);
            this.Controls.Add(this.lblPassLen);
            this.Controls.Add(this.dudPassLen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generator haseł";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTypes.ResumeLayout(false);
            this.gbTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dudPassLen;
        private System.Windows.Forms.Label lblPassLen;
        private System.Windows.Forms.Label lblPassCount;
        private System.Windows.Forms.DomainUpDown dudPassCount;
        private System.Windows.Forms.GroupBox gbTypes;
        private System.Windows.Forms.RadioButton rbDigits;
        private System.Windows.Forms.RadioButton rbDigChar;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.ListBox lbGeneratedPass;
        private System.Windows.Forms.Button btnGenerate;
    }
}

