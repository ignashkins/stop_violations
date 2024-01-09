using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data;

namespace WindowsFormsApp1
{
    internal class Claim
    {
        DataBase db = new DataBase();

        public string number { get; set; }
        public string desc { get; set; }
        public int state_id { get; set; }

        internal void Fill(string number, string desc, int state_id)
        {
            this.number = number;
            this.desc = desc;
            this.state_id = state_id;
        }

        internal void Save()
        {
            SqlConnection c = db.get();
            string query = $"insert into claims (number,[desc],state_id,user_id) values (N'{number}',N'{desc}','{state_id}','{User.sessionId}')";
            SqlCommand cmd = new SqlCommand(query, c);
            cmd.ExecuteNonQuery();
        }

        internal void Update(int id)
        {
            SqlConnection c = db.get();
            string query = $"update claims set number=N'{number}', [desc]=N'{desc}', state_id='{state_id}' where id={id}";
            SqlCommand cmd = new SqlCommand(query, c);
            cmd.ExecuteNonQuery();
        }
    }


}
