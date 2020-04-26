using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1
{
    public class Lines : ItemInterface
    {


        public string[] getSpesItem(string Item)
        {
            return Item.Split('\n');
        }

   
    }
}
