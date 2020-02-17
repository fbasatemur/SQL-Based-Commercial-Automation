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
    public partial class FrmBillProducts : Form
    {
        public FrmBillProducts()
        {
            InitializeComponent();
        }
        private string id; 
        public string idSetGet
        {
            set { id = value; }
            get { return id; }
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        void productsList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_BillDetail WHERE billID = " + id , connection.connect());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void FrmBillProducts_Load(object sender, EventArgs e)
        {
            productsList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmBillProductEdit frmBillProductEdit = new FrmBillProductEdit();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if ( dr != null )
            {
                frmBillProductEdit.productIdGetSet = dr["id"].ToString();
            }
            frmBillProductEdit.Show();
        }
    }
}
