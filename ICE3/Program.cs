// copied from https://github.com/GeorgianCollege/COMP1115-F2025-ICE2

using System.Reflection.PortableExecutable;

namespace ICE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable declaration

            // Character's Name
            string CharacterName = "Unknown";

            // Primary Attributes
            int Agility = 0;
            int Strength = 0;
            int Vigour = 0;
            int Perception = 0;
            int Intellect = 0;
            int Will = 0;

            // Secondary Attributes
            int Awareness = 0;
            int Toughness = 0;
            int Resolve = 0;

            // Career Variables
            string Career = "Unknown";
            bool HasChosenCareer = false;


            int min = 5;
            int max = 50;



            // Change the Console colours
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            // Change the Console Title Bar
            Console.Title = "Character Sheet";

            // Prompt for CharacterName
            Console.Write("Enter Character Name: ");
            CharacterName = Console.ReadLine();




        }
    }
}
