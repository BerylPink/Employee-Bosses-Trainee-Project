using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBossesTraineeProject
{
    class Trainee:Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainee(int workingHours, int schoolHours, string name, string firstname, int salary):base(name,firstname,salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }


        public void Learn()
        {
            Console.WriteLine("I'm learning for {0} hours!", SchoolHours);
        }

        public void Work()
        {
            Console.WriteLine("I work for {0} hours", WorkingHours);
        }
    }
}
