namespace MARKET_PROJESİ
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxUrunler = new System.Windows.Forms.ComboBox();
            this.CmbxPersonel = new System.Windows.Forms.ComboBox();
            this.LblCıkıs = new System.Windows.Forms.Label();
            this.LblTedarik = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 31);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "İŞ YERİ KONTROL PANELİ";
            // 
            // cmbxUrunler
            // 
            this.cmbxUrunler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbxUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbxUrunler.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbxUrunler.ForeColor = System.Drawing.Color.Black;
            this.cmbxUrunler.FormattingEnabled = true;
            this.cmbxUrunler.Items.AddRange(new object[] {
            "STOK DURUMU VE İNDİRİM"});
            this.cmbxUrunler.Location = new System.Drawing.Point(204, 161);
            this.cmbxUrunler.Name = "cmbxUrunler";
            this.cmbxUrunler.Size = new System.Drawing.Size(222, 43);
            this.cmbxUrunler.TabIndex = 8;
            this.cmbxUrunler.Text = "ÜRÜNLER";
            this.cmbxUrunler.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CmbxPersonel
            // 
            this.CmbxPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmbxPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbxPersonel.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbxPersonel.FormattingEnabled = true;
            this.CmbxPersonel.Items.AddRange(new object[] {
            "Personel Bilgileri",
            "Personel Değişikliği"});
            this.CmbxPersonel.Location = new System.Drawing.Point(204, 102);
            this.CmbxPersonel.Name = "CmbxPersonel";
            this.CmbxPersonel.Size = new System.Drawing.Size(222, 43);
            this.CmbxPersonel.TabIndex = 9;
            this.CmbxPersonel.Text = "PERSONELLER";
            this.CmbxPersonel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // LblCıkıs
            // 
            this.LblCıkıs.AutoSize = true;
            this.LblCıkıs.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCıkıs.Location = new System.Drawing.Point(266, 285);
            this.LblCıkıs.Name = "LblCıkıs";
            this.LblCıkıs.Size = new System.Drawing.Size(81, 35);
            this.LblCıkıs.TabIndex = 10;
            this.LblCıkıs.Text = "ÇIKIŞ";
            this.LblCıkıs.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblTedarik
            // 
            this.LblTedarik.AutoSize = true;
            this.LblTedarik.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTedarik.Location = new System.Drawing.Point(211, 230);
            this.LblTedarik.Name = "LblTedarik";
            this.LblTedarik.Size = new System.Drawing.Size(200, 35);
            this.LblTedarik.TabIndex = 11;
            this.LblTedarik.Text = "TEDARİKÇİLER";
            this.LblTedarik.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(654, 389);
            this.Controls.Add(this.LblTedarik);
            this.Controls.Add(this.LblCıkıs);
            this.Controls.Add(this.CmbxPersonel);
            this.Controls.Add(this.cmbxUrunler);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = " MENÜ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxUrunler;
        private System.Windows.Forms.ComboBox CmbxPersonel;
        private System.Windows.Forms.Label LblCıkıs;
        private System.Windows.Forms.Label LblTedarik;
    }
}