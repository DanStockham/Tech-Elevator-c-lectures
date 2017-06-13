using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGeography.DAL;
using WorldGeography.Models;

namespace WorldGeography
{
    public class WorldGeographyCLI
    {
        const string Command_GetAllContinentNames = "1";
        const string Command_CountriesInNorthAmerica = "2";
        const string Command_CitiesByCountryCode = "3";
        const string Command_LanguagesByCountryCode = "4";
        const string Command_AddNewLanguage = "5";
        const string Command_RemoveLanguage = "6";
        const string Command_Quit = "q";
        const string DatabaseConnectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=World;Integrated Security=True";

        public void RunCLI()
        {
            PrintHeader();
            PrintMenu();

            while (true)
            {
                string command = Console.ReadLine();

                Console.Clear();

                switch (command.ToLower())
                {
                    case Command_GetAllContinentNames:
                        GetContinentNames();
                        break;

                    case Command_CountriesInNorthAmerica:
                        GetCountriesInNorthAmerica();
                        break;

                    case Command_CitiesByCountryCode:
                        GetCitiesByCountryCode();
                        break;

                    case Command_LanguagesByCountryCode:
                        GetLanguagesForCountry();
                        break;

                    case Command_AddNewLanguage:
                        AddNewLanguage();
                        break;

                    case Command_RemoveLanguage:
                        RemoveLanguage();
                        break;

                    case Command_Quit:
                        Console.WriteLine("Thank you for using the world geography cli app");
                        return;

                    default:
                        Console.WriteLine("The command provided was not a valid command, please try again.");
                        break;
                }

                PrintMenu();
            }
        }



        private void PrintHeader()
        {
            Console.WriteLine(@" _    _  _____ ______  _     ______     ______   ___   _____   ___  ______   ___   _____  _____ ");
            Console.WriteLine(@"| |  | ||  _  || ___ \| |    |  _  \    |  _  \ / _ \ |_   _| / _ \ | ___ \ / _ \ /  ___||  ___|");
            Console.WriteLine(@"| |  | || | | || |_/ /| |    | | | |    | | | |/ /_\ \  | |  / /_\ \| |_/ // /_\ \\ `--. | |__  ");
            Console.WriteLine(@"| |/\| || | | ||    / | |    | | | |    | | | ||  _  |  | |  |  _  || ___ \|  _  | `--. \|  __| ");
            Console.WriteLine(@"\  /\  /\ \_/ /| |\ \ | |____| |/ /     | |/ / | | | |  | |  | | | || |_/ /| | | |/\__/ /| |___ ");
            Console.WriteLine(@" \/  \/  \___/ \_| \_|\_____/|___/      |___/  \_| |_/  \_/  \_| |_/\____/ \_| |_/\____/ \____/ ");
        }



        private void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Main-Menu Type in a command");
            Console.WriteLine(" 1 - Get all of the continent names");
            Console.WriteLine(" 2 - Get a list of the countries in North America");
            Console.WriteLine(" 3 - Get a list of the cities by country code");
            Console.WriteLine(" 4 - Get a list of the languages by country code");
            Console.WriteLine(" 5 - Add a new language");
            Console.WriteLine(" 6 - Remove language");
            Console.WriteLine(" Q - Quit");
        }




        private void GetContinentNames()
        {
            CountrySqlDAL countryDal = new CountrySqlDAL(DatabaseConnectionString);

            List<string> continents = countryDal.GetContinentNames();

            Console.WriteLine();
            Console.WriteLine("Printing all of the continents");

            for (int index = 0; index < continents.Count; index++)
            {
                Console.WriteLine(index + " - " + continents[index]);
            }
        }



        private void GetCountriesInNorthAmerica()
        {
            CountrySqlDAL countryDal = new CountrySqlDAL(DatabaseConnectionString);

            List<Country> northAmericanCountries = countryDal.GetCountriesInNorthAmerica();

            Console.WriteLine();
            Console.WriteLine("All North American Countries");

            foreach (var country in northAmericanCountries)
            {
                Console.WriteLine(country);
            }
        }



        private void GetCitiesByCountryCode()
        {
            string countryCode = CLIHelper.GetString("Enter the country code that you want to retrieve:");

            CitySqlDAL dal = new CitySqlDAL(DatabaseConnectionString);
            List<City> cities = dal.GetCitiesByCountryCode(countryCode);

            Console.WriteLine();
            Console.WriteLine($"Printing {cities.Count} cities for {countryCode}");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }

        private void AddNewLanguage()
        {
            string countryCode = CLIHelper.GetString("Enter the country code the language is for:");
            bool officialOnly = CLIHelper.GetBool("Is it official only? True/False ");
            int percentage = CLIHelper.GetInteger("What percentage is it spoken by?");
            string name = CLIHelper.GetString("What is the name of the lanaguage?");

            Language lang = new Language
            {
                CountryCode = countryCode,
                IsOfficial = officialOnly,
                Percentage = percentage,
                Name = name
            };

            LanguageSqlDAL languageDal = new LanguageSqlDAL(DatabaseConnectionString);
            bool result = languageDal.AddNewLanguage(lang);

            if (result)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("The new language was not inserted");
            }
        }

        private void RemoveLanguage()
        {
            throw new NotImplementedException();
        }

        private void GetLanguagesForCountry()
        {
            string countryCode = CLIHelper.GetString("Enter the country code you want to retrieve:");
            bool officialOnly = CLIHelper.GetBool("Retrieve official languages only? True/False ");

            LanguageSqlDAL languageDal = new LanguageSqlDAL(DatabaseConnectionString);
            List<Language> languages = languageDal.GetLanguages(countryCode, officialOnly);

            Console.WriteLine();
            Console.WriteLine($"Printing {languages.Count} languages for {countryCode}");

            foreach (var language in languages)
            {
                Console.WriteLine(language);
            }
        }


        

    }
}
