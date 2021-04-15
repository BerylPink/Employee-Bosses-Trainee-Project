using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBossesTraineeProject
{
    class Boss:Employee
    {
        protected string CompanyCar { get; set; }

        public Boss(string companyCar, string name, string firstName, int salary):base(name,firstName,salary)
        {
            this.CompanyCar = companyCar;

        }


        public void Lead()
        {
            Console.WriteLine("I'm Boss! My name is {0} {1}", FirstName, Name);
        }
    }
}
