CREATE TABLE CuisineType
(
	id				int				identity(1,1)	primary key,
	cuisineType	varchar(255)	not null,
);

CREATE TABLE Recipe
(
	id				int				identity(1,1)	primary key,
	name			varchar(255)	not null,
	description		varchar(255)	not null,
	cookingTime		int				null,
	prepTime		int				null,
	details			varchar(max)	not null,
	imageName		varchar(255)	null,
	cuisineTypeId	int				not null,

	CONSTRAINT fk_recipe_cuisineType FOREIGN KEY (cuisineTypeId) REFERENCES CuisineType(id)
);

INSERT INTO CuisineType VALUES ('Salad'), ('Bread & Doughs'), ('Side Dish'), ('Soup'), ('Sandwhich & Wraps'), ('Main Dish'), ('Dessert')


select * from recipe;