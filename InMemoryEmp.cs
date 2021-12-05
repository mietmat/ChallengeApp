using System;
using System.Collections.Generic;
using System.IO;

namespace ChallengeApp
{
    public class InMemoryEmpl : EmployeeBase
    {
        private List<double> grades;
        public override event GradeAddedDelegate GradeAdded;

        public InMemoryEmpl(string name) : base(name)
        {
            grades = new List<double>();

        }

        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade < 100)
            {
                grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }


            }
            else
            {
                throw new ArgumentException($"Invalid argument: {nameof(grade)}");
            }
        }


        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            for (var index = 0; index < grades.Count; index++)
            {
                result.Add(grades[index]);
            }

            return result;
        }


    }

}