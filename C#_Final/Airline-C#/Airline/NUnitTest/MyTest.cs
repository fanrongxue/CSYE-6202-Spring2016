using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using NUnit.Framework;

namespace Airline
{
    [TestFixture]
    public static class MyTest
    {
        static SqlConnection sqlConnection;

        [SetUp]
        public static void init()
        {
            sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
        }

        [Test]
        public static void LoginTest()
        {
            sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from [User] where ID='user' and Password='123'", sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Assert.AreEqual(true, dt.Rows.Count > 0);
            }
            catch
            {
                Assert.AreEqual(1, 0);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        [Test]
        public static void QueryFlightsTest()
        {
            sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Flight", sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Assert.AreEqual(true, dt.Rows.Count > 0);
            }
            catch
            {
                Assert.AreEqual(1, 0);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        [Test]
        public static void UpdateFlightsTest()
        {
            sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Update Flight set EconomyCount=EconomyCount+1 where FlightNo='MU564'", sqlConnection);
                Assert.AreEqual(1, cmd.ExecuteNonQuery());
            }
            catch
            {
                Assert.AreEqual(1, 0);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        [Test]
        public static void AddLogTest()
        {
            sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into [Log](UserID, [Event]) values("
                            + "'user'" + ","
                            + "'User Login.'" + ")", sqlConnection);
                Assert.AreEqual(1, cmd.ExecuteNonQuery());
            }
            catch
            {
                Assert.AreEqual(1, 0);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}