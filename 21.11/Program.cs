using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using help;

namespace _21._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 func = new Class1();
            Console.WriteLine("Введите имя");
            func.Hello(Console.ReadLine());
            Console.WriteLine("Введите возраст");
            Console.WriteLine($"Через 18 лет вам будет {func.Age(Convert.ToInt32(Console.ReadLine()))}");
        }
    }
}
