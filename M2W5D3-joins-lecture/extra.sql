-- Display all the films and their language
select f.title, l.name from film f inner join language l on f.language_id=l.language_id;

-- Display all the films and in English
select f.title, l.name from film f inner join language l on f.language_id=l.language_id where l.name='English';

-- Display all the films with their category
select f.title, c.name 
from film f 
inner join film_category fc on f.film_id=fc.film_id
inner join category c on fc.category_id=c.category_id;

-- Display all the films with a category of Horror
select f.title, c.name 
from film f 
inner join film_category fc on f.film_id=fc.film_id
inner join category c on fc.category_id=c.category_id
where c.name='Horror';

-- Display all the films with a category of Horror and title that begins with the letter F
select f.title, c.name 
from film f 
inner join film_category fc on f.film_id=fc.film_id
inner join category c on fc.category_id=c.category_id
where c.name='Horror' and f.title like 'F%';

-- Who acted in what together? (POSTGRESQL)
SELECT f.title, a1.first_name || ' ' || a1.last_name, a2.first_name || ' ' || a2.last_name FROM film f 
join film_actor fa1 on f.film_id = fa1.film_id 
join film_actor fa2 on f.film_id = fa2.film_id AND fa1.actor_id <> fa2.actor_id
join actor a1 on fa1.actor_id = a1.actor_id 
join actor a2 on fa2.actor_id = a2.actor_id

-- Who acted in what together? (SQL SERVER)
SELECT f.title, a1.first_name + ' ' + a1.last_name, a2.first_name + ' ' + a2.last_name FROM film f 
join film_actor fa1 on f.film_id = fa1.film_id 
join film_actor fa2 on f.film_id = fa2.film_id AND fa1.actor_id <> fa2.actor_id
join actor a1 on fa1.actor_id = a1.actor_id 
join actor a2 on fa2.actor_id = a2.actor_id

-- How many times have two actors appeared together? (POSTGRESQL)
SELECT count(*) as num_of_films, a1.actor_id, a1.first_name || ' ' || a1.last_name, a2.actor_id, a2.first_name || ' ' || a2.last_name FROM film f 
join film_actor fa1 on f.film_id = fa1.film_id 
join film_actor fa2 on f.film_id = fa2.film_id AND fa1.actor_id <> fa2.actor_id
join actor a1 on fa1.actor_id = a1.actor_id 
join actor a2 on fa2.actor_id = a2.actor_id
group by a1.actor_id, a2.actor_id
order by num_of_films DESC

-- How many times have two actors appeared together? (SQL SERVER)
SELECT count(*) as num_of_films, a1.actor_id, a1.first_name + ' ' + a1.last_name, a2.actor_id, a2.first_name + ' ' + a2.last_name FROM film f 
join film_actor fa1 on f.film_id = fa1.film_id 
join film_actor fa2 on f.film_id = fa2.film_id AND fa1.actor_id <> fa2.actor_id
join actor a1 on fa1.actor_id = a1.actor_id 
join actor a2 on fa2.actor_id = a2.actor_id
group by a1.actor_id, a2.actor_id
order by num_of_films DESC

-- What movies did the two most often acted together actors appear in together?
SELECT film.title FROM film
join film_actor af1 ON film.film_id = af1.film_id
join film_actor af2 ON film.film_id = af2.film_id
WHERE af1.actor_id = 27 AND af2.actor_id = 60