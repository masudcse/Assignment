using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stAssignment
{
   public class Operator
    {
       int x, y,z;

       public void OperatorFunction()
       {
           z = x + y; //addition
           z = x - y;//subtract
           z = x / y;//division
           z = x % y;//module
           z = x * y;//multiply
           z = x >> y;
           z = x << y;
           if (x > y)
           {

           }
           if (x > y)
           {

           }
           if (x < y)
           {

           }
           if (x != y)
           {

           }
           z = x & y;
           z = x | y;

           bool a=true;
           bool b=false;
           bool c = a && b;

           string Name = "Masud";
           string ss = Name ?? "null";

           x++;
           x--;
           --x;
           ++x;
           z = x++ * 5;
           Console.WriteLine(z);
           z = x-- * 5;
           Console.WriteLine(z);
       }
    }
}
