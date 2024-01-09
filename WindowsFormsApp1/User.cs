using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    internal class User
    {
        DataBase db = new DataBase();

        public static int sessionId;
        public static bool isAdmin;

        public User()
        {

        }

        public bool admin { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public UserList users;

        internal void Fill(string login, string password, string name, string phone, string email) {
            this.login = login;
            this.password = password;
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

        internal void Save()
        {
            SqlConnection c = db.get();
            string query = $"insert into users (login,password,name,phone,email,is_admin) values ('{login}','{password}',N'{name}','{phone}','{email}', 0)";
            SqlCommand cmd = new SqlCommand(query, c);
            cmd.ExecuteNonQuery();
        }

        internal bool Auth(string login, string password)
        {
            SqlConnection c = db.get();
            string query = $"select id,is_admin from users where login='{login}' and password='{password}'";
            SqlDataAdapter da = new SqlDataAdapter(query, c);
            DataSet ds = new DataSet();

            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count == 1)
            {
                Console.WriteLine("Find 1 user with login and password. Authorization completed");
                DataRow row = dt.Rows[0];

                isAdmin = (int)row["is_admin"] == 1;
                sessionId = (int)row["id"];

                if (isAdmin)
                {
                    Console.WriteLine("User is administrator!");
                }

                return true;
            }
            return false;
        }




    }
}
