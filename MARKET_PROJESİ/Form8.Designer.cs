namespace MARKET_PROJESİ
{
    partial class Form8
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
            this.cmbxMenü = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYılizin = new System.Windows.Forms.TextBox();
            this.txtHizin = new System.Windows.Forms.TextBox();
            this.txtindirim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmaas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbxMenü
            // 
            this.cmbxMenü.FormattingEnabled = true;
            this.cmbxMenü.Items.AddRange(new object[] {
            "İNDİRİM",
            "İZİN AL",
            "ÇIKIŞ"});
            this.cmbxMenü.Location = new System.Drawing.Point(227, 57);
            this.cmbxMenü.Name = "cmbxMenü";
            this.cmbxMenü.Size = new System.Drawing.Size(184, 43);
            this.cmbxMenü.TabIndex = 0;
            this.cmbxMenü.Text = "MENÜ";
            this.cmbxMenü.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "YILLIK İZİN:\r\n";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "İNDİRİM YÜZDESİ:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 35);
            this.label3.TabIndex = 2;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "HAFTALIK İZİN:\r\n";
            this.label4.Visible = false;
            // 
            // txtYılizin
            // 
            this.txtYılizin.Location = new System.Drawing.Point(261, 162);
            this.txtYılizin.Name = "txtYılizin";
            this.txtYılizin.Size = new System.Drawing.Size(114, 42);
            this.txtYılizin.TabIndex = 4;
            this.txtYılizin.Text = "0";
            this.txtYılizin.Visible = false;
            // 
            // txtHizin
            // 
            this.txtHizin.Location = new System.Drawing.Point(261, 219);
            this.txtHizin.Name = "txtHizin";
            this.txtHizin.Size = new System.Drawing.Size(114, 42);
            this.txtHizin.TabIndex = 5;
            this.txtHizin.Text = "0";
            this.txtHizin.Visible = false;
            // 
            // txtindirim
            // 
            this.txtindirim.Location = new System.Drawing.Point(261, 272);
            this.txtindirim.Name = "txtindirim";
            this.txtindirim.Size = new System.Drawing.Size(114, 42);
            this.txtindirim.TabIndex = 6;
            this.txtindirim.Text = "0";
            this.txtindirim.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "UYGULA\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "MAAŞIM:";
            // 
            // lblmaas
            // 
            this.lblmaas.AutoSize = true;
            this.lblmaas.Location = new System.Drawing.Point(280, 117);
            this.lblmaas.Name = "lblmaas";
            this.lblmaas.Size = new System.Drawing.Size(71, 35);
            this.lblmaas.TabIndex = 9;
            this.lblmaas.Text = "8000";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(619, 419);
            this.Controls.Add(this.lblmaas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtindirim);
            this.Controls.Add(this.txtHizin);
            this.Controls.Add(this.txtYılizin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxMenü);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form8";
            this.Text = "ÜNVAN:MÜDÜR";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbxMenü;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtYılizin;
        public System.Windows.Forms.TextBox txtHizin;
        public System.Windows.Forms.TextBox txtindirim;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblmaas;
    }
}