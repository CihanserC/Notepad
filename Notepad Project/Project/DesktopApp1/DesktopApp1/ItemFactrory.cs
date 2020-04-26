using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1
{
    class ItemFactrory
    {
          public ItemInterface GetInterface(string command)
        {
            if (command == null)
            {
                return null;
            }else if (command.Equals("Words"))
            {
                return new Words();
            }
            else if (command.Equals("Lines"))
            {
                return new Lines();
            }else if (command.Equals("Characters"))
            {
                return new Characters();
            }else if (command.Equals("T"))
            {
                return new startsWithT();
            }else if (command.Equals("longThanFive"))
            {
                return new longTF();
            }else if (command.Equals("palindrome"))
            {
                return new palindrome();
            }
            return null;
        }
    }
}
