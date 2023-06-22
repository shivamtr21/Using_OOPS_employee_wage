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


            int Max_Days = 20;
            int Max_Hours = 100;
            int Wage_Per_hrs = 20;
            int EmpHrs = 0;

            int Total_Wage = 0;

            int Total_Work_Hour = 0;
            int day = 1;

            while (day <= Max_Days && Total_Work_Hour <= Max_Hours)
            {

                Random random = new Random();
                int num = random.Next(0, 3);

                switch (num)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        EmpHrs = 0;
                        break;

                    case 1:
                        Console.WriteLine("Employee is present for part time");
                        EmpHrs = 4;
                        break;

                    case 2:
                        Console.WriteLine("Employee is present for full time");
                        EmpHrs = 8;
                        break;
                }
                day++;
                Total_Work_Hour = (Total_Work_Hour + EmpHrs);

                Total_Wage = (Total_Work_Hour * Wage_Per_hrs);
            }

            Console.WriteLine("Total working hour in a Month " + Total_Work_Hour);

            Console.WriteLine("Total salary for a month  " + Total_Wage);







        }
    }
}
