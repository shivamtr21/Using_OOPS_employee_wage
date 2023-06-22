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
            int EMP_WAGE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int result = random.Next(2);


            if (result == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");

                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }

            empWage = empHrs * EMP_WAGE_PER_HOUR;

            Console.WriteLine("Emp Wage : " + empWage);

        }
    }
}
