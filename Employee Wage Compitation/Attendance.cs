using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    public class Attendance
    {
        Random random = new Random();
        public string name;
        public void presnt()
        {
            int EmpCheck = random.Next(0, 2);
            if (EmpCheck == 1)
                Console.WriteLine(name + " Employee is present");
            else
                Console.WriteLine(name + " Employee is absent");
        }
    }
}
