// copied from https://github.com/GeorgianCollege/COMP1115-F2025-ICE2

using System.Collections;
using System.Numerics;
using System.Reflection.PortableExecutable;

namespace ICE5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // local helper funtion
            Random d10 = new Random();
            int roll5d10()
            {
                int total = 0;
                for (int roll = 0; roll < 5; roll++)
                {
                    total += (d10.Next(1, 11));
                }
                return total;
            }
            // local helper funtion that assign the career template
            void UseCareerTemplate(int[] career)
            {
                for (int index = 0; index < 6; index++)
                {
                    PrimaryAttributes[index] = career[index];
                }
            }

            // Primary Attribute Array
            int[] PrimaryAttributes = new int[6];
            string[] PrimaryAttributeNames = ["Agility", "Strength", "Vigur", "Pereception", "Intellect", "Will"];

            // Secondary Attribute Array
            int[] SecondaryAttributes = new int[6];
            string[] SecondaryAttributeNames = ["Awareness", "Tougness", "Resolve"];

            // Career Array
            int[] Army = [35, 35, 30, 30, 25, 25];
            int[] Psion = [30, 35, 30, 25, 35, 25];
            int[] Rouge = [35, 30, 30, 35, 25, 25];
            int[] Telepath = [25, 25, 30, 30, 35, 35];
            int[] Tinker = [30, 35, 25, 30, 35, 25];
            string[] Careers = ["Army", "Psion", "Rouge", "Telepath", "Tinker"];

            // outer while loop
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

                // Inner while loop
                bool IsValid = false;
                while (!IsValid)
                {
                    Console.Write("Enter 1 to 6: ");
                    IsValid = int.TryParse(Console.ReadLine(), out CareerChoice);

                    if (!IsValid)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid Entry. Try again.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                switch (CareerChoice)
                {
                    case 1:
                        Career = "Army";

                        UseCareerTemplate(Army);

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

                        UseCareerTemplate(Psion);

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

                        UseCareerTemplate(Rouge);

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

                        UseCareerTemplate(Telepath);

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

                        UseCareerTemplate(Tinker);

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

                        for (int index = 0; index < 6; index++)
                        {
                            PrimaryAttributes[index] = roll5d10();
                        }

                        Agility = roll5d10();
                        Strength = roll5d10();
                        Vigour = roll5d10();
                        Perception = roll5d10();
                        Intellect = roll5d10();
                        Will = roll5d10();
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
