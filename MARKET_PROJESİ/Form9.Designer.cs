namespace MARKET_PROJESİ
{
    partial class Form9
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
            this.cmbxmenü = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmaas = new System.Windows.Forms.Label();
            this.txthizin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtyizin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbxmenü
            // 
            this.cmbxmenü.FormattingEnabled = true;
            this.cmbxmenü.Items.AddRange(new object[] {
            "ÇIKIŞ"});
            this.cmbxmenü.Location = new System.Drawing.Point(260, 98);
            this.cmbxmenü.Name = "cmbxmenü";
            this.cmbxmenü.Size = new System.Drawing.Size(158, 43);
            this.cmbxmenü.TabIndex = 0;
            this.cmbxmenü.Text = "MENÜ";
            this.cmbxmenü.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAAŞIM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "YILLIK İZİN:";
            // 
            // lblmaas
            // 
            this.lblmaas.AutoSize = true;
            this.lblmaas.Location = new System.Drawing.Point(289, 169);
            this.lblmaas.Name = "lblmaas";
            this.lblmaas.Size = new System.Drawing.Size(69, 35);
            this.lblmaas.TabIndex = 3;
            this.lblmaas.Text = "5000";
            // 
            // txthizin
            // 
            this.txthizin.Location = new System.Drawing.Point(282, 285);
            this.txthizin.Name = "txthizin";
            this.txthizin.Size = new System.Drawing.Size(100, 42);
            this.txthizin.TabIndex = 4;
            this.txthizin.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "HAFTALIK İZİN:";
            // 
            // txtyizin
            // 
            this.txtyizin.Location = new System.Drawing.Point(282, 216);
            this.txtyizin.Name = "txtyizin";
            this.txtyizin.Size = new System.Drawing.Size(100, 42);
            this.txtyizin.TabIndex = 6;
            this.txtyizin.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "KULLAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(595, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtyizin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthizin);
            this.Controls.Add(this.lblmaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxmenü);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form9";
            this.Text = "ÜNVAN:M.YARDIMCISI";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbxmenü;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblmaas;
        public System.Windows.Forms.TextBox txthizin;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtyizin;
        public System.Windows.Forms.Button button1;
    }
}