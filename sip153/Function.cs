using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sip153
{
    static class Function
    {
        static public string GenerateNumber()
        {
            Random rnd = new Random();
            string number = "";
            int c;
            for (int i = 0; i < 4; )
            {
                c = rnd.Next(1, 10);
                if (!number.Contains(c.ToString()))
                {
                    number += c;
                    i++;
                }
            }
            return number;
        }

        static public string CheckAnswer(string c, string d)
        {
            string ans = "";
            if (string.IsNullOrEmpty(c))
                return "";
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    if (c[i] == d[i])
                        ans += "Бык";
                    else if (d.Contains(c[i]))
                        ans += "Корова";
                }
                return ans;
            }
            catch (IndexOutOfRangeException)
            {
                return "";
            }
            
        }
    }
}
