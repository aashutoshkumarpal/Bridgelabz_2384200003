using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSpanProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockSpan stockSpan = new StockSpan();
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
            int[] result = stockSpan.CalculateStockSpan(prices);

            Console.WriteLine("Stock Prices: " + string.Join(", ", prices));
            Console.WriteLine("Stock Spans:  " + string.Join(", ", result));
        }
    }
}
