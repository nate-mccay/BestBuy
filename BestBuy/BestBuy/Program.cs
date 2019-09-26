using System;

namespace BestBuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Mac = new Product();
            Mac.Name = "Mac";
            Mac.Price = 999;
            Console.WriteLine($"{Mac.Name} {Mac.Price} {Mac.PriceWithTax()}");
        }
    }
}
