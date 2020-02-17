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
    public partial class FrmStaff : Form
    {
        public FrmStaff()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        private void staffList()
        {
            SqlCommand commandList = new SqlCommand("SELECT * FROM Table_Staff", connection.connect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandList);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            connection.connect().Close();
        }
        private void cityList()
        {
            SqlCommand commandCityList = new SqlCommand("Select city From Table_City", connection.connect());
            SqlDataReader dr = commandCityList.ExecuteReader();
            while (dr.Read())
            {
                cmbCity.Items.Add(dr[0].ToString());
            }
            connection.connect().Close();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrict.Items.Clear();
            SqlCommand commandDistrict = new SqlCommand("Select district From Table_District WHERE city = @p1", connection.connect());
            commandDistrict.Parameters.AddWithValue("@p1", cmbCity.SelectedIndex + 1);
            SqlDataReader dr = commandDistrict.ExecuteReader();
            while (dr.Read())
            {
                cmbDistrict.Items.Add(dr[0].ToString());
            }
            connection.connect().Close();
        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            staffList();
            cityList();
        }
        private void clearBox()
        {
            txtID.Text = "";
            mskIdentityNo.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            mskPhone.Text = "";
            txtMail.Text = "";
            cmbCity.Text = "";
            cmbDistrict.Text = "";
            txtBoxAddress.Text = "";
            txtPosition.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandInsert = new SqlCommand("Insert Into Table_Staff (identityNo, name, surname, phone, mail, city, district, address, position) VALUES ( @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", connection.connect());
            commandInsert.Parameters.AddWithValue("@p1", mskIdentityNo.Text);
            commandInsert.Parameters.AddWithValue("@p2", txtName.Text);
            commandInsert.Parameters.AddWithValue("@p3", txtSurname.Text);
            commandInsert.Parameters.AddWithValue("@p4", mskPhone.Text);
            commandInsert.Parameters.AddWithValue("@p5", txtMail.Text);
            commandInsert.Parameters.AddWithValue("@p6", cmbCity.Text);
            commandInsert.Parameters.AddWithValue("@p7", cmbDistrict.Text);
            commandInsert.Parameters.AddWithValue("@p8", txtBoxAddress.Text);
            commandInsert.Parameters.AddWithValue("@p9", txtPosition.Text);

            commandInsert.ExecuteNonQuery();
            connection.connect().Close();
            MessageBox.Show("Staff added ! ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            staffList();
            clearBox();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["id"].ToString();
                mskIdentityNo.Text = dr["identityNo"].ToString();
                txtName.Text = dr["name"].ToString();
                txtSurname.Text = dr["surname"].ToString();
                mskPhone.Text = dr["phone"].ToString();
                txtMail.Text = dr["mail"].ToString();
                cmbCity.Text = dr["city"].ToString();
                cmbDistrict.Text = dr["district"].ToString();
                txtBoxAddress.Text = dr["address"].ToString();
                txtPosition.Text = dr["position"].ToString();
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clearBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdate = new SqlCommand("Update Table_Staff SET identityNo = @p1, name = @p2, surname = @p3, phone = @p4, mail = @p5, city = @p6, district = @p7, address = @p8, position = @p9 WHERE id = @p10", connection.connect());
            commandUpdate.Parameters.AddWithValue("@p1", mskIdentityNo.Text);
            commandUpdate.Parameters.AddWithValue("@p2", txtName.Text);
            commandUpdate.Parameters.AddWithValue("@p3", txtSurname.Text);
            commandUpdate.Parameters.AddWithValue("@p4", mskPhone.Text);
            commandUpdate.Parameters.AddWithValue("@p5", txtMail.Text);
            commandUpdate.Parameters.AddWithValue("@p6", cmbCity.Text);
            commandUpdate.Parameters.AddWithValue("@p7", cmbDistrict.Text);
            commandUpdate.Parameters.AddWithValue("@p8", txtBoxAddress.Text);
            commandUpdate.Parameters.AddWithValue("@p9", txtPosition.Text);
            commandUpdate.Parameters.AddWithValue("@p10", txtID.Text);
            commandUpdate.ExecuteNonQuery();
            connection.connect().Close();

            MessageBox.Show("Staff updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            staffList();
            clearBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Do you want to delete '" + txtName.Text + "'", "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand commandDelete = new SqlCommand("Delete From Table_Staff Where id = @p1", connection.connect());
                commandDelete.Parameters.AddWithValue("@p1", txtID.Text);
                commandDelete.ExecuteNonQuery();
                connection.connect().Close();
                staffList();
            }
            clearBox();
        }
    }
}
