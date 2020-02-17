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
using System.Xml;

namespace Commercial_Automation_System
{
    public partial class FrmDesktop : Form
    {
        public FrmDesktop()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        private void stockList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT top 10 name, sum(piece) as 'piece' FROM Table_Product GROUP BY Table_Product.name order by sum(piece)", connection.connect());
            da.Fill(dt);
            gridCStock.DataSource = dt;
            connection.connect().Close();
        }
        private void agentaList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT top 10 date, time, header FROM Table_Notes order by id desc", connection.connect());
            da.Fill(dt);
            gridCAgenda.DataSource = dt;
            connection.connect().Close();
        }
        private void companyTList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec CompanyTraLIST", connection.connect());
            da.Fill(dt);
            gridCLast10T.DataSource = dt;

        }
        private void companyTelephoneList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select name, authorizedNameSur as 'authorized', phone1 From Table_Company", connection.connect());
            da.Fill(dt);
            gridCTelephoneL.DataSource = dt;

        }
        private void newsXMLRead()
        {
            XmlTextReader xmlReader = new XmlTextReader("https://www.ntv.com.tr/sitemaps/news-sitemap.xml");
            while (xmlReader.Read())
            {
                if (xmlReader.Name == "news:title")
                {
                    listBox1.Items.Add(xmlReader.ReadString().ToString());
                }
            }
        }
        private void FrmDesktop_Load(object sender, EventArgs e)
        {
            stockList();
            agentaList();
            companyTList();
            companyTelephoneList();

            try
            {
                webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
                newsXMLRead();
            }
            catch (Exception)
            {
                // MessageBox.Show(error.Message.ToString(), "Internet connection failed ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
