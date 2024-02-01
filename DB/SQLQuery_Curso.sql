CREATE OR ALTER VIEW vwCursoPorCategoria
AS
    SELECT TOP 10
        [Curso].[Id] AS [CursoId],
        [Curso].[Nome] AS [Curso],
        [Categoria].[Nome] AS [Categoria]
    FROM
        [Curso]
        INNER JOIN
        [Categoria]
        ON 
    [Curso].[CategoriaId] = [Categoria].[Id]
    ORDER BY
    [Curso].[Nome]

