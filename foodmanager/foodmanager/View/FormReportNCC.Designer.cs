namespace foodmanager.View
{
    partial class FormReportNCC
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
            this.quanLyThucPhamDataSet = new foodmanager.QuanLyThucPhamDataSet();
            this.nhaCungCapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter = new foodmanager.QuanLyThucPhamDataSetTableAdapters.NhaCungCapTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThucPhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyThucPhamDataSet
            // 
            this.quanLyThucPhamDataSet.DataSetName = "QuanLyThucPhamDataSet";
            this.quanLyThucPhamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapBindingSource1
            // 
            this.nhaCungCapBindingSource1.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource1.DataSource = this.quanLyThucPhamDataSet;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.quanLyThucPhamDataSet;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNCC";
            reportDataSource1.Value = this.nhaCungCapBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "foodmanager.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 594);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormReportNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportNCC";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThucPhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QuanLyThucPhamDataSet quanLyThucPhamDataSet;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private QuanLyThucPhamDataSetTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}