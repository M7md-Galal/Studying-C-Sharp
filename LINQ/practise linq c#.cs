// Find all products that are out of stock
var outOfStockProducts = ProductList.Where(p => p.UnitsInStock == 0);
foreach (var product in outOfStockProducts)
    Console.WriteLine(product.ProductName);

// Find all products that are in stock and cost more than 3.00 per unit
var expensiveInStockProducts = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);
foreach (var product in expensiveInStockProducts)
    Console.WriteLine(product.ProductName);


// Returns digits whose name is shorter than their value.
String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
var shortDigits = Arr.Where((digit, Index) => digit.Length > Index);
foreach (var digit in shortDigits)
    Console.WriteLine($"The digit {digit} is shorter than its value.");


// Get first Product out of Stock 
var firstOutOfStockProduct = ProductList.First(p => p.UnitsInStock == 0);
Console.WriteLine(firstOutOfStockProduct.ProductName);


// Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
var firstExpensiveProduct = ProductList.FirstOrDefault(p => p.UnitPrice > 1000) ?? new Product { ProductName = "No products with a price greater than 1000" };
Console.WriteLine(firstExpensiveProduct.ProductName);


// Uses Count to get the number of odd numbers in the array
int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
int oddNumbers = Arr.Count(n => n % 2 == 1);


// Return a list of customers and how many orders each has.
var customerOrderCount = CustomerList.Select(c => new { c.CustomerID, OrderCount = c.Orders.Length });
foreach (var item in customerOrderCount)
    Console.WriteLine($"Customer {item.CustomerID} has {item.OrderCount} orders.");



// Sort a list of products by name
var sortedProducts = ProductList.OrderBy(p => p.ProductName);
foreach (var product in sortedProducts)
    Console.WriteLine(product.ProductName);

