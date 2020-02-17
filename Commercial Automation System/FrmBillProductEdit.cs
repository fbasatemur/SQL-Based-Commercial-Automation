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
    public partial class FrmBillProductEdit : Form
    {
        public FrmBillProductEdit()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private string productId;
        public string productIdGetSet
        {
            get { return productId; }
            set { productId = value; }
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        private void FrmBillProductEdit_Load(object sender, EventArgs e)
        {
            txtID.Text = productId;

            SqlCommand commandSelect = new SqlCommand("Select * From Table_BillDetail WHERE id = @p1", connection.connect());
            commandSelect.Parameters.AddWithValue("@p1", productId);
            SqlDataReader dr = commandSelect.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtPiece.Text = dr[2].ToString();
                txtPrice.Text = dr[3].ToString();
                txtTotal.Text = dr[4].ToString();
            }

            connection.connect().Close();

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            txtTotal.Text = (decimal.Parse(txtPrice.Text) * decimal.Parse(txtPiece.Text)).ToString();
            SqlCommand commandUpdate = new SqlCommand("UPdate Table_BillDetail SET name = @p1, piece = @p2, price = @p3, total = @p4 WHERE id = " + productId, connection.connect());
            commandUpdate.Parameters.AddWithValue("@p1", txtName.Text);
            commandUpdate.Parameters.AddWithValue("@p2", Int16.Parse(txtPiece.Text));
            commandUpdate.Parameters.AddWithValue("@p3", decimal.Parse(txtPrice.Text));
            commandUpdate.Parameters.AddWithValue("@p4", decimal.Parse(txtTotal.Text));
            commandUpdate.ExecuteNonQuery();

            connection.connect().Close();
            MessageBox.Show("Bill detail updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("Delete FrOM Table_BillDetail WHERE id = " + txtID.Text, connection.connect());
            commandDelete.ExecuteNonQuery();
            connection.connect().Close();

            MessageBox.Show("Product save deleted !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
