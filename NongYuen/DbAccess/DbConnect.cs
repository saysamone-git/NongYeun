using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongYuen.DbAccess
{
    public class DbConnect
    {
        string conString = "Server=localhost;Database=NongYuen;Uid=root;Password=''";
        private MySqlConnection sqlCon = new MySqlConnection();
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataAdapter da;

        public void connect()
        {
            sqlCon.ConnectionString = conString;
            if (sqlCon.State.Equals(ConnectionState.Open))
            {
                sqlCon.Close();
            }
            sqlCon.Open();
        }

        public DataTable getDataTable(string sql)
        {
            DataTable dt = new DataTable();
            cmd.Connection = sqlCon;
            cmd.CommandText = sql;
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
