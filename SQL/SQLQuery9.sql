
CREATE TABLE Pokemon
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	Name NVARCHAR (250) NOT NULL,
	Height NVARCHAR (100) NOT NULL,
	Weight Nvarchar (100) NOT NULL,
)

CREATE TABLE Type
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(100) UNIQUE NOT NULL,
)

CREATE TABLE PokemonType
(
	ID INT IDENTITY(1,1) PRIMARY KEY Not null,
	PokemonID INT  NOT NULL,
	TypeId INT NOT NULL,
	FOREIGN KEY (PokemonID) REFERENCES Pokemon,
	FOREIGN KEY (TypeId) REFERENCES Type,

	
)

INSERT INTO Pokemon
(Name, Height, Weight)
VAlues 
('Bulbasaur',7,70);

INSERT INTO Type
(Name)
VALUES
('Normal'),
('Grass');

-- LEFT JOIN
-- Returns all records from the "Left" table, even if there are not matching records in the "Right" table

-- SELECT column_name
-- FROM Table_A
-- LEFT JOIN Table_B
-- ON Table_A.column_name = Table_B.column_Name;

Select Name 'Bulbasur'
From TABLE Pokemon
LEFT JOIN
ON TABLE Type
on Name= PokemonType


