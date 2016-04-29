using System;
using System.Data.SqlClient;

namespace Airline
{
    class User
    {
        public string ID { get; set; }
        public string Password { get; set; }
        public string Usertype { get; set; }

        public User(string id, string password)
        {
            ID = id;
            Password = password;
        }

        public User(string id, string password, string usertype)
        {
            ID = id;
            Password = password;
            Usertype = usertype;
        }

        public bool IsAdmin()
        {
            return Usertype == "1";
        }

        public bool Login()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
            sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from [User] where ID='" + ID + "' and Password='" + Password + "'", sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    Usertype = sqlDataReader["UserType"].ToString();
                    return true;
                }
            }
            catch
            { }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }

        public bool ChangePassword(string password)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
            sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update [User] set Password='" + password + "'" + " where ID='" + ID + "'", sqlConnection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Password = password;
                    return true;
                }
            }
            catch
            { }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }
    }

    // normal user
    class NormalUser : User
    {
        public NormalUser(string id, string password) : base(id, password)
        {
            Usertype = "0";
        }

        public bool Register()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
            sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into [User](ID, Password) values("
                    + "'" + ID + "'" + ","
                    + "'" + Password + "'"
                    + ")", sqlConnection);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            { }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }
    }

    // admin user
    class Admin: User
    {
        public Admin(string id, string password) : base(id, password)
        {
            Usertype = "1";
        }
    }
}
