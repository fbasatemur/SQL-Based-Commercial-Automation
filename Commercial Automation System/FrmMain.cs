using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commercial_Automation_System
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        FrmProducts products;
        private void btnProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // product nesnesi bos alani isaret ediyorsa
            if(products == null || products.IsDisposed)
            {
                products = new FrmProducts();
                // bu parent i FrmMain deki MdiParent uzerinde ac
                products.MdiParent = this;
                products.Show();
            }
        }

        private FrmCustomers customers;
        private void btnCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(customers == null || customers.IsDisposed)
            {
                customers = new FrmCustomers();
                customers.MdiParent = this;
                customers.Show();
            }

        }

        FrmCompanies companies;
        private void btnCompanies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(companies == null || companies.IsDisposed)
            {
                companies = new FrmCompanies();
                companies.MdiParent = this;
                companies.Show();
            }
        }

        FrmStaff staff;
        private void btnStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (staff == null || staff.IsDisposed)
            {
                staff = new FrmStaff();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        FrmDirectory directory;
        private void btnDirectory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(directory == null || directory.IsDisposed)
            {
                directory = new FrmDirectory();
                directory.MdiParent = this;
                directory.Show();
            }
        }

        FrmExpense expense;
        private void btnExpenes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if(expense == null || expense.IsDisposed)
            {
                expense = new FrmExpense();
                expense.MdiParent = this;
                expense.Show();
            }

        }

        FrmBanks Banks;
        private void btnBanks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Banks == null || Banks.IsDisposed)
            {
                Banks = new FrmBanks();
                Banks.MdiParent = this;
                Banks.Show();
            }
        }

        FrmBill bill;
        private void btnBills_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bill == null || bill.IsDisposed)
            {
                bill = new FrmBill();
                bill.MdiParent = this;
                bill.Show();
            }
        }


        FrmNotes frmNotes;
        private void btnNotes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmNotes == null || frmNotes.IsDisposed)
            {
                frmNotes = new FrmNotes();
                frmNotes.MdiParent = this;
                frmNotes.Show();
            }
        }

        FrmTransactions frmTransactions;
        private void btnTransactions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmTransactions == null || frmTransactions.IsDisposed)
            {
                frmTransactions = new FrmTransactions();
                frmTransactions.MdiParent = this;
                frmTransactions.Show();
            }
        }

        FrmSafe frmSafe;
        private void btnCashRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSafe == null || frmSafe.IsDisposed)
            {
                frmSafe = new FrmSafe();
                frmSafe.MdiParent = this;
                frmSafe.Show();
            }
        }

        FrmReports frmReports;
        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmReports == null || frmReports.IsDisposed)
            {
                frmReports = new FrmReports();
                frmReports.MdiParent = this;
                frmReports.Show();
            }

        }

        FrmStock frmStock;
        private void btnStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmStock == null || frmStock.IsDisposed)
            {
                frmStock = new FrmStock();
                frmStock.MdiParent = this;
                frmStock.Show();
            }
        }

        DevExpress.XtraBars.ItemClickEventArgs d;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            btnDesktop_ItemClick(sender,  d);

        }

        FrmSettings frmSettings;
        private void btnSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSettings == null || frmSettings.IsDisposed)
            {
                frmSettings = new FrmSettings();
                frmSettings.Show();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        FrmDesktop frmDesktop;
        private void btnDesktop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmDesktop == null || frmDesktop.IsDisposed)
            {
                frmDesktop = new FrmDesktop();
                frmDesktop.MdiParent = this;
                frmDesktop.Show();
            }
        }

    }
}
