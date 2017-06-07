-- The name and population of all cities in the USA with a population of greater than 1 million people
SELECT name, population FROM city WHERE countrycode = 'USA' and population > 1000000;

-- The name and population of all cities in China with a population of greater than 1 million people
SELECT name, population FROM city WHERE countrycode = 'CHN' and population > 1000000;

-- The name and region of all countries in North or South America
SELECT name, region FROM country WHERE continent IN ('North America', 'South America');
  
-- The name, continent, and head of state of all countries whose form of government is a monarchy
SELECT name, continent, headofstate FROM country WHERE governmentform = 'Monarchy';

-- The name, country code, and population of all cities with a population less than one thousand people
SELECT name, countrycode, population FROM city WHERE population < 1000

-- The name and region of all countries in North or South America except for countries in the Caribbean
SELECT name, region FROM country WHERE continent IN ('North America', 'South America') AND region <> 'Caribbean';

-- The name, population, and GNP of all countries with a GNP greater than $1 trillion dollars and a population of less than 1 billion people
SELECT name, population, gnp FROM country WHERE gnp > 1000000 AND population < 1000000000;

-- The name and population of all cities in Texas that have a population of greater than 1 million people
SELECT name, population FROM city WHERE population > 1000000;

-- The name and average life expectancy of all countries in southern regions
SELECT name, lifeexpectancy, region FROM country WHERE region like '%south%';

-- The name and average life expectancy of all countries in southern regions for which an average life expectancy has been provided (i.e. not equal to null)
SELECT name, lifeexpectancy FROM country WHERE region like '%south%' and lifeexpectancy is not null;

-- The name, continent, GNP, and average life expectancy of all countries in Africa or Asia that have an average life expectancy of at least 70 years and a GNP between $1 million and $100 million dollars
SELECT name, continent, gnp, lifeexpectancy FROM country WHERE continent in ('Africa', 'Asia') and lifeexpectancy >= 70
