using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Using_OOPS_Employee_Wage
{
    public class EmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public void Wage()
        {
           

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for(int day = 0; day <NUM_OF_WORKING_DAYS; day++)
            {


                Random random = new Random();

                int result = random.Next(3);


                switch (result)
                {
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is present for part time");
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is present for full time");
                        empHrs = 8;
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;
                }

                empWage = empHrs * EMP_WAGE_PER_HOUR;
                totalEmpWage += empWage;

                Console.WriteLine("Emp Wage : " + empWage);

            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
 





        }
    }
}
