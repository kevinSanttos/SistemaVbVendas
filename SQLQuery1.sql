use sistemavb

CREATE TABLE funcionarios(
id_func int PRIMARY KEY NOT NULL IDENTITY,
nome VARCHAR (60) NOT NULL,
sexo VARCHAR (30) NOT NULL,
cpf VARCHAR (30) NOT NULL,
endereco VARCHAR (100) NOT NULL,
telefone VARCHAR (30) NOT NULL,
email VARCHAR (30) NOT NULL
)
GO

CREATE TABLE clientes(
id_cliente int PRIMARY KEY NOT NULL IDENTITY,
nome VARCHAR (60) NOT NULL,
sexo VARCHAR (30) NOT NULL,
cpf VARCHAR (30) NOT NULL,
endereco VARCHAR (100) NOT NULL,
telefone VARCHAR (30) NOT NULL,
email VARCHAR (30) NOT NULL
)
GO

CREATE TABLE produtos(
id_produto int PRIMARY KEY NOT NULL IDENTITY,
nome VARCHAR (60) NOT NULL,
descricao Varchar (50) NOT NULL,
quantidade int NOT NULL,
valor decimal (10, 2),

)
GO

create table vendas(
id_vendas int PRIMARY KEY NOT NULL IDENTITY,
num_vendas int NOT NULL,
id_produto int NOT NULL,
id_cliente int NOT NULL,
quantidade int NOT NULL,
valor decimal (18,2),
funcionario VARCHAR (50),
data_venda DATETIME
FOREIGN KEY (id_produto) REFERENCES produtos (id_produto),
FOREIGN KEY (id_cliente) REFERENCES clientes (id_cliente)
)
----------------------------------------------------------------------------------------
--PROCEDIMENTOS FUNCIONARIOS
CREATE PROCEDURE sp_salvarfunc
@nome VARCHAR (60),
@sexo VARCHAR (30),
@cpf VARCHAR (30),
@endereco VARCHAR (100),
@telefone VARCHAR (30),
@email VARCHAR (30),
@mensagem VARCHAR (100) OUTPUT
AS
BEGIN
IF(EXISTS(SELECT * FROM funcionarios WHERE cpf = @cpf))
SET @mensagem= 'Numero do CPF: ' +@cpf + ' ja Registrado'
ELSE 
BEGIN
INSERT INTO funcionarios VALUES (@nome, @sexo, @cpf, @telefone, @endereco, @email)
SET @mensagem = 'Funcionario registrado com sucesso'
END
END
GO
---------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_editarfunc
@nome VARCHAR (60),
@sexo VARCHAR (30),
@cpf VARCHAR (30),
@endereco VARCHAR (100),
@telefone VARCHAR (30),
@email VARCHAR (30),
@mensagem VARCHAR (100) OUTPUT
AS
BEGIN
 
UPDATE funcionarios SET nome = @nome, endereco = @endereco, telefone = @telefone, email = @email where cpf = @cpf
SET @mensagem = 'Dados Alterados'
END

GO

--------------------------------------------------------------------------------

CREATE PROC sp_buscarfuncNome
@nome VARCHAR (60)
AS
BEGIN
SELECT * FROM funcionarios WHERE nome LIKE @nome + '%'
END
GO
------------------------------------------------------------------------------------

CREATE PROC sp_excluirfunc
@nome VARCHAR (60),
@mensagem VARCHAR (100) OUTPUT
AS
BEGIN
DELETE funcionarios WHERE nome = @nome
SET @mensagem = 'Dados excluídos'
END
GO
------------------------------------------------------------------------------------------


INSERT INTO funcionarios VALUES 
('admin', 'Masculino', '000.000.000-00', 'Guaruja', '(00)00000-0000', 'admin@hotmail.com')

------------------------------------------------------------------------------------------
--PROCEDIMENTOS DOS CLIENTES

CREATE PROCEDURE sp_salvarcli
@nome VARCHAR (60),
@sexo VARCHAR (30),
@cpf VARCHAR (30),
@endereco VARCHAR (100),
@telefone VARCHAR (30),
@email VARCHAR (30),
@mensagem VARCHAR (100) OUTPUT
AS
BEGIN
IF(EXISTS(SELECT * FROM clientes WHERE cpf = @cpf))
SET @mensagem= 'Numero do CPF: ' +@cpf + ' ja Registrado'
ELSE 
BEGIN
INSERT INTO clientes VALUES (@nome, @sexo, @cpf, @telefone, @endereco, @email)
SET @mensagem = 'Cliente registrado com sucesso'
END
END
GO
---------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_editarcli
@nome VARCHAR (60),
@sexo VARCHAR (30),
@cpf VARCHAR (30),
@endereco VARCHAR (100),
@telefone VARCHAR (30),
@email VARCHAR (30),
@mensagem VARCHAR (100) OUTPUT
AS
BEGIN
 
UPDATE clientes SET nome = @nome, endereco = @endereco, telefone = @telefone, email = @email where cpf = @cpf
SET @mensagem = 'Dados Alterados'
END

GO

--------------------------------------------------------------------------------

CREATE PROC sp_buscarcliNome
@nome VARCHAR (60)
AS
BEGIN
SELECT * FROM clientes WHERE nome LIKE @nome + '%'
END
GO
------------------------------------------------------------------------------------

CREATE PROC sp_excluircli
@nome VARCHAR (60),
@mensagem VARCHAR (100) OUTPUT
AS
BEGIN
DELETE clientes WHERE nome = @nome
SET @mensagem = 'Dados excluídos'
END
GO
----------------------------------------------------------------------------------------
--PROCEDIMENTOS DOS PRODUTOS

CREATE PROCEDURE sp_salvarpro
@nome VARCHAR (60),
@descricao Varchar (50),
@quantidade int ,
@valor decimal (10, 2),
@mensagem VARCHAR (100) OUTPUT
AS
BEGIN

INSERT INTO produtos VALUES (@nome, @descricao, @quantidade, @valor)
SET @mensagem = 'Produto registrado com sucesso'
END

GO
---------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_editarpro
@id_produto int,
@nome VARCHAR (60),
@descricao Varchar (50),
@quantidade int ,
@valor decimal (10, 2),
@mensagem VARCHAR (100) OUTPUT
AS
BEGIN
 
UPDATE produtos SET nome = @nome, descricao = @descricao, quantidade = @quantidade, valor = @valor where id_produto = @id_produto
SET @mensagem = 'Dados Alterados'
END

GO

--------------------------------------------------------------------------------

CREATE PROC sp_buscarpro
@nome VARCHAR (60)
AS
BEGIN
SELECT * FROM produtos WHERE nome LIKE @nome + '%'
END
GO
------------------------------------------------------------------------------------

CREATE PROC sp_excluirpro
@id_produto VARCHAR (60),
@mensagem VARCHAR (100) OUTPUT
AS
BEGIN
DELETE produtos WHERE id_produto = @id_produto
SET @mensagem = 'Dados excluídos'
END
GO
----------------------------------------------------------------------------------------
--PROCEDIMENTO DE LOGIN
create proc login(
@nome varchar (30),
@cpf varchar (50),
@msg varchar (100) output
)
as
begin
if(not exists(select * from funcionarios where nome = @nome and cpf = @cpf))
set 
@msg = 'Dados incorretos'
else
begin
set
@msg = 'Bem Vindo ao Sistema ' + @nome
end
end
go

--Procedimento valor produto
create proc buscar_valor (
@id_produto int
)
as
begin
select valor from produtos where id_produto = @id_produto
end 
go


--Procedimento salvar venda

CREATE PROCEDURE sp_salvarvenda
@num_vendas int,
@id_produto int,
@id_cliente int ,
@quantidade int ,
@valor decimal (10, 2),
@funcionario varchar (50),
@mensagem VARCHAR (100) OUTPUT,
@data_venda DATETIME
AS
BEGIN

INSERT INTO vendas VALUES (@num_vendas, @id_produto, @id_cliente, @quantidade, @valor, @funcionario, @mensagem, @data_venda )
SET @mensagem = 'Produto registrado com sucesso'
END

GO

CREATE PROC sp_excluirvenda
@id_vendas int,
@mensagem varchar (100) output
AS
BEGIN
DELETE vendas WHERE id_vendas = @id_vendas
SET @mensagem = 'Dados excluídos'
END
GO

CREATE PROC sp_buscarvenda
@num_venda int
AS
BEGIN
SELECT * FROM vendas WHERE num_vendas LIKE @num_venda + '%'
END
GO