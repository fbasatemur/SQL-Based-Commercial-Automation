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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        private void customerList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Customer", connection.connect());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            connection.connect().Close();
        }


        private void cityList()
        {
            SqlCommand commandCityRead = new SqlCommand("Select city From Table_City", connection.connect());
            SqlDataReader dr = commandCityRead.ExecuteReader();
            while (dr.Read())
            {
                cmbCity.Items.Add(dr[0].ToString());
            }
            connection.connect().Close();

        }
      

        private void messageShow(string messageText, string messageHeader = "", MessageBoxIcon messageIcon = MessageBoxIcon.Information)
        {
            MessageBox.Show(messageText, messageHeader, MessageBoxButtons.OK, messageIcon);
        }

        private void cleanBox()
        {
            mskIdentityNo.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            mskPhone1.Text = "";
            mskPhone2.Text = "";
            txtMail.Text = "";
            cmbCity.Text = "";
            cmbDistrict.Text = "";
            txtBoxAddress.Text = "";
            txtInstitutionC.Text = "";
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            customerList();
            cityList();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrict.Items.Clear();
            SqlCommand commandDistrictList = new SqlCommand("Select district FROM Table_District WHERE city  = @p1", connection.connect());
            commandDistrictList.Parameters.AddWithValue("@p1", cmbCity.SelectedIndex + 1);
            SqlDataReader dr = commandDistrictList.ExecuteReader();
            while (dr.Read())
            {
                cmbDistrict.Items.Add(dr[0].ToString());
            }
            connection.connect().Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandSave = new SqlCommand("insert into Table_Customer (identityNo, name, surname, phone1, phone2, mail, city, district, address, institutionCity) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)", connection.connect());
            commandSave.Parameters.AddWithValue("@p1", mskIdentityNo.Text);
            commandSave.Parameters.AddWithValue("@p2", txtName.Text);
            commandSave.Parameters.AddWithValue("@p3", txtSurname.Text);
            commandSave.Parameters.AddWithValue("@p4", mskPhone1.Text);
            commandSave.Parameters.AddWithValue("@p5", mskPhone2.Text);
            commandSave.Parameters.AddWithValue("@p6", txtMail.Text);
            commandSave.Parameters.AddWithValue("@p7", cmbCity.Text);
            commandSave.Parameters.AddWithValue("@p8", cmbDistrict.Text);
            commandSave.Parameters.AddWithValue("@p9", txtBoxAddress.Text);
            commandSave.Parameters.AddWithValue("@p10", txtInstitutionC.Text);

            commandSave.ExecuteNonQuery();
            messageShow("Customer Added !");
            customerList();
            cleanBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdate = new SqlCommand("Update Table_Customer SET " +
            "identityNo = @p1, name = @p2, surname = @p3, phone1 = @p4, phone2 = @p5, mail = @p6, city = @p7, district = @p8, address = @p9, institutionCity = @p10 " +
            "WHERE id = @p11", connection.connect());
            commandUpdate.Parameters.AddWithValue("@p1", mskIdentityNo.Text);
            commandUpdate.Parameters.AddWithValue("@p2", txtName.Text);
            commandUpdate.Parameters.AddWithValue("@p3", txtSurname.Text);
            commandUpdate.Parameters.AddWithValue("@p4", mskPhone1.Text);
            commandUpdate.Parameters.AddWithValue("@p5", mskPhone2.Text);
            commandUpdate.Parameters.AddWithValue("@p6", txtMail.Text);
            commandUpdate.Parameters.AddWithValue("@p7", cmbCity.Text);
            commandUpdate.Parameters.AddWithValue("@p8", cmbDistrict.Text);
            commandUpdate.Parameters.AddWithValue("@p9", txtBoxAddress.Text);
            commandUpdate.Parameters.AddWithValue("@p10", txtInstitutionC.Text);
            commandUpdate.Parameters.AddWithValue("@p11", txtID.Text);
            commandUpdate.ExecuteNonQuery();
            connection.connect().Close();

            messageShow(txtName.Text + " Updated !");
            customerList();
            cleanBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = new DialogResult();
            answer = MessageBox.Show("Do you want to delete '" + txtName.Text + "'", "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                SqlCommand commandDelete = new SqlCommand("DELETE FROM Table_Customer WHERE id = @p1", connection.connect());
                commandDelete.Parameters.AddWithValue("@p1", txtID.Text);
                commandDelete.ExecuteNonQuery();
                connection.connect().Close();
            }
            customerList();
            cleanBox();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["id"].ToString();
                txtName.Text = dr["name"].ToString();
                txtSurname.Text = dr["surname"].ToString();
                mskIdentityNo.Text = dr["identityNo"].ToString();
                mskPhone1.Text = dr["phone1"].ToString();
                mskPhone2.Text = dr["phone2"].ToString();
                txtMail.Text = dr["mail"].ToString();
                cmbCity.Text = dr["city"].ToString();
                cmbDistrict.Text = dr["district"].ToString();
                txtBoxAddress.Text = dr["address"].ToString();
                txtInstitutionC.Text = dr["institutionCity"].ToString();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanBox();
        }
    }
}
