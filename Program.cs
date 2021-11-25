using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeApp
{
    struct Point
    {

    }

    class Program
    {
        static void Main(string[] args)

        {

            var employee = new Employee("Mateusz");

            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(30);
            employee.AddGrade("35");

            var stat = employee.GetStatistics();

            Console.WriteLine($"The  low grade is: {stat.Low:N2}.");
            Console.WriteLine($"The high grade is: {stat.High:N2}");
            Console.WriteLine($"The average grade is: {stat.Average:N2}");


            var namesWithAges = new NamesWithAgesInList();
            namesWithAges.PrintNamesWithAges();




            // var driver1 = new Driver("Michał", "Kowalski");

            // driver1.AddKilometersTravelledPerDay(452.3);
            // driver1.AddKilometersTravelledPerDay(398.5);
            // driver1.AddKilometersTravelledPerDay(422.0);
            // driver1.AddKilometersTravelledPerDay(501);
            // driver1.AddKilometersTravelledPerDay(483.4);

            // driver1.DriverRenamed("Jan54");

            // driver1.GetStatistics();


        }
    }


}
