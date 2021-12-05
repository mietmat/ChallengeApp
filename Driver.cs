using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class Driver : DriverBase
    {
        public delegate void TravelledRoadDelegate(object sender, EventArgs args);
        public event TravelledRoadDelegate TravelledRoad;

        public List<double> kilometersPerDay = new List<double>();
        public Driver(string name, string surname) : base(name, surname)
        {


        }

        public Driver()
        {

        }

        public override void DrivingRoadDaily(double kilometersDaily)
        {

            this.kilometersPerDay.Add(kilometersDaily);

            if (kilometersDaily < 75)
            {
                TravelledRoad(this, new EventArgs());

            }
        }


        public override void DrivingRoadDaily(string kilometersDaily)
        {
            double temporaryValue = 0;
            if (double.TryParse(kilometersDaily, out temporaryValue))
            {
                DrivingRoadDaily(temporaryValue);

            }
            else
            {
                throw new ArgumentException($"Invalid argument: {nameof(kilometersDaily)}. Please use only numbers!");
            }
            //else
            //{
            //    double travelledDaily = 0;
            //    switch (kilometersDaily)
            //    {
            //        /* 100+ = 150km jako bonus za realizację przewozu w terminie
            //           100- = 75km jako minus za opóźnienie w realizacji */
            //        case "100+":
            //            travelledDaily = 150;
            //            break;
            //        case "100-":
            //            travelledDaily = 75;
            //            break;
            //        case "200+":
            //            travelledDaily = 250;
            //            break;
            //        case "200-":
            //            travelledDaily = 175;
            //            break;
            //        case "300+":
            //            travelledDaily = 350;
            //            break;
            //        case "300-":
            //            travelledDaily = 275;
            //            break;
            //        case "400+":
            //            travelledDaily = 450;
            //            break;
            //        case "400-":
            //            travelledDaily = 375;
            //            break;
            //        case "500+":
            //            travelledDaily = 550;
            //            break;
            //        case "500-":
            //            travelledDaily = 475;
            //            break;
            //        case "600+":
            //            travelledDaily = 650;
            //            break;
            //        case "600-":
            //            travelledDaily = 575;
            //            break;
            //        default:
            //            travelledDaily = 0;
            //            break;

            //    }

            //    this.kilometersPerDay.Add(travelledDaily);

            //}

       


        // if (travelledDaily >= 1 && travelledDaily <= 1000)
        // {

        //     temporaryValue = 0;
        //     if (double.TryParse(kilometersDaily, out temporaryValue))
        //     {
        //         // kilometersPerDay.Add(travelledDaily);
        //         DrivingRoadDaily(temporaryValue);

        //     }
        // }
        // else
        // {
        //     throw new ArgumentException($"Invalid argument: {nameof(kilometersDaily)}. Kierowca dziennie powinien przejechać 1-1000 km. ");
        // }

    }


        //public void DriverRenamed(string newName)
        //{
        //    name = newName;

        //    foreach (var item in newName)
        //    {
        //        if (Char.IsDigit(item))
        //        {
        //            System.Console.WriteLine("W podanym imieniu znajduje się co najmniej jedna cyfra !");
        //            return;
        //        }

        //    }
        //    System.Console.WriteLine("Zmieniono imię kierowcy !");

        //}

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            int i = 0;
            result.Low = kilometersPerDay[i];
            result.High = kilometersPerDay[i];

            foreach (var data in kilometersPerDay)
            {
                if (result.Low >= data)
                    result.Low = data;

                if (result.High <= data)
                    result.High = data;


            }

            Console.WriteLine($"{name.ToUpper()} {surname.ToUpper()} przejechał najmniej w tym tygodniu: {result.Low:N2} km/dzień");
            Console.WriteLine($"{name.ToUpper()} {surname.ToUpper()} przejechał najwięcej w tym tygodniu: {result.High:N2} km/dzień");
            Console.WriteLine($"{name.ToUpper()} {surname.ToUpper()} przejechał średnio w tym tygodniu: {result.Average:N2} km/dzień");

            return result;


        }

    }
}