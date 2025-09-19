// copied from https://github.com/GeorgianCollege/COMP1115-F2025-ICE2

namespace ICE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Character Sheet";

            string CharacterName;

            // Primary Attributes
            int Agility;
            int Strength;
            int Vigour;
            int Perception;
            int Intellect;
            int Will;

            // Secondary Attributes
            int Awareness;
            int Toughness;
            int Resolve;

            // Prompt for CharacterName
            Console.Write("Enter Character Name: ");
            CharacterName = Console.ReadLine();
        }
    }
}
