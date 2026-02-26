
BULK INSERT dbo.Product
FROM 'C:\Users\TONY\Downloads\Compressed\tech_50k.csv'
WITH (
    DATAFILETYPE = 'char',
    FIELDTERMINATOR = ',',  -- use ',' for CSV files
    ROWTERMINATOR = '\n',   -- use '\n' for new lines
    FIRSTROW = 2,           -- skip header row if one exists
    BATCHSIZE = 5000,
    TABLOCK                 -- improves performance
);
