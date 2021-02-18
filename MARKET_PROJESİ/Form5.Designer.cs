namespace MARKET_PROJESİ
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbleisandTerfi = new System.Windows.Forms.Label();
            this.cmbxEis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxYis = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbxpersonel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbxmenu = new System.Windows.Forms.ComboBox();
            this.cmbxmevki = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "İŞ YERİ KONTROL PANELİ";
            // 
            // lbleisandTerfi
            // 
            this.lbleisandTerfi.AutoSize = true;
            this.lbleisandTerfi.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleisandTerfi.Location = new System.Drawing.Point(324, 202);
            this.lbleisandTerfi.Name = "lbleisandTerfi";
            this.lbleisandTerfi.Size = new System.Drawing.Size(140, 35);
            this.lbleisandTerfi.TabIndex = 5;
            this.lbleisandTerfi.Text = "Eski İş Yeri";
            this.lbleisandTerfi.Visible = false;
            // 
            // cmbxEis
            // 
            this.cmbxEis.FormattingEnabled = true;
            this.cmbxEis.Items.AddRange(new object[] {
            "Market X",
            "Market Y",
            "Market Z"});
            this.cmbxEis.Location = new System.Drawing.Point(297, 274);
            this.cmbxEis.Name = "cmbxEis";
            this.cmbxEis.Size = new System.Drawing.Size(225, 43);
            this.cmbxEis.TabIndex = 7;
            this.cmbxEis.Text = "Şubesini Seçiniz:";
            this.cmbxEis.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(597, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yeni İş Yeri";
            this.label4.Visible = false;
            // 
            // cmbxYis
            // 
            this.cmbxYis.FormattingEnabled = true;
            this.cmbxYis.Items.AddRange(new object[] {
            "Market X",
            "Market Y",
            "Market Z"});
            this.cmbxYis.Location = new System.Drawing.Point(579, 274);
            this.cmbxYis.Name = "cmbxYis";
            this.cmbxYis.Size = new System.Drawing.Size(232, 43);
            this.cmbxYis.TabIndex = 8;
            this.cmbxYis.Text = "Şubesini Seçiniz:";
            this.cmbxYis.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "DEĞİŞTİR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbxpersonel
            // 
            this.cmbxpersonel.FormattingEnabled = true;
            this.cmbxpersonel.Items.AddRange(new object[] {
            "MÜDÜR X",
            "MÜDÜR Y",
            "MÜDÜR Z",
            "M.YARDIMCISI X",
            "M.YARDIMCISI Y",
            "M.YARDIMCISI Z",
            "KASİYER X",
            "KASİYER Y",
            "KASİYER Z"});
            this.cmbxpersonel.Location = new System.Drawing.Point(6, 274);
            this.cmbxpersonel.Name = "cmbxpersonel";
            this.cmbxpersonel.Size = new System.Drawing.Size(225, 43);
            this.cmbxpersonel.TabIndex = 16;
            this.cmbxpersonel.Text = "Personeli Seçiniz";
            this.cmbxpersonel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 35);
            this.label5.TabIndex = 17;
            this.label5.Text = "PERSONELLER";
            this.label5.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(680, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 56);
            this.button2.TabIndex = 18;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(680, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 53);
            this.button3.TabIndex = 19;
            this.button3.Text = "GERİ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbxmenu
            // 
            this.cmbxmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbxmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbxmenu.FormattingEnabled = true;
            this.cmbxmenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbxmenu.Items.AddRange(new object[] {
            "PERSONEL YER DEĞİŞİKLİĞİ",
            "TERFİ"});
            this.cmbxmenu.Location = new System.Drawing.Point(263, 129);
            this.cmbxmenu.Name = "cmbxmenu";
            this.cmbxmenu.Size = new System.Drawing.Size(301, 43);
            this.cmbxmenu.TabIndex = 20;
            this.cmbxmenu.Text = "MENÜ";
            this.cmbxmenu.SelectedIndexChanged += new System.EventHandler(this.cmbxmenu_SelectedIndexChanged);
            // 
            // cmbxmevki
            // 
            this.cmbxmevki.FormattingEnabled = true;
            this.cmbxmevki.Items.AddRange(new object[] {
            "MÜDÜR",
            "M.YARDIMCISI"});
            this.cmbxmevki.Location = new System.Drawing.Point(263, 274);
            this.cmbxmevki.Name = "cmbxmevki";
            this.cmbxmevki.Size = new System.Drawing.Size(283, 43);
            this.cmbxmevki.TabIndex = 21;
            this.cmbxmevki.Text = "Yeni mevkisini giriniz";
            this.cmbxmevki.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(823, 513);
            this.Controls.Add(this.cmbxmevki);
            this.Controls.Add(this.cmbxmenu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbxpersonel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbxYis);
            this.Controls.Add(this.cmbxEis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbleisandTerfi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form5";
            this.Text = "PERSONEL DEĞİŞİKLİĞİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbleisandTerfi;
        private System.Windows.Forms.ComboBox cmbxEis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxYis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbxpersonel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ComboBox cmbxmenu;
        private System.Windows.Forms.ComboBox cmbxmevki;
    }
}