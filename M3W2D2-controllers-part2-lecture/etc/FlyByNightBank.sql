CREATE TABLE customer_surveys
(
	survey_id			int					identity(1,1),
	customer_name		varchar(200)		null,
	state				varchar(100)		not null,
	customer_experience	int					not null,
	additional_feedback	varchar(max)		null,
	survey_submitted	datetime			not null,

	constraint pk_customer_surveys primary key(survey_id)
);

create table loan_applications
(
	application_id		int				identity(1,1),
	first_name			varchar(200)	not null,
	last_name			varchar(200)	not null,
	logon_username		varchar(100)	not null,

	home_address		varchar(200)	not null,
	home_city			varchar(200)	not null,
	home_state			varchar(100)	not null,
	home_postalCode		varchar(10)		not null,
	home_phone			varchar(10)		not null,

	job_title			varchar(100)	null,
	work_address		varchar(200)	null,
	work_city			varchar(200)	null,
	work_state			varchar(100)	null,
	work_postalCode		varchar(10)		null,
	work_phone			varchar(10)		null,

	net_worth			decimal			not null,
	reference1_name		varchar(100)	not null,
	reference1_phone	varchar(10)		not null,
	
	date_submitted		datetime		not null,


	constraint pk_loan_applications primary key(application_id)
);