-----Create databases-----

create database ManagementSystem;
GO

USE ManagementSystem;
GO


-----Create tables-------

create table tbCustomer(
	CustomerID int not null IDENTITY(1,1) primary key , 
	CusTelegram varchar(15));
GO

create table tbFoodCategory(
	FoodCategoryID int not null IDENTITY(1,1) primary key, 
	FoodCategoryName varchar(50) not null);
GO

create table tbUser(
	UserID int not null IDENTITY(1,1) primary key, 
	FullName varchar(50) not null,
	UserName varchar(25) not null,  
	Password varchar(4) not null, 
	Role varchar(25) not null,
	Status Bit not null,
	PhotoImage varbinary(MAX) not null

)
GO

create table tbPaymentMethod(
	PaymentMethodID int not null IDENTITY(1,1) primary key, 
	PaymentMethod varchar(10) not null);
GO

create table tbProduct(
	ProductID int  primary key  IDENTITY(1,1), 
	ProductName varchar(25) not null, 
	Price decimal(8,2) not null, 
	Description varchar(100) not null,
	FoodCategoryID int not null,
	constraint FKFOODCATEGORYID
	foreign key(FoodCategoryID)
	References tbFoodCategory(FoodCategoryID) 
	on delete cascade on update cascade,
	Image varbinary(MAX),
	);
GO

create table tbOrder(
	OrderID int not null IDENTITY(1,1) primary key, 
	OrderDate Datetime not null,
	TotalRiel decimal(8,2) not null,
	TotalDollar decimal(8,2) not null,
	ChargeRiel decimal(8,2) not null,
	ChargeDollar decimal(8,2) not null,
	PaymentMethodID int not null,
	Tax DECIMAL(5, 2),
	constraint FKPAYMENTMETHODID
	foreign key(PaymentMethodID) 
	References tbPaymentMethod(PaymentMethodID)
	on delete cascade on update cascade,
	CustomerID int not null,
	constraint FKCUSTOMERID
	foreign key(CustomerID) 
	References tbCustomer(CustomerID)
	on delete cascade on update cascade);
GO

create table tbOrderDetail(
	OrderID int not null,
	ProductID int not null,
	Size varchar(5),
	OrderQty int not null,
	UnitPrice decimal(8,2) not null,
	Amount decimal(8,2) not null,
	constraint	PKORDERDETAIL1 primary key (OrderID, ProductID),
	constraint FKORDERID1 foreign key(OrderID) References tbOrder(OrderID) on delete cascade on update cascade,
	constraint FKPRODUCTID2 foreign key(ProductID) References dbo.tbProduct(ProductID) on delete cascade on update cascade);
GO

CREATE TABLE tbStockIn (
    StockInID INT PRIMARY KEY IDENTITY(1,1) not null,
    StockName VARCHAR(100),
    StockIn INT,
    UnitPrice DECIMAL(10, 2),
    Amount DECIMAL(10, 2),
    Date DATETIME, 
	Photo varbinary(MAX),
	FoodCategoryID int,
	FoodCategory varchar(25),
	CONSTRAINT FKFOODCATEGORYID4 FOREIGN KEY (FoodCategoryID) REFERENCES tbFoodCategory(FoodCategoryID) 
	ON DELETE CASCADE  ON UPDATE CASCADE 
);


CREATE TABLE tbStockOut (
    StockOutID INT PRIMARY KEY IDENTITY(1,1) not null,
    StockName VARCHAR(100),
    StockOut INT,
    UnitPrice DECIMAL(10, 2),
    Amount DECIMAL(10, 2),
    Date DATETIME,
    Photo varbinary(MAX),
	FoodCategoryID int,
	FoodCategory varchar(25),
	CONSTRAINT FKFOODCATEGORYID3 FOREIGN KEY (FoodCategoryID) REFERENCES tbFoodCategory(FoodCategoryID)
	ON DELETE CASCADE  ON UPDATE CASCADE 
);


CREATE TABLE tbStockCount (
    StockCountID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    StockName VARCHAR(100),
    StockCount INT,
    UnitPrice DECIMAL(10, 2),
    Amount DECIMAL(10, 2),
	Photo varbinary(MAX),
	FoodCategoryID int,
	FoodCategory varchar(25),
	CONSTRAINT FKFOODCATEGORYID5 FOREIGN KEY (FoodCategoryID) REFERENCES tbFoodCategory(FoodCategoryID) 
	ON DELETE CASCADE  ON UPDATE CASCADE 
);

create table tbAccountBank(
    AccID int primary key IDENTITY(1,1) NOT NULL,
	AccNo int not null, 
    AccName varchar (50) not null,
	PaymentDollar DECIMAL(10, 2),
	PaymentKhmer DECIMAL(10, 2),
	PaymentMethodID int not null,
	constraint FKPAYMENTMETHODID1
	foreign key(PaymentMethodID) 
	References tbPaymentMethod(PaymentMethodID)
	on delete cascade on update cascade);
GO

---------Update column-----------

alter table tbOrder Alter column CustomerID int null;
alter table tbOrder Alter column PaymentMethodID int null;
alter table tbOrder Alter column ChargeRiel decimal(8,2) null;
alter table tbOrder Alter column ChargeDollar decimal(8,2) null;

-----Insert data into tables------

Insert into tbCustomer(CusTelegram) 
Values(099584212), (011274234), (089344444), (012325677), (08934311), (012344988), (089344344), 
(011325677), (08934321), (012328988), (01934321), (092328988)

Insert into tbFoodCategory(FoodCategoryName)
Values('Beverages'), ('Frappes'), ('Juices'), 
('Snacks'),  ('Breakfast'),  ('Lunch'),  ('Others'),  ('PromotionSet');

Insert into tbUser(FullName, UserName, Password, Status, Role, PhotoImage)
Values ('Siv Naysim', 'naysim', '2024',0, 'Staff', 
(SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\naysim.jpg', SINGLE_BLOB) as StockImg));


Insert into tbPaymentMethod(PaymentMethod) 
Values ('Cash'), ('KHQR');


Insert into tbAccountBank(AccNo, AccName, PaymentDollar, PaymentKhmer, PaymentMethodID)  --PaymentDollar, PaymentKhmer must match TotalRiel, TotalDollar in tbOrder
Values (299933, 'Siv Naysim' , 30, 0, 2),
(299928, 'Siv Nayheak' , 10, 0, 2),
(299933, 'linyi ' , 0, 12000, 2);


Insert into tbOrder(OrderDate, TotalRiel, TotalDollar, ChargeRiel, ChargeDollar, PaymentMethodID, CustomerID, Tax)
Values
('2009-01-01 10:00:00', 10000, 0, 0, 0, 1, 1, 0.0),
('2009-01-01 10:30:00', 80000, 0, 20000, 0, 1, 2, 0.0),
('2009-01-01 9:02:00', 0, 5, 0, 0, 1, 3, 0.0), 
('2009-01-01 10:07:00', 0, 30, 0, 0, 2, 4, 0.0),
('2009-01-01 10:07:00', 0, 10, 0, 0, 2, 5, 0.0),
('2009-01-01 10:07:00', 12000, 0, 0, 0, 2, 6, 0.0),
('2009-02-01 10:00:00', 5000, 0, 0, 0, 1, 7, 0.0),
('2009-02-01 10:30:00', 80000, 0, 20000, 0, 1, 8, 0.0),
('2009-03-01 9:02:00', 0, 5, 0, 0, 1, 9, 0.0), 
('2009-04-01 10:07:00', 0, 25, 0, 0, 2, 10, 0.0),
('2009-04-01 10:07:00', 0, 10, 0, 0, 2, 11, 0.0),
('2009-05-01 10:07:00', 2000, 0, 0, 0, 2, 12, 0.0);


 Insert into tbStockIn(StockName, StockIn, UnitPrice, Amount, Date, Photo,  FoodcategoryID, FoodCategory)
 Values ('Coca', 2, 15, 30, '2009-02-01 9:02:00', 
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\coca.jpg', SINGLE_BLOB) as StockImg),
7, 'Others');
 Insert into tbStockIn(StockName, StockIn, UnitPrice, Amount, Date, Photo, FoodcategoryID, FoodCategory)
 Values('Vigor', 2, 16, 32, '2010-02-01 9:10:00',
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\Vigor.gif', SINGLE_BLOB) as StockImg),
7, 'Others' );
 Insert into tbStockIn(StockName, StockIn, UnitPrice, Amount, Date, Photo, FoodcategoryID, FoodCategory)
 Values('Vigor', 3, 16, 48, '2010-02-01 9:05:00',
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\Vigor.gif', SINGLE_BLOB) as StockImg),
7, 'Others');
 Insert into tbStockIn(StockName, StockIn, UnitPrice, Amount, Date, Photo, FoodcategoryID, FoodCategory)
 Values('Beef', 1, 10, 10, '2010-02-01 9:15:00', 
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\Beef.jpg', SINGLE_BLOB) as StockImg),
 7, 'Others');

 
 Insert into tbStockOut(StockName, StockOut, UnitPrice, Amount, Date, Photo, FoodcategoryID, FoodCategory) 
 Values ('Coca', 1, 15, 15, '2009-03-01 9:02:00',
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\coca.jpg', SINGLE_BLOB) as StockImg),
 7, 'Others'),
 ('Vigor', 2, 16, 32, '2010-03-01 9:10:00',
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\Vigor.gif', SINGLE_BLOB) as StockImg),
 7, 'Others');


 Insert into tbStockCount(StockName, StockCount, UnitPrice, Amount, Photo, FoodcategoryID, FoodCategory)
 Values ('Coca', 1, 15, 15,
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\coca.jpg', SINGLE_BLOB) as StockImg),
 7, 'Others'), 
 ( 'Vigor', 3, 16, 48, 
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\Vigor.gif', SINGLE_BLOB) as StockImg),
7, 'Others'), 
 ( 'Beef', 1, 10, 10, 
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\Beef.jpg', SINGLE_BLOB) as StockImg),
 7, 'Others'),
 ( 'Chicken', 1, 5, 5, 
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\Chicken.jpg', SINGLE_BLOB) as StockImg),
 7, 'Others');

 Insert into tbProduct(ProductName, Price, Description, FoodCategoryID, Image)
 Values ('Coca' , 1, 'Ice', 1, 
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\coca.jpg', SINGLE_BLOB) as ItemImg)),
 ('BBQ', 1, 'Spicy', 4, 
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\BBQ.png', SINGLE_BLOB) as ItemImg)),
 ('Vigor' , 1, 'Ice', 1, 
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\Vigor.gif', SINGLE_BLOB) as ItemImg)),

 ('Vigor' , 16, 'Ice', 7, 
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\Vigor.gif', SINGLE_BLOB) as ItemImg)),
 ('Coca' , 15, 'Ice', 7, 
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\coca.jpg', SINGLE_BLOB) as ItemImg)),
 ('Beef' , 10, 'Ice', 7, 
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\Beef.jpg', SINGLE_BLOB) as ItemImg)),
 ('Chicken' , 5, 'Ice', 7, 
 (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\year4\OOAD\RMS-Project\RMS Photo\Chicken.jpg', SINGLE_BLOB) as ItemImg));


 
 ----Select Statement ------

Select * from tbCustomer;
Select * from tbFoodCategory;
Select * from tbUser;
Select * from tbPaymentMethod;
Select * from tbOrder;
select * from tbStockCount;
Select * from tbStockOut;
Select * from tbStockIn;
select * from tbOrderDetail;


WITH CTE AS (
    SELECT OrderID, OrderDate,
           ROW_NUMBER() OVER(PARTITION BY OrderDate ORDER BY OrderID) AS RowNum
    FROM tbOrder
)
DELETE FROM CTE
WHERE RowNum > 1;

-- kae Insert tbuser-> Username to UserName , Cashier to Staff
-- tbCustomer ot brer, in tbOrder col CustomerID ot ban use, in finance pel click create ot mean customerID





