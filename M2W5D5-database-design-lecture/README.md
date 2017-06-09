# Address Book Database

Design a database to hold the contents of an address book.

The address book is comprised of contacts. 

Each contact has the following attributes:

* lastname
* firstname
* zero-to-many addresses
* zero-to-many phones
* zero-to-many email addresses
* date added to the address book
* date last updated

Each address has the following attributes:

* type (home, work, shipping, billing, or other)
* address line one
* address line two
* city
* state or province
* postal code

Each phone has the following attributes:

* type (home, work, mobile, other)
* phone number

Each email has the following attributes:

* type (home, work, other)
* email address 

All tables are required to have a primary key.

If an individual address, phone, or email type is specified as "other", you need to allow for a description of the type for each individual item.

Populate the tables with data for at least six contacts. Each contact must have at least three items associated with it.  This can be any combination of addresses, phones, and contacts you desire.

**Design Tips:**
	
Questions you should ask yourself.

* Is a natural key available for the primary key, or will you need a surrogate?
* What data type should be used for each column?
* What attribues are required? Which are optional?
* Are there additional constraints such as length, data format, or restricted values for any columns?
* What table columns will the user likely search?

Don't forget to normalize.



