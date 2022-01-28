/* DAY 3 */
Select DISTINCT City
From Customers 
Where City Not In (select City from Employees)

Select c.CustomerId, c.City, o.City 
From Customers c Left Join Employees o On c.City = o.City
WHERE o.City IS NULL


SELECT p.ProductName, SUM(od.Quantity) as"Total Order Quantities"
FROM Products p LEFT JOIN [Order Details] od ON od.ProductID = p.ProductID JOIN Orders o ON od.OrderID= o.OrderID
Group By p.ProductName

SELECT c.City , Count(p.ProductName) as "Count of Products"
FROM Customers c JOIN Orders o ON c.CustomerID =  o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID  JOIN Products p ON od.ProductID= p.ProductID
Group By c.City


SELECT  c1.city, Count(DISTINCT c1.CustomerID)
FROM Customers c1
GROUP by c1.city
HAVING Count(DISTINCT c1.CustomerID) >=2


SELECT DISTINCT c.ContactName
FROM Customers c JOIN Orders o ON c.CustomerID =  o.CustomerID
WHERE c.City not in (SELECT o.ShipCity FROM Orders)


SELECT PopProducts.ProductName, [Average Price], [Quantity Ordered] FROM(
	SELECT TOP 50  c.City, p.ProductName, AVG(p.UnitPrice) as "Average Price", SUM(od.Quantity) as"Quantity Ordered"
	FROM Customers c JOIN Orders o ON c.CustomerID =  o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID  JOIN Products p ON od.ProductID= p.ProductID
	Group by p.ProductName, c.City
	Order by SUM(od.Quantity) desc
) AS PopProducts



SELECT *
FROM Customers c left JOIN Orders o ON c.CustomerID =  o.CustomerID  LEFT JOIN Employees e ON o.EmployeeID = e.EmployeeID
WHERE o.OrderID is null 


SELECT * FROM(
	SELECT TOP 20 o.ShipCity, e.EmployeeID, Count(o.ShipCity) as "Orders Sold By Employee" 
	FROM Orders o LEFT JOIN Employees e ON o.EmployeeID = e.EmployeeID
	Group By e.EmployeeID ,o.ShipCity
	Order By Count(o.ShipCity) desc
) AS Sub1

INNER JOIN
(
	SELECT TOP 20 o.EmployeeID, Count(od.Quantity) as "Quantity of Products Ordered" 
	FROM Customers c LEFT  JOIN Orders o ON c.CustomerID =  o.CustomerID LEFT  JOIN [Order Details] od ON o.OrderID = od.OrderID 
	Group By o.EmployeeID
	Order By  Count(od.Quantity) desc
) AS Sub2
ON sub1.EmployeeID = Sub2.EmployeeID
