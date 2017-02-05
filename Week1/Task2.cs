using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public int gpa;
        public string name;
        public string lastname;

        public Student()
        {

        }

        public Student(string lastname, string name, int gpa)
        {
            //присваиваем заданные значения
            this.lastname = lastname;
            this.name = name;
            this.gpa = gpa;
        }

        public override string ToString()
        {
            //возрвращаем заданные значения в нужном виде
            return lastname + " " + name + ": " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Khassen", "Alisher", 3);
            Console.WriteLine(s.ToString());
            Console.ReadKey();
        }
    }
}
