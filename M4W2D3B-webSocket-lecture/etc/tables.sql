drop table order_items;
drop table orders;
drop table products;
drop table users;

create table users
(
	id int identity(1,1),
	email varchar(256) not null,
	password varchar(256) not null,

	constraint pk_users primary key (id)
);

create table products
(
	id int identity(1,1),
	sku varchar(10) not null,
	name varchar(256) not null,
	description text not null,
	price decimal(4,2) not null,
	imageName varchar(128) not null,
	weight decimal(5, 2) not null,
	active bit default 1

	constraint pk_products primary key (id)
);


create table orders
(
	id int identity(1,1),
	userId int not null,
	billingAddress1 varchar(300) not null,
	billingAddress2 varchar(300) null,
	billingCity varchar(300) not null,
	billingState varchar(300) not null,
	billingPostalCode varchar(10) not null,
	shippingAddress1 varchar(300) not null,
	shippingAddress2 varchar(300) null,
	shippingCity varchar(300) not null,
	shippingState varchar(300) not null,
	shippingPostalCode varchar(10) not null,
	nameOnCard varchar(100) not null,
	creditCardNumber varchar(20) not null,
	expirationDate varchar(10) not null,
	subTotal decimal(4,2) not null,
	weight decimal(5, 2) not null,
	shippingType varchar(100) not null,
	shipping decimal(4, 2) not null,
	tax decimal(4,2) not null,
	
	constraint pk_orders primary key (id),
	constraint fk_orders_users foreign key (userId) references users(id)
);

create table order_items
(
	orderId int not null,
	productId int not null,
	quantity int not null,
	price decimal(4,2) not null,

	constraint fk_order_items_orders foreign key (orderId) references orders(id),
	constraint fk_order_items_products foreign key (productId) references products(id)
);


create table chat_history
(
	id int identity(1,1),
	userId int not null,
	messaage varchar(max) not null,
	sentDate datetime not null default(getdate()),

	constraint fk_chat_history_users foreign key (userId) references users(id)
);


USE [historygeek]
GO
SET IDENTITY_INSERT [dbo].[products] ON 

GO
INSERT [dbo].[products] ([id], [sku], [name], [description], [price], [imageName], [weight], [active]) VALUES (3, N'ABC-1234', N'A People''s History of the United States', N'With a new introduction by Anthony Arnove, this updated edition of the classic national bestseller reviews the book’s thirty-five year history and demonstrates once again why it is a significant contribution to a complete and balanced understanding of American history.

Since its original landmark publication in 1980, A People''s History of the United States has been chronicling American history from the bottom up, throwing out the official version of history taught in schools—with its emphasis on great men in high places—to focus on the street, the home, and the, workplace.

Known for its lively, clear prose as well as its scholarly research, A People''s History of the United States is the only volume to tell America''s story from the point of view of—and in the words of—America''s women, factory workers, African-Americans, Native Americans, the working poor, and immigrant laborers. As historian Howard Zinn shows, many of our country''s greatest battles—the fights for a fair wage, an eight-hour workday, child-labor laws, health and safety standards, universal suffrage, women''s rights, racial equality—were carried out at the grassroots level, against bloody resistance.

Covering Christopher Columbus''s arrival through President Clinton''s first term, A People''s History of the United States, which was nominated for the American Book Award in 1981, features insightful analysis of the most important events in our history.', CAST(18.99 AS Decimal(4, 2)), N'ABC-1234.jpg', CAST(22.80 AS Decimal(5, 2)), 1)
GO
INSERT [dbo].[products] ([id], [sku], [name], [description], [price], [imageName], [weight], [active]) VALUES (4, N'DEF-5678', N'Lincoln Little Thinker', N'Yes, in many ways we feel like Lincoln, though not quite as tall. And that''s why we put such care and pride into our Abraham Lincoln Little Thinker doll. Abe stands a towering 12 inches tall and sports his trademark stovepipe hat. He''s well constructed with exacting attention to every detail. They just don''t make Republicans like they used to. Thankfully, we do.
', CAST(8.99 AS Decimal(4, 2)), N'DEF-5678.jpg', CAST(8.80 AS Decimal(5, 2)), 1)
GO
INSERT [dbo].[products] ([id], [sku], [name], [description], [price], [imageName], [weight], [active]) VALUES (5, N'GHI-9123', N'Theodore Roosevelt Plush Doll', N'TR was a conservationist who took steps to preserve natural wonders such as the Grand Canyon, though he failed to champion the people from whom the continent was "won." Theodore Roosevelt bristled with contradictions! He was a privileged and sickly child who refashioned himself into a rowdy intellectual who took on the powerful and the moneyed on behalf of the people. Now this man who was immortalized on Mount Rushmore (a/k/a Six Grandfathers) is immortalized as a cuddly 11" Little Thinker doll!', CAST(9.25 AS Decimal(4, 2)), N'GHI-9123.jpg', CAST(8.20 AS Decimal(5, 2)), 1)
GO
INSERT [dbo].[products] ([id], [sku], [name], [description], [price], [imageName], [weight], [active]) VALUES (7, N'JKL-4567', N'George Washington Plush Doll', N'Have you ever wanted to hug the father of our country? In real life, George Washington was known to be a hugger. Washington hugged his pal, Lafayette, who was a major-general in the Revolutionary War. On his way to resign his commission, Washington wept unashamedly and embraced each of his officers in appreciation for their camaraderie.', CAST(12.99 AS Decimal(4, 2)), N'JKL-4567.jpg', CAST(11.10 AS Decimal(5, 2)), 1)
GO
SET IDENTITY_INSERT [dbo].[products] OFF
GO
