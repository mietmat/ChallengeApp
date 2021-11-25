using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class Employee
    {
        private string name;

        public string Name { get; set; }
        private List<double> grades = new List<double>();

        public Employee(string name)
        {
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade < 100)
            {
                this.grades.Add(grade);

            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }

        public void AddGrade(string grade)
        {
            int temporaryVariable = 0;
            if (int.TryParse(grade, out temporaryVariable))
            {
                AddGrade(temporaryVariable);
            }

        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;



            for (var index = 0; index > grades.Count; index++)
            {
                if (grades[index] == 5)
                {
                    break;
                }

                if (grades[index] == 6)
                {
                    continue;
                }

                if (grades[index] == 7)
                {
                    goto here;
                }


                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];

            }

        here:


            result.Average /= grades.Count;

            return result;

        }


    }
}