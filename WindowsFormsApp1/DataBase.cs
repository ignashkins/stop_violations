using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DataBase
    {
        SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=data;Integrated Security=True");

        public void open()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection get()
        {
            open();
            return connection;
        }
    }
}
