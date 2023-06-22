using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_OOPS_Employee_Wage
{
    public class EmpWage
    {
        public void Wage()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();

            int result = random.Next(2);


            if (result == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
