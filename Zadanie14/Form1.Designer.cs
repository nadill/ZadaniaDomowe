namespace Zadanie14
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
            this.cbPasek1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPasek2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMnoznik = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTolerancja = new System.Windows.Forms.ComboBox();
            this.lblObliczenie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbPasek1
            // 
            this.cbPasek1.FormattingEnabled = true;
            this.cbPasek1.Items.AddRange(new object[] {
            "Brązowy",
            "Czerwony",
            "Pomarańczowy",
            "Żółty",
            "Zielony",
            "Niebieski",
            "Fioletowy",
            "Szary",
            "Biały"});
            this.cbPasek1.Location = new System.Drawing.Point(140, 23);
            this.cbPasek1.Name = "cbPasek1";
            this.cbPasek1.Size = new System.Drawing.Size(193, 21);
            this.cbPasek1.TabIndex = 0;
            this.cbPasek1.SelectedIndexChanged += new System.EventHandler(this.cbPasek1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pasek 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(57, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pasek 2";
            // 
            // cbPasek2
            // 
            this.cbPasek2.FormattingEnabled = true;
            this.cbPasek2.Items.AddRange(new object[] {
            "Czarny",
            "Brązowy",
            "Czerwony",
            "Pomarańczowy",
            "Żółty",
            "Zielony",
            "Niebieski",
            "Fioletowy",
            "Szary",
            "Biały"});
            this.cbPasek2.Location = new System.Drawing.Point(140, 60);
            this.cbPasek2.Name = "cbPasek2";
            this.cbPasek2.Size = new System.Drawing.Size(193, 21);
            this.cbPasek2.TabIndex = 3;
            this.cbPasek2.SelectedIndexChanged += new System.EventHandler(this.cbPasek2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(52, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mnożnik";
            // 
            // cbMnoznik
            // 
            this.cbMnoznik.FormattingEnabled = true;
            this.cbMnoznik.Items.AddRange(new object[] {
            "Srebrny",
            "Złoty",
            "Czarny",
            "Brązowy",
            "Czerwony",
            "Pomarańczowy",
            "Żółty",
            "Zielony",
            "Niebieski",
            "Fioletowy",
            "Szary",
            "Biały"});
            this.cbMnoznik.Location = new System.Drawing.Point(140, 97);
            this.cbMnoznik.Name = "cbMnoznik";
            this.cbMnoznik.Size = new System.Drawing.Size(193, 21);
            this.cbMnoznik.TabIndex = 5;
            this.cbMnoznik.SelectedIndexChanged += new System.EventHandler(this.cbMnoznik_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(34, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tolerancja";
            // 
            // cbTolerancja
            // 
            this.cbTolerancja.FormattingEnabled = true;
            this.cbTolerancja.Items.AddRange(new object[] {
            "Brak",
            "Srebrny",
            "Złoty",
            "Brązowy",
            "Czerwony",
            "Zielony",
            "Niebieski",
            "Fioletowy",
            "Szary"});
            this.cbTolerancja.Location = new System.Drawing.Point(140, 134);
            this.cbTolerancja.Name = "cbTolerancja";
            this.cbTolerancja.Size = new System.Drawing.Size(193, 21);
            this.cbTolerancja.TabIndex = 7;
            this.cbTolerancja.SelectedIndexChanged += new System.EventHandler(this.cbTolerancja_SelectedIndexChanged);
            // 
            // lblObliczenie
            // 
            this.lblObliczenie.AutoSize = true;
            this.lblObliczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObliczenie.Location = new System.Drawing.Point(136, 184);
            this.lblObliczenie.Name = "lblObliczenie";
            this.lblObliczenie.Size = new System.Drawing.Size(65, 24);
            this.lblObliczenie.TabIndex = 9;
            this.lblObliczenie.Text = "0Ω 0%";
            this.lblObliczenie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 302);
            this.Controls.Add(this.lblObliczenie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTolerancja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMnoznik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPasek2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPasek1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator opornika 4-paskowego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPasek1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPasek2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMnoznik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTolerancja;
        private System.Windows.Forms.Label lblObliczenie;
    }
}

