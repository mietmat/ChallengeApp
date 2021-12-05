using System;

namespace ChallengeApp
{
    public class Statistics
    {
        public double High;
        public double Low;

        public double Sum;
        public int Count;

        public Statistics()
        {
            Sum = 0;
            Count = 0;
            Low = double.MaxValue;
            High = double.MinValue;
        }

        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }

        public char Letter
        {
            get
            {

                switch (Average)
                {
                    case var d when d >= 90:
                        return 'A';
                    case var d when d >= 80:
                        return 'B';
                    case var d when d >= 70:
                        return 'C';
                    case var d when d >= 60:
                        return 'D';
                    default:
                        return 'Z';

                }
            }
        }

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Low = Math.Min(number, Low);
            High = Math.Max(number, High);

        }




    }
}