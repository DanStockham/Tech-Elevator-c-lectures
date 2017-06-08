-- Constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS



-- INSERT DATA
-- Let's add Klingon to the languages in the database.
--  Don't have a country code handy, and not sure about whether its an offical language anywhere, or the percentage of people who speak, but I want to get it into the database before I forget.
insert into countrylanguage (language) values ('Klingon');


-- That wasn't very friendly.
-- But I really want to get the record into the table, so I'll use a made up countrycode, and guess that its likely not an official language anywhere, and the percentage is near enough to zero, that its ok to specify that.
insert into countrylanguage (countrycode, language, isofficial, percentage) values ('XQR', 'Klingon', false, 0);


-- Referential integrity requires that foreign keys point to valid primary keys. There is no country with a code of XQR in the database
-- Since Star Trek is an American TV show, let's set the countrylanguage.countrycode to 'USA', and hope it all works out.
insert into countrylanguage (countrycode, language, isofficial, percentage) values ('USA', 'Klingon', false, 0);

-- let's confirm
select * from countrylanguage where language='Klingon';


-- Add the exciting new language, Klinglish.
insert into countrylanguage values ('USA', 'Klinglish', false, 0);
select * from countrylanguage where language='Klinglish';


-- You can also rearrange the column names in the list, you just need to make sure the values match.
insert into countrylanguage (percentage, isofficial, language, countrycode) values (0, false,  'Englon', 'USA');


-- DELETE
-- Let's delete all the Klingon, Klingish, and Englon rows we just added, starting with Englon.
delete from countrylanguage
where language='Englon';

-- Then a simple select to confirm the deletion
select * from countrylanguage where language='Englon';


-- The WHERE clause can have other conditions besides equals. 
 -- We can could do `language='Klingon' or language='Klinglish'`. 
 -- We might even do something daring, `'language LIKE 'Kling%'`, and remove the rows with a wildcard LIKE.  
 -- BETWEEN n AND n+1` is also a really handy technique for deleting rows within a range of values, such numeric keys.
delete from countrylanguage
where language='Klingon' or language='Klinglish';


-- The last deletion exercise demonstrates referential integrity.
-- Confirm the county.captial for USA is Washington.
select ci.id, ci.name from country co inner join city ci on co.capital=ci.id where code='USA';

-- Remember, country.capital is a foreign key pointing to city.id.  Attempting to delete Washington from the city table using its id will violate referential integrity, and the deletion will not be allowed.
delete from city where id=3813 and name='Washington'; --Just being extra careful in WHERE



-- UPDATE
-- Let's start by adding back Klingon.
insert into countrylanguage (countrycode, language, isofficial, percentage) values ('USA', 'Klingon', false, 0);


-- And just in time, because Klingon is now an official language in the US, and is spoken by 2 percent of the population.
update countrylanguage
set isofficial=true, percentage=2
where countrycode='USA' and language='Klingon';



-- TRANSACTIONS
-- Let's wrap updating the Klingon row in a trasaction. Begin by noting the current values for isofficial and percentage.
select * from countrylanguage where countrycode='USA' and language='Klingon';


-- Now start the transaction, change isofficial and percentage, and then commit.
BEGIN TRANSACTION;

update countrylanguage
set isofficial=false, percentage=4
where countrycode='USA' and language='Klingon';

COMMIT;


-- Confirm the commited transaction took place.
select * from countrylanguage where countrycode='USA' and language='Klingon';


-- Repeat with new values for isoficial and percentage, and this time rollback the tranaction.
BEGIN TRANSACTION;

update countrylanguage
set isofficial=true, percentage=6
where countrycode='USA' and language='Klingon';

ROLLBACK;


-- Finally, confirm that the changes were not committed, but were rolled back.
select * from countrylanguage where countrycode='USA' and language='Klingon';