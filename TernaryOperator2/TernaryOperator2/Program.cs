using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator2
{
    class Program
    {
        static string BravoNoBravo(int x)
        {
            return (x > 10) ? "Bravo" : "No Bravo";
        }
        static void Main(string[] args)
        {
            int i = 10;
            string result;
            if (i > 10)
            {
                result = "Bravo";
            }
            else
            {
                result = "Try again";
            }

            Console.WriteLine(result);

            Console.WriteLine("----------------------");
            int j = 12;
            string message = (j > 10) ? "Bravo" : "No bravo";
            Console.WriteLine(message);

            Console.WriteLine("----------------------");
            //int a = 5;
            Console.WriteLine(BravoNoBravo(5));

        }
    }
}
