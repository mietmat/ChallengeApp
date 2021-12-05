
namespace ChallengeApp
{
    public abstract class EmployeeBase : NamedObject, IEmployee
    {
        public EmployeeBase(string name) : base(name)
        {

        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);
        public abstract Statistics GetStatistics();


    }

}