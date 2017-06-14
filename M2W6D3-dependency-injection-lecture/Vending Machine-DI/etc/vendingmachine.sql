USE [master]
GO

DROP DATABASE [VendingMachine]
GO

CREATE DATABASE [VendingMachine]
GO

USE [VendingMachine]
GO

create table inventory
(
	slot_id char(2) not null,
	product_name varchar(150) not null,
	cost_in_cents int not null,
	
	primary key (slot_id)
);

create table transaction_log
(
	transaction_id 	int 			identity(1,1),
	slot_id			char(2) 		not null,
	product_name	varchar(150)	not null,
	amount_accepted	decimal(10, 2)	not null,
	remaining_balance decimal(10, 2) not null,
	timestamp		datetime 		not null,
);

insert into inventory values
('A1','Burrito','75'),
('A2','Cheese Pizza','75'),
('A3','Quesarito','60'),
('A4','Enchilada','85'),
('B1','Mountain Dew','120'),
('B2','Mountain Dew','90'),
('B3','Mountain Dew','95'),
('B4','Mountain Dew','100'),
('C1','Hot Sauce','125'),
('C2','Hot Sauce','150'),
('C3','Hot Sauce','65'),
('C4','Hot Sauce','110'),
('D1','Tums','75'),
('D2','Tums','75'),
('D3','Tums','75'),
('D4','Tums','75'),
('E1','Gum','50'),
('E2','Gum','50'),
('E3','Gum','50'),
('E4','Gum','50');