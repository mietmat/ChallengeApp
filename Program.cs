using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Mateusz");

            employee.AddGrade(24.4);


            var grades = new[] { 12.4, 5, 0.333 };

            employee.ShowStatistics();



        }
    }


}
