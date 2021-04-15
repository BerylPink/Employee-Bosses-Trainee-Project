using System;

namespace EmployeeBossesTraineeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee micheal = new Employee("Micheal", "Miller", 40000);
            micheal.Work();
            micheal.Pause();

            Boss chuck = new Boss("Ferrari", "Norris", "Chuck", 999999999);
            chuck.Lead();

            Trainee michelle = new Trainee(32, 8, "Gartner", "Michelle", 10000);

            michelle.Learn();
            michelle.Work();

            Console.ReadKey();
        }
    }
}
