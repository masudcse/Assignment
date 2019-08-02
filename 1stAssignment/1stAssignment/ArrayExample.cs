using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stAssignment
{
    class ArrayExample
    {
        public void ArrayMethod()
        {
            int[] ages = new int[10];

            //loop for assigning   array value
            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = int.Parse(Console.ReadLine());//value assign
            }
        }
    }
}
