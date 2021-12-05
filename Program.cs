using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeApp
{
    class Program
    {

        ////------ FOR LEARNING ------////
        // static void Main(string[] args)
        // {
        //     var employee = new InMemoryEmpl("Mateusz");
        //     // employee.GradeAdded += OnGradeAdded;
        //     // employee.GradeAdded += OnGradeAdded;
        //     // employee.GradeAdded -= OnGradeAdded;

        //     // var name = employee.Name;
        //     // employee.Name = "new OnE";
        //     // var aa = Employee.FIRM;

        //     EnterGrade(employee);

        //     var stats = employee.GetStatistics();
        //     Console.WriteLine($"High: {stats.High}");
        //     Console.WriteLine($"Low: {stats.Low}");
        //     Console.WriteLine($"Average: {stats.Average}");
        //     Console.WriteLine($"Letter: {stats.Letter}");

        // }

        // private static void EnterGrade(IEmployee employee)
        // {
        //     while (true)
        //     {
        //         // Console.ForegroundColor = ConsoleColor.Yellow;
        //         Console.WriteLine($"Hello! Enter grade for {employee.Name}");
        //         var input = Console.ReadLine();

        //         if (input == "q")
        //         {
        //             break;
        //         }

        //         // try
        //         // {
        //         //     employee.AddGrade(input);

        //         // }
        //         // catch (ArgumentException ex)
        //         // {
        //         //     Console.WriteLine(ex.Message);
        //         // }


        //         try
        //         {
        //             var grade = double.Parse(input);

        //             employee.AddGrade(grade);
        //         }
        //         catch (FormatException ex)
        //         {
        //             var message = "Podano błędny format ! Podaj liczbę !";
        //             Console.WriteLine(message);
        //             Console.WriteLine(ex.Message);
        //         }
        //         catch (ArgumentException ex)
        //         {
        //             var message = "Podano liczbę wychodzącą poza zakres 1-100 ! Podaj proszę liczbę z tego zakresu !";
        //             Console.WriteLine(message);
        //             Console.WriteLine(ex.Message);
        //         }
        //         finally
        //         {
        //             Console.WriteLine("HERE IS finally");
        //         }


        //     }
        // }

        // static void OnGradeAdded(object sender, EventArgs args)
        // {
        //     Console.WriteLine($"New grade is added");
        // }


        //------FOR MY APPLICATION:------//

        static void Main(string[] args)
        {
            // var employee = new Employee("Mateusz");

            // employee.AddGrade(5);
            // employee.AddGrade(10);
            // employee.AddGrade(30);
            // employee.AddGrade("35");

            // var stat = employee.GetStatistics();

            // Console.WriteLine($"The low grade is: {stat.Low:N2}.");
            // Console.WriteLine($"The high grade is: {stat.High:N2}");
            // Console.WriteLine($"The average grade is: {stat.Average:N2}");

            // var namesWithAges = new NamesWithAgesInList();
            // namesWithAges.PrintNamesWithAges();


            // var driver = new FileSaveDriver("Michał", "Kowalski");
            var driver = new FileSaveDriver();

            // driver.TravelledRoad += ToSmallTravelledRoad;

            while (true)
            {

                Console.WriteLine($"Enter daily kilometers travelled by {driver.name}");
                var input = Console.ReadLine();
                

                if (input == "q")
                {
                    break;
                }

                try
                {
                    double temp;
                    if (double.TryParse(input, out temp))
                    {
                        driver.DrivingRoadDaily(input);
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid argument: {nameof(input)}. Please use only the numbers!");

                    }                   

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

            }

            driver.GetStatistics();

            Console.WriteLine("The operation of this application has been closed. Have a nice day and see you later !\nPress any key to close the console view !");
            Console.ReadKey();


            // driver.DrivingRoadDaily(452.3);
            // driver.DrivingRoadDaily(398.5);
            // driver.DrivingRoadDaily(422.0);
            // driver.DrivingRoadDaily(501);
            // driver.DrivingRoadDaily(483.4);

            // driver.DriverRenamed("Jan54");
        }


        static void ToSmallTravelledRoad(object sender, EventArgs args)
        {
            Console.WriteLine($"Oh no! We should inform driver’s boss about this fact. It is not enought for a day's work!");
        }
    }


}
