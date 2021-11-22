using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class Driver
    {
        private string driverName;
        private string driverSurname;

        public List<double> kilometersPerDay = new List<double>();
        public Driver(string driverName, string driverSurname)
        {
            this.driverName = driverName;
            this.driverSurname = driverSurname;

        }

        public void AddKilometersTravelledPerDay(double kilometersPerDay)
        {
            this.kilometersPerDay.Add(kilometersPerDay);
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


            Console.WriteLine($"{driverName.ToUpper()} {driverSurname.ToUpper()} przejechał najmniej w tym tygodniu: {result.Low:N2} km/dzień");
            Console.WriteLine($"{driverName.ToUpper()} {driverSurname.ToUpper()} przejechał najwięcej w tym tygodniu: {result.High:N2} km/dzień");
            Console.WriteLine($"{driverName.ToUpper()} {driverSurname.ToUpper()} przejechał średnio w tym tygodniu: {result.Average:N2} km/dzień");


            return result;

        }



    }
}