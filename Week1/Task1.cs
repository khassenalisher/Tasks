using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        // создаем функцию которая будет проверять является ли данное число простым
        // если простое то будет возвращать тrue
        // иначе false
        static bool Prime(string x)
        {
            // так как мы задали х стринговым то нам нужно получить числовое значение
            int a = int.Parse(x);
            int cnt = 0;
            // создаем счетчик который будет увеличиваться каждый раз когда каждый раз находим
            //делитель данного числа, для этого мы пробигаемся от 1 до данного числа включительно 
            // соответсвеено если данный счетчик будет равен 2 то данное число ПРОСТОЕ
            // этот код можно доработать но на данный момент я его оставлю таким
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    cnt++;
                }
            }
            if (cnt == 2) return true;
            else
                return false;

        }
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i)
            {
                if (Prime(args[i]))
                {
                    Console.WriteLine(args[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
