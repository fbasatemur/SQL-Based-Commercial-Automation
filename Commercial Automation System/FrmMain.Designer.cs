namespace Commercial_Automation_System
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDesktop = new DevExpress.XtraBars.BarButtonItem();
            this.btnStock = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.btnProducts = new DevExpress.XtraBars.BarButtonItem();
            this.btnCashRegister = new DevExpress.XtraBars.BarButtonItem();
            this.btnCompanies = new DevExpress.XtraBars.BarButtonItem();
            this.btnDirectory = new DevExpress.XtraBars.BarButtonItem();
            this.btnSettings = new DevExpress.XtraBars.BarButtonItem();
            this.btnBills = new DevExpress.XtraBars.BarButtonItem();
            this.btnExpenes = new DevExpress.XtraBars.BarButtonItem();
            this.btnStaff = new DevExpress.XtraBars.BarButtonItem();
            this.btnBanks = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotes = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDesktop,
            this.btnStock,
            this.btnCustomers,
            this.btnProducts,
            this.btnCashRegister,
            this.btnCompanies,
            this.btnDirectory,
            this.btnSettings,
            this.btnBills,
            this.btnExpenes,
            this.btnStaff,
            this.btnBanks,
            this.btnNotes,
            this.btnTransactions,
            this.btnReport});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(1084, 183);
            // 
            // btnDesktop
            // 
            this.btnDesktop.Caption = "DESKTOP";
            this.btnDesktop.Id = 1;
            this.btnDesktop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDesktop.ImageOptions.Image")));
            this.btnDesktop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDesktop.ImageOptions.LargeImage")));
            this.btnDesktop.Name = "btnDesktop";
            this.btnDesktop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDesktop_ItemClick);
            // 
            // btnStock
            // 
            this.btnStock.Caption = "STOCK";
            this.btnStock.Id = 2;
            this.btnStock.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.ImageOptions.Image")));
            this.btnStock.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStock.ImageOptions.LargeImage")));
            this.btnStock.Name = "btnStock";
            this.btnStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStock_ItemClick);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Caption = "CUSTOMERS";
            this.btnCustomers.Id = 3;
            this.btnCustomers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.ImageOptions.Image")));
            this.btnCustomers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.ImageOptions.LargeImage")));
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomers_ItemClick);
            // 
            // btnProducts
            // 
            this.btnProducts.Caption = "PRODUCTS";
            this.btnProducts.Id = 4;
            this.btnProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.ImageOptions.Image")));
            this.btnProducts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.ImageOptions.LargeImage")));
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProducts_ItemClick);
            // 
            // btnCashRegister
            // 
            this.btnCashRegister.Caption = "SAFE";
            this.btnCashRegister.Id = 5;
            this.btnCashRegister.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCashRegister.ImageOptions.Image")));
            this.btnCashRegister.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCashRegister.ImageOptions.LargeImage")));
            this.btnCashRegister.Name = "btnCashRegister";
            this.btnCashRegister.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCashRegister_ItemClick);
            // 
            // btnCompanies
            // 
            this.btnCompanies.Caption = "COMPANIES";
            this.btnCompanies.Id = 6;
            this.btnCompanies.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCompanies.ImageOptions.Image")));
            this.btnCompanies.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCompanies.ImageOptions.LargeImage")));
            this.btnCompanies.Name = "btnCompanies";
            this.btnCompanies.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompanies_ItemClick);
            // 
            // btnDirectory
            // 
            this.btnDirectory.Caption = "DIRECTORY";
            this.btnDirectory.Id = 7;
            this.btnDirectory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDirectory.ImageOptions.Image")));
            this.btnDirectory.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDirectory.ImageOptions.LargeImage")));
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDirectory_ItemClick);
            // 
            // btnSettings
            // 
            this.btnSettings.Caption = "SETTINGS";
            this.btnSettings.Id = 8;
            this.btnSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.ImageOptions.Image")));
            this.btnSettings.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.ImageOptions.LargeImage")));
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSettings_ItemClick);
            // 
            // btnBills
            // 
            this.btnBills.Caption = "BILLS";
            this.btnBills.Id = 9;
            this.btnBills.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBills.ImageOptions.Image")));
            this.btnBills.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBills.ImageOptions.LargeImage")));
            this.btnBills.Name = "btnBills";
            this.btnBills.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBills_ItemClick);
            // 
            // btnExpenes
            // 
            this.btnExpenes.Caption = "EXPENSES";
            this.btnExpenes.Id = 10;
            this.btnExpenes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExpenes.ImageOptions.Image")));
            this.btnExpenes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExpenes.ImageOptions.LargeImage")));
            this.btnExpenes.Name = "btnExpenes";
            this.btnExpenes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExpenes_ItemClick);
            // 
            // btnStaff
            // 
            this.btnStaff.Caption = "STAFF";
            this.btnStaff.Id = 11;
            this.btnStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.ImageOptions.Image")));
            this.btnStaff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStaff.ImageOptions.LargeImage")));
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStaff_ItemClick);
            // 
            // btnBanks
            // 
            this.btnBanks.Caption = "BANKS";
            this.btnBanks.Id = 12;
            this.btnBanks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBanks.ImageOptions.Image")));
            this.btnBanks.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBanks.ImageOptions.LargeImage")));
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBanks_ItemClick);
            // 
            // btnNotes
            // 
            this.btnNotes.Caption = "NOTES";
            this.btnNotes.Id = 13;
            this.btnNotes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNotes.ImageOptions.Image")));
            this.btnNotes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNotes.ImageOptions.LargeImage")));
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotes_ItemClick);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Caption = "TRANSACTIONS";
            this.btnTransactions.Id = 14;
            this.btnTransactions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactions.ImageOptions.Image")));
            this.btnTransactions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTransactions.ImageOptions.LargeImage")));
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTransactions_ItemClick);
            // 
            // btnReport
            // 
            this.btnReport.Caption = "REPORT";
            this.btnReport.Id = 15;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.Image")));
            this.btnReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.LargeImage")));
            this.btnReport.Name = "btnReport";
            this.btnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReport_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Commercial Automation System";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDesktop);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProducts);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStock);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDirectory);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCompanies);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCustomers);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStaff);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCashRegister);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExpenes);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBanks);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBills);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnReport);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTransactions);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotes);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSettings);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 687);
            this.Controls.Add(this.ribbonControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDesktop;
        private DevExpress.XtraBars.BarButtonItem btnStock;
        private DevExpress.XtraBars.BarButtonItem btnCustomers;
        private DevExpress.XtraBars.BarButtonItem btnProducts;
        private DevExpress.XtraBars.BarButtonItem btnCashRegister;
        private DevExpress.XtraBars.BarButtonItem btnCompanies;
        private DevExpress.XtraBars.BarButtonItem btnDirectory;
        private DevExpress.XtraBars.BarButtonItem btnSettings;
        private DevExpress.XtraBars.BarButtonItem btnBills;
        private DevExpress.XtraBars.BarButtonItem btnExpenes;
        private DevExpress.XtraBars.BarButtonItem btnStaff;
        private DevExpress.XtraBars.BarButtonItem btnBanks;
        private DevExpress.XtraBars.BarButtonItem btnNotes;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnTransactions;
        private DevExpress.XtraBars.BarButtonItem btnReport;
    }
}

