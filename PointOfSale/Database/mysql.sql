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