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

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
