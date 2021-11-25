using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class Driver
    {
        // public string driverName;
        private string driverSurname;

        public string DriverName { get; private set; }

        public List<double> kilometersPerDay = new List<double>();
        public Driver(string driverName, string driverSurname)
        {
            this.DriverName = driverName;
            this.driverSurname = driverSurname;

        }


        public void AddKilometersTravelledPerDay(double kilometersPerDay)
        {
            this.kilometersPerDay.Add(kilometersPerDay);
        }


        public void AddKilometersTravelledPerDay(string kilometersPerDay)
        {
            int temporaryVariable = 0;
            if (int.TryParse(kilometersPerDay, out temporaryVariable))
            {
                AddKilometersTravelledPerDay(temporaryVariable);
            }

        }

        public void DriverRenamed(string newName)
        {
            DriverName = newName;

            char[] names;

            names = newName.ToCharArray(0, newName.Length);

            foreach (var item in names)
            {
                if (Char.IsDigit(item))
                {
                    System.Console.WriteLine("W podanym imieniu znajduje się co najmniej jedna cyfra !");
                    return;
                }

            }
            System.Console.WriteLine("Zmieniono imię kierowcy !");

        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            int i = 0;
            result.Low = kilometersPerDay[i];
            result.High = kilometersPerDay[i];
            result.Average = 0.0;

            foreach (var data in kilometersPerDay)
            {
                if (result.Low >= data)
                    result.Low = data;

                if (result.High <= data)
                    result.High = data;

                result.Average += data;

            }
            result.Average /= kilometersPerDay.Count;


            Console.WriteLine($"{DriverName.ToUpper()} {driverSurname.ToUpper()} przejechał najmniej w tym tygodniu: {result.Low:N2} km/dzień");
            Console.WriteLine($"{DriverName.ToUpper()} {driverSurname.ToUpper()} przejechał najwięcej w tym tygodniu: {result.High:N2} km/dzień");
            Console.WriteLine($"{DriverName.ToUpper()} {driverSurname.ToUpper()} przejechał średnio w tym tygodniu: {result.Average:N2} km/dzień");


            return result;

        }



    }
}