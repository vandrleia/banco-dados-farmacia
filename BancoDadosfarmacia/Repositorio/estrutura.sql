DROP TABLE produtos_higienicos;
CREATE TABLE produtos_higienicos(
id INT PRIMARY KEY IDENTITY (1,1),
nome VARCHAR (100) NOT NULL,
preco DECIMAL(6,2),
quantidade INT,
categoria VARCHAR (100)
);


DROP TABLE comestiveis;
CREATE TABLE comestiveis(
	id INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (100),
	valor DECIMAL (6,2),
	data_vencimento DATETIME2,
	quantidade INT,
	marca VARCHAR(100)
);
