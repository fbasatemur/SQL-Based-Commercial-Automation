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
using System.Net;
using System.Net.Mail;

namespace Commercial_Automation_System
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string mail;
        public string mailSetGet
        {
            get { return mail; }
            set { mail = value; }
        }

        private void FrmMail_Load(object sender, EventArgs e)
        {
            txtMailAddress.Text = mail;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            /*
             * txtSystemAddress -> gonderen mail 
             * txtSystemPassw   -> gonderen password
             * txtMAilAddress   -> gonderilen mail adresi
             */
            try
            {
                MailMessage message = new MailMessage();

                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(txtSystemAddress.Text, txtSystemPassw.Text);
                client.Port = 587;
                client.Host = "smtp.gmail.com";  // secilen sunucusu uzerinden (microsoft live <-> gmail)
                client.EnableSsl = true;


                message.To.Add(txtMailAddress.Text);
                message.From = new MailAddress(txtSystemAddress.Text);
                message.Subject = txtSubject.Text;
                message.Body = txtBoxMessage.Text;

                client.Send(message);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
