using System;
using System.Data.SqlClient;

namespace Airline.Model
{
    class Crew : Base
    {
        public string CrewNo { get; set; }
        public string FlightNo { get; set; }
        public string CrewName { get; set; }
        public string Role { get; set; }

        private void setBase()
        {
            TableName = "Crew";
            Key = "CrewNo";
        }

        public Crew()
        {
            setBase();
        }

        public Crew(string crewNo)
        {
            CrewNo = crewNo;
            setBase();
        }

        public Crew(string crewNo, string flightNo, string crewName, string role)
        {
            FlightNo = flightNo;
            CrewNo = crewNo;
            CrewName = crewName;
            Role = role;
            setBase();
        }

        public void Fetch()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
            sqlConnection.Open();
            try
            {
                // fetch flight record
                SqlCommand cmd = new SqlCommand("select * from " + TableName + " where " + Key + " = '" + CrewNo + "'", sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    FlightNo = sqlDataReader["FlightNo"].ToString();
                    CrewName = sqlDataReader["CrewName"].ToString();
                    Role = sqlDataReader["Role"].ToString();
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
                    + "'" + CrewNo + "'" + ","
                    + "'" + FlightNo + "'" + ","
                    + "'" + CrewName + "'" + ","
                    + "'" + Role + "')", sqlConnection);
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
                    + "FlightNo = '" + FlightNo + "'" + ","
                    + "CrewName = '" + CrewName + "'" + ","
                    + "Role = '" + Role + "'"
                    + " where " + Key + " = '" + CrewNo + "'", sqlConnection);
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
