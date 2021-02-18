namespace MARKET_PROJESİ
{
    partial class Form4
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbxPersonel = new System.Windows.Forms.ComboBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblAdres = new System.Windows.Forms.Label();
            this.LblYİzin = new System.Windows.Forms.Label();
            this.LblMaas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNewMaas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblHizin = new System.Windows.Forms.Label();
            this.lblyıl = new System.Windows.Forms.Label();
            this.lblhafta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(2, -3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "İŞ YERİ KONTROL PANELİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ad-Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 35);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 35);
            this.label8.TabIndex = 7;
            this.label8.Text = "MAAŞ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 35);
            this.label9.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 35);
            this.label10.TabIndex = 9;
            this.label10.Text = "Yıllık İzin:";
            // 
            // CmbxPersonel
            // 
            this.CmbxPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CmbxPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbxPersonel.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbxPersonel.FormattingEnabled = true;
            this.CmbxPersonel.Items.AddRange(new object[] {
            "MÜDÜR X",
            "M.YARDIMCISI X",
            "KASİYER X",
            "MÜDÜR Y",
            "M.YARDIMCISI Y",
            "KASİYER Y",
            "MÜDÜR Z",
            "M.YARDIMCISI Z",
            "KASİYER Z"});
            this.CmbxPersonel.Location = new System.Drawing.Point(324, 91);
            this.CmbxPersonel.Name = "CmbxPersonel";
            this.CmbxPersonel.Size = new System.Drawing.Size(220, 43);
            this.CmbxPersonel.TabIndex = 10;
            this.CmbxPersonel.Text = "PERSONELLER";
            this.CmbxPersonel.SelectedIndexChanged += new System.EventHandler(this.CmbxPersonel_SelectedIndexChanged);
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(375, 151);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(85, 35);
            this.LblAdSoyad.TabIndex = 11;
            this.LblAdSoyad.Text = "label1";
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(375, 202);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(86, 35);
            this.LblTelefon.TabIndex = 12;
            this.LblTelefon.Text = "label2";
            // 
            // LblAdres
            // 
            this.LblAdres.AutoSize = true;
            this.LblAdres.Location = new System.Drawing.Point(375, 253);
            this.LblAdres.Name = "LblAdres";
            this.LblAdres.Size = new System.Drawing.Size(85, 35);
            this.LblAdres.TabIndex = 13;
            this.LblAdres.Text = "label3";
            // 
            // LblYİzin
            // 
            this.LblYİzin.AutoSize = true;
            this.LblYİzin.Location = new System.Drawing.Point(375, 304);
            this.LblYİzin.Name = "LblYİzin";
            this.LblYİzin.Size = new System.Drawing.Size(42, 35);
            this.LblYİzin.TabIndex = 15;
            this.LblYİzin.Text = "14";
            // 
            // LblMaas
            // 
            this.LblMaas.AutoSize = true;
            this.LblMaas.Location = new System.Drawing.Point(375, 401);
            this.LblMaas.Name = "LblMaas";
            this.LblMaas.Size = new System.Drawing.Size(29, 35);
            this.LblMaas.TabIndex = 15;
            this.LblMaas.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 50);
            this.button2.TabIndex = 17;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNewMaas
            // 
            this.txtNewMaas.Location = new System.Drawing.Point(324, 452);
            this.txtNewMaas.Name = "txtNewMaas";
            this.txtNewMaas.Size = new System.Drawing.Size(220, 42);
            this.txtNewMaas.TabIndex = 18;
            this.txtNewMaas.Text = "Yeni Maaşı Giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "ZAM:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 532);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 41);
            this.button3.TabIndex = 20;
            this.button3.Text = "Zam Yap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 35);
            this.label2.TabIndex = 21;
            this.label2.Text = "Haftalık İzin:\r\n";
            // 
            // LblHizin
            // 
            this.LblHizin.AutoSize = true;
            this.LblHizin.Location = new System.Drawing.Point(375, 353);
            this.LblHizin.Name = "LblHizin";
            this.LblHizin.Size = new System.Drawing.Size(28, 35);
            this.LblHizin.TabIndex = 22;
            this.LblHizin.Text = "1";
            // 
            // lblyıl
            // 
            this.lblyıl.AutoSize = true;
            this.lblyıl.Location = new System.Drawing.Point(648, 162);
            this.lblyıl.Name = "lblyıl";
            this.lblyıl.Size = new System.Drawing.Size(29, 35);
            this.lblyıl.TabIndex = 23;
            this.lblyıl.Text = "0";
            // 
            // lblhafta
            // 
            this.lblhafta.AutoSize = true;
            this.lblhafta.Location = new System.Drawing.Point(648, 226);
            this.lblhafta.Name = "lblhafta";
            this.lblhafta.Size = new System.Drawing.Size(29, 35);
            this.lblhafta.TabIndex = 24;
            this.lblhafta.Text = "0";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(802, 637);
            this.Controls.Add(this.lblhafta);
            this.Controls.Add(this.lblyıl);
            this.Controls.Add(this.LblHizin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewMaas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblMaas);
            this.Controls.Add(this.LblYİzin);
            this.Controls.Add(this.LblAdres);
            this.Controls.Add(this.LblTelefon);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.CmbxPersonel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form4";
            this.Text = "PERSONELLER";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LblHizin;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox CmbxPersonel;
        public System.Windows.Forms.Label LblAdSoyad;
        public System.Windows.Forms.Label LblTelefon;
        public System.Windows.Forms.Label LblAdres;
        public System.Windows.Forms.Label LblYİzin;
        public System.Windows.Forms.Label LblMaas;
        public System.Windows.Forms.TextBox txtNewMaas;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label lblyıl;
        public System.Windows.Forms.Label lblhafta;
    }
}