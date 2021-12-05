using System;

namespace ChallengeApp
{

    public delegate void TravelledRoadDelegate(object sender, EventArgs args);

    public interface IDriver
    {
        void DrivingRoadDaily(double DrivingRoadDaily);

        Statistics GetStatistics();

    }


}