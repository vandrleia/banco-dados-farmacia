DROP TABLE produtos_higienicos;
CREATE TABLE produtos_higienicos(
id INT PRIMARY KEY IDENTITY (1,1),
nome VARCHAR (100) NOT NULL,
preco DECIMAL(3,1),
categoria VARCHAR (100)
);

