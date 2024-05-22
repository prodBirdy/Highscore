use Apec3DB;

Drop Table IF EXISTS PriceListsPositions;
Drop Table IF EXISTS ProductsProperties;
Drop Table IF EXISTS PriceLists;
Drop Table IF EXISTS Properties;

Drop Table IF EXISTS StoragePlaces;
Drop Table IF EXISTS Storages;

Drop Table IF EXISTS Products;
Drop Table IF EXISTS Currencies;


CREATE TABLE Products (
	ProductID		INT NOT NULL IDENTITY(1,1),
	Title			NVARCHAR(100) NOT NULL,
	GrossWeight		FLOAT,
	Discount		DECIMAL(5,4) NOT NULL DEFAULT 0,
	Producer		NVARCHAR(100) NOT NULL,
	LOT				INT NOT NULL DEFAULT 1,
	Notes			NVARCHAR(500) NULL,    
	
	CONSTRAINT		pkProducts PRIMARY KEY (ProductID),
	CONSTRAINT		ckDiscount CHECK (Discount >= 0 AND Discount <= 1)

);

CREATE TABLE Currencies (
	CurrencyID		Char(3) NOT NULL,
	Title			NVARCHAR(50) NOT NULL,
	Symbol			NVARCHAR(5) NULL,
	isStandard		BIT NOT NULL DEFAULT 0,
	ExchangeRate	DECIMAL(18,9) NOT NULL,    

	CONSTRAINT		pkCurrencies PRIMARY KEY (CurrencyID)
);

CREATE TABLE Properties (
	PropertyID		INT NOT NULL IDENTITY(1,1),
	Title			NVARCHAR(50) NOT NULL,
	Notes			NVARCHAR(500) NULL,              

	CONSTRAINT		 pkProperties PRIMARY KEY (PropertyID)
);

CREATE TABLE ProductsProperties (
	ProductID		INT NOT NULL,
	PropertyID		INT NOT NULL,
	PropValue		NVARCHAR(100) NOT NULL,

	CONSTRAINT		pkProductsProperties PRIMARY KEY (ProductID, PropertyID),
	CONSTRAINT		fkProductsProperties_ProductID FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE,
	CONSTRAINT		fkProductsProperties_PropertyID FOREIGN KEY (PropertyID) REFERENCES Properties(PropertyID) ON DELETE CASCADE,

);

CREATE TABLE Storages ( 
	StorageID		INT NOT NULL IDENTITY(1,1),
	Title			NVARCHAR(50) NOT NULL,
	Notes			NVARCHAR(500) NULL,              

	CONSTRAINT		pkStorages PRIMARY KEY (StorageID)
);

CREATE TABLE StoragePlaces (
	StoragePlaceID	INT NOT NULL IDENTITY(1,1),
	StorageID		INT NOT NULL,
	ProductID		INT NULL,
	Title			NVARCHAR(50) NOT NULL,
	Amount			INT NULL,	
	Notes			NVARCHAR(500) NULL,              

	CONSTRAINT		pkStoragePlaces PRIMARY KEY (StoragePlaceID),
	CONSTRAINT		fkStoragePlaces_StorageID FOREIGN KEY (StorageID) REFERENCES Storages(StorageID) ON DELETE CASCADE,
	CONSTRAINT		fkStoragePlaces_ProductID FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE,
);




CREATE TABLE PriceLists (
	PriceListID		INT NOT NULL IDENTITY(1,1),
	Title			NVARCHAR(50) NOT NULL,
	Notes			NVARCHAR(500) NULL,              
	ValidFrom 		DATE NOT NULL,
	ValidTo 		DATE NULL,
	CurrencyID		Char(3) NOT NULL,

	CONSTRAINT		pkPriceLists PRIMARY KEY (PriceListID),
	CONSTRAINT		fkPriceLists_CurrencyID FOREIGN KEY (CurrencyID) REFERENCES Currencies(CurrencyID) ON UPDATE CASCADE,
);

CREATE TABLE PriceListsPositions (
	PriceListPositionID	INT NOT NULL IDENTITY(1,1),
	PriceListID			INT NOT NULL,
	ProductID			INT NOT NULL,
	Price				DECIMAL(18,4) NOT NULL,    
	Tax					DECIMAL(5,4) NOT NULL DEFAULT 0,
	Notes				NVARCHAR(500) NULL,

	CONSTRAINT			pkPriceListsPositions PRIMARY KEY (PriceListPositionID),
	CONSTRAINT			fkPriceListsPositions_PriceListID FOREIGN KEY (PriceListID) REFERENCES PriceLists(PriceListID) ON DELETE CASCADE,
	CONSTRAINT			fkPriceListsPositions_ProductID FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
	CONSTRAINT			ckTax CHECK (Tax >= 0 AND Tax <= 1)
);

CREATE TABLE Customer (
	CustomerID		INT NOT NULL IDENTITY,

	AdressID		INT NOT	NULL,
);
