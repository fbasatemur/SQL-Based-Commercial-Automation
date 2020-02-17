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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private ClassSqlConnection connection = new ClassSqlConnection();

        private void productsList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Product", connection.connect());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void cleanBox()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtMark.Text = "";
            txtModel.Text = "";
            mskYear.Text = "";
            upDownPieces.Value = 0;
            txtPPrice.Text = "";
            txtSPrice.Text = "";
            rtxtBoxDetails.Text = "";
        }
        private void messageShow(string messageText, string messageHeader = "", MessageBoxIcon messageIcon = MessageBoxIcon.Information)
        {
            MessageBox.Show(messageText, messageHeader, MessageBoxButtons.OK, messageIcon);
        }
        private void FrmProducts_Load(object sender, EventArgs e)
        {
            productsList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // data save
            SqlCommand commandInsert = new SqlCommand("insert into Table_Product (name, mark, model, year, piece, purchasePrice, salePrice, details  ) " +
            "VALUES (@pName, @pMark, @pModel, @pYear, @pPiece, @pPPrice, @pSPrice, @pDetails)", connection.connect());

            commandInsert.Parameters.AddWithValue("@pName", txtName.Text);
            commandInsert.Parameters.AddWithValue("@pMark", txtMark.Text);
            commandInsert.Parameters.AddWithValue("@pModel", txtModel.Text);
            commandInsert.Parameters.AddWithValue("@pYear", mskYear.Text);
            commandInsert.Parameters.AddWithValue("@pPiece", Int16.Parse(upDownPieces.Value.ToString()));
            commandInsert.Parameters.AddWithValue("@pPPrice", decimal.Parse(txtPPrice.Text));
            commandInsert.Parameters.AddWithValue("@pSPrice", decimal.Parse(txtSPrice.Text));
            commandInsert.Parameters.AddWithValue("@pDetails", rtxtBoxDetails.Text);
            
            commandInsert.ExecuteNonQuery();
            connection.connect().Close();

            messageShow("Product added !", "Succesful");
            productsList();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdate = new SqlCommand("Update Table_Product SET " +
            "name = @pName, mark = @pMark, model = @pModel, year = @pYear, piece = @pPiece, purchasePrice = @pPPrice, salePrice = @pSPrice, details = @pDetails WHERE id =@pId", connection.connect());

            commandUpdate.Parameters.AddWithValue("@pId", int.Parse(txtID.Text));
            commandUpdate.Parameters.AddWithValue("@pName", txtName.Text);
            commandUpdate.Parameters.AddWithValue("@pMark", txtMark.Text);
            commandUpdate.Parameters.AddWithValue("@pModel", txtModel.Text);
            commandUpdate.Parameters.AddWithValue("@pYear", mskYear.Text);
            commandUpdate.Parameters.AddWithValue("@pPiece", Int16.Parse(upDownPieces.Value.ToString()));
            commandUpdate.Parameters.AddWithValue("@pPPrice", decimal.Parse(txtPPrice.Text));
            commandUpdate.Parameters.AddWithValue("@pSPrice", decimal.Parse(txtSPrice.Text));
            commandUpdate.Parameters.AddWithValue("@pDetails", rtxtBoxDetails.Text);

            commandUpdate.ExecuteNonQuery();
            connection.connect().Close();

            messageShow("Row updated");
            productsList();

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("DELETE FROM Table_Product WHERE id = @pId", connection.connect());
            commandDelete.Parameters.AddWithValue("@pId", txtID.Text);
            commandDelete.ExecuteNonQuery();

            connection.connect().Close();
            messageShow("Product Deleted !", "DELETED", MessageBoxIcon.Warning);
            productsList();

        }

        // GridView1 de row degisikliginde yapilacak islem
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // mouse ile isaretlenen gridview1 alaninin satirini dr ye yukle
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["id"].ToString();
            txtName.Text = dr["name"].ToString();
            txtMark.Text = dr["mark"].ToString();
            txtModel.Text = dr["model"].ToString();
            mskYear.Text = dr["year"].ToString();
            upDownPieces.Value = Int16.Parse(dr["piece"].ToString());
            txtPPrice.Text =dr["purchasePrice"].ToString();
            txtSPrice.Text = dr["salePrice"].ToString(); ;
            rtxtBoxDetails.Text = dr["details"].ToString();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanBox();
        }
    }
}
