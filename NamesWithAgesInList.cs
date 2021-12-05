using System;

namespace ChallengeApp
{
    public class NamesWithAgesInList
    {
        string[] persons = new string[] { "Jan", "Michał", "Wojciech", "Łukasz", "Adam", "Franciszek", "Eryk", "Krzysztof", "Andrzej", "Grzegorz" };
        int[] ages = new int[] { 10, 15, 20, 13, 60, 45, 80, 9, 4, 88 };

        int j = 0;

        public void PrintNamesWithAges()
        {
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"{persons[i] + " " + ages[j]}");
                j++;

            }
        }



    }
}