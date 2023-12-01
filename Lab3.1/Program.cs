using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y;
            for (double x = 0.1; x<=1; x+= (1-0.1)/10)
            {
                double cos = Math.Cos(x);
                y = 2 * (cos * cos - 1);
                Console.WriteLine($"x = {x} y = {y}");
            }

            Console.ReadLine();

        }
    }
}
