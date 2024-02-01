SELECT TOP (100)
    [Id]
  , [Tag]
  , [Title]
  , [Url]
  , [Summary]
  , [Category]
  , [Author]
FROM vwCourse
ORDER BY [CreateDate] DESC