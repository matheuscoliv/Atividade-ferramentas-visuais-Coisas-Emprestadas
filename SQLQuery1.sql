CREATE TABLE Emprestimos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Item NVARCHAR(100) NOT NULL,
    DataEmprestimo DATE NOT NULL,
    NomeAmigo NVARCHAR(100) NOT NULL,
    ContatoAmigo NVARCHAR(50) NULL,
    DataCombinadaDevolucao DATE NOT NULL,
    DataDevolucaoReal DATE NULL
);