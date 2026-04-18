using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace linq_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q_01
            //1. Get top 3 most expensive products
            //   var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            #endregion

            #region Q_02
            //2. show page 2 of products, with page size = 5
            //var result = Source.ProductList.Skip(5).Take(5);

            #endregion

            #region Q_03
            //Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //var result = Source.ProductList.TakeWhile(p => p.UnitPrice <25).OrderBy(p => p.UnitPrice);

            #endregion

            #region Q_04
            //4. Check if ALL products in the "Seafood" category are in stock
            //var res = Source.ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            //Console.WriteLine(res);
            #endregion

            #region Q_05
            //5. Check if the ID list contains 9
            //var res = Source.ProductList.Any(p => p.ProductID == 9);
            //Console.WriteLine(res);
            #endregion

            #region Q_06
            //Group all products by Category and print each group with its product count.
            //var res = Source.ProductList.GroupBy(p => p.Category);
            //foreach (var group in res)
            //{
            //    Console.WriteLine($"{group.Key}   contain {group.Count()} products");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region Q_07
            //Group products by Category and project only product names per group
            //var res = Source.ProductList.GroupBy(p => p.Category);
            //foreach (var group in res)
            //{
            //    Console.WriteLine(group.Key );
            //   Console.WriteLine("-------------------");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item.ProductName);
            //    }
            //    Console.WriteLine("===============================================");
            //}
            #endregion

            #region Q_08
            //8. Find all categories that have MORE THAN 3 products
            // var result = Source.ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3).Select(g => g.Key);
            #endregion

            #region Q_09
            //9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.
            //var result =
            // from c in Source.CustomerList
            // group c by c.Country into g
            // select new
            // {
            //     Country = g.Key,
            //     Count = g.Count(),
            //     TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            // };
            #endregion

            #region Q_10
            //10. Calculate the total number of units in stock across all products
            //var totalUnits = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(totalUnits);
            #endregion

            #region Q_11
            //11. Find the CHEAPEST and MOST EXPENSIVE product prices
            //var cheapestPrice =Source.ProductList.Min(p => p.UnitPrice);
            //Console.WriteLine(cheapestPrice);
            //var mostExpensivePrice =Source. ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine(mostExpensivePrice);
            #endregion

            #region Q_12
            //12. Get a distinct list of all product categories
            //var result = Source.ProductList.Select(p => p.Category).Distinct();


            #endregion

            #region Q_13
            //13. find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);
            #endregion

            #region Q_14
            //14. Find countries that appear in list1 but NOT in list2 (case -insensitive).
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //  string[] list2 = { "france", "SPAIN", "Italy" };
            //
            // var result = list1.Where(c => !list2.Contains(c, StringComparer.OrdinalIgnoreCase));
            #endregion

            #region Q_15
            //15. Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.
            //var dict =Source.ProductList.ToDictionary(p => p.ProductID);

            //var product18 = dict[18];
            //Console.WriteLine(product18);
            #endregion

            #region Q_16
            //16. Get the first product whose price is greater than $50.
            // var result =Source.ProductList.First(p => p.UnitPrice > 50);
            //Console.WriteLine(result);
            #endregion

            #region Q_17
            //17. Try to get the first product with a price > $500. it returns null instead of throwing.
            //var result =Source. ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(result);
            #endregion

            #region Q_18
            //18. Generate a multiplication table row for 7

            //  var result = Enumerable.Range(1, 10).Select(x => $"7 x {x} = {7 * x}");

            #endregion


            #region Q_19
            //19. Generate even numbers between 1 and 30.

            //var result = Enumerable.Range(1, 30).Where(x => x % 2 == 0);
            #endregion

            #region Q_20
            //Concatenate the first 3 product names with the first 3 customer company names into a single sequence.
            // var result = Source.ProductList.Take(3).Select(p => p.ProductName).Concat(Source.CustomerList.Take(3).Select(c => c.CompanyName));

            #endregion

            #region Q_21
            //21. Pair each product with a customer (by position) and produce a string "ProductName sold to CompanyName".
           // var result =Source. ProductList.Zip(Source. CustomerList, (p, c) =>$"{p.ProductName} sold to {c.CompanyName}");

            #endregion

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
 }

