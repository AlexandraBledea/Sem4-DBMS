USE ExamenPractic
go


drop table Delivery
drop table Customer
drop table PizzaShop
drop table Drone
drop table DroneModel
drop table DroneManufacturer

CREATE TABLE DroneManufacturer(
	ManufacturerID INT PRIMARY KEY IDENTITY(1,1),
	MName varchar(50),
)

CREATE TABLE DroneModel(
	DroneModelID INT PRIMARY KEY IDENTITY(1,1),
	DMName varchar(50),
	DMBattery int,
	DMaxSpeed int,
	ManufacturerID int not null,
	foreign key(ManufacturerID) references DroneManufacturer(ManufacturerID) on delete cascade on update cascade
);

CREATE TABLE Drone(
	DroneID INT PRIMARY KEY IDENTITY(1,1),
	DSerialNr varchar(50),
	DroneModelID int not null,
	foreign key(DroneModelID) references DroneModel(DroneModelID) on delete cascade on update cascade
);

CREATE TABLE PizzaShop(
	ShopID INT PRIMARY KEY IDENTITY(1,1),
	SName varchar(50),
	SAddress varchar(50)
);

CREATE TABLE Customer(
	CustomerID INT PRIMARY KEY IDENTITY(1,1),
	CName varchar(50),
	CScore int
);

CREATE TABLE Delivery(
	DeliveryID INT PRIMARY KEY IDENTITY(1,1),
	CustomerID int not null,
	foreign key (CustomerID) references Customer(CustomerID) on delete cascade on update cascade,
	ShopID int,
	foreign key (ShopID) references PizzaShop(ShopID) on delete cascade on update cascade,
	DroneID int,
	foreign key (DroneID) references Drone(DroneID) on delete cascade on update cascade,
	DDate DATE,
	DTime TIME
);

INSERT INTO DroneManufacturer VALUES('DroneManufacturer1')
INSERT INTO DroneModel VALUES('M1', 100, 40, 1)
INSERT INTO Drone VALUES ('D1-121as', 1)
INSERT INTO Drone VALUES ('D2-asgsa', 1)
INSERT INTO PizzaShop VALUES ('S1', 'SA1')
INSERT INTO PizzaShop VALUES ('S2', 'SA2')
INSERT INTO Customer VALUES ('C1', 10), ('C2', 20), ('C3', 15)
INSERT INTO Delivery VALUES (1,1,1, '2008-7-04', '08:30:00')
INSERT INTO Delivery VALUES (2,1,1, '2009-08-06', '10:45:00')


SELECT * FROM Delivery