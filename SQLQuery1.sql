--CREATE DATABASE RpgDBTurma15

--USE RpgDBTurma15

CREATE TABLE Usuarios (
		IdUsuario INT PRIMARY KEY IDENTITY, 
		Email VARCHAR(100) UNIQUE NOT NULL, 
		Senha VARCHAR(255) NOT NULL 
)

CREATE TABLE Classes (
		IdClasse INT PRIMARY KEY IDENTITY,
		Nome VARCHAR(100) UNIQUE NOT NULL,
		Descricao VARCHAR(255)
)

CREATE TABLE Personagens (
		IdPersonagem INT PRIMARY KEY IDENTITY,
		Nome VARCHAR(30) UNIQUE NOT NULL,
		IdUsuario INT UNIQUE FOREIGN KEY REFERENCES Usuarios(IdUsuario),
		IdClasse INT FOREIGN KEY REFERENCES Classes(IdClasse)
)

CREATE TABLE Habilidade (
		IdHabilidade INT PRIMARY KEY IDENTITY,
		Nome VARCHAR(100) UNIQUE NOT NULL,
		Descricao VARCHAR(255)
)

CREATE TABLE ClasseHabilidade (
		IdClasse INT FOREIGN KEY  REFERENCES Classes(IdClasse),
		IdHabilidade INT FOREIGN KEY  REFERENCES Habilidade(IdHabilidade)
)

--DML--
INSERT INTO Usuarios (Email, Senha) VALUES ('email@email.com', 123456)
INSERT INTO Classes VALUES ('Barbaro', 'Descrição da classe Barbaro')
INSERT INTO Habilidade VALUES ('Lança Mortal ', 'Descrição da Lança Mortal'), ('Escudo Supremo','Descrição do Escudo Supremo')
INSERT INTO Personagens VALUES ('DeuBug', 1, 1)
INSERT INTO ClasseHabilidade VALUES (1, 1), (1, 2)

INSERT INTO Usuarios (Email, Senha) VALUES ('email2@email.com', 123456)
INSERT INTO Classes VALUES ('Monge', 'Descrição da classe Monge')
INSERT INTO Habilidade VALUES ('Recuperar Vida ', 'Descrição de Recuperar Vida')
INSERT INTO Personagens VALUES ('BitBug', 2, 2)
INSERT INTO ClasseHabilidade VALUES (2, 2), (2, 3)

UPDATE Usuarios 
SET Senha = 654321 
WHERE IdUsuario = 1


--DQL--
SELECT * FROM Usuarios
SELECT Senha, Email FROM Usuarios
SELECT * FROM Classes
SELECT * FROM Habilidade
SELECT * FROM Personagens
SELECT * FROM ClasseHabilidade

SELECT * FROM Personagens
INNER JOIN Classes
ON Personagens.IdClasse = Classes.IdClasse

SELECT P.Nome, C.Nome, C.Descricao FROM Personagens AS P
INNER JOIN Classes C
ON P.IdClasse = C.IdClasse

--------------------------------------------------------

CREATE DATABASE ExemploJoin2
GO

USE ExemploJoin2
GO

CREATE TABLE NomeA(
	Nome VARCHAR(50) NOT NULL
)
GO

CREATE TABLE NomeB(
	Nome VARCHAR(50) NOT NULL
)
GO

INSERT INTO NomeA VALUES ('Lucas'), ('Silvia'), ('Tadeu'), ('Uiara')
INSERT INTO NomeB VALUES ('Ursula'), ('Rafael'), ('Diego'), ('Theo')

SELECT * FROM NomeA
SELECT * FROM NomeB

SELECT * FROM NomeA
JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
LEFT JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
RIGHT JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT * FROM NomeA
Full OUTER JOIN NomeB
ON NomeA.Nome = NomeB.Nome

SELECT NomeA.Nome 'Nome A', NomeB.Nome 'Nome B' FROM NomeA
Full OUTER JOIN NomeB
ON NomeA.Nome = NomeB.Nome
WHERE NomeA.Nome IS NULL OR NomeB.Nome IS NULL