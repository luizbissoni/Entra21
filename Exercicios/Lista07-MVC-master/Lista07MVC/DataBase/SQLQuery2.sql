CREATE TABLE alunos(
id int IDENTITY(1,1) PRIMARY KEY, 
nome VARCHAR(100), 
codigo_matricula VARCHAR(15),
nota_1 DECIMAL(2,2),
nota_2 DECIMAL(2,2),
nota_3 DECIMAL(2,2),
frequencia TINYINT
 );