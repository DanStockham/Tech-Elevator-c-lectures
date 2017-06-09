
CREATE TABLE contact
(
	contactId int identity not null,
	lastName varchar(100) not null,
	firstName varchar(100) not null,
	dateAdded datetime not null,
	dateLastUpdated datetime null,
	
	constraint pk_contactId primary key (contactId)
);

CREATE TABLE address
(
	addressId int identity not null,
	contactId int not null,
	addressType varchar(100) not null,
	addressOtherDescription varchar(200),
	addressLine1 varchar(200) not null,
	addressLine2 varchar(200) null,
	city varchar(100) not null,
	state varchar(50) not null,
	postalCode varchar(10) not null,
	
	constraint pk_addressId primary key (addressId),
	constraint fk_addressContactId foreign key (contactId) references contact(contactId),
	constraint chk_addressType check (addressType IN ('Home', 'Work', 'Shipping', 'Billing', 'Other')),
	constraint chk_addressOtherDescription check ((addressType = 'Other' AND addressOtherDescription is not null) OR (addressType <> 'Other' AND addressOtherDescription is null))
);

CREATE TABLE phone
(
	phoneId int identity not null,
	contactId int not null,
	phoneType varchar(100) not null,
	phoneOtherDescription varchar(200),
	phoneNumber varchar(10) not null,

	constraint pk_phoneId primary key (phoneId),
	constraint fk_phoneContactId foreign key (contactId) references contact(contactId),
	constraint chk_phoneType check (phoneType IN ('Home', 'Work', 'Mobile', 'Other')),
	constraint chk_phoneOtherDescription check ((phoneType = 'Other' AND phoneOtherDescription is not null) OR (phoneType <> 'Other' AND phoneOtherDescription is null))
);

CREATE TABLE email
(
	emailId int identity not null,
	contactId int not null,
	emailType varchar(100) not null,
	emailOtherDescription varchar(200),
	emailAddress varchar(10) not null,

	constraint pk_emailId primary key (emailId),
	constraint fk_emailContactId foreign key (contactId) references contact(contactId),
	constraint chk_emailType check (emailType IN ('Home', 'Work', 'Other')),
	constraint chk_emailOtherDescription check ((emailType = 'Other' AND emailOtherDescription is not null) OR (emailType <> 'Other' AND emailOtherDescription is null))
);



