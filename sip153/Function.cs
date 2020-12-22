using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sip153
{
    static class Function
    {
        
      public static string ReverseText(string str)
        {
            string y;
            string z;
            int c;
            for (int i = 0; i < str.Length/2; i++)
            {
                
                c = (str.Length - 1) - i;
                y = str[c].ToString();
                z = str[i].ToString();
                str = str.Remove(i, 1);
                str = str.Remove(c-1, 1);
                str = str.Insert(c-1, z);
                str = str.Insert(i, y);
            }
            return str;
        }
    }
}
