using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stAssignment
{
    class IFCondition
    {
        public void IFCondition()
        {
            int x = 5;
            int y = 6;
            if (x > y)
            {
                Console.WriteLine(x);
            }
            if (x < y)
            {
                Console.WriteLine(y);
            }
            else if (x == 6)
            {
                Console.WriteLine(x);
            }

        }
    }
}
