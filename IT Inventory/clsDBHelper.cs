using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Inventory
{
    public class clsDBHelper
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MXWH279ConnectionString"].ConnectionString;

        public bool IsUserEnable(string userName)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_check_user_access", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = userName;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.HasRows) return true;
                        else return false;
                    }
                }
            }
            catch(Exception e)
            {
                return false;
            }

            
        }

        public bool AddNewUser(string userName, string email, bool isAdministrator)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_add_new_user", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = userName;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = email;
                    cmd.Parameters.Add("@IsAdministrator", SqlDbType.Bit, 2).Value = isAdministrator;

                    connection.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        connection.Close();

                        return true;
                    }
                    else
                    {
                        connection.Close();

                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetUsers()
        {
            DataTable table = new DataTable();

            SqlDataAdapter dataAdapter = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_get_users", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    connection.Open();

                    dataAdapter = new SqlDataAdapter(cmd);

                    dataAdapter.Fill(table);
                }

                return table;
            }
            catch
            {
                return table;
            }
        }


        public bool UpdateUserInformation(int userId, string userName, string email, bool enable, bool isAdministrator)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_update_users_information", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add("@IdUser", SqlDbType.SmallInt, 2).Value = userId;
                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = userName;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = email;
                    cmd.Parameters.Add("@Enable", SqlDbType.Bit, 2).Value = enable;
                    cmd.Parameters.Add("@IsAdministrator", SqlDbType.Bit, 2).Value = isAdministrator;

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        conn.Close();

                        return true;
                    }
                    else
                    {
                        conn.Close();

                        return false;
                    }

                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
