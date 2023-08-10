namespace StokTakip
{
    partial class Eposta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eposta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDosya = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richtxtIcerik = new System.Windows.Forms.RichTextBox();
            this.txtIcerikBasligi = new System.Windows.Forms.TextBox();
            this.txtdosyaYolu = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbGonderici = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAlıcı = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDosya);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richtxtIcerik);
            this.panel1.Controls.Add(this.txtIcerikBasligi);
            this.panel1.Controls.Add(this.txtdosyaYolu);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 221);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "İçerik :";
            // 
            // btnDosya
            // 
            this.btnDosya.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDosya.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDosya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDosya.ForeColor = System.Drawing.Color.White;
            this.btnDosya.Location = new System.Drawing.Point(4, 188);
            this.btnDosya.Name = "btnDosya";
            this.btnDosya.Size = new System.Drawing.Size(106, 22);
            this.btnDosya.TabIndex = 5;
            this.btnDosya.Text = "Dosya Ekle";
            this.btnDosya.UseVisualStyleBackColor = false;
            this.btnDosya.Click += new System.EventHandler(this.btnDosya_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "İçerik Başlığı : ";
            // 
            // richtxtIcerik
            // 
            this.richtxtIcerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richtxtIcerik.Location = new System.Drawing.Point(115, 35);
            this.richtxtIcerik.Name = "richtxtIcerik";
            this.richtxtIcerik.Size = new System.Drawing.Size(391, 150);
            this.richtxtIcerik.TabIndex = 4;
            this.richtxtIcerik.Text = "";
            // 
            // txtIcerikBasligi
            // 
            this.txtIcerikBasligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIcerikBasligi.Location = new System.Drawing.Point(116, 10);
            this.txtIcerikBasligi.Name = "txtIcerikBasligi";
            this.txtIcerikBasligi.Size = new System.Drawing.Size(391, 22);
            this.txtIcerikBasligi.TabIndex = 3;
            // 
            // txtdosyaYolu
            // 
            this.txtdosyaYolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdosyaYolu.Location = new System.Drawing.Point(116, 188);
            this.txtdosyaYolu.Name = "txtdosyaYolu";
            this.txtdosyaYolu.Size = new System.Drawing.Size(391, 22);
            this.txtdosyaYolu.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cmbGonderici);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbAlıcı);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 51);
            this.panel2.TabIndex = 0;
            // 
            // cmbGonderici
            // 
            this.cmbGonderici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGonderici.FormattingEnabled = true;
            this.cmbGonderici.Location = new System.Drawing.Point(370, 16);
            this.cmbGonderici.Name = "cmbGonderici";
            this.cmbGonderici.Size = new System.Drawing.Size(136, 24);
            this.cmbGonderici.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(283, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gönderen : ";
            // 
            // cmbAlıcı
            // 
            this.cmbAlıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAlıcı.FormattingEnabled = true;
            this.cmbAlıcı.Location = new System.Drawing.Point(116, 16);
            this.cmbAlıcı.Name = "cmbAlıcı";
            this.cmbAlıcı.Size = new System.Drawing.Size(136, 24);
            this.cmbAlıcı.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(61, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alıcı : ";
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGonder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGonder.FlatAppearance.BorderSize = 2;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.Color.White;
            this.btnGonder.Location = new System.Drawing.Point(236, 330);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(113, 32);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // Eposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 381);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Eposta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İletişim";
            this.Load += new System.EventHandler(this.Eposta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDosya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richtxtIcerik;
        private System.Windows.Forms.TextBox txtIcerikBasligi;
        private System.Windows.Forms.TextBox txtdosyaYolu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.ComboBox cmbAlıcı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGonderici;
    }
}