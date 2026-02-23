BULK INSERT dbo.Product
FROM 'C:\Users\TONY\Downloads\Compressed\data1.csv'
WITH (
    DATAFILETYPE = 'char',
    FIELDTERMINATOR = ',',  -- use ',' for CSV files
    ROWTERMINATOR = '\n',   -- use '\n' for new lines
    FIRSTROW = 2,           -- skip header row if one exists
    TABLOCK                 -- improves performance
);