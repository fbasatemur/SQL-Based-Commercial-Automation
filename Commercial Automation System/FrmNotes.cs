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
    public partial class FrmNotes : Form
    {
        public FrmNotes()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        void notesList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Notes", connection.connect());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            connection.connect().Close();
        }
        void cleanBox()
        {
            txtID.Text = "";
            mskDate.Text = "";
            mskTime.Text = "";
            txtHeader.Text = "";
            txtBoxNotes.Text = "";
            txtCreativePer.Text = "";
            txtRelatedPer.Text = "";
        }
        private void FrmNotes_Load(object sender, EventArgs e)
        {
            notesList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandInsert = new SqlCommand("insert into Table_Notes (date, time, header, detail, creativePerson, relatedPerson) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", connection.connect());
            commandInsert.Parameters.AddWithValue("@p1", mskDate.Text);
            commandInsert.Parameters.AddWithValue("@p2", mskTime.Text);
            commandInsert.Parameters.AddWithValue("@p3", txtHeader.Text);
            commandInsert.Parameters.AddWithValue("@p4", txtBoxNotes.Text);
            commandInsert.Parameters.AddWithValue("@p5", txtCreativePer.Text);
            commandInsert.Parameters.AddWithValue("@p6", txtRelatedPer.Text);
            commandInsert.ExecuteNonQuery();

            connection.connect().Close();
            MessageBox.Show("Note added !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            notesList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["id"].ToString();
            mskDate.Text = dr["date"].ToString();
            mskTime.Text = dr["time"].ToString();
            txtHeader.Text = dr["header"].ToString();
            txtBoxNotes.Text = dr["detail"].ToString();
            txtCreativePer.Text = dr["creativePerson"].ToString();
            txtRelatedPer.Text = dr["relatedPerson"].ToString();

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete the note ?", "Are You Sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand commanDelete = new SqlCommand("Delete From Table_Notes WHERE id = " + txtID.Text, connection.connect());
                commanDelete.ExecuteNonQuery();
                connection.connect().Close();

                notesList();
                cleanBox();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdate = new SqlCommand("update Table_Notes SET date = @p1, time = @p2, header = @p3, detail = @p4, creativePerson = @p5, relatedPerson = @p6 WHERE id = " + txtID.Text, connection.connect());
            commandUpdate.Parameters.AddWithValue("@p1", mskDate.Text);
            commandUpdate.Parameters.AddWithValue("@p2", mskTime.Text);
            commandUpdate.Parameters.AddWithValue("@p3", txtHeader.Text);
            commandUpdate.Parameters.AddWithValue("@p4", txtBoxNotes.Text);
            commandUpdate.Parameters.AddWithValue("@p5", txtCreativePer.Text);
            commandUpdate.Parameters.AddWithValue("@p6", txtRelatedPer.Text);
            commandUpdate.ExecuteNonQuery();

            connection.connect().Close();
            MessageBox.Show("Note updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            notesList();
            cleanBox();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNoteDetails frmNoteDetails = new FrmNoteDetails();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frmNoteDetails.textGetSet = dr["detail"].ToString();
                frmNoteDetails.Show();
            }
        }
    }
}
