
using System;
using System.IO;

namespace ChallengeApp
{

    public class SavedEmployee : EmployeeBase
    {
        public SavedEmployee(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {

            // var writer = File.AppendText($"{Name + "STUDENT"}.txt");
            // writer.WriteLine(grade);
            // writer.Dispose();

            if (grade >= 0 && grade < 100)
            {

                using (var writer = File.AppendText($"{Name}.txt"))
                {
                    writer.WriteLine(grade);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
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

            using (var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }

            return result;
        }
    }

}