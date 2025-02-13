using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularTourProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularTour solver = new CircularTour();
            int[] petrol = { 4, 6, 7, 4 };
            int[] distance = { 6, 5, 3, 5 };
            int result = solver.FindStartingPump(petrol, distance);

            if (result == -1)
                Console.WriteLine("No valid starting pump found.");
            else
                Console.WriteLine("Starting pump index: " + result);
        }
    }
}
