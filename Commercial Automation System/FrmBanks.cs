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
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();
        private void bankList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE BANKLIST", connection.connect());
            da.Fill(dt);
            gridControl1.DataSource = dt;

            connection.connect().Close();
        }
        private void cleanBox()
        {
            txtID.Text = "";
            txtBankName.Text = "";
            txtIBAN.Text = "";
            cmbCity.Text = "";
            cmbDistrict.Text = "";
            txtBranch.Text = "";
            txtAuthorized.Text = "";
            mskPhone.Text = "";
            mskDate.Text = "";
            txtAccountNo.Text = "";
            txtAccountType.Text = "";
        }
        private void cityList()
        {
            SqlCommand commandCityRead = new SqlCommand("Select city From Table_City", connection.connect());
            SqlDataReader dr = commandCityRead.ExecuteReader();
            while (dr.Read())
            {
                cmbCity.Items.Add(dr[0]);
            }
            connection.connect().Close();
        }

        void companyList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select id, name From Table_Company", connection.connect());
            da.Fill(dt);
            lookUpEdit.Properties.NullText = "choose a company";
            lookUpEdit.Properties.DisplayMember = "name";
            lookUpEdit.Properties.ValueMember = "id";
            lookUpEdit.Properties.DataSource = dt;
            
            connection.connect().Close();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            bankList();
            cityList();
            companyList();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandInsert = new SqlCommand("insert into Table_Bank (name, iban, city, district, branch, authorized, phone, date, accountNo, accountType, companyId) Values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11)", connection.connect());
            commandInsert.Parameters.AddWithValue("@p1", txtBankName.Text);
            commandInsert.Parameters.AddWithValue("@p2", txtIBAN.Text);
            commandInsert.Parameters.AddWithValue("@p3", cmbCity.Text);
            commandInsert.Parameters.AddWithValue("@p4", cmbDistrict.Text);
            commandInsert.Parameters.AddWithValue("@p5", txtBranch.Text);
            commandInsert.Parameters.AddWithValue("@p6", txtAuthorized.Text);
            commandInsert.Parameters.AddWithValue("@p7", mskPhone.Text);
            commandInsert.Parameters.AddWithValue("@p8", mskDate.Text);
            commandInsert.Parameters.AddWithValue("@p9", txtAccountNo.Text);
            commandInsert.Parameters.AddWithValue("@p10", txtAccountType.Text);
            commandInsert.Parameters.AddWithValue("@p11", lookUpEdit.EditValue);
            commandInsert.ExecuteNonQuery();
            connection.connect().Close();

            MessageBox.Show("Bank added !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bankList();
            cleanBox();

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrict.Items.Clear();
            SqlCommand commandCityRead = new SqlCommand("Select district From Table_District WHERE city = @p1", connection.connect());
            commandCityRead.Parameters.AddWithValue("@p1", cmbCity.SelectedIndex + 1);
            SqlDataReader dr = commandCityRead.ExecuteReader();
            while (dr.Read())
            {
                cmbDistrict.Items.Add(dr[0]);
            }
            connection.connect().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["id"].ToString();
                txtBankName.Text = dr["name"].ToString();
                txtIBAN.Text = dr["iban"].ToString();
                cmbCity.Text = dr["city"].ToString();
                cmbDistrict.Text = dr["district"].ToString();
                txtBranch.Text = dr["branch"].ToString();
                txtAuthorized.Text = dr["authorized"].ToString();
                mskPhone.Text = dr["phone"].ToString();
                mskDate.Text = dr["date"].ToString();
                txtAccountNo.Text = dr["accountNo"].ToString();
                txtAccountType.Text = dr["accountType"].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete bank information ? ", "Are yo Sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand commandDelete = new SqlCommand("Delete FROm Table_Bank WHERE id = @p1", connection.connect());
                commandDelete.Parameters.AddWithValue("@p1", txtID.Text);
                commandDelete.ExecuteNonQuery();
                connection.connect().Close();

                bankList();
                cleanBox();
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdate = new SqlCommand("Update Table_Bank set " +
                "name = @p1, iban = @p2, city = @p3, district = @p4, branch = @p5, authorized = @p6, phone= @p7, date = @p8, accountNo = @p9, accountType = @p10, companyId = @p11 " +
                "WHERE id = @p12", connection.connect());
            commandUpdate.Parameters.AddWithValue("@p1", txtBankName.Text);
            commandUpdate.Parameters.AddWithValue("@p2", txtIBAN.Text);
            commandUpdate.Parameters.AddWithValue("@p3", cmbCity.Text);
            commandUpdate.Parameters.AddWithValue("@p4", cmbDistrict.Text);
            commandUpdate.Parameters.AddWithValue("@p5", txtBranch.Text);
            commandUpdate.Parameters.AddWithValue("@p6", txtAuthorized.Text);
            commandUpdate.Parameters.AddWithValue("@p7", mskPhone.Text);
            commandUpdate.Parameters.AddWithValue("@p8", mskDate.Text);
            commandUpdate.Parameters.AddWithValue("@p9", txtAccountNo.Text);
            commandUpdate.Parameters.AddWithValue("@p10", txtAccountType.Text);
            commandUpdate.Parameters.AddWithValue("@p11", lookUpEdit.EditValue);
            commandUpdate.Parameters.AddWithValue("@p12", txtID.Text);

            commandUpdate.ExecuteNonQuery();
            connection.connect().Close();

            MessageBox.Show("Bank information updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bankList();
            cleanBox();

        }
    }
}
