 /* Day 2*/
 
 SELECT Count(ProductSubcategoryID)
 FROM Production.Product 
 

SELECT ProductSubcategoryID, Count(ProductSubcategoryID)as "Counted Products"
From Production.Product 
Group By ProductSubcategoryID


SELECT Count(ISNULL(ProductSubcategoryID,0))as "Counted NULL Products"
From Production.Product 
WHERE ProductSubcategoryID is null


SELECT ProductID,Shelf, AVG(Quantity) as "TheAvg"
FROM Production.ProductInventory
WHERE Shelf not like '%N/A%' 
Group By ProductID,Shelf
Order by Shelf


SELECT Color, Class, AVG(ListPrice) as "AvgPrice"
FROM Production.Product
WHERE Color is not null AND Class is not null
Group By Color, Class


SELECT c.Name as "Country" , s.Name as "Province"
FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name in ('Germany','Canada')

SELECT p.ProductName
FROM Products p JOIN [Order Details] od ON od.ProductID = p.ProductID JOIN Orders o ON od.OrderID= o.OrderID
WHERE o.OrderDate >=  DATEADD(YEAR, -25,getDate())
Group By p.ProductName
Order By p.ProductName

SELECT o.ShipCity, Count(o.CustomerID) as "Number of Customers"
FROM Products p JOIN [Order Details] od ON od.ProductID = p.ProductID JOIN Orders o ON od.OrderID= o.OrderID
Group by o.ShipCity
HAVING Count(o.CustomerID) > 2
Order by Count(o.CustomerID) DESC


SELECT c.CustomerID, Count(p.ProductName) as "Count of Products"
FROM Customers c JOIN Orders o ON c.CustomerID =  o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID  JOIN Products p ON od.ProductID= p.ProductID
Group By c.CustomerID
HAVING  Count(p.ProductName) > 100


SELECT DISTINCT s.CompanyName AS "Supplier Company name" , sh.CompanyName AS "Shipping Company name"
FROM Suppliers s JOIN Products p ON s.SupplierID = p.SupplierID  JOIN [Order Details] od ON od.ProductID = p.ProductID JOIN Orders o ON od.OrderID= o.OrderID JOIN Shippers sh ON o.ShipVia =sh.ShipperID


SELECT  o.OrderDate, p.ProductName
FROM Products p LEFT JOIN [Order Details] od ON od.ProductID = p.ProductID JOIN Orders o ON od.OrderID= o.OrderID
Order by o.OrderDate


SELECT DISTINCT e1.FirstName + ' ' + e1.LastName AS "Employee1", e2.FirstName + ' ' + e2.LastName AS "Employee2", e1.Title 
FROM Employees e1 join Employees e2 ON e1.Title= e2.Title
WHERE e1.FirstName != e2.FirstName



SELECT IsNull(m.FirstName + ' ' + m.LastName, 'N/A') AS ManagerName, Count(e.EmployeeID) AS "Num of Employees Reporting" 
FROM Employees m LEFT JOIN Employees e ON e.ReportsTo = m.EmployeeID
Group By IsNull(m.FirstName + ' ' + m.LastName, 'N/A') 
HAVING Count(e.EmployeeID)>2

SELECT c.City, c.CompanyName as "Name",c.ContactName as "Contact Name", 'Customers' as Type
FROM Customers c
UNION
SELECT s.City, s.CompanyName as "Name",s.ContactName as "Contact Name", 'Suppliers' as Type
FROM Suppliers s
