using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var Stack = new Stack<int>();
            //Алгоритм Евклида вычитание большего от меньшего
            while (a != b)
            {
                Stack.Push(a);
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            //Добавялем в стэк значение "а" в последний раз который и является ответом
            Stack.Push(a);
            Console.WriteLine(Stack.Peek());


            Console.ReadKey();
        }
    }
}
