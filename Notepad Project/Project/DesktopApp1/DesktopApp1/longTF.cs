using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1
{
    class longTF : ItemInterface
    {
        public string[] getSpesItem(string v)
        {
            string[] a = new string[v.Split(' ').Length];
            int i = 0;
            foreach (String s in v.Split(' '))
            {
                if (s.Length > 5)
                {

                        a[i] = s;
                        i++;
                }

            }
            return a;
        }
    }
}

