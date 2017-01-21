using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hisogram
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;


            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num <= 199)
                {
                    p1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            Console.WriteLine("{0:0.00}%", 100 * p1 / n);
            Console.WriteLine("{0:0.00}%", 100 * p2 / n);
            Console.WriteLine("{0:0.00}%", 100 * p3 / n);
            Console.WriteLine("{0:0.00}%", 100 * p4 / n);
            Console.WriteLine("{0:0.00}%", 100 * p5 / n);

        }
    }
}
