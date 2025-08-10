using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SportCLUB
{
    public class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5TBAK58Q;Initial Catalog=SportClub;Integrated Security=True");
        public void OpenCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
