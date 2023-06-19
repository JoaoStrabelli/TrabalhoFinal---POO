CREATE DATABASE gerenciamentopedidoscomida;

USE GerenciamentoPedidosComida;

CREATE TABLE Cliente (
Id INT NOT NULL AUTO_INCREMENT,
Nome VARCHAR(100) NOT NULL,
Endereco VARCHAR(100) NOT NULL,
Email VARCHAR(100) NOT NULL UNIQUE,
Senha VARCHAR(100) NOT NULL,
NumeroTelefone VARCHAR(20) NOT NULL UNIQUE,
PRIMARY KEY(Id)
);

CREATE TABLE Restaurante (
Id INT NOT NULL AUTO_INCREMENT,
Nome VARCHAR(100) NOT NULL,
Endereco VARCHAR(100) NOT NULL,
NumeroTelefone VARCHAR(20) NOT NULL UNIQUE,
PRIMARY KEY(Id)
);

CREATE TABLE Pedido (
Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
DataPedido DATE NOT NULL,
Status VARCHAR(15) NOT NULL,
Total DECIMAL(10, 2) NOT NULL,
ClienteId INT NOT NULL REFERENCES Cliente(Id),
RestauranteId INT NOT NULL REFERENCES Restaurante(Id)
);

CREATE TABLE ItemPedido (
PedidoId INT NOT NULL REFERENCES Pedido(Id),
PratoId INT NOT NULL REFERENCES Prato(Id),
Quantidade INT NOT NULL,
PrecoUnitario DECIMAL(10, 2) NOT NULL,
Total DECIMAL(10, 2) NOT NULL,
PRIMARY KEY (PedidoId, PratoId)
);

CREATE TABLE Prato (
Id INT NOT NULL AUTO_INCREMENT,
NomeItem VARCHAR(100) NOT NULL,
Descricao VARCHAR(100) NOT NULL,
Preco DECIMAL(10, 2) NOT NULL,
RestauranteId INT NOT NULL REFERENCES Restaurante(Id),
PRIMARY KEY (Id)
);

CREATE TABLE Avaliacao (
Id INT NOT NULL AUTO_INCREMENT,
Comentario VARCHAR(255),
Classificacao INT NOT NULL,
ClienteId INT NOT NULL REFERENCES Cliente(Id),
RestauranteId INT NOT NULL REFERENCES Restaurante(Id),
PedidoId INT NOT NULL REFERENCES Pedido(Id),
PRIMARY KEY (Id)
);