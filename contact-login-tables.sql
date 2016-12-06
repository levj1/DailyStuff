
-- Create contact table
create table contact(Id int not null identity(1,1) primary key, firstname varchar(100), lastname varchar(100), email varchar(100),
  AddressLine1 varchar(200), AddressLine2 varchar(200), City varchar(100), state varchar(100), zipcode varchar(25))

  -- Insert contacts
 insert into contact(firstname, lastname, email, AddressLine1, AddressLine2, City, state, zipcode)
 values('James', 'Leveille', 'ljam@gmail.com', '123 Street ave', '', 'Greenbelt', 'GA', '20722')
 insert into contact(firstname, lastname, email, AddressLine1, AddressLine2, City, state, zipcode)
 values('Edwards', 'Cruise', 'ecru@yahoo.com', '524 Avenue st', '', 'HyattsVille', 'MA', '12345')


 select * from contact

 -- drop table login
 create table login
 (
	ID int not null identity(1,1) primary key,
	username nvarchar(50) not null, 
	password nvarchar(50) not null,
	ContactId int foreign key references contact(id)
 )
 
 -- Insert login
 insert into login (username, password, ContactId)
 values('levj1', HASHBYTES('SHA1', 'secure'), 1)

  select * from login