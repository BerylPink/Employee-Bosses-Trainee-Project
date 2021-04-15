using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBossesTraineeProject
{
    class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public Employee()
        {
            Name = "Timi";
            FirstName = "Adiel";
            Salary = 50000;
        }

        public void Work()
        {
            Console.WriteLine("I am working!");
        }

        public void Pause()
        {
            Console.WriteLine("I am having a break!");
        }
    }
}
