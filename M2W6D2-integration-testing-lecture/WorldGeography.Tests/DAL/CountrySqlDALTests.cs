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
    public class CountrySqlDALTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source = localhost\sqlexpress;Initial Catalog = World; Integrated Security = True";
        private int countriesInNorthAmerica = 0;

        /*
        * INITIALIZE
        * Before adding the country, get the number of known countries in North America.
        * Create a fake country (ABC Country) into the country table.
        */
        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                connection.Open();

                // Get the number of existing countris in North America
                cmd = new SqlCommand("SELECT COUNT(*) FROM country WHERE continent = 'North America';", connection);
                countriesInNorthAmerica = (int)cmd.ExecuteScalar();

                //Create a country (ABC Country) for testing
                cmd = new SqlCommand("INSERT INTO Country VALUES ('ABC', 'ABC Country', 'North America', 'Southern Asia', 1, 1111, 1, 1, 1, 1, 'ABC Country', 'Monarchy', 'Josh Tucholski', null, 'AB');", connection);
                cmd.ExecuteNonQuery();
            }

        }

        /*
        * CLEANUP
        * Rollback the existing transaction.
        */
        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }


        /*
        * TEST
        * Get the list of continent names.
        */
        [TestMethod()]
        public void GetContinentNamesTest()
        {
            //Arrange
            CountrySqlDAL countrySqlDal = new CountrySqlDAL(connectionString);

            //Act
            List<string> names = countrySqlDal.GetContinentNames();

            //Assert
            Assert.IsNotNull(names);
            Assert.AreEqual(7, names.Count);
        }

        /*
        * TEST
        * Get the list of known countries in North America. 
        * We checked before the test ran and stored in countriesInNorthAmerica variable. 
        * After adding ABC Country it should be countriesInNorthAmerica + 1
        */
        [TestMethod()]
        public void GetCountriesInNorthAmericaTest()
        {
            //Arrange
            CountrySqlDAL countrySqlDal = new CountrySqlDAL(connectionString);

            //Act
            List<Country> countries = countrySqlDal.GetCountriesInNorthAmerica();

            //Assert
            Assert.IsNotNull(countries);
            Assert.AreEqual(countriesInNorthAmerica + 1, countries.Count);            
        }
    }
}