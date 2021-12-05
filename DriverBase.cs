using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public abstract class DriverBase : NameSurnameObject, IDriver
    {
        public DriverBase()
        {

        }
        public DriverBase(string name, string surname) : base(name, surname)
        {

        }


        

        public abstract void DrivingRoadDaily(string kilometersDaily);
        public abstract void DrivingRoadDaily(double kilometersDaily);



        public event TravelledRoadDelegate TravelledRoad;


        public abstract Statistics GetStatistics();


    }
}