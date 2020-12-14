using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sip153
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вычисляет сумму вклада");
            Console.WriteLine("Введите сумму вклада");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите срок хранения");
            double term = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент вклада");
            double percent = double.Parse(Console.ReadLine());
            double currentAmount = amount;
            for (int i = 1; i <= term; i++)
            {
                currentAmount +=  currentAmount / 100 * percent;
            }

            Console.WriteLine($"Итоговая сумма через {term} лет — {currentAmount}");


            Console.ReadKey();
        }
    }
}
