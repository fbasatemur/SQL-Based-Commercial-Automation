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
using DevExpress.Charts;

namespace Commercial_Automation_System
{
    public partial class FrmSafe : Form
    {
        public FrmSafe()
        {
            InitializeComponent();
        }
        ClassSqlConnection connection = new ClassSqlConnection();

        private void customerTransactions()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec CustomerTransactionsLIST", connection.connect());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            connection.connect();
        }
        private void companyTransactions()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec CompanyTransactionsLIST", connection.connect());
            da.Fill(dt);
            gridControl3.DataSource = dt;
            connection.connect();
        }

        private void expenseList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * FROM Table_Expense", connection.connect());
            da.Fill(dt);
            gridControl2.DataSource = dt;
            connection.connect().Close();
        }
        private void FrmSafe_Load(object sender, EventArgs e)
        {
            companyTransactions();
            customerTransactions();
            expenseList();

            // toplam tutar
            SqlCommand commandTotal = new SqlCommand("Select sum(total) From Table_BillDetail", connection.connect());
            SqlDataReader dr = commandTotal.ExecuteReader();

            while (dr.Read())
            {
                lblTotal.Text = dr[0].ToString() + "TL";
            }
            connection.connect().Close();

            // Son ayin Fatura tutari 
            SqlCommand commandPayments = new SqlCommand("select (electric + water + fuel + internet + extra), salary FROM Table_Expense Order By id desc", connection.connect());
            SqlDataReader dr2 = commandPayments.ExecuteReader();
            dr2.Read();
            lblPayments.Text = dr2[0].ToString() + "TL";

            // Son ayin personel maasleri
            lblStaffSalary.Text = dr2[1].ToString();

            connection.connect().Close();

            // toplam customer sayisi
            SqlCommand commandCustomers = new SqlCommand("select count(*), count(distinct(city)) FROM Table_Customer", connection.connect());
            SqlDataReader dr3 = commandCustomers.ExecuteReader();
            dr3.Read();
            lblCustomers.Text = dr3[0].ToString();
            // toplam customer farkli city sayisi
            lblCuCity.Text = dr3[1].ToString();

            connection.connect().Close();

            // toplam company sayisi
            SqlCommand commandCompany = new SqlCommand("select count(name), count(distinct(city)) FROM Table_Company", connection.connect());
            SqlDataReader dr4 = commandCompany.ExecuteReader();
            dr4.Read();
            lblCompanies.Text = dr4[0].ToString();

            // toplam company farkli city sayisi
            lblCCity.Text = dr4[1].ToString();

            connection.connect().Close();

            // toplam staff sayisi
            SqlCommand commandStaff = new SqlCommand("select count(*) FROM Table_Staff", connection.connect());
            SqlDataReader dr5 = commandStaff.ExecuteReader();
            dr5.Read();
            lblStaff.Text = dr5[0].ToString();

            connection.connect().Close();

            // kalan stock miktari
            SqlCommand commandProduct = new SqlCommand("select sum(piece) FROM Table_Product", connection.connect());
            SqlDataReader dr6 = commandProduct.ExecuteReader();
            dr6.Read();
            lblStock.Text = dr6[0].ToString();

            connection.connect().Close();

            
        }

        int counter1 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1++;
            if (counter1 >= 0 && counter1 < 5)
            {
                groupControl9.Text = "Electric";
                chartControl1.Series["Aylar"].Points.Clear();
                // ChartControl1, son 4 ay elektrik faturasi listele
                SqlCommand commandChart1 = new SqlCommand("select top 4 date, electric FROM Table_Expense order by id desc", connection.connect());
                SqlDataReader dr7 = commandChart1.ExecuteReader();
                while (dr7.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr7[0].ToString() , dr7[1]));
                }

                connection.connect().Close();

                
            }
            else if(counter1 >= 5 && counter1 < 10)
            {
                groupControl9.Text = "Water";
                chartControl1.Series["Aylar"].Points.Clear();

                // ChartControl1, son 4 ay su faturasi listele
                SqlCommand commandChart1 = new SqlCommand("select top 4 date, water FROM Table_Expense order by id desc", connection.connect());
                SqlDataReader dr8 = commandChart1.ExecuteReader();
                while (dr8.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr8[0], dr8[1]));
                }

                connection.connect().Close();
            }
            else if (counter1 >= 10 && counter1 < 15)
            {
                groupControl9.Text = "Fuel";
                chartControl1.Series["Aylar"].Points.Clear();

                // ChartControl1, son 4 ay su faturasi listele
                SqlCommand commandChart1 = new SqlCommand("select top 4 date, fuel FROM Table_Expense order by id desc", connection.connect());
                SqlDataReader dr8 = commandChart1.ExecuteReader();
                while (dr8.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr8[0], dr8[1]));
                }

                connection.connect().Close();
            }
            else if (counter1 >= 15 && counter1 < 20)
            {
                groupControl9.Text = "Internet";
                chartControl1.Series["Aylar"].Points.Clear();

                // ChartControl1, son 4 ay su faturasi listele
                SqlCommand commandChart1 = new SqlCommand("select top 4 date, internet FROM Table_Expense order by id desc", connection.connect());
                SqlDataReader dr8 = commandChart1.ExecuteReader();
                while (dr8.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr8[0], dr8[1]));
                }

                connection.connect().Close();
            }

            else if (counter1 >= 20 && counter1 < 25)
            {
                groupControl9.Text = "Extra";
                chartControl1.Series["Aylar"].Points.Clear();

                // ChartControl1, son 4 ay su faturasi listele
                SqlCommand commandChart1 = new SqlCommand("select top 4 date, extra FROM Table_Expense order by id desc", connection.connect());
                SqlDataReader dr8 = commandChart1.ExecuteReader();
                while (dr8.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr8[0], dr8[1]));
                }

                connection.connect().Close();
            }

            if (counter1 == 25)
                counter1 = 0;
        }

        

        Boolean firtsClick = true;
        Boolean secondClick = false;
        private void chartControl1_Click(object sender, EventArgs e)
        {
            if(firtsClick == true)
            {
                firtsClick = false;
                secondClick = true;
                timer1.Stop();
            }
            else if (secondClick == true)
            {
                firtsClick = true;
                secondClick = false;
                timer1.Start();
            }
        }
    }
}
