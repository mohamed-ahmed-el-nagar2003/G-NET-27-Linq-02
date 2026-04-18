using System.Collections.Generic;
using System.Diagnostics;

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
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
