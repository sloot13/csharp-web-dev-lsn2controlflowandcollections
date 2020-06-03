using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "I would not, could not, in a box. I would not, could not with a fox.\nI will not eat them in a house. I will not eat them with a mouse.";
            string[] words = val.Split(" ");
            Console.WriteLine(val);
            Console.WriteLine(string.Join(" ", words));

            string[] nextWords = val.Split("\n");
            Console.WriteLine(val);
            Console.WriteLine(string.Join("\n", nextWords));
        }
    }
}
