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
    public partial class FrmExpense : Form
    {
        public FrmExpense()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        private void expenseList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Expense ORDER BY id ASC", connection.connect());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void cleanBox()
        {
            txtID.Text = "";
            txtElectric.Text = "";
            txtWater.Text = "";
            txtFuel.Text = "";
            txtInternet.Text = "";
            txtSalary.Text = "";
            txtExtra.Text = "";
            txtBoxNote.Text = "";
            dateTimePicker1.Text = System.DateTime.Now.ToString();

        }

        private void FrmExpense_Load(object sender, EventArgs e)
        {
            expenseList();
            cleanBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandInsert = new SqlCommand("insert into Table_Expense (electric, water, fuel, internet, salary, extra, note, date) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", connection.connect());
            txtElectric.Text = txtElectric.Text == "" ? txtElectric.Text = "0" : txtElectric.Text;
            txtWater.Text = txtWater.Text == "" ? txtWater.Text = "0" : txtWater.Text;
            txtFuel.Text = txtFuel.Text == "" ? txtFuel.Text = "0" : txtFuel.Text;
            txtInternet.Text = txtInternet.Text == "" ? txtInternet.Text = "0" : txtInternet.Text;
            txtSalary.Text = txtSalary.Text == "" ? txtSalary.Text = "0" : txtSalary.Text;
            txtExtra.Text = txtExtra.Text == "" ? txtExtra.Text = "0" : txtExtra.Text;

            commandInsert.Parameters.AddWithValue("@p1", decimal.Parse(txtElectric.Text));
            commandInsert.Parameters.AddWithValue("@p2", decimal.Parse(txtWater.Text));
            commandInsert.Parameters.AddWithValue("@p3", decimal.Parse(txtFuel.Text));
            commandInsert.Parameters.AddWithValue("@p4", decimal.Parse(txtInternet.Text));
            commandInsert.Parameters.AddWithValue("@p5", decimal.Parse(txtSalary.Text));
            commandInsert.Parameters.AddWithValue("@p6", decimal.Parse(txtExtra.Text));
            commandInsert.Parameters.AddWithValue("@p7", txtBoxNote.Text);
            commandInsert.Parameters.AddWithValue("@p8", dateTimePicker1.Text);
            commandInsert.ExecuteNonQuery();
            connection.connect().Close();

            MessageBox.Show("Expense added !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            expenseList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["id"].ToString();
                txtElectric.Text = dr["electric"].ToString();
                txtWater.Text = dr["water"].ToString();
                txtFuel.Text = dr["fuel"].ToString();
                txtInternet.Text = dr["internet"].ToString();
                txtSalary.Text = dr["salary"].ToString();
                txtExtra.Text = dr["extra"].ToString();
                txtBoxNote.Text = dr["note"].ToString();
                dateTimePicker1.Text = dr["date"].ToString();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete it ?", "Are You Sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand commandDelete = new SqlCommand("Delete From Table_Expense Where id = " + txtID.Text, connection.connect());
                commandDelete.ExecuteNonQuery();
                connection.connect().Close();
                expenseList();
                cleanBox();

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdate = new SqlCommand("Update Table_Expense Set electric = @p1, water = @p2, fuel = @p3, internet = @p4, salary = @p5, extra = @p6, note = @p7, date = @p8 WHERE id = @p9", connection.connect());
            commandUpdate.Parameters.AddWithValue("@p9", txtID.Text);
            commandUpdate.Parameters.AddWithValue("@p1", decimal.Parse(txtElectric.Text));
            commandUpdate.Parameters.AddWithValue("@p2", decimal.Parse(txtWater.Text));
            commandUpdate.Parameters.AddWithValue("@p3", decimal.Parse(txtFuel.Text));
            commandUpdate.Parameters.AddWithValue("@p4", decimal.Parse(txtInternet.Text));
            commandUpdate.Parameters.AddWithValue("@p5", decimal.Parse(txtSalary.Text));
            commandUpdate.Parameters.AddWithValue("@p6", decimal.Parse(txtExtra.Text));
            commandUpdate.Parameters.AddWithValue("@p7", txtBoxNote.Text);
            commandUpdate.Parameters.AddWithValue("@p8", dateTimePicker1.Text);
            commandUpdate.ExecuteNonQuery();
            connection.connect().Close();

            MessageBox.Show("Expense updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            expenseList();
            cleanBox();
        }
    }
}
