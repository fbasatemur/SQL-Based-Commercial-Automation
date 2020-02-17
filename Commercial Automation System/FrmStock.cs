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
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }
        ClassSqlConnection connection = new ClassSqlConnection();

        private void productList()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select name, count(*) as 'count' FROM Table_Product Group By name", connection.connect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmStock_Load(object sender, EventArgs e)
        {
            productList();

            // chart product - piece
            SqlCommand commandProductPiece = new SqlCommand("Select name, sum(piece) FROM Table_Product Group By name ", connection.connect());
            SqlDataReader dr1 = commandProductPiece.ExecuteReader();
            while (dr1.Read())
            {
                chartControl1.Series["Product"].Points.AddPoint(dr1[0].ToString(), int.Parse(dr1[1].ToString()));
            }
            connection.connect().Close();

            // chart company - city
            SqlCommand commandCompanyCity = new SqlCommand("Select Table_Company.name, count(city) From Table_Company Group By name", connection.connect());
            SqlDataReader dr2 = commandCompanyCity.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 2"].Points.AddPoint(dr2[0].ToString(), int.Parse(dr2[1].ToString()));
            }
            connection.connect().Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmStockDetail frmStockDetail = new FrmStockDetail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frmStockDetail.productNameGetSet = dr["name"].ToString();
            }
            frmStockDetail.Show();
        }
    }
}
