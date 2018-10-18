--DROP TABLE pizzas;   --apaga tabela
CREATE TABLE pizzas	
(
	cliente VARCHAR(100),
	preco DECIMAL(5,2),
	diametro SMALLINT,
	fatias TINYINT,
	sabor_1 VARCHAR(50),
	sabor_2 VARCHAR(50),
	sabor_3 VARCHAR(50),
	sabor_4 VARCHAR(50),
	com_borda BIT,
	com_brinde BIT
);

INSERT INTO pizzas VALUES('FrancisGod',12.4,70,40,'calabresa','frango com catupiry','seis queijos','alho e oleo',1,1);
INSERT INTO pizzas(cliente,diametro,fatias,sabor_1,sabor_4,com_borda,com_brinde) VALUES('ygor',45,20,'pepino com tomate','brocolis',0,0);
INSERT INTO pizzas (cliente,preco,diametro,fatias,sabor_1,sabor_2,com_borda,com_brinde)VALUES('stolfi junior',40,20,16,'frango com cebola','frango sem cebola',0,1);
INSERT INTO pizzas (cliente,preco,diametro,fatias,sabor_1,sabor_2,sabor_3,com_borda,com_brinde)VALUES('Fadinha',65,35,25,'italiana','alema','britanica',0,0);
INSERT INTO pizzas (cliente,preco,diametro,fatias,sabor_1,sabor_2,sabor_4,com_borda,com_brinde)VALUES('Desenhista',55,35,8,'kostelinha','Quatro presuntoS','bacon',0,0);