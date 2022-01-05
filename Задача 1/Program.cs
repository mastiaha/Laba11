using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение первого коэффициента");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение второго коэффициента");
            double b = Convert.ToDouble(Console.ReadLine());
            Linejnoe linejnoe = new Linejnoe(k, b);
            Console.WriteLine(linejnoe.Root());
            Console.ReadKey();
        }
    }
}
