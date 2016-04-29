using System;
using System.Data.SqlClient;

namespace Airline.Model
{
    class Carrier : Base
    {
        public string CarrierNo { get; set; }
        public string CarrierName { get; set; }
        public string Country { get; set; }

        private void setBase()
        {
            TableName = "Carrier";
            Key = "CarrierNo";
        }

        public Carrier()
        {
            setBase();
        }

        public Carrier(string carrierNo)
        {
            CarrierNo = carrierNo;
            setBase();
        }

        public Carrier(string carrierNo, string carrierName, string country)
        {
            CarrierNo = carrierNo;
            CarrierName = carrierName;
            Country = country;
            setBase();
        }

        public void Fetch()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
            sqlConnection.Open();
            try
            {
                // fetch flight record
                SqlCommand cmd = new SqlCommand("select * from " + TableName + " where " + Key + " = '" + CarrierNo + "'", sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    CarrierName = sqlDataReader["CarrierName"].ToString();
                    Country = sqlDataReader["Country"].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public bool Add()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
            sqlConnection.Open();
            try
            {
                // add flight record
                SqlCommand cmd = new SqlCommand("insert into " + TableName + " values("
                    + "'" + CarrierNo + "'" + ","
                    + "'" + CarrierName + "'" + ","
                    + "'" + Country + "')", sqlConnection);
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

        public bool Update()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
            sqlConnection.Open();
            try
            {
                // add flight record
                SqlCommand cmd = new SqlCommand("update " + TableName + " set "
                    + "CarrierName = '" + CarrierName + "'" + ","
                    + "Country = '" + Country + "'"
                    + " where " + Key + " = '" + CarrierNo + "'", sqlConnection);
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
