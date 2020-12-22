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
            string numb = Function.GenerateNumber();
            int trying = 7;
            //Console.WriteLine(numb);
            string result;
            do
            {
                string g = Console.ReadLine();
                if (g.Length > 4)
                    g = g.Substring(0, 4);
                result = Function.CheckAnswer(g, numb);
                Console.WriteLine(result);
                trying--;
            } while (result != "БыкБыкБыкБык" && trying > 0);
            if (trying == 0)
            {
                Console.WriteLine("Попытки закончились!");
            }
            else
                Console.WriteLine("Поздравляю");
            Console.ReadKey();
        }

        
    }
}
