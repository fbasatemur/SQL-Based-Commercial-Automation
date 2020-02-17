using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;

namespace Commercial_Automation_System
{
    public partial class FrmDirectory : Form
    {
        public FrmDirectory()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();
        private void listCustomers()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select name, surname, phone1, phone2, mail From Table_Customer", connection.connect());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            connection.connect().Close();
        }
        private void listCompanies()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select name, sector, authorizedNameSur, authorizedPosition, phone1, phone2, phone3, mail, fax  From Table_Company", connection.connect());
            da.Fill(dt);
            gridControl2.DataSource = dt;
            connection.connect().Close();
        }
        private void FrmDirectory_Load(object sender, EventArgs e)
        {
            listCustomers();
            listCompanies();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frmMail = new FrmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); 
            if(dr != null)
            {
                frmMail.mailSetGet = dr["mail"].ToString();
            }
            frmMail.Show();
        }
    }
}
