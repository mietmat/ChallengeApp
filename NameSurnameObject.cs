using System;

namespace ChallengeApp
{
    public class NameSurnameObject
    {
        public string name;
        protected string surname;
        protected double salaryPerTravelledRoad;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string SurName
        {
            get
            {
                return this.surname;
            }
            set
            {
                this.surname = value;
            }
        }




        public NameSurnameObject(string name, string surname)
        {
            this.Name = name;
            this.surname = surname;

        }

        public NameSurnameObject()
        {
            this.Name = name;
            this.SurName = surname;

        }


    }
}