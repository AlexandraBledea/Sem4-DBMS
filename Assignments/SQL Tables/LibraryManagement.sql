USE LibraryManagement;
drop table Location;
drop table Review;
drop table Critic;
drop table Subscription;
drop table Staff_Member;
drop table Finished;
drop table Borrowed;
drop table Opinion;
drop table Subscriber;
drop table Book;
drop table Library;


CREATE TABLE Library (
	ID integer not null primary key,
	Address varchar(30) not null,
	Nr_Of_Books integer,
	Capacity integer
);

CREATE TABLE Book (
	ID integer not null primary key,
	Title varchar(100) not null,
	Author varchar(30) not null,
	Edition varchar(15),
	Publisher varchar(30),
	Category varchar(50),
	Description varchar(100),
	Popularity integer default 0
);

CREATE TABLE Subscriber (
	CNP integer primary key,
	Name varchar(30) not null,
	Age integer,
	Nr_Of_Rented_Books integer,
	Favorite_Book varchar(100),
	Favorite_Author varchar(30)
);

CREATE TABLE Opinion (
	ID integer primary key,
	CNP_Sub integer not null,
	Title varchar(100) not null,
	Author varchar(40) not null,
	Idea varchar(100) not null,
	foreign key(CNP_Sub) references Subscriber(CNP) on delete cascade on update cascade
);

CREATE TABLE Borrowed (
	ID integer primary key,
	Issued_Date date,
	Due_Date date,
	Book_ID integer not null,
	Library_ID integer not null,
	CNP_Sub integer not null,
	foreign key (Book_ID) references Book(ID) on delete cascade on update cascade,
	foreign key (Library_ID) references Library(ID) on delete cascade on update cascade,
	foreign key(CNP_Sub) references Subscriber(CNP) on delete cascade on update cascade,
	--constraint pk_borrowed primary key (Book_ID, Library_ID, CNP_Sub)
);

CREATE TABLE Finished(
	Borrowed_ID integer unique not null,
	Date_Finished Date default NULL,
	foreign key(Borrowed_ID) references Borrowed(ID) on delete cascade on update cascade,
	constraint pk_finished primary key(Borrowed_ID)
)

/*	foreign key (CNP_Sub) references Subscriber(CNP) on delete cascade on update cascade,
	foreign key (Book_ID) references Book(ID) on delete cascade on update cascade,
	constraint pk_finished primary key(Book_ID, CNP_Sub, Library_ID)*/


CREATE TABLE Staff_Member (
	CNP integer primary key,
	Name varchar(30) not null,
	Age integer,
	Telephone integer,
	Library_ID integer not null,
	Salary integer,
	foreign key (Library_ID) references Library(ID) on delete cascade on update cascade
);

CREATE TABLE Subscription (
	Library_ID integer not null,
	CNP_Sub integer not null,
	Price integer,
	Availability BIT,
	foreign key (Library_ID) references Library(ID) on delete cascade on update cascade,
	foreign key (CNP_Sub) references Subscriber(CNP) on delete cascade on update cascade,
	constraint pk_subscription primary key (Library_ID, CNP_Sub)
);

CREATE TABLE Critic (
	CNP integer primary key,
	Name varchar(30) not null,
	Age integer,
	Nr_Of_Age_Working integer
);

CREATE TABLE Review (
	Book_ID integer not null,
	CNP integer not null,
	Book_Title varchar(100) not null,
	Book_Author varchar(30) not null,
	Ideea varchar(100),
	Grade integer,
	foreign key (Book_ID) references Book(ID) on delete cascade on update cascade,
	foreign key (CNP) references Critic(CNP) on delete cascade on update cascade,
	constraint pk_review primary key (Book_ID, CNP)
);

CREATE TABLE Location (
	ID integer not null primary key,
	Shelf_ID integer,
	Section_ID integer,
	Book_ID integer not null unique,
	foreign key (Book_ID) references Book(ID) on delete cascade on update cascade
);


/* INSERT STATEMENTS */
-- at least one statement should violate referential integrity constraints -> first row
-- insert into Review values(1,20,'Ana','Liviu Teodor', '1', 'lupta')


--- populating the library table ---
insert into Library VALUES(1,'Decembrie 1',3000,1005)
insert into Library VALUES(2, 'Mihai Eminescu 2', 4000, 3012)
insert into Library VALUES(3, 'Stefan cel Mare 43', 1000, 45)
insert into Library VALUES(4, 'Alexandri 100', 3000, 3212)
insert into Library VALUES(5, 'Mihai Viteazu 40', 100, 10)
SELECT * from Library


--- populating the books table ---
insert into Book values(1, 'Harry Potter and the chamber of secrets', 'J. K. Rowling', '4', 'Corint Junior', 'Fiction', 'Full of magic!', 12)
insert into Book values(2, 'Percy Jackson and the olympians', 'Rick Riordan', '3', 'Arthur', 'Battle', 'Gods', 13)
insert into Book values(3, 'Eleanor & Park', 'Rainbow Rowell', '10', 'YoungArt', 'Romance', 'Romance and friendship', 20)
insert into Book(ID, Title, Author, Edition, Publisher, Category) values(4, 'Balada Serpilor si a Pasarilor Cantatoare', 'Suzanne Collins','5', 'Armada', 'Battle')
insert into Book(ID, Title, Author, Edition, Publisher, Category) values(5, 'Harry Potter and the Deathly Hallows', 'J. K. Rowling', '1', 'Arthur', 'Fiction')
insert into Book(ID, Title, Author, Edition, Publisher, Category) values(6, 'Hunger Games 1', 'Suzanne Collins', '10', 'Armada', 'Battle')
insert into Book(ID, Title, Author, Edition, Publisher, Category) values(7, 'Hobbit', 'J. R. R. Tolkien', '6', 'RAO', 'Battle')
insert into Book values(8, 'Harry Potter and the prisoner of Azkaban', 'J. K. Rowling', '2', 'Corint Junior', 'Fiction', 'Magic world!', 14)
insert into Book values(9, 'Harry Potter and the chamber of secrets', 'J. K. Rowling', '15', 'Corint Junior', 'Fiction', 'Magic and Wizards!', 22)
insert into Book values(10, 'Harry Potter and the prisoner of Azkaban', 'J. K. Rowling', '3', 'Corint Junior', 'Fiction', 'Magic world!', 32)
insert into Book values(11, 'Divergent', 'Veronica Roth', '12', 'Arthur', 'Fiction', 'War and Love', 123)
insert into Book values(12, 'Divergent', 'Veronica Roth', '12', 'Arthur', 'Fiction', 'War and Love', 123)
insert into Book values(13, 'Harry Potter and Deathly Hallows', 'J. K. Rowling', '12', 'Arthur', 'Fiction', 'Magical!', 200)
insert into Book values(14, 'Harry Potter and the philosopher stone', 'J. K. Rowling', '13', 'Arthur', 'Fiction', 'Magical and family!', 124)
SELECT * from Book


--- populating the critic table ---
insert into Critic values(1, 'Pop Ana', 24, 6)
insert into Critic values(3, 'Orza Andreea', 20, 25)
insert into Critic values(12, 'Semeniuc Laura', 30, 0)
SELECT * from Critic


insert into Review values(1, 1, 'Harry Potter and the chamber of secrets', 'J. K. Rowling','Best seller!', 10)
insert into Review values(2, 3, 'Percy Jackson and the olympians', 'Rick Riordan', 'Amazing book!', 9)
insert into Review values(10, 3, 'Harry Potter and the prisoner of Azkaban', 'J. K. Rowling', 'Very interesting!', 7)
insert into Review values(3, 12, 'Eleanor & Park', 'Rainbow Rowell', 'Very Romantic!', 8)
insert into Review values(9, 12, 'Harry Potter and the chamber of secrets', 'J. K. Rowling', 'The best!', 10)
insert into Review values(3, 1, 'Eleanor & Park', 'Rainbow Rowell', 'Too romantic and boring!', 5)
SELECT * from Review

--- populating the subscriber table ---
insert into Subscriber values(2, 'Orza Andreea', 21, 30, 'Hunger Games 1', 'Suzanne Collins')
insert into Subscriber(CNP, Name, Age, Nr_Of_Rented_Books) values(5, 'Lihet Crina', 20, 10)
insert into Subscriber values(4, 'Onisa Antonela', 20, 15, 'Hobbit', 'J. R. R. Tolkien')
insert into Subscriber(CNP, Name, Age, Nr_Of_Rented_Books, Favorite_Author) values(6, 'Pop Gabriel', 21, 10, 'J. K. Rowling')
insert into Subscriber(CNP, Name, Age, Nr_Of_Rented_Books, Favorite_Book) values(9, 'Ples Ovidiu', 22, 5, 'Hobbit')
insert into Subscriber(CNP, Name, Age, Nr_Of_Rented_Books, Favorite_Author) values(10, 'Pop Ana', 20, 3,'Suzanne Collins')
insert into Subscriber(CNP, Name, Age, Nr_Of_Rented_Books, Favorite_Author)values(15, 'Man Renata', 20, 6, 'J. K. Rowling')
SELECT * from Subscriber

--- populating the borrowed table ---

insert into Borrowed values(2, '2021-08-02', '2021-08-23', 1, 1, 2)
insert into Borrowed values(3, '2021-09-30', '2021-10-15', 2, 2, 6)
insert into Borrowed values(4, '2021-08-28', '2021-10-01', 6, 4, 5)
insert into Borrowed values(5, '2021-08-25', '2021-09-10', 7, 2, 4)
insert into Borrowed values(1, '2021-07-01', '2021-09-01', 3, 3, 6)

--- populating the finished table --- 

insert into Finished(Borrowed_ID) values(2)
insert into Finished(Borrowed_ID) values(3)
insert into Finished values(4, '2021-07-03')
insert into Finished values(5, '2021-06-23')
insert into Finished values(1, '2021-08-21')

--- populating the subscription table ---
insert into Subscription values(1, 2, 50, 1)
insert into Subscription values(2, 5, 30, 1)
insert into Subscription values(3, 5, 100, 0)
insert into Subscription values(4, 5, 100, 1)
insert into Subscription values(3, 6, 100, 1)
insert into Subscription values(2, 6, 110, 1)
insert into Subscription values(3, 4, 100, 0)
insert into Subscription values(2, 4, 34, 1)
insert into Subscription values(2, 9, 30, 0)
insert into Subscription values(1, 10, 50, 0)
insert into Subscription values(2, 10, 30, 1)
SELECT * from Subscription


--- populationg the staff members table --- 
insert into Staff_Member values(7, 'Orza Adrian', 27, 0743123564, 2, 1020)
insert into Staff_Member values(8, 'Pop Carina', 21, 0734526174, 1, 1400)
insert into Staff_Member values(11, 'Suciu Carmen', 44, 0723756123, 4, 1300)
insert into Staff_Member values(13, 'Muresan Daria', 28, 0745324123, 2, 1000)
insert into Staff_Member values(14, 'Lihet Andreea', 28, 0765432564, 4, 1500)


--- populating the location table ---
-- ID, Shelf_ID, Section_ID, Book_ID -- 
insert into Location values(1, 1, 1, 1)
insert into Location values(2, 1, 1, 2)
insert into Location values(3, 1, 2, 3)
insert into Location values(4, 2, 3, 4)

