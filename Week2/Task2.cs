using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //нужно для работы с файлами

namespace Task2
{
    class Program
    {
        public static int min=100000, p;
        // создаем функцию которая будет проверять является ли данное число простым и если
        // оно является простым то провермяем является ли оно самым маленьким(из простых)
        // если простое то будет возвращать тrue
        // иначе false
        static bool Prime(string x)
        {
            int a = int.Parse(x);
            int cnt = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    cnt++;
                }
            }
            if (cnt == 2)
            {
                p = a;
                return true;
            }
            else
                return false;

        }
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream(@"C:\Users\User\Desktop\Labs\Week2\Task1.txt", FileMode.Open);
            //созадем потоковый читатель и связываем с файловым потоком
            StreamReader r = new StreamReader(f1);
            //будем считать что все данные вводятся в одной строке и через пробел
            //и прочитаем с помощью стринговой переменной 
            string a = r.ReadLine();


            string l = "";

            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] != ' ')
                {
                    l = l + a[i];
                }
                else
                { 
                    if(Prime(l))
                    {

                        if (p < min)
                            min = p;
                        else l = "";
                    }
                    l = "";
                }
            }
            //Для проверки конечного числа
            if (p < min)
                min = p;
            r.Close();
            f1.Close();
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
