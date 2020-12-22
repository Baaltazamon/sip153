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
            string str;
            do
            {
                str = Console.ReadLine();
            } while (string.IsNullOrEmpty(str));
            
            
            Console.WriteLine(Function.ReverseText(str));
            Console.ReadKey();
        }

        
    }
}
