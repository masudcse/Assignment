using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stAssignment
{
    class Loop
    {
        int x = 5;
        int y = 0;
        public void ForExample()
        {
           
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void WhileExmaple()
        {
            while (x > y)
            {
                y++;
            }
        }

        public void doWhileExample()
        {
            do
            {
                Console.WriteLine(y);
                y++;
            } while (x > y);
        }

        public void ForeachExample()
        {
            string[] Names = new string[12];
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
        }
    
    }
}
