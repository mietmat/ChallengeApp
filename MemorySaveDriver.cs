using System;

namespace ChallengeApp
{
    public class MemorySaveDriver : DriverBase
    {
        public MemorySaveDriver(string name, string surname) : base(name, surname)
        {
        }

        public override void DrivingRoadDaily(string kilometersDaily)
        {
            throw new System.NotImplementedException();
        }

        public override void DrivingRoadDaily(double kilometersDaily)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            Console.WriteLine($"{name.ToUpper()} {surname.ToUpper()} przejechał najmniej w tym tygodniu: {result.Low:N2} km/dzień");
            Console.WriteLine($"{name.ToUpper()} {surname.ToUpper()} przejechał najwięcej w tym tygodniu: {result.High:N2} km/dzień");
            Console.WriteLine($"{name.ToUpper()} {surname.ToUpper()} przejechał średnio w tym tygodniu: {result.Average:N2} km/dzień");

            return result;
        }
    }



}