using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Uravnenie
{
    class Uravnenie
    {
        double k;
        double b;
        public double K
        {
            set
            {
                if (value != 0)
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
                if (value != 0)
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
            double x = -(b) / k;
            Console.WriteLine("x = {0}", Math.Round(x, 2));
        }
    }
}
