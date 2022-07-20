USE DatabaseName;  
GO  
CREATE PROCEDURE InvertRecordNotNull
    @Id INT,   
    @ColName CHAR(1)
AS   
    SET NOCOUNT ON;  

    UPDATE TableName  
    SET @ColName = ~@ColName
    WHERE Id = @Id AND @ColName IS NOT NULL;
GO  