Create Procedure spAddressBook
(
 @FirstName nvarchar(200),
 @LastName nvarchar(200),
 @Address varchar,
 @City varchar,
 @State varchar,
 @Zip varchar,
 @PhoneNumber varchar,
 @Email varchar
 )
 As
 Insert into AddressBook(FirstName,LastName,Address,City,State,Zip, PhoneNumber,Email)
 values(@FirstName, @LastName, @Address, @City, @State, @Zip, @PhoneNumber, @Email );