using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int total;

            for (int i = 1; i < 11; i++)
            {
                numbers.Add(i);
            }

            total = evenNum.evenSum(numbers);

            Console.WriteLine("The even sum is " + total);
            
            List<string> planets = new List<string>();
            planets.Add("Mercury");
            planets.Add("Venus");
            planets.Add("Earth");
            planets.Add("Mars");
            planets.Add("Jupiter");
            planets.Add("Saturn");
            planets.Add("Uranus");
            planets.Add("Neptune");

            Console.WriteLine("How many letters to output?");
            int input = int.Parse(Console.ReadLine());
            
            evenNum.charOut(planets, input);

        }
    }
}
