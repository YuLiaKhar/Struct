using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 = k * x + b");
            Console.WriteLine();
            Uravnenie uravnenie = new Uravnenie { k = 3, b = 4 };
            uravnenie.WriteUravnenie();
            uravnenie.Root();
            Console.WriteLine();
            Uravnenie uravnenie1 = new Uravnenie{k = 4, b = 12};
            uravnenie1.WriteUravnenie();
            uravnenie1.Root();
            Console.ReadKey();
        }
        struct Uravnenie
        {
            public double k;
            public double b;
            public double x;
            public void WriteUravnenie()
            {
                Console.WriteLine("0 = {0} * x + {1}", k, b);
            }
            public void Root()
            {
                x = -b / k;
                Console.WriteLine("x = {0}", Math.Round(x, 2));
            }
        }
    }
}
