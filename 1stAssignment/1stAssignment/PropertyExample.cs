using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stAssignment
{
    class PropertyExample
    {

        public void Property()
        {
            var _objSalary = new Salary();
            _objSalary.SalaryAmount = 12000;
        }
    }

    class Salary
    {
        public double SalaryAmount { get; set; }//Property Declaration we can set logic or condition within get
    }
}
