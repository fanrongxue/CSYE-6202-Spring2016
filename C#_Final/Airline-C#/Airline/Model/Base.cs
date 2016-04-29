using System;
using System.Data.SqlClient;

namespace Airline.Model
{
    class Base
    {
        protected string TableName { get; set; }
        protected string Key { get; set; }

        public Base() { }

        // delete from database
        public bool Delete(string IDs)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
            sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete from " + TableName + " where " + Key + " in " + IDs, sqlConnection);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {

            }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }
    }
}
