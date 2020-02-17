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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        private void list()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Admin", connection.connect());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            connection.connect().Close();
        }
        private void FrmSettingscs_Load(object sender, EventArgs e)
        {
            list();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand adminControl = new SqlCommand("SELECT userName FROM Table_Admin WHERE EXISTS (Select userName From Table_Admin WHERE Table_Admin.userName = @p1) AND userName = @p1 ", connection.connect());
            adminControl.Parameters.AddWithValue("@p1", txtUser.Text);
            SqlDataReader dr = adminControl.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("Enter a different username !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand commandInsert = new SqlCommand("insert into Table_Admin VALUES (@p1, @p2)", connection.connect());
                commandInsert.Parameters.AddWithValue("@p1", txtUser.Text);
                commandInsert.Parameters.AddWithValue("@p2", txtPass.Text);
                commandInsert.ExecuteNonQuery();
                connection.connect().Close();

                MessageBox.Show("Admin added !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
            }
            

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtUser.Text = dr["userName"].ToString();
                txtPass.Text = dr["password"].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdate = new SqlCommand("UPDATE Table_Admin SET password = @p2 WHERE userName = @p1", connection.connect());
            commandUpdate.Parameters.AddWithValue("@p1", txtUser.Text);
            commandUpdate.Parameters.AddWithValue("@p2", txtPass.Text);
            commandUpdate.ExecuteNonQuery();
            connection.connect().Close();

            MessageBox.Show("Admin updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }
    }
}
