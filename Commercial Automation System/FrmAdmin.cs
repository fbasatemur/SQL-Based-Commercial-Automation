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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand commandSelect = new SqlCommand("Select * From Table_Admin WHERE userName=@p1 AND password=@p2", connection.connect());
            commandSelect.Parameters.AddWithValue("@p1", txtUser.Text);
            commandSelect.Parameters.AddWithValue("@p2", txtPass.Text);
            SqlDataReader dr = commandSelect.ExecuteReader();
            if(dr.Read())
            {
                FrmMain main = new FrmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("user name or password incorrect !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.connect().Close();

            
        }
    }
}
