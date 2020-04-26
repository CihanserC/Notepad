using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1
{
    class palindrome : ItemInterface
    {
        public string[] getSpesItem(string v)
        {
            String[] withSplit = v.Split(' ');
            int count = 0;
            string[] a = new string[withSplit.Length];
            foreach (String s in withSplit)
            {
                char[] ch = s.ToCharArray();

                Array.Reverse(ch);
                string rev = new string(ch);

                if (s.Equals(rev, StringComparison.OrdinalIgnoreCase))
                {
                    a[count] = s;
                    count++;
                }
            }
            return a;
        }
    }
}
