using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoP_Assignment
{
    internal class Student : Person
    {
        public string StudentNumber { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public string FullName { get; set; }
        public float[] Scores { get; set; }
        public float AverageScore { get; set; }
        public string FullAddress { get; set; }

        public Student()
        {
         Address = new Address();
        }
        public void ScoreInput(int i)
        {
            float input = 0;
            Scores = new float[i];
            for (int j = 0; j < Scores.Length; j++)
            {
                Console.WriteLine($"Please enter grade {j + 1}:");
                Scores[j] = validateInput(input, "Please enter a valid float grade");
            }
        }
        public void CalculateProperties()
        {
            FullName = FirstName + " " + LastName;
            FullAddress = $"{Address.Street} {Address.AddressNumber}, {Address.City}, {Address.Country}";
            CalculateFullScore(Scores);
        }

        public override string ToString()
        {
            return $"Student {FullName} with average score:{AverageScore} is living in {FullAddress}.";
        }

        private void CalculateFullScore(float[] Score)
        {
            for (int i = 0; i < Score.Length; i++)
            {
                AverageScore = AverageScore + Score[i];
            }
            AverageScore=AverageScore/Score.Length;
        }

        private static float validateInput(float input, string message)
        {
            bool inputValid = false;
            while (inputValid == false)
            {

                try
                {
                    input = float.Parse(Console.ReadLine());
                    inputValid = true;
                }
                catch
                {
                    Console.WriteLine(message);
                }

            }
            return input;
        }

    }
}
