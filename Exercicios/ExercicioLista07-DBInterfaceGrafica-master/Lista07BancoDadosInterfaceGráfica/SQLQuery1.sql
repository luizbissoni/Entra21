--DROP TABLE alunos;

CREATE TABLE alunos (
id        INT           IDENTITY (1, 1) NOT NULL,
    nome       VARCHAR (150) NOT NULL,
    matricula  TINYINT       NOT NULL,
    nota_1     INT           NOT NULL,
    nota_2     INT           NOT NULL,
    nota_3     INT           NOT NULL,
    frequencia TINYINT       NULL,
	media_notas DECIMAL,
	situacao_aluno VARCHAR(11)
	
	)