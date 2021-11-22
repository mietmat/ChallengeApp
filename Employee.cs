using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class Employee
    {
        private string name;
        private List<double> grades = new List<double>();

        public Employee(string name)
        {
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {

                lowGrade = Math.Min(lowGrade, number);
                highGrade = Math.Max(highGrade, number);

            }

            Console.WriteLine($"The low grade is: {lowGrade:N2}. The high grade is: {highGrade:N2}");

        }
    }
}