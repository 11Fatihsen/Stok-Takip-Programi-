namespace StokTakip
{
    partial class Reyon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reyon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGönder = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSon = new System.Windows.Forms.Button();
            this.btnOrta = new System.Windows.Forms.Button();
            this.btnIleeri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnIlk = new System.Windows.Forms.Button();
            this.txtCinsi = new System.Windows.Forms.TextBox();
            this.txtKdvFiyat = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(32, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 369);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "*    Reyona Gönderilecek Ürünü Seçiniz.";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnGönder);
            this.panel2.Controls.Add(this.txtMiktar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtBarkod);
            this.panel2.Controls.Add(this.txtStok);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Location = new System.Drawing.Point(518, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 432);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 35;
            this.button1.Text = "Reyon Raporu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGönder
            // 
            this.btnGönder.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGönder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGönder.FlatAppearance.BorderSize = 2;
            this.btnGönder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGönder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGönder.ForeColor = System.Drawing.Color.White;
            this.btnGönder.Location = new System.Drawing.Point(43, 273);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(81, 36);
            this.btnGönder.TabIndex = 34;
            this.btnGönder.Text = "Gönder";
            this.btnGönder.UseVisualStyleBackColor = false;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(14, 233);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(142, 22);
            this.txtMiktar.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(17, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Miktarı :";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(14, 182);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(142, 22);
            this.txtBarkod.TabIndex = 32;
            // 
            // txtStok
            // 
            this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStok.Location = new System.Drawing.Point(14, 131);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(142, 22);
            this.txtStok.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Barkod No : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(14, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 16);
            this.label20.TabIndex = 31;
            this.label20.Text = "Stok No : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnSon);
            this.panel3.Controls.Add(this.btnOrta);
            this.panel3.Controls.Add(this.btnIleeri);
            this.panel3.Controls.Add(this.btnGeri);
            this.panel3.Controls.Add(this.btnIlk);
            this.panel3.Location = new System.Drawing.Point(125, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 43);
            this.panel3.TabIndex = 2;
            // 
            // btnSon
            // 
            this.btnSon.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSon.FlatAppearance.BorderSize = 2;
            this.btnSon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSon.Image = ((System.Drawing.Image)(resources.GetObject("btnSon.Image")));
            this.btnSon.Location = new System.Drawing.Point(233, 3);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(44, 33);
            this.btnSon.TabIndex = 5;
            this.btnSon.UseVisualStyleBackColor = false;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // btnOrta
            // 
            this.btnOrta.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOrta.Enabled = false;
            this.btnOrta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrta.FlatAppearance.BorderSize = 2;
            this.btnOrta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrta.ForeColor = System.Drawing.Color.White;
            this.btnOrta.Location = new System.Drawing.Point(96, 3);
            this.btnOrta.Name = "btnOrta";
            this.btnOrta.Size = new System.Drawing.Size(88, 33);
            this.btnOrta.TabIndex = 2;
            this.btnOrta.UseVisualStyleBackColor = false;
            // 
            // btnIleeri
            // 
            this.btnIleeri.BackColor = System.Drawing.Color.CadetBlue;
            this.btnIleeri.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIleeri.FlatAppearance.BorderSize = 2;
            this.btnIleeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIleeri.Image = ((System.Drawing.Image)(resources.GetObject("btnIleeri.Image")));
            this.btnIleeri.Location = new System.Drawing.Point(191, 3);
            this.btnIleeri.Name = "btnIleeri";
            this.btnIleeri.Size = new System.Drawing.Size(44, 33);
            this.btnIleeri.TabIndex = 4;
            this.btnIleeri.UseVisualStyleBackColor = false;
            this.btnIleeri.Click += new System.EventHandler(this.btnIleeri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGeri.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGeri.FlatAppearance.BorderSize = 2;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.Location = new System.Drawing.Point(45, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(44, 33);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnIlk
            // 
            this.btnIlk.BackColor = System.Drawing.Color.CadetBlue;
            this.btnIlk.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIlk.FlatAppearance.BorderSize = 2;
            this.btnIlk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIlk.Image = ((System.Drawing.Image)(resources.GetObject("btnIlk.Image")));
            this.btnIlk.Location = new System.Drawing.Point(3, 3);
            this.btnIlk.Name = "btnIlk";
            this.btnIlk.Size = new System.Drawing.Size(44, 33);
            this.btnIlk.TabIndex = 0;
            this.btnIlk.UseVisualStyleBackColor = false;
            this.btnIlk.Click += new System.EventHandler(this.btnIlk_Click);
            // 
            // txtCinsi
            // 
            this.txtCinsi.Enabled = false;
            this.txtCinsi.Location = new System.Drawing.Point(593, 126);
            this.txtCinsi.Name = "txtCinsi";
            this.txtCinsi.Size = new System.Drawing.Size(100, 20);
            this.txtCinsi.TabIndex = 3;
            // 
            // txtKdvFiyat
            // 
            this.txtKdvFiyat.Enabled = false;
            this.txtKdvFiyat.Location = new System.Drawing.Point(593, 102);
            this.txtKdvFiyat.Name = "txtKdvFiyat";
            this.txtKdvFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtKdvFiyat.TabIndex = 5;
            // 
            // Reyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtKdvFiyat);
            this.Controls.Add(this.txtCinsi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reyon";
            this.Load += new System.EventHandler(this.Reyon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSon;
        private System.Windows.Forms.Button btnOrta;
        private System.Windows.Forms.Button btnIleeri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnIlk;
        private System.Windows.Forms.TextBox txtCinsi;
        private System.Windows.Forms.TextBox txtKdvFiyat;
        private System.Windows.Forms.Button button1;
    }
}