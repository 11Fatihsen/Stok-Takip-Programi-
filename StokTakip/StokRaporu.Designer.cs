namespace StokTakip
{
    partial class StokRaporu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokRaporu));
            this.tblStokTakipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipDBDataSet1 = new StokTakip.StokTakipDBDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_StokTakipTableAdapter = new StokTakip.StokTakipDBDataSet1TableAdapters.tbl_StokTakipTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblStokTakipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDBDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblStokTakipBindingSource
            // 
            this.tblStokTakipBindingSource.DataMember = "tbl_StokTakip";
            this.tblStokTakipBindingSource.DataSource = this.stokTakipDBDataSet1;
            // 
            // stokTakipDBDataSet1
            // 
            this.stokTakipDBDataSet1.DataSetName = "StokTakipDBDataSet1";
            this.stokTakipDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 437);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblStokTakipBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StokTakip.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(706, 433);
            this.reportViewer1.TabIndex = 1;
            // 
            // tbl_StokTakipTableAdapter
            // 
            this.tbl_StokTakipTableAdapter.ClearBeforeFill = true;
            // 
            // StokRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StokRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Raporu";
            this.Load += new System.EventHandler(this.StokRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblStokTakipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDBDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private StokTakipDBDataSet1 stokTakipDBDataSet1;
        private System.Windows.Forms.BindingSource tblStokTakipBindingSource;
        private StokTakipDBDataSet1TableAdapters.tbl_StokTakipTableAdapter tbl_StokTakipTableAdapter;
    }
}