using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Rec_
{
    class Program
    {
        // Созадем функцию для нахождения наибольшего общего делителя двух заданных чисел
        static int Rec(int n,int m)
        {
            int l;
            if (n == 0)
            {
                Console.WriteLine(m);
                return 0;
            }
            else Console.Write("");//Спросить про Else
            if(n>m)
            {
                l = m;
                m = n;
                n = l;
            }
            else Console.Write("");
            Rec(m - n, n);
            return 0;
        }
        static void Main(string[] args) 
        {
            //Вызываем функцию для нахождения наибольшегго общего делителя
            Rec(25, 100);
            Console.ReadKey();    
        }
    }
}
