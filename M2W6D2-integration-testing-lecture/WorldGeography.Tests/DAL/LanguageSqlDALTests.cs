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
    public class LanguageSqlDALTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source = localhost\sqlexpress;Initial Catalog = World; Integrated Security = True";

             /*
             * SETUP
             * Create a fake country ('ABC Country').
             * Add an OfficialLanguage to ABC Country
             * Add an UnofficialLanguage to ABC Country
             */
             [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                conn.Open();

                cmd = new SqlCommand("INSERT INTO Country VALUES ('ABC', 'ABC Country', 'Asia', 'Southern Asia', 1, 1111, 1, 1, 1, 1, 'ABC Country', 'Monarchy', 'Josh Tucholski', null, 'AB');", conn);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("INSERT INTO countrylanguage VALUES ('ABC', 'OfficialLanguage', 1, 100.00)", conn);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("INSERT INTO countrylanguage VALUES ('ABC', 'UnofficialLanguage', 0, 0.00)", conn);
                cmd.ExecuteNonQuery();
            }
        }

        /*
        * CLEANUP
        * Rollback the Transaction and get rid of the new records added for the test.        
        */
        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }



        /*
        * TEST:
        * Using ABC Country, validate that there is only one official language.
        */
        [TestMethod()]
        public void GetLanguagesTest()
        {
            //Arrange
            LanguageSqlDAL languageDal = new LanguageSqlDAL(connectionString);

            //Act
            List<Language> languages = languageDal.GetLanguages("ABC", true);

            //Assert
            Assert.AreEqual(1, languages.Count);
            Assert.AreEqual("OfficialLanguage", languages[0].Name);
        }


        /*
        * TEST:
        * Using ABC Country, add a new language.
        */
        [TestMethod()]
        public void AddNewLanguageTest()
        {
            //Arrange
            LanguageSqlDAL languageDal = new LanguageSqlDAL(connectionString);
            Language language = new Language
            {
                CountryCode = "ABC",
                IsOfficial = true,
                Name = "Test Language",
                Percentage = 100
            };

            //Act
            bool didWork = languageDal.AddNewLanguage(language);

            //Assert
            Assert.AreEqual(true, didWork);
        }

        /*
        * TEST:
        * Using ABC Country, remove one the UnofficialLanguage.
        */
        [TestMethod()]
        public void RemoveLanguageTest_ReturnsTrueIfExists()
        {
            //Arrange
            LanguageSqlDAL dal = new LanguageSqlDAL(connectionString);
            Language deadLanguage = new Language()
            {
                CountryCode = "ABC",
                Name = "OfficialLanguage"
            };

            //Act
            bool didRemove = dal.RemoveLanguage(deadLanguage);

            //Assert
            Assert.IsTrue(didRemove);
        }

        /*
        * TEST:
        * Using ABC Country, remove a language that does not exist.
        */
        [TestMethod]
        public void RemoveLanguageTest_ReturnsFalseIfNotExists()
        {
            //Arrange
            LanguageSqlDAL dal = new LanguageSqlDAL(connectionString);
            Language deadLanguage = new Language()
            {
                CountryCode = "ABC",
                Name = "Nonexistent-Language"
            };

            //Act
            bool didRemove = dal.RemoveLanguage(deadLanguage);

            //Assert
            Assert.IsFalse(didRemove);

        }
    }
}