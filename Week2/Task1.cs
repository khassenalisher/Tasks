using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //нужно для работы с файлами

namespace Task1
{
    class Program

    {
        static void Main(string[] args)
        {
            //файловый поток
            FileStream f1 = new FileStream(@"C:\Users\User\Documents\Visual Studio 2015\Projects\Task1W2\Task1W2\MinMax.txt", FileMode.Open);
            //созадем потоковый читатель и связываем с файловым потоком
            StreamReader r = new StreamReader(f1);
            string a = r.ReadLine();

            string l = "";
            long max = -10000000;
            long min = 1000000;
            long x;

            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] != ' ')
                {
                    l = l + a[i];
                }
                else
                {
                    x = int.Parse(l);
                    if (x > max)
                        max = x;
                    else l = "";
                    l = "";
                }
            }
            if (int.Parse(l) > max)
                max = int.Parse(l);
            else l = "";

            l = "";
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] != ' ')
                {
                    l = l + a[i];
                }
                else
                {
                    x = int.Parse(l);
                    if (x < min)
                        min = x;
                    else l = "";
                    l = "";
                }
            }
            x = int.Parse(l);
            if (x < min)
                min = x;

            Console.WriteLine(max);
            Console.WriteLine(min);
            r.Close(); // закрываем поток
            Console.ReadKey();
        }
    }
}

