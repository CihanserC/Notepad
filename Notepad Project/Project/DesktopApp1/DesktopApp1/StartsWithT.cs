using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1
{
    public class startsWithT : ItemInterface
    {
        public string[] getSpesItem(string v)
        {
            string[] a = new string[v.Split(' ').Length];
            int i = 0;
            foreach (String s in v.Split(' '))
            {
                if (s.Length > 0)
                {
                    if (s[0] == 'T')
                    {
                        a[i] = s;
                        i++;
                    }
                }

            }
            return a;
        }
    }
}
