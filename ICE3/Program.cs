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
            int CareerChoice = 0;
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

            Console.WriteLine("Select your Career: ");
            Console.WriteLine("1. Army (AGL: 35, STR: 35, VGR: 30, PER: 30, INT: 25, WIL: 25)");
            Console.WriteLine("2. Psion (AGL: 30, STR: 35, VGR: 30, PER: 25, INT: 35, WIL: 25)");
            Console.WriteLine("3. Rogue (AGL: 35, STR: 30, VGR: 30, PER: 35, INT: 25, WIL: 25)");
            Console.WriteLine("4. Telepath (AGL: 25, STR: 25, VGR: 30, PER: 30, INT: 35, WIL: 35)");
            Console.WriteLine("5. Tinker (AGL: 30, STR: 35, VGR: 25, PER: 30, INT: 35, WIL: 25)");
            Console.WriteLine("6. Random ");
            Console.Write("You Selection: ");
            CareerChoice = Convert.ToInt32(Console.ReadLine());

            if(CareerChoice == 1)
            {
                Career = "Army";
                Agility = 35;
                Strength = 35;
                Vigour = 30;
                Perception = 30;
                Intellect = 25;
                Will = 25;
            }
            else if (CareerChoice == 2)
            {
                Career = "Psion";
                Agility = 30;
                Strength = 35;
                Vigour = 30;
                Perception = 30;
                Intellect = 35;
                Will = 25;
            }
            else if (CareerChoice == 3)
            {
                Career = "Rogue";
                Agility = 35;
                Strength = 30;
                Vigour = 30;
                Perception = 35;
                Intellect = 25;
                Will = 25;
            }
            else if (CareerChoice == 4)
            {
                Career = "Telepath";
                Agility = 25;
                Strength = 25;
                Vigour = 30;
                Perception = 30;
                Intellect = 35;
                Will = 35;
            }
            else if (CareerChoice == 5)
            {
                Career = "Tinker";
                Agility = 30;
                Strength = 35;
                Vigour = 25;
                Perception = 30;
                Intellect = 35;
                Will = 25;
            }
            else
            {
                Console.WriteLine("You entered an incorrect choice. Please run the program again.");
            }

        }
    }
}
