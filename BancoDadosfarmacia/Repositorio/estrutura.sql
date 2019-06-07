DROP TABLE produtos_higienicos;
CREATE TABLE produtos_higienicos(
id INT PRIMARY KEY IDENTITY (1,1),
nome VARCHAR (100) NOT NULL,
preco DECIMAL(6,2),
quantidade INT,
categoria VARCHAR (100)
);


CREATE TABLE comestiveis(
	id INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (100),
	valor DECIMAL (6,2),
	data_vencimento DATETIME2,
	quantidade INT,
	marca VARCHAR(100)
	);

CREATE TABLE remedios(
id INT PRIMARY KEY IDENTITY (1,1),
nome VARCHAR (100),
generico VARCHAR (100),
categoria VARCHAR (100),
contra_indicacao VARCHAR(500),
bula VARCHAR (1000),
faixa VARCHAR (100),
receita BIT ,
);
SELECT * FROM remedios;
