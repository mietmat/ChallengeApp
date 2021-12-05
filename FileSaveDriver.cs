using System;
using System.Globalization;
using System.IO;

namespace ChallengeApp
{
    enum Month
    {
        Styczeń,
        Luty,
        Marzec,
        Kwiecień,
        Maj,
        Czerwiec,
        Lipiec,
        Sierpień,
        Wrzesień,
        Październik,
        Listopad,
        Grudzień
    }

    public class FileSaveDriver : DriverBase
    {

        public FileSaveDriver(string name, string surname) : base(name, surname)
        {
        }
        public FileSaveDriver()
        {
            Console.WriteLine($"Hello! Welcome to the driver settlement application!");
            Console.Write("Please enter name of the driver: ");
            this.name = Console.ReadLine().ToUpper();


            Console.Write("Please enter the surname of the driver: ");
            this.surname = Console.ReadLine().ToUpper();

            Console.Write("Please enter salary per travelled road: ");
            var input = Console.ReadLine();

            double salary;

            try
            {
                if (double.TryParse(input, out salary))
                {
                    this.salaryPerTravelledRoad = salary;
                }
                else
                {
                    throw new Exception("Please use only the number !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void DrivingRoadDaily(double kilometersDaily)
        {
            var fileName = $"{Name}.txt";
            var fileStat = $"{Name + surname + "_stat"}.txt";


            if (File.Exists(fileStat))
            {
                File.Delete(fileStat);
            }

            using (var travelledRoadFile = File.AppendText(fileName))
            {
                travelledRoadFile.WriteLine(kilometersDaily);

            }

            using (var travelledRoadFile = File.AppendText($"{Name + " " + surname}.txt"))
            {
                travelledRoadFile.WriteLine($"Kierowca: {name + " " + surname}");
                travelledRoadFile.WriteLine($"Miesiąc: {DateTime.Now.Month}");
                travelledRoadFile.WriteLine($"Data zapisu: {DateTime.UtcNow}");
                travelledRoadFile.WriteLine($"Przejechano: {kilometersDaily} km");

                travelledRoadFile.WriteLine();
            }
        }

        public override void DrivingRoadDaily(string kilometersDaily)
        {           
            DrivingRoadDaily(double.Parse(kilometersDaily));

        }


        public static int WeekOfYear(DateTime date)
        {
            var day = (int)CultureInfo.CurrentCulture.Calendar.GetDayOfWeek(date);
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date.AddDays(4 - (day == 0 ? 7 : day)), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            var fileName = $"{Name + surname + "_stat"}.txt";


            using (var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }


                using (var statFile = File.AppendText(fileName))
                {     

                    statFile.WriteLine($"Statistics of the week: {WeekOfYear(DateTime.UtcNow)} - was recorded on: {DateTime.UtcNow}");
                    statFile.WriteLine("Result high: " + result.High + " km/day");
                    statFile.WriteLine("Result low: " + result.Low + " km/day");
                    statFile.WriteLine("Result average: " + Math.Round(result.Average, 2) + " km/day");
                                        
                    statFile.WriteLine($"In this week {Name} travelled: " + result.Sum + " km");
                    statFile.WriteLine($"His salary is: {salaryPerTravelledRoad} zł/km. Wynagrodzenie w tygodniu {WeekOfYear(DateTime.UtcNow)} wynosi: " + salaryPerTravelledRoad*result.Sum + " zł");

                }

            }

            return result;
        }

       
    }



}