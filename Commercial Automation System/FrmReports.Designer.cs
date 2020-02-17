namespace Commercial_Automation_System
{
    partial class FrmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReports));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Table_StaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommercialAutomationDBDataSet3 = new Commercial_Automation_System.CommercialAutomationDBDataSet3();
            this.Table_ExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommercialAutomationDBDataSet2 = new Commercial_Automation_System.CommercialAutomationDBDataSet2();
            this.Table_CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommercialAutomationDBDataSet1 = new Commercial_Automation_System.CommercialAutomationDBDataSet1();
            this.Table_CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommercialAutomationDBDataSet = new Commercial_Automation_System.CommercialAutomationDBDataSet();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Table_CustomerTableAdapter = new Commercial_Automation_System.CommercialAutomationDBDataSetTableAdapters.Table_CustomerTableAdapter();
            this.Table_CompanyTableAdapter = new Commercial_Automation_System.CommercialAutomationDBDataSet1TableAdapters.Table_CompanyTableAdapter();
            this.Table_ExpenseTableAdapter = new Commercial_Automation_System.CommercialAutomationDBDataSet2TableAdapters.Table_ExpenseTableAdapter();
            this.Table_StaffTableAdapter = new Commercial_Automation_System.CommercialAutomationDBDataSet3TableAdapters.Table_StaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Table_StaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommercialAutomationDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_ExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommercialAutomationDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_CompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommercialAutomationDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommercialAutomationDBDataSet)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_StaffBindingSource
            // 
            this.Table_StaffBindingSource.DataMember = "Table_Staff";
            this.Table_StaffBindingSource.DataSource = this.CommercialAutomationDBDataSet3;
            // 
            // CommercialAutomationDBDataSet3
            // 
            this.CommercialAutomationDBDataSet3.DataSetName = "CommercialAutomationDBDataSet3";
            this.CommercialAutomationDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Table_ExpenseBindingSource
            // 
            this.Table_ExpenseBindingSource.DataMember = "Table_Expense";
            this.Table_ExpenseBindingSource.DataSource = this.CommercialAutomationDBDataSet2;
            // 
            // CommercialAutomationDBDataSet2
            // 
            this.CommercialAutomationDBDataSet2.DataSetName = "CommercialAutomationDBDataSet2";
            this.CommercialAutomationDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Table_CompanyBindingSource
            // 
            this.Table_CompanyBindingSource.DataMember = "Table_Company";
            this.Table_CompanyBindingSource.DataSource = this.CommercialAutomationDBDataSet1;
            // 
            // CommercialAutomationDBDataSet1
            // 
            this.CommercialAutomationDBDataSet1.DataSetName = "CommercialAutomationDBDataSet1";
            this.CommercialAutomationDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Table_CustomerBindingSource
            // 
            this.Table_CustomerBindingSource.DataMember = "Table_Customer";
            this.Table_CustomerBindingSource.DataSource = this.CommercialAutomationDBDataSet;
            // 
            // CommercialAutomationDBDataSet
            // 
            this.CommercialAutomationDBDataSet.DataSetName = "CommercialAutomationDBDataSet";
            this.CommercialAutomationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.reportViewer4);
            this.xtraTabPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage5.ImageOptions.Image")));
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1080, 473);
            this.xtraTabPage5.Text = "Staff";
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetStaff";
            reportDataSource1.Value = this.Table_StaffBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Commercial_Automation_System.Report4.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1080, 473);
            this.reportViewer4.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.reportViewer3);
            this.xtraTabPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage4.ImageOptions.Image")));
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1080, 473);
            this.xtraTabPage4.Text = "Expense";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetExpense";
            reportDataSource2.Value = this.Table_ExpenseBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Commercial_Automation_System.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1080, 473);
            this.reportViewer3.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.reportViewer2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1080, 473);
            this.xtraTabPage2.Text = "Companies";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetCompany";
            reportDataSource3.Value = this.Table_CompanyBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Commercial_Automation_System.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1080, 473);
            this.reportViewer2.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1082, 503);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.reportViewer1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1080, 473);
            this.xtraTabPage1.Text = "Customers";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.Table_CustomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Commercial_Automation_System.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1080, 473);
            this.reportViewer1.TabIndex = 0;
            // 
            // Table_CustomerTableAdapter
            // 
            this.Table_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // Table_CompanyTableAdapter
            // 
            this.Table_CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // Table_ExpenseTableAdapter
            // 
            this.Table_ExpenseTableAdapter.ClearBeforeFill = true;
            // 
            // Table_StaffTableAdapter
            // 
            this.Table_StaffTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 503);
            this.Controls.Add(this.xtraTabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.FrmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_StaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommercialAutomationDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_ExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommercialAutomationDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_CompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommercialAutomationDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommercialAutomationDBDataSet)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Table_CustomerBindingSource;
        private CommercialAutomationDBDataSet CommercialAutomationDBDataSet;
        private CommercialAutomationDBDataSetTableAdapters.Table_CustomerTableAdapter Table_CustomerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource Table_CompanyBindingSource;
        private CommercialAutomationDBDataSet1 CommercialAutomationDBDataSet1;
        private CommercialAutomationDBDataSet1TableAdapters.Table_CompanyTableAdapter Table_CompanyTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource Table_ExpenseBindingSource;
        private CommercialAutomationDBDataSet2 CommercialAutomationDBDataSet2;
        private CommercialAutomationDBDataSet2TableAdapters.Table_ExpenseTableAdapter Table_ExpenseTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource Table_StaffBindingSource;
        private CommercialAutomationDBDataSet3 CommercialAutomationDBDataSet3;
        private CommercialAutomationDBDataSet3TableAdapters.Table_StaffTableAdapter Table_StaffTableAdapter;
    }
}