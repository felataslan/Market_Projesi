namespace MARKET_PROJESİ
{
    partial class Form10
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
            this.button1 = new System.Windows.Forms.Button();
            this.txthizin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtyizin = new System.Windows.Forms.TextBox();
            this.lblmaas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxmenu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "KULLAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txthizin
            // 
            this.txthizin.Location = new System.Drawing.Point(332, 253);
            this.txthizin.Name = "txthizin";
            this.txthizin.Size = new System.Drawing.Size(100, 42);
            this.txthizin.TabIndex = 14;
            this.txthizin.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 35);
            this.label4.TabIndex = 13;
            this.label4.Text = "HAFTALIK İZİN:";
            // 
            // txtyizin
            // 
            this.txtyizin.Location = new System.Drawing.Point(332, 184);
            this.txtyizin.Name = "txtyizin";
            this.txtyizin.Size = new System.Drawing.Size(100, 42);
            this.txtyizin.TabIndex = 12;
            this.txtyizin.Text = "0";
            // 
            // lblmaas
            // 
            this.lblmaas.AutoSize = true;
            this.lblmaas.Location = new System.Drawing.Point(343, 137);
            this.lblmaas.Name = "lblmaas";
            this.lblmaas.Size = new System.Drawing.Size(70, 35);
            this.lblmaas.TabIndex = 11;
            this.lblmaas.Text = "2000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "YILLIK İZİN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "MAAŞIM:";
            // 
            // cmbxmenu
            // 
            this.cmbxmenu.FormattingEnabled = true;
            this.cmbxmenu.Items.AddRange(new object[] {
            "ÇIKIŞ"});
            this.cmbxmenu.Location = new System.Drawing.Point(318, 78);
            this.cmbxmenu.Name = "cmbxmenu";
            this.cmbxmenu.Size = new System.Drawing.Size(166, 43);
            this.cmbxmenu.TabIndex = 8;
            this.cmbxmenu.Text = "MENÜ";
            this.cmbxmenu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txthizin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtyizin);
            this.Controls.Add(this.lblmaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxmenu);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form10";
            this.Text = "UNVAN: KASİYER";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txthizin;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtyizin;
        public System.Windows.Forms.Label lblmaas;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbxmenu;
    }
}