namespace MARKET_PROJESİ
{
    partial class Form6
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CmbxStok = new System.Windows.Forms.ComboBox();
            this.CmBxIndirim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndirim = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.LblStk1 = new System.Windows.Forms.Label();
            this.LblStk2 = new System.Windows.Forms.Label();
            this.LblStk3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "İŞ YERİ KONTROL PANELİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 70);
            this.label5.TabIndex = 6;
            this.label5.Text = "STOK:\r\n\r\n";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(359, 343);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(56, 35);
            this.lblStok.TabIndex = 9;
            this.lblStok.Text = "100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(595, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CmbxStok
            // 
            this.CmbxStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmbxStok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbxStok.FormattingEnabled = true;
            this.CmbxStok.Items.AddRange(new object[] {
            "GIDA",
            "TEMİZLİK",
            "KAMPANYALI ÜRÜN"});
            this.CmbxStok.Location = new System.Drawing.Point(282, 271);
            this.CmbxStok.Name = "CmbxStok";
            this.CmbxStok.Size = new System.Drawing.Size(229, 43);
            this.CmbxStok.TabIndex = 13;
            this.CmbxStok.Text = "STOK DURUMU";
            this.CmbxStok.SelectedIndexChanged += new System.EventHandler(this.CmbxStok_SelectedIndexChanged);
            // 
            // CmBxIndirim
            // 
            this.CmBxIndirim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmBxIndirim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmBxIndirim.FormattingEnabled = true;
            this.CmBxIndirim.Items.AddRange(new object[] {
            "GIDA",
            "TEMİZLİK",
            "KAMPANYALI ÜRÜN"});
            this.CmBxIndirim.Location = new System.Drawing.Point(282, 77);
            this.CmBxIndirim.Name = "CmBxIndirim";
            this.CmBxIndirim.Size = new System.Drawing.Size(229, 43);
            this.CmBxIndirim.TabIndex = 15;
            this.CmBxIndirim.Text = "İNDİRİM YAP";
            //this.CmBxIndirim.SelectedIndexChanged += new System.EventHandler(this.CmBxIndirim_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "İndirim Yüzdesi:";
            // 
            // txtIndirim
            // 
            this.txtIndirim.Location = new System.Drawing.Point(327, 134);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(126, 42);
            this.txtIndirim.TabIndex = 17;
            this.txtIndirim.Text = "50";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 50);
            this.button3.TabIndex = 18;
            this.button3.Text = "Uygula";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LblStk1
            // 
            this.LblStk1.AutoSize = true;
            this.LblStk1.Location = new System.Drawing.Point(25, 421);
            this.LblStk1.Name = "LblStk1";
            this.LblStk1.Size = new System.Drawing.Size(29, 35);
            this.LblStk1.TabIndex = 19;
            this.LblStk1.Text = "0";
            this.LblStk1.Visible = false;
            // 
            // LblStk2
            // 
            this.LblStk2.AutoSize = true;
            this.LblStk2.Location = new System.Drawing.Point(25, 478);
            this.LblStk2.Name = "LblStk2";
            this.LblStk2.Size = new System.Drawing.Size(29, 35);
            this.LblStk2.TabIndex = 20;
            this.LblStk2.Text = "0";
            this.LblStk2.Visible = false;
            // 
            // LblStk3
            // 
            this.LblStk3.AutoSize = true;
            this.LblStk3.Location = new System.Drawing.Point(25, 532);
            this.LblStk3.Name = "LblStk3";
            this.LblStk3.Size = new System.Drawing.Size(29, 35);
            this.LblStk3.TabIndex = 21;
            this.LblStk3.Text = "0";
            this.LblStk3.Visible = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(742, 576);
            this.Controls.Add(this.LblStk3);
            this.Controls.Add(this.LblStk2);
            this.Controls.Add(this.LblStk1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtIndirim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmBxIndirim);
            this.Controls.Add(this.CmbxStok);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form6";
            this.Text = "STOK DURUMU";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox CmbxStok;
        public System.Windows.Forms.Label lblStok;
        public System.Windows.Forms.ComboBox CmBxIndirim;
        public System.Windows.Forms.TextBox txtIndirim;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LblStk1;
        public System.Windows.Forms.Label LblStk2;
        public System.Windows.Forms.Label LblStk3;
    }
}