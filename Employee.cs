using System;
using System.Collections.Generic;

namespace ChallengeApp
{

    // public class Employee2 : IEmployee
    // {
    //     public string Name => throw new NotImplementedException();

    //     public event GradeAddedDelegate GradeAdded;

    //     public void AddGrade(double grade)
    //     {
    //         throw new NotImplementedException();
    //     }

    //     public Statistics GetStatistics()
    //     {
    //         throw new NotImplementedException();
    //     }
    // }

    public class Employee : EmployeeBase
    {

        public override event GradeAddedDelegate GradeAdded;

        public const string FIRM = "M";


        private List<double> grades = new List<double>();

        public Employee(string name) : base(name)
        {

        }

        public Employee(string name, string emp) : base(name)
        {

        }

        public void AddGrade(double grade, int a)
        {
        }

        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade < 100)
            {
                this.grades.Add(grade);

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

        // public void AddGrade(string grade)
        // {
        //     double temporaryValue;

        //     switch (grade)
        //     {
        //         case "1+":
        //             temporaryValue = 1.5;
        //             break;
        //         case "2+":
        //             temporaryValue = 2.5;
        //             break;
        //         case "3+":
        //             temporaryValue = 3.5;
        //             break;
        //         case "4+":
        //             temporaryValue = 4.5;
        //             break;
        //         case "5+":
        //             temporaryValue = 5.5;
        //             break;
        //         case "2-":
        //             temporaryValue = 1.75;
        //             break;
        //         case "3-":
        //             temporaryValue = 2.75;
        //             break;
        //         case "4-":
        //             temporaryValue = 3.75;
        //             break;
        //         case "5-":
        //             temporaryValue = 4.75;
        //             break;
        //         case "1":
        //             temporaryValue = 1;
        //             break;
        //         case "2":
        //             temporaryValue = 2;
        //             break;
        //         case "3":
        //             temporaryValue = 3;
        //             break;
        //         case "4":
        //             temporaryValue = 4;
        //             break;
        //         case "5":
        //             temporaryValue = 5;
        //             break;
        //         case "6":
        //             temporaryValue = 6;
        //             break;
        //         default:
        //             temporaryValue = 0;
        //             break;
        //     }

        //     if (temporaryValue >= 1 && temporaryValue <= 6)
        //     {
        //         this.grades.Add(temporaryValue);
        //     }
        //     else
        //     {
        //         throw new ArgumentException($"Invalid argument: {nameof(grade)}");
        //     }
        // }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                    this.AddGrade(100);
                    break;
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'C':
                    this.AddGrade(60);
                    break;
                case 'D':
                    this.AddGrade(50);
                    break;
                default:
                    this.AddGrade(0);
                    break;

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

        public override Statistics GetStatistics()
        {
            // const int val = 14;
            var result = new Statistics();
            result.High = double.MinValue;
            result.Low = double.MaxValue;



            for (var index = 0; index < grades.Count; index++)
            {
                // if (grades[index] == 5)
                // {
                //     break;
                // }

                // if (grades[index] == 6)
                // {
                //     continue;
                // }

                // if (grades[index] == 7)
                // {
                //     goto here;
                // }


                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);

            }

            // here:




            return result;

        }


    }
}