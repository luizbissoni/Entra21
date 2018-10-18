--DROP TABLE pessoas; apaga tabela
/*cria uma tabela chamada pessoas, com duas colunas nome e sobrenome*/

/*CREATE TABLE pessoas
(
	nome VARCHAR(100), /*coluna que pode armazenar ate 100 caracteres*/
	sobrenome VARCHAR(100)/*coluna que pode armazenar ate 170 caracteres*/
);*/

/*inserir um registro na tabela pessoas  nas colunas nome e sobrenome*/
TRUNCATE TABLE	pessoas; /*retirar todos os registros da tabela*/
INSERT INTO pessoas VALUES('João','da Silva');
INSERT INTO pessoas VALUES ('Pedro','Machado');
INSERT INTO pessoas VALUES('Elricledison','Pereira');
INSERT INTO pessoas VALUES('Jaison','da Silva');
INSERT INTO pessoas VALUES('Yudi','da Priscila');
