using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace OOP_BakeTrack_Final
{
    internal class Util
    {
        public static String checkValidName(String input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetter(input[i]) && input[i] != ' ')
                {
                    throw new Exception("Invalid name.");
                }
            }

            return input;
        }
        public static bool checkIfNameExists(String table, String name)
        {
            SqlConnection cq = Connection.getConn();
            cq.Open();

            string query = "SELECT COUNT(*) FROM " + table + " WHERE name = @name";

            try
            {
                SqlCommand cmd = new SqlCommand(query, cq);
                cmd.Parameters.AddWithValue("@name", name);

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    cmd.Dispose();
                    cq.Close();
                    cq.Dispose();
                    return true;
                }
            }
            catch (Exception ex)
            { }

            cq.Close();
            cq.Dispose();
            return false;
        }

        public static bool checkNameChangeValid(String table, String name, int id)
        {
            SqlConnection cq = Connection.getConn();
            cq.Open();

            string query = "SELECT id FROM " + table + " WHERE name = @name";
            bool valid = true;

            try
            {
                SqlCommand cmd = new SqlCommand(query, cq);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader[0]) != id)
                    {
                        valid = false;
                        break;
                    }
                }
            }
            catch (Exception ex)
            { }

            cq.Close();
            cq.Dispose();
            return valid;
        }
    }
}
