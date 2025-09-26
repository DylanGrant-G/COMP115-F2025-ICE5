// copied from https://github.com/GeorgianCollege/COMP1115-F2025-ICE2

using System.Reflection.PortableExecutable;

namespace ICE4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable declaration

            ConsoleKey NextKey = ConsoleKey.None;
            while (NextKey != ConsoleKey.Q && NextKey != ConsoleKey.Escape)
            {
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

                switch (CareerChoice)
                {
                    case 1:
                        Career = "Army";
                        Agility = 35;
                        Strength = 35;
                        Vigour = 30;
                        Perception = 30;
                        Intellect = 25;
                        Will = 25;
                        HasChosenCareer = true;
                        break;

                    case 2:
                        Career = "Psion";
                        Agility = 30;
                        Strength = 35;
                        Vigour = 30;
                        Perception = 30;
                        Intellect = 35;
                        Will = 25;
                        HasChosenCareer = true;
                        break;

                    case 3:
                        Career = "Rogue";
                        Agility = 35;
                        Strength = 30;
                        Vigour = 30;
                        Perception = 35;
                        Intellect = 25;
                        Will = 25;
                        HasChosenCareer = true;
                        break;

                    case 4:
                        Career = "Telepath";
                        Agility = 25;
                        Strength = 25;
                        Vigour = 30;
                        Perception = 30;
                        Intellect = 35;
                        Will = 35;
                        HasChosenCareer = true;
                        break;

                    case 5:
                        Career = "Tinker";
                        Agility = 30;
                        Strength = 35;
                        Vigour = 25;
                        Perception = 30;
                        Intellect = 35;
                        Will = 25;
                        HasChosenCareer = true;
                        break;

                    case 6:
                        Career = "Random";
                        Random d10 = new Random();
                        Agility = d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11);
                        Strength = d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11);
                        Vigour = d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11);
                        Perception = d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11);
                        Intellect = d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11); ;
                        Will = d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11) + d10.Next(1, 11);
                        HasChosenCareer = true;
                        break;

                    default:
                        Console.WriteLine("You entered an incorrect choice. Please run the program again.");
                        HasChosenCareer = false;
                        Console.WriteLine("Press Q or ESC to exit.");
                        NextKey = Console.ReadKey(true).Key;
                        continue;
                }

                if (HasChosenCareer == true)
                {
                    // compute secondary attributes
                    Awareness = Agility + Perception;
                    Toughness = Strength + Vigour;
                    Resolve = Intellect + Will;

                    // output the character sheet
                    Console.Clear();

                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"Character Name: {CharacterName}");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"Career        : {Career}");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Primary Attributes");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"Agility        : {Agility}");
                    Console.WriteLine($"Strength       : {Strength}");
                    Console.WriteLine($"Vigour         : {Vigour}");
                    Console.WriteLine($"Perception     : {Perception}");
                    Console.WriteLine($"Intellect      : {Intellect}");
                    Console.WriteLine($"Will           : {Will}");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Secondary Attributes");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"Awareness       : {Awareness}");
                    Console.WriteLine($"Toughness       : {Toughness}");
                    Console.WriteLine($"Resolve         : {Resolve}");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Press Q or ESC to Exit");
                    NextKey = Console.ReadKey(true).Key;
                    Console.Clear();
                    continue;
                }
            }

        }
    }
}
