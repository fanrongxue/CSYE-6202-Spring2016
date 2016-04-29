using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Airline
{
    class Log
    {
        static SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
        public static bool Add(string uid, string log)
        {
            sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into [Log](UserID, [Event]) values("
                            + "'" + uid + "'" + ","
                            + "'" + log + "'" + ")", sqlConnection);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
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
}
