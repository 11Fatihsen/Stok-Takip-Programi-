namespace StokTakip
{
    partial class ReyonRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReyonRapor));
            this.tbl_ReyonGonderilenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipDBDataSet = new StokTakip.StokTakipDBDataSet();
            this.tblReyonGonderilenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_ReyonGonderilenTableAdapter = new StokTakip.StokTakipDBDataSetTableAdapters.tbl_ReyonGonderilenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ReyonGonderilenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReyonGonderilenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDBDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_ReyonGonderilenBindingSource
            // 
            this.tbl_ReyonGonderilenBindingSource.DataMember = "tbl_ReyonGonderilen";
            this.tbl_ReyonGonderilenBindingSource.DataSource = this.stokTakipDBDataSet;
            // 
            // stokTakipDBDataSet
            // 
            this.stokTakipDBDataSet.DataSetName = "StokTakipDBDataSet";
            this.stokTakipDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblReyonGonderilenBindingSource
            // 
            this.tblReyonGonderilenBindingSource.DataMember = "tbl_ReyonGonderilen";
            this.tblReyonGonderilenBindingSource.DataSource = this.stokTakipDBDataSetBindingSource;
            // 
            // stokTakipDBDataSetBindingSource
            // 
            this.stokTakipDBDataSetBindingSource.DataSource = this.stokTakipDBDataSet;
            this.stokTakipDBDataSetBindingSource.Position = 0;
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
            reportDataSource1.Value = this.tbl_ReyonGonderilenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StokTakip.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(706, 433);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_ReyonGonderilenTableAdapter
            // 
            this.tbl_ReyonGonderilenTableAdapter.ClearBeforeFill = true;
            // 
            // ReyonRapor
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
            this.Name = "ReyonRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reyon Raporu";
            this.Load += new System.EventHandler(this.ReyonRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ReyonGonderilenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReyonGonderilenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDBDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private StokTakipDBDataSet stokTakipDBDataSet;
        private System.Windows.Forms.BindingSource stokTakipDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblReyonGonderilenBindingSource;
        private StokTakipDBDataSetTableAdapters.tbl_ReyonGonderilenTableAdapter tbl_ReyonGonderilenTableAdapter;
        private System.Windows.Forms.BindingSource tbl_ReyonGonderilenBindingSource;
    }
}