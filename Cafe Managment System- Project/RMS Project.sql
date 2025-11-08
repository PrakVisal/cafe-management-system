-----Create databases-----

create database ManagementSystem;
GO

USE ManagementSystem;
GO


-----Create tables-------

create table tbFoodCategory(
	FoodCategoryID int not null IDENTITY(1,1) primary key, 
	FoodCategoryName varchar(50) not null);
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
	Tax DECIMAL(5, 2));
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

---------Update column-----------

alter table tbOrder Alter column ChargeRiel decimal(8,2) null;
alter table tbOrder Alter column ChargeDollar decimal(8,2) null;

-----Insert data into tables------

Insert into tbFoodCategory(FoodCategoryName)
Values('Beverages'), ('Frappes'), ('Juices'), 
('Snacks'),  ('Breakfast'),  ('Lunch'),  ('Others'),  ('PromotionSet');
GO

Insert into tbOrder(OrderDate, TotalRiel, TotalDollar, ChargeRiel, ChargeDollar, Tax)
Values
('2009-01-01 10:00:00', 10000, 0, 0, 0, 0.0),
('2009-01-01 10:30:00', 80000, 0, 20000, 0, 0.0),
('2009-01-01 9:02:00', 0, 5, 0, 0, 0.0), 
('2009-01-01 10:07:00', 0, 30, 0, 0, 0.0),
('2009-01-01 10:07:00', 0, 10, 0, 0, 0.0),
('2009-01-01 10:07:00', 12000, 0, 0, 0, 0.0),
('2009-02-01 10:00:00', 5000, 0, 0, 0, 0.0),
('2009-02-01 10:30:00', 80000, 0, 20000, 0, 0.0),
('2009-03-01 9:02:00', 0, 5, 0, 0, 0.0), 
('2009-04-01 10:07:00', 0, 25, 0, 0, 0.0),
('2009-04-01 10:07:00', 0, 10, 0, 0, 0.0),
('2009-05-01 10:07:00', 2000, 0, 0, 0, 0.0);
GO

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
GO

 
----Select Statement ------

Select * from tbFoodCategory;
Select * from tbProduct;
Select * from tbOrder;
select * from tbOrderDetail;
GO

WITH CTE AS (
    SELECT OrderID, OrderDate,
           ROW_NUMBER() OVER(PARTITION BY OrderDate ORDER BY OrderID) AS RowNum
    FROM tbOrder
)
DELETE FROM CTE
WHERE RowNum > 1;
GO
