
CREATE DATABASE [Curso]

USE [Curso]

-- Apaga a tabela Aluno se existir
DROP TABLE IF EXISTS [Aluno]

-- Criação da tabela Aluno
CREATE TABLE [Aluno](
    [Id] INT NOT NULL IDENTITY(1,1),
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL UNIQUE,
    [Nascimento] DATETIME NULL,
    [Active] BIT NOT NULL DEFAULT(0),

    CONSTRAINT [PK_Aluno] PRIMARY KEY([Id]),
)
GO

-- Apaga a tabela Categoria se existir
DROP TABLE IF EXISTS [Categoria]

-- Criação da tabela
CREATE TABLE [Categoria](
    [Id] INT NOT NULL IDENTITY(1,1),
    [Nome] NVARCHAR(80) NOT NULL,

    CONSTRAINT [PK_Categoria] PRIMARY KEY([Id]),
)
GO

-- Apaga a tabela Curso se existir
DROP TABLE IF EXISTS [Curso]

-- Criação da tabela
CREATE TABLE [Curso](
    [Id] INT NOT NULL IDENTITY(1,1),
    [Nome] NVARCHAR(80) NOT NULL,
    [Descricao] NVARCHAR(180) NOT NULL,
    [Active] BIT NOT NULL DEFAULT(0),
    [CategoriaId] INT NOT NULL,

    CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Curso_Categoria] FOREIGN KEY([CategoriaId]) 
        REFERENCES [Categoria]([Id]),
)
GO

-- Apaga a tabela ProgressoCurso se existir
DROP TABLE IF EXISTS [ProgressoCurso]

-- Criação da tabela
CREATE TABLE [ProgressoCurso](
    [AlunoId] INT NOT NULL,
    [CursoId] INT NOT NULL,
    [Progresso] INT NOT NULL DEFAULT(0),
    [UltimaAtualizacao] DATETIME NOT NULL DEFAULT(GETDATE()),

    CONSTRAINT [PK_ProgressoCurso] PRIMARY KEY([AlunoId], [CursoId]),
)
GO

-- Indice para a tabela Aluno
CREATE INDEX [IX_Aluno_Email] ON [Aluno]([Email])

