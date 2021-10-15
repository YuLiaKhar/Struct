using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 = k * x + b");
            Uravnenie uravnenie = new Uravnenie(3,4);
            uravnenie.WriteUravnenie();
            uravnenie.Root();
            Console.WriteLine();
            Uravnenie uravnenie1 = new Uravnenie(0, 6);
            uravnenie1.WriteUravnenie();
            uravnenie1.Root();
            Console.ReadKey();
        }
    }
    class Uravnenie
    {
        double k;
        double b;
        public double K
        {
            set
            {
                if (value!=0)
                {
                    k = value;
                }
                else
                {
                    Console.WriteLine("Ошибка. Переменная не может равняться 0");
                    return;
                }
            }
            get
            {
                return k;
            }
        }
        public double B
        {
            set
            {
                if (value!=0)
                {
                    b = value;
                }
                else
                {
                    Console.WriteLine("Ошибка. Переменная не может равняться 0");
                    return;
                }
            }
            get
            {
                return b;
            }
        }
        public Uravnenie(double k, double b)
        {
            K = k;
            B = b;
        }
        public void WriteUravnenie()
        {
            Console.WriteLine("0 = {0} * x + {1}", k, b);
        }
        public void Root()
        {
            double x = -( b )/ k;
            Console.WriteLine("x = {0}", Math.Round(x, 2));
        }
    }
}
