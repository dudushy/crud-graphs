--? db_graphs
CREATE DATABASE [db_graphs];

--? tb_cliente
CREATE TABLE [tb_cliente] (
    id INTEGER IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(60),
    cpf VARCHAR(15),
    email VARCHAR(60),
    telefone VARCHAR(25),
    endereco VARCHAR(200)
);

INSERT INTO [tb_cliente] (nome, cpf, email, telefone, endereco)
VALUES ('João da Silva', '123.456.789-00', 'joaosilva@test.com', '(11) 99999-9999', 'Rua dos Bobos, 0, São Paulo - SP');

SELECT * FROM [tb_cliente];

--? tb_produto
CREATE TABLE [tb_produto] (
    id INTEGER IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(60),
    categoria VARCHAR(60),
    quantidade INTEGER,
    descricao VARCHAR(60),
    clientes VARCHAR(600),
    preco VARCHAR(60)
);

INSERT INTO [tb_produto] (nome, categoria, quantidade, descricao, clientes, preco)
VALUES ('Cadeira', 'Móveis', 10, 'Cadeira de escritório', 'João da Silva', 'R$ 100,00');

SELECT * FROM [tb_produto];

--? tb_orcamento
CREATE TABLE [tb_orcamento] (
    id INTEGER IDENTITY(1,1) PRIMARY KEY,
    clientes VARCHAR(600),
    produtos VARCHAR(60),
    valor FLOAT,
    data VARCHAR(30),
    status INTEGER,
    arquivo VARBINARY(MAX)
);

INSERT INTO [tb_orcamento] (clientes, produtos, valor, data, status, arquivo)
VALUES ('João da Silva', 'Cadeira', 100.00, '2020-10-10', 1, );

SELECT * FROM [tb_orcamento];