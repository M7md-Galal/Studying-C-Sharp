using Study_Linq.Data;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using static Study_Linq.ListGenerators;
namespace Study_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Study
            //LINQ Execution
            // Deffered Execution (Latest Update Of Data)
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var EvenNumbers = Numbers.Where(x => x % 2 == 0);
            Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            foreach (var item in EvenNumbers)
                Console.WriteLine(item);


            // Immediate Execution
            // Element Operators , Casting Operators , Aggregation Operators

            //Using Casting For Converting Deffered Executing LINQ Operators
            List<int> NumbersImmediate = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var EvenNumbersImmediate = NumbersImmediate.Where(x => x % 2 == 0).ToList();
            NumbersImmediate.AddRange(new int[] { 11, 12, 13, 14, 15 });
            foreach (var item in EvenNumbersImmediate)
                Console.WriteLine(item);


            //Using Element Operators
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // First: Returns the first element of a sequence
            int first = numbers.First();
            Console.WriteLine($"First: {first}");

            // FirstOrDefault: Returns the first element of a sequence, or a default value if no element is found
            int firstOrDefault = numbers.FirstOrDefault();
            Console.WriteLine($"FirstOrDefault: {firstOrDefault}");

            // Last: Returns the last element of a sequence
            int last = numbers.Last();
            Console.WriteLine($"Last: {last}");

            // LastOrDefault: Returns the last element of a sequence, or a default value if no element is found
            int lastOrDefault = numbers.LastOrDefault();
            Console.WriteLine($"LastOrDefault: {lastOrDefault}");

            // Single: Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence
            int single = numbers.Single(x => x == 5);
            Console.WriteLine($"Single: {single}");

            // SingleOrDefault: Returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence
            int singleOrDefault = numbers.SingleOrDefault(x => x == 5);
            Console.WriteLine($"SingleOrDefault: {singleOrDefault}");

            // ElementAt: Returns the element at a specified index in a sequence
            int elementAt = numbers.ElementAt(3);
            Console.WriteLine($"ElementAt: {elementAt}");

            // ElementAtOrDefault: Returns the element at a specified index in a sequence, or a default value if the index is out of range
            int elementAtOrDefault = numbers.ElementAtOrDefault(20);
            Console.WriteLine($"ElementAtOrDefault: {elementAtOrDefault}");

            Console.WriteLine(ProductList[0]);
            Console.WriteLine(CustomerList[0]);

            for (int i = 0; i < ProductList.Count; i++)
                Console.WriteLine(ProductList[i]);

            for (int i = 0; i < CustomerList.Count; i++)
                Console.WriteLine(CustomerList[i]);


            var products = ProductList.Where(x => x.UnitsInStock == 0);
            foreach (var item in products)
                Console.WriteLine(item);

            var customers = from c in CustomerList
                            where c.City == "London"
                            select c;

            foreach (var item in customers)
                Console.WriteLine(item);

            //Indexed Where(Vaild only with fluent syntax)
            var indexedWhereRes = ProductList.Where((x, i) => i < 10 && x.UnitsInStock == 0);

            foreach (var item in indexedWhereRes)
                Console.WriteLine(item);


            // Transformation Operators
            var transformationRes = ProductList.Select(x => x.ProductName);

            foreach (var item in transformationRes)
                Console.WriteLine(item);

            var transformationResQuery = from p in ProductList
                                         select p.ProductName;

            foreach (var item in transformationResQuery)
                Console.WriteLine(item);


            //var res = CustomerList.Where(x => x.Address == "Cario").SelectMany(x => x.Orders);
            var selectManyRes = CustomerList.SelectMany(x => x.Orders);

            foreach (var item in selectManyRes)
                Console.WriteLine(item);


            var selectManyResQuery = from c in CustomerList
                                     from o in c.Orders
                                     select o;

            foreach (var item in selectManyResQuery)
                Console.WriteLine(item);

            var anonymousTypeRes = ProductList.Select(P => new { P.ProductID, P.ProductName });

            foreach (var item in anonymousTypeRes)
                Console.WriteLine(item.ProductID + " " + item.ProductName);


            var anonymousTypeResQuery = from p in ProductList
                                        select new
                                        {
                                            ProductID = p.ProductID,
                                            ProductName = p.ProductName
                                        };

            foreach (var item in anonymousTypeResQuery)
                Console.WriteLine(item.ProductID + " => " + item.ProductName);


            var discount = ProductList.Where(p => p.UnitsInStock > 0)
                                 .Select(p => new
                                 {
                                     ProductID = p.ProductID,
                                     ProductName = p.ProductName,
                                     OldPrice = p.UnitPrice,
                                     newPrice = p.UnitPrice - (p.UnitPrice * 0.1M)
                                 });

            foreach (var item in discount)
                Console.WriteLine("ProductID " + item.ProductID + " => ProductName " + item.ProductName + " => OldPrice " + item.OldPrice + " =>  NewPrice " + item.newPrice);


            var discountQuery = from p in ProductList
                                where p.UnitsInStock > 0
                                select new
                                {
                                    ProductID = p.ProductID,
                                    ProductName = p.ProductName,
                                    OldPrice = p.UnitPrice,
                                    newPrice = p.UnitPrice - (p.UnitPrice * 0.1M)
                                };

            foreach (var item in discountQuery)
                Console.WriteLine("ProductID " + item.ProductID + " => ProductName " + item.ProductName + " => OldPrice " + item.OldPrice + " =>  NewPrice " + item.newPrice);

            //Indexed Select (Valid only Fluent syntax)
            var indexedSelectRes = ProductList.Where(p => p.UnitsInStock > 0).Select((p, i) => new { Index = i, ProductName = p.ProductName });

            foreach (var item in indexedSelectRes)
                Console.WriteLine("Index " + item.Index + " => ProductName " + item.ProductName);



            var orderedRes = ProductList.OrderBy(p => p.UnitPrice);
            orderedRes = ProductList.OrderBy(p => p.UnitPrice).ThenBy(p => p.UnitsInStock);
            orderedRes = ProductList.OrderByDescending(p => p.UnitPrice);

            foreach (var item in orderedRes)
                Console.WriteLine(item);


            var orderedResQuery = from p in ProductList
                                  orderby p.UnitPrice
                                  select p;

            var orderedResQueryDesc = from p in ProductList
                                      orderby p.UnitPrice descending
                                      select p;

            var orderedResQueryMultiple = from p in ProductList
                                          orderby p.UnitPrice, p.UnitsInStock
                                          select p;

            var firstProduct = ProductList.First();
            var lastProduct = ProductList.Last();
            Console.WriteLine(firstProduct.ProductName);
            Console.WriteLine(lastProduct.ProductName);

            List<Product> productsList = new List<Product>();

            var firstProductInList = productsList.FirstOrDefault();
            if (firstProductInList != null)
            {
                Console.WriteLine(firstProductInList.ProductName);
            }
            else
            {
                Console.WriteLine("No products found.");
            }

            // Aggregation Operators
            decimal totalProductPrice = ProductList.Sum(p => p.UnitPrice);
            Console.WriteLine($"Total Product Price: {totalProductPrice:C}");

            decimal averageProductPrice = ProductList.Average(p => p.UnitPrice);
            Console.WriteLine($"Average Product Price: {averageProductPrice:C}");

            int productCountInStock = ProductList.Count(p => p.UnitsInStock > 0);
            Console.WriteLine($"Count of Products in Stock: {productCountInStock}");

            decimal minProductPrice = ProductList.Min(p => p.UnitPrice);
            Console.WriteLine($"Minimum Product Price: {minProductPrice:C}");

            decimal maxProductPrice = ProductList.Max(p => p.UnitPrice);
            Console.WriteLine($"Maximum Product Price: {maxProductPrice:C}");

            decimal totalOrderValue = CustomerList.Sum(c => c.Orders.Sum(o => o.Total));
            Console.WriteLine($"Total Order Value: {totalOrderValue:C}");

            string allProductNames = ProductList.Aggregate("", (current, product) => current + product.ProductName + ", ");
            Console.WriteLine($"All Product Names: {allProductNames.TrimEnd(',', ' ')}");
            #endregion

        }
    }
}
