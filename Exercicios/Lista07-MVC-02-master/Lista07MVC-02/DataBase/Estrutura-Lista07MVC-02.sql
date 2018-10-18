CREATE TABLE mecanicas (
id INT IDENTITY(1,1),
dono VARCHAR(100) NOT NULL,
modelo VARCHAR(100) NOT NULL,
cor VARCHAR(30)NOT NULL,
colaborador_responsavel VARCHAR(100) NOT NULL,
estatus VARCHAR(100),
data_orcamento DATE,
valor_orcamento DECIMAL(4,2),
valor_desconto DECIMAL(4,2),
valor_total DECIMAL(4,2),
data_finalizacao_servico DATE
);