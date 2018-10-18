﻿--DROP TABLE fraquezas3;
--DROP TABLE fraquezas2;
--DROP TABLE fraquezas1;
--DROP TABLE categorias;
--DROP TABLE pokemons;

--CREATE TABLE pokemons(id INT IDENTITY(1,1) PRIMARY KEY, nome VARCHAR(150));
--CREATE TABLE categorias(id INT IDENTITY(1,1) PRIMARY KEY,id_pokemon INT,nome VARCHAR(150), FOREIGN KEY(id_pokemon) REFERENCES pokemons(id));
--CREATE TABLE fraquezas1(id INT IDENTITY(1,1) PRIMARY KEY,id_pokemonFraqueza1 INT, nome VARCHAR(50),FOREIGN KEY(id_pokemonFraqueza1) REFERENCES pokemons(id));
--CREATE TABLE fraquezas2(id INT IDENTITY(1,1) PRIMARY KEY,id_pokemonFraqueza2 INT, nome VARCHAR(50),FOREIGN KEY(id_pokemonFraqueza2) REFERENCES pokemons(id));
--CREATE TABLE fraquezas3(id INT IDENTITY(1,1) PRIMARY KEY,id_pokemonFraqueza3 INT, nome VARCHAR(50),FOREIGN KEY(id_pokemonFraqueza3) REFERENCES pokemons(id));
--
--INSERT INTO pokemons (nome) VALUES('Umbreon');
--INSERT INTO pokemons (nome) VALUES('Magcargo');
--INSERT INTO pokemons (nome) VALUES('Lotad');
--INSERT INTO pokemons (nome) VALUES('Silcoon');
--INSERT INTO pokemons (nome) VALUES('Slakoth');
--INSERT INTO pokemons (nome) VALUES('Manectric');
--INSERT INTO pokemons (nome) VALUES('Sharpedo');
--INSERT INTO pokemons (nome) VALUES('Zangoose');
--INSERT INTO pokemons (nome) VALUES('Glalie');
--INSERT INTO pokemons (nome) VALUES('Beldum');
--
--INSERT INTO categorias(id_pokemon, nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Umbreon'),'Moonlight');
--INSERT INTO categorias(id_pokemon, nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Magcargo'),'Lava');
--INSERT INTO categorias(id_pokemon, nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Lotad'),'Water Weed');
--INSERT INTO categorias(id_pokemon, nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Silcoon'),'Cocoon');
--INSERT INTO categorias(id_pokemon, nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Slakoth'),'Slacker');
--INSERT INTO categorias(id_pokemon, nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Manectric'),'Discharge');
--INSERT INTO categorias(id_pokemon, nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Sharpedo'),'Brutal');
--INSERT INTO categorias(id_pokemon, nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Zangoose'),'Cat Ferret');
--INSERT INTO categorias(id_pokemon, nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Glalie'),'Face');
--INSERT INTO categorias(id_pokemon, nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Beldum'),'Iron Ball');
--
--INSERT INTO fraquezas1(id_pokemonFraqueza1,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Umbreon'),'FIGHTING');
--INSERT INTO fraquezas2(id_pokemonFraqueza2,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Umbreon'),'BUG');
--INSERT INTO fraquezas3(id_pokemonFraqueza3,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Umbreon'),'FAIRY');
--
--INSERT INTO fraquezas1(id_pokemonFraqueza1,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Magcargo'),'GROUND');
--INSERT INTO fraquezas2(id_pokemonFraqueza2,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Magcargo'),'WATER');
--INSERT INTO fraquezas3(id_pokemonFraqueza3,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Magcargo'),'ROCK');
--
--INSERT INTO fraquezas1(id_pokemonFraqueza1,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Lotad'),'BUG');
--INSERT INTO fraquezas2(id_pokemonFraqueza2,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Lotad'),'FLYING');
--INSERT INTO fraquezas3(id_pokemonFraqueza3,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Lotad'),'POISON');
--
--INSERT INTO fraquezas1(id_pokemonFraqueza1,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Silcoon'),'FIRE');
--INSERT INTO fraquezas2(id_pokemonFraqueza2,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Silcoon'),'FLYING');
--INSERT INTO fraquezas3(id_pokemonFraqueza3,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Silcoon'),'ROCK');
--
--INSERT INTO fraquezas1(id_pokemonFraqueza1,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Slakoth'),'FIGHTING');
--INSERT INTO fraquezas2(id_pokemonFraqueza2,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Slakoth'),NULL);
--INSERT INTO fraquezas3(id_pokemonFraqueza3,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Slakoth'),NULL);
--
--INSERT INTO fraquezas1(id_pokemonFraqueza1,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Manectric'),'GROUND');
--INSERT INTO fraquezas2(id_pokemonFraqueza2,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Manectric'),NULL);
--INSERT INTO fraquezas3(id_pokemonFraqueza3,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Manectric'),NULL);
--
--INSERT INTO fraquezas1(id_pokemonFraqueza1,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Sharpedo'),'FIGHTING');
--INSERT INTO fraquezas2(id_pokemonFraqueza2,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Sharpedo'),'GRASS');
--INSERT INTO fraquezas3(id_pokemonFraqueza3,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Sharpedo'),'ELECTRIC');
--
--INSERT INTO fraquezas1(id_pokemonFraqueza1,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Zangoose'),'FIGHTING');
--INSERT INTO fraquezas2(id_pokemonFraqueza2,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Zangoose'),NULL);
--INSERT INTO fraquezas3(id_pokemonFraqueza3,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Zangoose'),NULL);
--
--INSERT INTO fraquezas1(id_pokemonFraqueza1,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Glalie'),'ROCK');
--INSERT INTO fraquezas2(id_pokemonFraqueza2,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Glalie'),'STEEL');
--INSERT INTO fraquezas3(id_pokemonFraqueza3,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Glalie'),'FIRE');
--
--INSERT INTO fraquezas1(id_pokemonFraqueza1,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Beldum'),'GHOST');
--INSERT INTO fraquezas2(id_pokemonFraqueza2,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Beldum'),'DARK');
--INSERT INTO fraquezas3(id_pokemonFraqueza3,nome) VALUES((SELECT id FROM pokemons WHERE nome = 'Beldum'),'FIRE');

--SELECT * FROM pokemons;
--SELECT id_pokemon,nome FROM categorias;
--SELECT id_pokemonFraqueza1,nome FROM fraquezas1;
--SELECT id_pokemonFraqueza2,nome FROM fraquezas2;
--SELECT id_pokemonFraqueza3,nome FROM fraquezas3;

