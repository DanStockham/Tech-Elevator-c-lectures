using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldGeography.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL.Tests
{
    [TestClass()]
    public class CitySqlDALTests
    {
        private TransactionScope tran;      //<-- used to begin a transaction during initialize and rollback during cleanup
        private string connectionString = @"Data Source = localhost\sqlexpress;Initial Catalog = World; Integrated Security = True";
        private int cityId;                 //<-- used to hold the city id of the row created for our test


        // Set up the database before each test        
        [TestInitialize]
        public void Initialize()
        {
            // Initialize a new transaction scope. This automatically begins the transaction.
            tran = new TransactionScope();

            // Open a SqlConnection object using the active transaction
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd;

                conn.Open();

                //Insert a Dummy Record for Country                
                cmd = new SqlCommand("INSERT INTO Country VALUES ('ABC', 'ABC Country', 'Asia', 'Southern Asia', 1, 1111, 1, 1, 1, 1, 'ABC Country', 'Monarchy', 'Josh Tucholski', null, 'AB');", conn);
                cmd.ExecuteNonQuery();

                //Insert a Dummy Record for City that belongs to 'ABC Country'
                //If we want to the new id of the record inserted we can use
                // SELECT CAST(SCOPE_IDENTITY() as int) as a work-around
                // This will get the newest identity value generated for the record most recently inserted
                cmd = new SqlCommand("INSERT INTO City VALUES ('Test City', 'ABC', 'Test District', 1); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                cityId = (int)cmd.ExecuteScalar();
            }
        }

        // Cleanup runs after every single test
        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose(); //<-- disposing the transaction without committing it means it will get rolled back
        }




        /*
        * In order to test Get Cities by Country Code, we should see if we can get cities in ABC Country.        
        */
        [TestMethod()]
        public void GetCitiesByCountryCodeTest()
        {

            // Arrange 
            CitySqlDAL cityDal = new CitySqlDAL(connectionString);

            //Act
            List<City> cities = cityDal.GetCitiesByCountryCode("ABC"); //<-- use our dummy country 

            //Assert
            Assert.AreEqual(1, cities.Count);               // We should only have one city in ABC country
            Assert.AreEqual(cityId, cities[0].CityId);      // We created the city ahead of time and know the id to check for
        }
    }
}