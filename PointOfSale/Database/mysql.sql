CREATE DATABASE POS;
GO

USE POS;
GO

CREATE TABLE ProductTable (
    ProductId VARCHAR(5) PRIMARY KEY,    
    ProductName NVARCHAR(100),
	Quantity INT,
    CostPrice DECIMAL(10, 2),
    SellingPrice DECIMAL(10, 2),
    Description NVARCHAR(255),
	Status VARCHAR(20),                    
	ImagePath NVARCHAR(200)
);
Go



CREATE TABLE EmployeeTable (
    EmployeeId NVARCHAR(10) PRIMARY KEY,
    EmployeeName NVARCHAR(100),
    EmployeeNIC NVARCHAR(12),
    EmployeeTeleNo INT,
    EmployeeAddress NVARCHAR(50),
    EmployeeEmail NVARCHAR(50),
    EmployeeRole NVARCHAR(50),
    EmployeeGender VARCHAR(10),
    EmployeePhoto VARBINARY(MAX),
    EmployeeUserName NVARCHAR(50),
    EmployeePassword NVARCHAR(50),
    EmployeeSalary NVARCHAR(20)
);
GO

CREATE TABLE Sales (
    BillNo INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId NVARCHAR(10),
    SaleDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    Total DECIMAL(10, 2),
    Discount DECIMAL(10, 2),
    FOREIGN KEY (EmployeeId) REFERENCES EmployeeTable(EmployeeId)
);


GO

CREATE TABLE Orders (
    BillNo INT,
    ProductId VARCHAR(5),
    Qty INT,
    PRIMARY KEY (BillNo, ProductId),
    FOREIGN KEY (BillNo) REFERENCES Sales(BillNo),  
    FOREIGN KEY (ProductId) REFERENCES ProductTable(ProductId)  
);
GO


CREATE TABLE Loyality (
    PhoneNo INT PRIMARY KEY,    
    Name NVARCHAR(100),         
    Points INT                  
);

GO

INSERT INTO ProductTable (ProductId, ProductName, Quantity, CostPrice, SellingPrice, Description, Status, ImagePath) VALUES
('P1', 'Anchor Full Cream Milk Powder', 30, 1000.00, 1100.00, 'Sizes :- 12g, 25g, 100g, 400g, 1kg, 2kg|Categories :- Dairy Products', 'Available','pos system\resources\anchor.jpg'),
('P10', 'Himalaya Purifying Neem Facewash 50Ml', 33, 800.00, 850.00, 'Sizes :- 15ml, 50ml, 100ml|Categories :- Face Care', 'Available','pos system\resources\himalaya.jpg'),
('P11', 'Ponds Bright Beauty Serum Cream 35G', 15, 800.00, 820.00, 'Sizes :- 7g, 18g, 35g, 50g|Categories :- Personal Care', 'Available','pos system\resources\ponds.jpg'),
('P12', 'Kotmale Processed Cheese Wedges Pepper', 25, 500.00, 580.00, 'Sizes :- 120g (8 wedges × 15g)|Categories :- Dairy Products', 'Available','pos system\resources\cheese.jpg'),
('P13', 'Time Wafer Master Chocolate Cream 65G', 48, 700.00, 750.00, 'Sizes :- 35g, 50g, 65g|Categories :- Daily Deals, Biscuits & Cookies', 'Available','pos system\resources\wafer master.jpg'),
('P14', 'Munchee Onion Biscuits - 170.00 g', 50, 340.00, 380.00, 'Sizes :- 85g, 170g, 200g|Categories :- Snacks / Biscuits', 'Available','pos system\resources\onion.jpg'),
('P15', 'Lux Body Soap Multipack - 4.00 pcs', 60, 540.00, 620.00, 'Sizes :- 4 pcs × 100g (400g)|Categories :- Personal Care', 'Available','pos system\resources\lux.jpg'),
('P16', 'Motha Rasperry Flavoured Jelly - 100.00 g', 15, 195.00, 230.00, 'Sizes :- 80g, 100g|Categories :- Desserts Mix', 'OutOfStock','pos system\resources\Motha jelly.jpg'),
('P17', 'Ritzbury Chunky Chocolate - 200.00 g', 35, 400.00, 450.00, 'Sizes :- 100g, 200g, 250g|Categories :- Confectionery', 'Available','pos system\resources\Chunky Chocolate.jpg'),
('P18', 'Keells Krest Chicken Bockwurst 400G', 20, 1000.00, 1090.00, 'Sizes :- 200g, 400g|Categories :- Frozen Processed Meat', 'Available','pos system\resources\Chicken Bockwurst.jpg'),
('P19', 'Prima Sunrise Tea Bun 65G', 28, 80.00, 100.00, 'Sizes :- 65g, 100g|Categories :- Breads & Buns', 'Available','pos system\resources\bun.jpg'),
('P2', 'Quality Street Favourits 283G', 34, 1800.00, 2000.00, 'Sizes :- 240g, 283g, 450g|Categories :- Chocolates', 'Available','pos system\resources\Quality Street.jpg'),
('P20', 'Twinfish Oat Choco Orginal 180G', 16, 1100.00, 1250.00, 'Sizes :- 180g, 360g|Categories :- Healthy Snacks', 'OutOfStock','pos system\resources\oat choco.jpg'),
('P3', 'Munchee Crevo Savoury Biscuits 215G', 40, 600.00, 680.00, 'Sizes :- 80g, 150g, 215g|Categories :- Snacks / Biscuits', 'Available','pos system\resources\cervo.jpg'),
('P4', 'Kotmale Fruit N Nut Icecream 1L', 22, 750.00, 820.00, 'Sizes :- 1L, 1.3L|Categories :- Ice Cream', 'Available','pos system\resources\fruit&nut.jpg'),
('P5', 'Elephant House Karutha Kolumban Ice Cream 900Ml', 18, 700.00, 790.00, 'Sizes :- 500ml, 900ml, 1L|Categories :- Ice Cream', 'OutOfStock','pos system\resources\Karutha Kolumban Ice Cream.jpg'),
('P6', 'Nescafe 3In1 Original 18Gx28S 504G', 26, 2250.00, 2950.00, 'Sizes :- 252g , 504g|Categories :- Coffee Mix', 'Available','pos system\resources\nescafe.jpg'),
('P7', 'Nestle Milo Nuggets Mocha 25G', 32, 500.00, 550.00, 'Sizes :- 25g, 80g|Categories :- Coffee Mix', 'Available','pos system\resources\Milo.jpg'),
('P8', 'Sweetzone Double Fruits 180G', 45, 700.00, 725.00, 'Sizes :- 100g, 180g, 300g|Categories :- Daily Deals, Candies & Sweets', 'Available','pos system\resources\Sweetzone Double Fruits.jpg'),
('P9', 'Prima Kottu Mee Koream Ramen Seafood 116G', 28, 280.00, 300.00, 'Sizes :- 70g, 85g, 116g|Categories :- Noodles And Pastas', 'Available','pos system\resources\Koream Ramen.jpg');

GO


INSERT INTO [POS].[dbo].[Sales] (BillNo, EmployeeId, SaleDate, SaleTime, Total) VALUES
(2,  'EMP003', '2025-01-05', '10:15:00', 15000.00),
(3,  'EMP004', '2025-01-20', '14:30:00', 4800.00),
(4,  'EMP005', '2025-02-03', '11:45:00', 3200.00),
(5,  'EMP006', '2025-02-18', '16:10:00', 5100.00),
(6,  'EMP004', '2025-03-02', '09:55:00', 3700.00),
(7,  'EMP005', '2025-03-21', '13:25:00', 2950.00),
(8,  'EMP006', '2025-04-07', '10:05:00', 4200.00),
(9,  'EMP003', '2025-04-22', '15:45:00', 16500.00),
(10, 'EMP004', '2025-05-03', '11:10:00', 4000.00),
(11, 'EMP005', '2025-05-17', '14:50:00', 3500.00),
(12, 'EMP006', '2025-06-05', '09:40:00', 4800.00),
(13, 'EMP004', '2025-06-20', '13:30:00', 4300.00),
(14, 'EMP005', '2025-07-04', '11:15:00', 3900.00),
(15, 'EMP006', '2025-07-18', '16:00:00', 5200.00),
(16, 'EMP003', '2025-08-06', '10:25:00', 17200.00),
(17, 'EMP004', '2025-08-21', '12:45:00', 4600.00),
(18, 'EMP005', '2025-09-05', '09:50:00', 3100.00),
(19, 'EMP006', '2025-09-19', '15:20:00', 3900.00),
(20, 'EMP004', '2025-10-03', '10:35:00', 4500.00),
(21, 'EMP005', '2025-10-18', '13:15:00', 3200.00),
(22, 'EMP006', '2025-11-02', '09:25:00', 5000.00),
(23, 'EMP003', '2025-11-17', '14:55:00', 18500.00),
(24, 'EMP004', '2025-12-05', '11:05:00', 4800.00),
(25, 'EMP005', '2025-12-20', '15:30:00', 3400.00),
(26, 'EMP006', '2025-01-10', '09:45:00', 4600.00),
(27, 'EMP004', '2025-02-25', '14:25:00', 3900.00),
(28, 'EMP005', '2025-03-10', '10:55:00', 3200.00),
(29, 'EMP006', '2025-04-25', '16:15:00', 4900.00),
(30, 'EMP004', '2025-05-09', '11:35:00', 4200.00),
(31, 'EMP005', '2025-06-24', '13:10:00', 3000.00),
(32, 'EMP006', '2025-07-08', '10:45:00', 5100.00),
(33, 'EMP004', '2025-08-23', '14:50:00', 4700.00),
(34, 'EMP005', '2025-09-07', '09:30:00', 3100.00),
(35, 'EMP006', '2025-10-22', '15:40:00', 4500.00),
(36, 'EMP004', '2025-11-06', '10:20:00', 4000.00),
(37, 'EMP005', '2025-12-21', '12:30:00', 3500.00),
(38, 'EMP006', '2025-02-07', '09:10:00', 4800.00),
(39, 'EMP004', '2025-03-22', '14:15:00', 3900.00),
(40, 'EMP005', '2025-04-06', '11:50:00', 3000.00),
(41, 'EMP006', '2025-05-21', '16:05:00', 5200.00);


INSERT INTO [POS].[dbo].[Orders] (BillNo, ProductId, Qty) VALUES
(42, 'P18', 3),
(42, 'P3', 2),
(43, 'P4', 1),
(43, 'P5', 2),
(44, 'P6', 1),
(44, 'P7', 2),
(45, 'P8', 3),
(45, 'P9', 2),
(46, 'P18', 4),
(46, 'P3', 1),
(47, 'P4', 2),
(47, 'P5', 1),
(48, 'P6', 3),
(48, 'P7', 1),
(49, 'P8', 2),
(49, 'P9', 1),
(50, 'P18', 2),
(50, 'P3', 2),
(51, 'P4', 3),
(51, 'P5', 2),
(52, 'P6', 1),
(52, 'P7', 3),
(53, 'P8', 1),
(53, 'P9', 2),
(54, 'P18', 2),
(54, 'P3', 3),
(55, 'P4', 1),
(55, 'P5', 2),
(56, 'P6', 2),
(56, 'P7', 1),
(57, 'P8', 3),
(57, 'P9', 2),
(58, 'P18', 1),
(58, 'P3', 2),
(59, 'P4', 2),
(59, 'P5', 1),
(60, 'P6', 3),
(60, 'P7', 2),
(61, 'P8', 1),
(61, 'P9', 3);