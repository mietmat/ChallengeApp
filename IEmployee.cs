using System;
using System.Collections.Generic;


namespace ChallengeApp
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);


    public interface IEmployee
    {
        void AddGrade(double grade);

        Statistics GetStatistics();

        string Name { get; }
        event GradeAddedDelegate GradeAdded;

    }
}