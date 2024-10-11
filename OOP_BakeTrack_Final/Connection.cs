
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace OOP_BakeTrack_Final
{
    internal class Connection
    {
        public static SqlConnection getConn()
        {
            return new SqlConnection("Data Source=DESKTOP-6DR48AV\\SQLEXPRESS;Initial Catalog=BakeTrackDB;Integrated Security=True;Encrypt=False");
        }
        public static int getVacantID(String tableName)
        {
            SqlConnection conn = getConn();
            conn.Open();

            string query = "SELECT id FROM " + tableName + " ORDER BY id";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int id = 1;
            while (reader.Read())
            {
                if (Convert.ToInt32(reader[0]) != id)
                {
                    break;
                } else
                {
                    id++;
                }
            }
            cmd.Dispose();
            reader.Close();
            conn.Close();
            return id;
        }
    }
}
