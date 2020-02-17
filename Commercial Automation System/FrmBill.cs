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
    public partial class FrmBill : Form
    {
        public FrmBill()
        {
            InitializeComponent();
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        ClassSqlConnection connection = new ClassSqlConnection();

        private void billList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Bill", connection.connect());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            connection.connect().Close();
        }
        private void cleanBox()
        {
            txtID.Text = "";
            txtSeries.Text = "";
            txtOrderNo.Text = "";
            mskDate.Text = "";
            mskTime.Text = "";
            txtTaxAdm.Text = "";
            txtReceiver.Text = "";
            txtDelivering.Text = "";
            txtRecipient.Text = "";

        }

        private void FrmBill_Load(object sender, EventArgs e)
        {
            billList();
            // default olarak company secili olsun
            cmbType.Text = "Company";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtBDBillID.Text == "")
            {
                SqlCommand commandInsertB = new SqlCommand("insert into Table_Bill (series, orderNo, date, time, taxAdministration, receiver, delivering, recipient )" +
                " VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", connection.connect());
                commandInsertB.Parameters.AddWithValue("@p1 ", txtSeries.Text);
                commandInsertB.Parameters.AddWithValue("@p2 ", txtOrderNo.Text);
                commandInsertB.Parameters.AddWithValue("@p3 ", mskDate.Text);
                commandInsertB.Parameters.AddWithValue("@p4 ", mskTime.Text);
                commandInsertB.Parameters.AddWithValue("@p5 ", txtTaxAdm.Text);
                commandInsertB.Parameters.AddWithValue("@p6 ", txtReceiver.Text);
                commandInsertB.Parameters.AddWithValue("@p7 ", txtDelivering.Text);
                commandInsertB.Parameters.AddWithValue("@p8 ", txtRecipient.Text);
                commandInsertB.ExecuteNonQuery();
                connection.connect().Close();

                MessageBox.Show("Bill added !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                billList();
            }

            // type->Company secilirse company transactions icin fatura olustursun
            if (txtBDBillID.Text != "" && cmbType.Text == "Company")
            {
                txtBDTotal.Text = (Convert.ToDouble(txtBDPrice.Text) * Convert.ToDouble(txtBDPiece.Text)).ToString();

                SqlCommand commandInsertBD = new SqlCommand("insert into Table_BillDetail (name, piece, price, total, billID) VALUES (@p1, @p2, @p3, @p4, @p5)", connection.connect());
                commandInsertBD.Parameters.AddWithValue("@p1 ", txtBDName.Text);
                commandInsertBD.Parameters.AddWithValue("@p2 ", txtBDPiece.Text);
                commandInsertBD.Parameters.AddWithValue("@p3 ", decimal.Parse(txtBDPrice.Text));
                commandInsertBD.Parameters.AddWithValue("@p4 ", decimal.Parse(txtBDTotal.Text));
                commandInsertBD.Parameters.AddWithValue("@p5 ", txtBDBillID.Text);
              
                commandInsertBD.ExecuteNonQuery();
                connection.connect().Close();

                // Company Transations veri girişi
                SqlCommand commandInsert = new SqlCommand("insert into Table_CompanyTransactions (productId, piece, staffId, companyId, price, total, billId, date) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", connection.connect());
                commandInsert.Parameters.AddWithValue("@p1", txtBDID.Text);
                commandInsert.Parameters.AddWithValue("@p2", txtBDPiece.Text);
                commandInsert.Parameters.AddWithValue("@p3", txtBDStaffID.Text);
                commandInsert.Parameters.AddWithValue("@p4", txtBDCompany.Text);
                commandInsert.Parameters.AddWithValue("@p5", decimal.Parse(txtBDPrice.Text));
                commandInsert.Parameters.AddWithValue("@p6", decimal.Parse(txtBDTotal.Text));
                commandInsert.Parameters.AddWithValue("@p7", txtBDBillID.Text);
                commandInsert.Parameters.AddWithValue("@p8", mskDate.Text);
                commandInsert.ExecuteNonQuery();
                connection.connect().Close();

                // Stock sayisini azaltma
                SqlCommand commandUpdate = new SqlCommand("update Table_Product SET piece = piece - @p1 WHERE id = @p2", connection.connect());
                commandUpdate.Parameters.AddWithValue("@p1", txtBDPiece.Text);
                commandUpdate.Parameters.AddWithValue("@p2", txtBDID.Text);
                commandUpdate.ExecuteNonQuery();
                connection.connect().Close();

                MessageBox.Show("Bill Details added !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                billList();
            }



            // Type -> Customer secilirse cutomers transactions icin fatura olutursun
            if (txtBDBillID.Text != "" && cmbType.Text == "Customer")
            {
                txtBDTotal.Text = (Convert.ToDouble(txtBDPrice.Text) * Convert.ToDouble(txtBDPiece.Text)).ToString();

                SqlCommand commandInsertBD = new SqlCommand("insert into Table_BillDetail (name, piece, price, total, billID) VALUES (@p1, @p2, @p3, @p4, @p5)", connection.connect());
                commandInsertBD.Parameters.AddWithValue("@p1 ", txtBDName.Text);
                commandInsertBD.Parameters.AddWithValue("@p2 ", txtBDPiece.Text);
                commandInsertBD.Parameters.AddWithValue("@p3 ", decimal.Parse(txtBDPrice.Text));
                commandInsertBD.Parameters.AddWithValue("@p4 ", decimal.Parse(txtBDTotal.Text));
                commandInsertBD.Parameters.AddWithValue("@p5 ", txtBDBillID.Text);

                commandInsertBD.ExecuteNonQuery();
                connection.connect().Close();

                // Company Transations veri girişi
                SqlCommand commandInsert = new SqlCommand("insert into Table_CustomerTransactions (productId, piece, staffId, customerId, price, total, billId, date) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", connection.connect());
                commandInsert.Parameters.AddWithValue("@p1", txtBDID.Text);
                commandInsert.Parameters.AddWithValue("@p2", txtBDPiece.Text);
                commandInsert.Parameters.AddWithValue("@p3", txtBDStaffID.Text);
                commandInsert.Parameters.AddWithValue("@p4", txtBDCompany.Text);
                commandInsert.Parameters.AddWithValue("@p5", decimal.Parse(txtBDPrice.Text));
                commandInsert.Parameters.AddWithValue("@p6", decimal.Parse(txtBDTotal.Text));
                commandInsert.Parameters.AddWithValue("@p7", txtBDBillID.Text);
                commandInsert.Parameters.AddWithValue("@p8", mskDate.Text);
                commandInsert.ExecuteNonQuery();
                connection.connect().Close();

                // Stock sayisini azaltma
                SqlCommand commandUpdate = new SqlCommand("update Table_Product SET piece = piece - @p1 WHERE id = @p2", connection.connect());
                commandUpdate.Parameters.AddWithValue("@p1", txtBDPiece.Text);
                commandUpdate.Parameters.AddWithValue("@p2", txtBDID.Text);
                commandUpdate.ExecuteNonQuery();
                connection.connect().Close();

                MessageBox.Show("Bill Details added !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                billList();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["id"].ToString();
                txtSeries.Text = dr["series"].ToString();
                txtOrderNo.Text = dr["orderNo"].ToString();
                mskDate.Text = dr["date"].ToString();
                mskTime.Text = dr["time"].ToString();
                txtTaxAdm.Text = dr["taxAdministration"].ToString();
                txtReceiver.Text = dr["receiver"].ToString();
                txtDelivering.Text = dr["delivering"].ToString();
                txtRecipient.Text = dr["recipient"].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("do you want to delete the bill ?", "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                SqlCommand commandDelete = new SqlCommand("Delete FROM Table_Bill WHERE id = @p1", connection.connect());
                commandDelete.Parameters.AddWithValue("@p1", txtID.Text);
                commandDelete.ExecuteNonQuery();

                connection.connect().Close();
                billList();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdate = new SqlCommand("Update Table_Bill SET series = @p1, orderNo = @p2, date = @p3, time = @p4, taxAdministration = @p5, receiver = @p6, delivering = @p7, recipient = @p8 WHERE id = " + txtID.Text, connection.connect());
            commandUpdate.Parameters.AddWithValue("@p1", txtSeries.Text);
            commandUpdate.Parameters.AddWithValue("@p2", txtOrderNo.Text);
            commandUpdate.Parameters.AddWithValue("@p3", mskDate.Text);
            commandUpdate.Parameters.AddWithValue("@p4", mskTime.Text);
            commandUpdate.Parameters.AddWithValue("@p5", txtTaxAdm.Text);
            commandUpdate.Parameters.AddWithValue("@p6", txtReceiver.Text);
            commandUpdate.Parameters.AddWithValue("@p7", txtDelivering.Text);
            commandUpdate.Parameters.AddWithValue("@p8", txtRecipient.Text);
            commandUpdate.ExecuteNonQuery();
            connection.connect().Close();

            MessageBox.Show("Bill updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            billList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmBillProducts frmBillProducts = new FrmBillProducts();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frmBillProducts.idSetGet = dr["id"].ToString();

            }
            frmBillProducts.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand commandProductGet = new SqlCommand("Select name, salePrice  FROM Table_Product WHERE id = @p1", connection.connect());
            commandProductGet.Parameters.AddWithValue("@p1", txtBDID.Text);
            SqlDataReader dr = commandProductGet.ExecuteReader();
            while (dr.Read())
            {
                txtBDName.Text = dr[0].ToString();
                txtBDPrice.Text = dr[1].ToString();
            }
            connection.connect().Close();
        }


    }
}
