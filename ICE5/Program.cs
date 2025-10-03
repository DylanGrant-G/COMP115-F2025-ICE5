// copied from https://github.com/GeorgianCollege/COMP1115-F2025-ICE2

using System;
using System.Collections;
using System.Numerics;
using System.Reflection.PortableExecutable;

namespace ICE5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Change the Console colours
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

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

            int[][] CareerPresets =
                [
                    [35, 35, 30, 30, 25, 25], // Army
                    [30, 35, 30, 30, 35, 25], // Psion
                    [35, 30, 30, 35, 25, 25], // Rogue
                    [25, 25, 30, 30, 35, 35], // Telepath
                    [30, 35, 25, 30, 35, 25] // Tinker
                ];

            // local helper funtion that assign the career template
            void UseCareerTemplate(int[] career)
            {
                for (int index = 0; index < 6; index++)
                {
                    PrimaryAttributes[index] = career[index];
                }
            }

            // outer while loop
            ConsoleKey NextKey = ConsoleKey.None;
            while (NextKey != ConsoleKey.Q && NextKey != ConsoleKey.Escape)
            {
                // Character's Name
                string CharacterName = "Unknown";

                

                // Career Variables
                string Career = "Unknown";
                int CareerChoice = 0;
                bool HasChosenCareer = false;


                


               
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

                if (CareerChoice == 0 && CareerChoice < 6)
                {
                    Career = Careers[CareerChoice - 1];
                    UseCareerTemplate(CareerPresets[CareerChoice - 1]);
                    HasChosenCareer = true;
                }
                else if (CareerChoice == 6)
                {
                    Career = "Random";

                    for (int index = 0; index < 6; index++)
                    {
                        PrimaryAttributes[index] = roll5d10();
                    }


                    HasChosenCareer = true;
                }
                else
                {
                    Console.WriteLine("You entered an incorrect choice. Please run the program again.");
                    HasChosenCareer = false;
                    Console.WriteLine("Press Q or ESC to exit.");
                    NextKey = Console.ReadKey(true).Key;
                    continue;
                }

                    //switch (CareerChoice)
                    //{
                    //    case 1:
                    //        Career = Careers[0];

                    //        UseCareerTemplate(CareerPresets[0]);


                    //        HasChosenCareer = true;
                    //        break;

                    //    case 2:
                    //        Career = Careers[1];

                    //        UseCareerTemplate(CareerPresets[1]);


                    //        HasChosenCareer = true;
                    //        break;

                    //    case 3:
                    //        Career = Careers[2];

                    //        UseCareerTemplate(CareerPresets[2]);


                    //        HasChosenCareer = true;
                    //        break;

                    //    case 4:
                    //        Career = Careers[3];

                    //        UseCareerTemplate(CareerPresets[3]);


                    //        HasChosenCareer = true;
                    //        break;

                    //    case 5:
                    //        Career = Careers[4];

                    //        UseCareerTemplate(CareerPresets[4]);


                    //        HasChosenCareer = true;
                    //        break;

                    //    case 6:
                    //        Career = "Random";

                    //        for (int index = 0; index < 6; index++)
                    //        {
                    //            PrimaryAttributes[index] = roll5d10();
                    //        }


                    //        HasChosenCareer = true;
                    //        break;

                    //    default:
                    //        Console.WriteLine("You entered an incorrect choice. Please run the program again.");
                    //        HasChosenCareer = false;
                    //        Console.WriteLine("Press Q or ESC to exit.");
                    //        NextKey = Console.ReadKey(true).Key;
                    //        continue;
                    //}

                if (HasChosenCareer == true)
                {
                    // compute secondary attributes
                    SecondaryAttributes[0] = PrimaryAttributes[0] + PrimaryAttributes[3];
                    SecondaryAttributes[1] = PrimaryAttributes[1] + PrimaryAttributes[2];
                    SecondaryAttributes[2] = PrimaryAttributes[4] + PrimaryAttributes[5];

                    //Awareness = Agility + Perception;
                    //Toughness = Strength + Vigour;
                    //Resolve = Intellect + Will;

                    // output the character sheet
                    Console.Clear();

                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"Character Name: {CharacterName}");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"Career        : {Career}");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Primary Attributes");
                    Console.WriteLine("------------------------------------------------------");
                    PrintAttribute(PrimaryAttributeNames, PrimaryAttributes);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Secondary Attributes");
                    Console.WriteLine("------------------------------------------------------");
                    PrintAttribute(SecondaryAttributeNames, SecondaryAttributes);
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Press Q or ESC to Exit");
                    NextKey = Console.ReadKey(true).Key;
                    Console.Clear();
                    continue;

                    void PrintAttribute(string[] attributeNames, int[] attributeValues)
                    {
                        for (int index = 0; index < attributeNames.Length; index++)
                        {
                            Console.WriteLine($"{attributeNames[index]} : {attributeValues[index]}");
                        }
                        
                    }
                }
            }

        }
    }
}
