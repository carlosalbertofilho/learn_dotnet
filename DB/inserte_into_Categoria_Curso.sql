USE [Curso]
-- Insert into Categoria and Curso tables

INSERT INTO [Categoria]
    ([Nome])
VALUES('Backend')
INSERT INTO [Categoria]
    ([Nome])
VALUES('Frontend')
INSERT INTO [Categoria]
    ([Nome])
VALUES('Mobile')

INSERT INTO [Curso]
    ([Nome], [Descricao], [Active], [CategoriaId])
VALUES('Fundomentos de c#', 'Iniciante', 1, '1')
INSERT INTO [Curso]
    ([Nome], [Descricao], [Active], [CategoriaId])
VALUES('Fundamentos OOP', 'Iniciante', 1, '1')
INSERT INTO [Curso]
    ([Nome], [Descricao], [Active], [CategoriaId])
VALUES('Angula', 'Intermediario', 1, '2')
INSERT INTO [Curso]
    ([Nome], [Descricao], [Active], [CategoriaId])
VALUES('Flutter', 'Intermediario', 1, '3')