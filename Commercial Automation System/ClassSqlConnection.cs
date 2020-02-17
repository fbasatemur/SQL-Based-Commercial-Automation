using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data.SqlClient;
namespace Commercial_Automation_System
{
    class ClassSqlConnection
    {
        public SqlConnection connect()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-U5PMUAL\\SQLEXPRESS;Initial Catalog=CommercialAutomationDB;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
