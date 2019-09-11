using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUp_program
{
    class MyLib
    {
        public string getname(string str)
        {
            string name = "";
            int[] tmp = { 0, str.Length };
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals('\\')) tmp[0] = i+1;
                if (str[i].Equals('.')) tmp[1] = i;
            }
            for(int i = tmp[0]; i < tmp[1]; i++) name += str[i];
            return name;
        }
        public string gettime()
        {
            string tmp = DateTime.Now.ToString(), new_name = "_";

            for(int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == '.' || tmp[i] == ' ' || tmp[i] == ':') new_name += "_";
                else new_name += tmp[i];
            }
            return new_name;
        }
    }
}
