using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    class LCPrint: IStrategy 
    {
        public string Change(string str)
        {

            string str_out = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    str_out += '_';
                else
                    str_out += str[i];
            }

            str_out = str_out.ToLower();

            return str_out;
        }
    }
}
