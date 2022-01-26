Use AdventureWorks2019
  go

/* 1.  */
SELECT ProductID, Name, Color, ListPrice FROM Production.Product

/* 2. */
SELECT ProductID, Name, Color, ListPrice FROM Production.Product
WHERE ListPrice != 0 

/* 3. */
SELECT ProductID, Name, Color, ListPrice FROM Production.Product
WHERE Color Is Null 

/* 4. */
SELECT ProductID, Name, Color, ListPrice FROM Production.Product
WHERE Color Is not Null 

/* 5. */
SELECT ProductID, Name, Color, ListPrice FROM Production.Product
WHERE Color Is not Null AND ListPrice >0

/* 6. & 7.*/
SELECT Name, Color FROM Production.Product
WHERE Color Is not Null 

/* 8. */
SELECT ProductID, Name FROM Production.Product
WHERE ProductID between 400 AND 500

/* 9. */
SELECT ProductID, Name, Color FROM Production.Product 
WHERE Color in ('Black','Blue')

/* 10. */
SELECT * FROM Production.Product 
WHERE Name like 'S%'

/* 11. */
SELECT Name, ListPrice FROM Production.Product 
WHERE Name like 'S%'
Order by Name

/* 12. */
SELECT Name, ListPrice FROM Production.Product 
WHERE Name like '[AS]%'
Order by Name

/* 13. */
SELECT Name, ListPrice FROM Production.Product 
WHERE Name like '[SPO]%' AND Name not like '%K%'
Order by Name

/* 14. */
SELECT DISTINCT Color FROM Production.Product
Order by Color desc

/* 15. */
SELECT DISTINCT ProductSubcategoryID, Color FROM Production.Product
WHERE Color is not Null AND ProductSubcategoryID is not Null
