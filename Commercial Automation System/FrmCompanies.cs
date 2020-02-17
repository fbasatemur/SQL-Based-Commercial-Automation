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
    public partial class FrmCompanies : Form
    {
        public FrmCompanies()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        ClassSqlConnection connection = new ClassSqlConnection();

        private void companyList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Company", connection.connect());
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

        private void companySpecialCode1View()
        {
            SqlCommand commandSpecialCode1List = new SqlCommand("Select companyCode1 From Table_Code", connection.connect());
            SqlDataReader dr = commandSpecialCode1List.ExecuteReader();
            while (dr.Read())
            {
                txtBoxCode1.Text = dr[0].ToString();
            }
            connection.connect().Close();
        }
        private void FrmCompanies_Load(object sender, EventArgs e)
        {
            
            companyList();
            cityList();
            companySpecialCode1View();
        }

        private void clearBox()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtSector.Text = "";
            mskAIdentity.Text = "";
            txtAName.Text = "";
            txtAMission.Text = "";
            mskPhone1.Text = "";
            mskPhone2.Text = "";
            mskPhone3.Text = "";
            txtMail.Text = "";
            mskFax.Text = "";
            cmbCity.Text = "";
            cmbDistrict.Text = "";
            txtAddress.Text = "";
            txtInstitutionC.Text = "";
            txtCode1.Text = "";
            txtCode2.Text = "";
            txtCode3.Text = "";

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["id"].ToString();
                txtName.Text = dr["name"].ToString();
                txtSector.Text = dr["sector"].ToString();
                mskAIdentity.Text = dr["authorizedIdentityNo"].ToString();
                txtAName.Text = dr["authorizedNameSur"].ToString();
                txtAMission.Text = dr["authorizedPosition"].ToString();
                mskPhone1.Text = dr["phone1"].ToString();
                mskPhone2.Text = dr["phone2"].ToString();
                mskPhone3.Text = dr["phone3"].ToString();
                txtMail.Text = dr["mail"].ToString();
                mskFax.Text = dr["fax"].ToString();
                cmbCity.Text = dr["city"].ToString();
                cmbDistrict.Text = dr["district"].ToString();
                txtAddress.Text = dr["address"].ToString();
                txtInstitutionC.Text = dr["institutionCity"].ToString();
                txtCode1.Text = dr["specialFilter1"].ToString();
                txtCode2.Text = dr["specialFilter2"].ToString();
                txtCode3.Text = dr["specialFilter3"].ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlCommand commandInsert = new SqlCommand("insert into Table_Company (name, sector, authorizedIdentityNo, authorizedNameSur, authorizedPosition, phone1, phone2, phone3, mail, fax, city, district, address, institutionCity, specialFilter1, specialFilter2, specialFilter3) " +
                "VALUES " +
                "(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17)", connection.connect());
            commandInsert.Parameters.AddWithValue("@p1", txtName.Text);
            commandInsert.Parameters.AddWithValue("@p2", txtSector.Text);
            commandInsert.Parameters.AddWithValue("@p3", mskAIdentity.Text);
            commandInsert.Parameters.AddWithValue("@p4", txtAName.Text);
            commandInsert.Parameters.AddWithValue("@p5", txtAMission.Text);
            commandInsert.Parameters.AddWithValue("@p6", mskPhone1.Text);
            commandInsert.Parameters.AddWithValue("@p7", mskPhone2.Text);
            commandInsert.Parameters.AddWithValue("@p8", mskPhone3.Text);
            commandInsert.Parameters.AddWithValue("@p9", txtMail.Text);
            commandInsert.Parameters.AddWithValue("@p10", mskFax.Text);
            commandInsert.Parameters.AddWithValue("@p11", cmbCity.Text);
            commandInsert.Parameters.AddWithValue("@p12", cmbDistrict.Text);
            commandInsert.Parameters.AddWithValue("@p13", txtAddress.Text);
            commandInsert.Parameters.AddWithValue("@p14", txtInstitutionC.Text);
            commandInsert.Parameters.AddWithValue("@p15", txtCode1.Text);
            commandInsert.Parameters.AddWithValue("@p16", txtCode2.Text);
            commandInsert.Parameters.AddWithValue("@p17", txtCode3.Text);
            commandInsert.ExecuteNonQuery();

            connection.connect().Close();

            MessageBox.Show("Company added !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            companyList();
            clearBox();

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Do you want to delete '"+ txtName.Text + "' company ?", "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                SqlCommand commandDelete = new SqlCommand("Delete From Table_Company Where id= @p1 ", connection.connect());
                commandDelete.Parameters.AddWithValue("@p1", txtID.Text);
                commandDelete.ExecuteNonQuery();
                connection.connect().Close();
                companyList();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdate = new SqlCommand("Update Table_Company SET name = @p1, sector= @p2, authorizedIdentityNo = @p3, authorizedNameSur = @p4, authorizedPosition = @p5, " +
                "phone1 = @p6, phone2 = @p7, phone3 = @p8, mail = @p9, fax = @p10, city = @p11, district = @p12, address = @p13, institutionCity = @p14, specialFilter1 = @p15, specialFilter2 = @p16, specialFilter3 = @p17 " +
                "WHERE id = @p18", connection.connect());
            commandUpdate.Parameters.AddWithValue("@p1", txtName.Text);
            commandUpdate.Parameters.AddWithValue("@p2", txtSector.Text);
            commandUpdate.Parameters.AddWithValue("@p3", mskAIdentity.Text);
            commandUpdate.Parameters.AddWithValue("@p4", txtAName.Text);
            commandUpdate.Parameters.AddWithValue("@p5", txtAMission.Text);
            commandUpdate.Parameters.AddWithValue("@p6", mskPhone1.Text);
            commandUpdate.Parameters.AddWithValue("@p7", mskPhone2.Text);
            commandUpdate.Parameters.AddWithValue("@p8", mskPhone3.Text);
            commandUpdate.Parameters.AddWithValue("@p9", txtMail.Text);
            commandUpdate.Parameters.AddWithValue("@p10", mskFax.Text);
            commandUpdate.Parameters.AddWithValue("@p11", cmbCity.Text);
            commandUpdate.Parameters.AddWithValue("@p12", cmbDistrict.Text);
            commandUpdate.Parameters.AddWithValue("@p13", txtAddress.Text);
            commandUpdate.Parameters.AddWithValue("@p14", txtInstitutionC.Text);
            commandUpdate.Parameters.AddWithValue("@p15", txtCode1.Text);
            commandUpdate.Parameters.AddWithValue("@p16", txtCode2.Text);
            commandUpdate.Parameters.AddWithValue("@p17", txtCode3.Text);
            commandUpdate.Parameters.AddWithValue("@p18", txtID.Text);
            commandUpdate.ExecuteNonQuery();
      
            MessageBox.Show("Company updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            connection.connect().Close();
            companyList();
            clearBox();
        }
    }
}
