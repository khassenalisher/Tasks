using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Complex
    {
        int a;
        int b;
        public Complex(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public static Complex operator +(Complex C1, Complex C2)
        {
            Complex res = new Complex(0, 0);

            res.a = C1.a + C2.a;
            res.b = C1.b + C2.b;
            return res;
        }
        public override string ToString()
        {
            return string.Format("{0}+{1}i",a,b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 4);
            Complex c2 = new Complex(2, 7);
            Console.WriteLine(c1 + c2);
            Console.ReadKey();
        }
    }
}
