SELECT DISTINCT buyers.CustomerID 
FROM buyers
WHERE buyers.ProductName='milk'
EXCEPT
SELECT buyers.CustomerID 
FROM buyers
WHERE buyers.ProductName='sourcream'
AND buyers.PurchaiseDatetime > DATEADD (mm, -1, GETDATE())
