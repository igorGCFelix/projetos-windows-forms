CREATE DATABASE crud_animal;
CREATE TABLE tubarao(
	id INT(11) NULL PRIMARY KEY,
	nomeComum VARCHAR(50) NULL,
	nomeCientifico VARCHAR(100) NULL,
	familia VARCHAR(100) NULL,
	sexo VARCHAR(30) NULL,
	comprimento float(11) NULL,
	peso float(11) NULL,
	corPele VARCHAR(20) NULL
);