CREATE TABLE recrutadoras(id INT IDENTITY(1,1) PRIMARY KEY, nome VARCHAR(100) NOT NULL, 
cpf CHAR(11) NOT NULL, tempo_empresa SMALLINT, salario DECIMAL(12,2));

INSERT INTO recrutadoras (nome, cpf, tempo_empresa, salario) VALUES ('DOUFIM', '12345678912', 2, 10000.00),
('JOAFIM', '32165498732', 3, 20000.00),('CAFIM', '65498732165', 4, 1500.00);