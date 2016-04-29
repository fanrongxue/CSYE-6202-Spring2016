using System;
using System.Data.SqlClient;

namespace Airline.Model
{
    class Flight : Base
    {
        public string FlightNo { get; set; }
        public string CarrierNo { get; set; }
        public string Start { get; set; }
        public string Destination { get; set; }
        public DateTime LeavingAt { get; set; }
        public DateTime ArrivalAt { get; set; }
        public float EconomyPrice { get; set; }
        public int EconomyCount { get; set; }
        public float EconomyPlusPrice { get; set; }
        public int EconomyPlusCount { get; set; }
        public float BusinessPrice { get; set; }
        public int BusinessCount { get; set; }

        private void setBase()
        {
            TableName = "Flight";
            Key = "FlightNo";
        }

        public Flight()
        {
            setBase();
        }

        public Flight(string flightNo)
        {
            FlightNo = flightNo;
            setBase();
        }

        public Flight(string flightNo, string carrierNo, string start, string destination, DateTime leavingAt, DateTime arrivalAt,
            float economyPrice, int economyCount, float economyPlusPrice, int economyPlusCount, float businessPrice, int businessCount)
        {
            FlightNo = flightNo;
            CarrierNo = carrierNo;
            Start = start;
            Destination = destination;
            LeavingAt = leavingAt;
            ArrivalAt = arrivalAt;
            EconomyPrice = economyPrice;
            EconomyCount = economyCount;
            EconomyPlusPrice = economyPlusPrice;
            EconomyPlusCount = economyPlusCount;
            BusinessPrice = businessPrice;
            BusinessCount = businessCount;
            setBase();
        }

        public void Fetch()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
            sqlConnection.Open();
            try
            {
                // fetch flight record
                SqlCommand cmd = new SqlCommand("select * from " + TableName + " where " + Key + " = '" + FlightNo + "'", sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    FlightNo = sqlDataReader["FlightNo"].ToString();
                    CarrierNo = sqlDataReader["CarrierNo"].ToString();
                    Start = sqlDataReader["Start"].ToString();
                    Destination = sqlDataReader["Destination"].ToString();
                    LeavingAt = DateTime.Parse(sqlDataReader["LeavingAt"].ToString());
                    ArrivalAt = DateTime.Parse(sqlDataReader["ArrivalAt"].ToString());
                    EconomyPrice = float.Parse(sqlDataReader["EconomyPrice"].ToString());
                    EconomyCount = int.Parse(sqlDataReader["EconomyCount"].ToString());
                    EconomyPlusPrice = float.Parse(sqlDataReader["EconomyPlusPrice"].ToString());
                    EconomyPlusCount = int.Parse(sqlDataReader["EconomyPlusCount"].ToString());
                    BusinessPrice = float.Parse(sqlDataReader["BusinessPrice"].ToString());
                    BusinessCount = int.Parse(sqlDataReader["BusinessCount"].ToString());
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
                    + "'" + FlightNo + "'" + ","
                    + "'" + CarrierNo + "'" + ","
                    + "'" + Start + "'" + ","
                    + "'" + Destination + "'" + ","
                    + "'" + LeavingAt.ToString("yyyy/MM/dd HH:mm:ss") + "'" + ","
                    + "'" + ArrivalAt.ToString("yyyy/MM/dd HH:mm:ss") + "'" + ","
                    + EconomyPrice + ","
                    + EconomyCount + ","
                    + EconomyPlusPrice + ","
                    + EconomyPlusCount + ","
                    + BusinessPrice + ","
                    + BusinessCount
                    + ")", sqlConnection);
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
                    + "CarrierNo = '" + CarrierNo + "'" + ","
                    + "Start = '" + Start + "'" + ","
                    + "Destination = '" + Destination + "'" + ","
                    + "LeavingAt = '" + LeavingAt.ToString("yyyy/MM/dd HH:mm:ss") + "'" + ","
                    + "ArrivalAt = '" + ArrivalAt.ToString("yyyy/MM/dd HH:mm:ss") + "'" + ","
                    + "EconomyPrice = " + EconomyPrice + ","
                    + "EconomyCount = " + EconomyCount + ","
                    + "EconomyPlusPrice = " + EconomyPlusPrice + ","
                    + "EconomyPlusCount = " + EconomyPlusCount + ","
                    + "BusinessPrice = " + BusinessPrice + ","
                    + "BusinessCount = " + BusinessCount
                    + " where " + Key + " = '" + FlightNo + "'", sqlConnection);
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
