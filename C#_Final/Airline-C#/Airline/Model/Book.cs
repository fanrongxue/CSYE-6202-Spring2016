using System;
using System.Data.SqlClient;

namespace Airline.Model
{
    class Book
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string FlightNo { get; set; }
        public string TicketType { get; set; }
        public DateTime BookTime { get; set; }

        public Book(int id, string flightNo, string ticketType)
        {
            ID = id;
            FlightNo = flightNo;
            TicketType = ticketType;
        }

        public Book(string flightNo, string userID, string ticketType)
        {
            FlightNo = flightNo;
            UserID = userID;
            TicketType = ticketType;
        }

        public Book(int id, string flightNo, string userID, string ticketType, DateTime bookTime)
        {
            ID = id;
            FlightNo = flightNo;
            UserID = userID;
            TicketType = ticketType;
            BookTime = bookTime;
        }

        // book a ticket
        public bool Add()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
            sqlConnection.Open();
            try
            {
                // check are tickets enough
                SqlCommand cmd = new SqlCommand("select " + TicketType + "Count from Flight where FlightNo='" + FlightNo + "'", sqlConnection);
                if (int.Parse(cmd.ExecuteScalar().ToString()) > 0)
                {
                    // add book record
                    cmd = new SqlCommand("insert into Book(FlightNo, UserID, TicketType) values("
                        + "'" + FlightNo + "'" + ","
                        + "'" + UserID + "'" + ","
                        + "'" + TicketType + "'"
                        + ")", sqlConnection);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        // update ticket count
                        cmd = new SqlCommand("update Flight set " + TicketType + "Count=" + TicketType + "Count-1 where FlightNo='" + FlightNo + "'", sqlConnection);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
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

        // unbook a ticket
        public bool Delete()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
            sqlConnection.Open();
            try
            {
                // delete book record
                SqlCommand cmd = new SqlCommand("delete from Book where ID=" + ID, sqlConnection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    // update ticket count
                    cmd = new SqlCommand("update Flight set " + TicketType + "Count=" + TicketType + "Count+1 where FlightNo='" + FlightNo + "'", sqlConnection);
                    return cmd.ExecuteNonQuery()>0;
                }
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
