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
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CommercialAutomationDBDataSet3.Table_Staff' table. You can move, or remove it, as needed.
            this.Table_StaffTableAdapter.Fill(this.CommercialAutomationDBDataSet3.Table_Staff);
            // TODO: This line of code loads data into the 'CommercialAutomationDBDataSet2.Table_Expense' table. You can move, or remove it, as needed.
            this.Table_ExpenseTableAdapter.Fill(this.CommercialAutomationDBDataSet2.Table_Expense);
            // TODO: This line of code loads data into the 'CommercialAutomationDBDataSet1.Table_Company' table. You can move, or remove it, as needed.
            this.Table_CompanyTableAdapter.Fill(this.CommercialAutomationDBDataSet1.Table_Company);
            // TODO: This line of code loads data into the 'CommercialAutomationDBDataSet.Table_Customer' table. You can move, or remove it, as needed.
            this.Table_CustomerTableAdapter.Fill(this.CommercialAutomationDBDataSet.Table_Customer);
            // TODO: This line of code loads data into the 'CommercialAutomationDBDataSet.Table_Customer' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }
    }
}
