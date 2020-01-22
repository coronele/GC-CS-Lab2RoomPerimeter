using System;

namespace Lab_2___Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string ContinueEntry="y";
            decimal length, width, height, perimeter, area, volume;

            // Not so splashy screen - the one line kind
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Room Calculator\n\n");
       
            while (ContinueEntry == "y")
            {
                // Prompt and input
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please enter the length of the room: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                length = decimal.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please enter the width of the room: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                width = decimal.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please enter the height of the room: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                height = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\n\n\n");

                // Evaluate measurements
                perimeter = ((2 * length) + (2 * width));
                area = length * width;
                volume = area * height;

                // Output to user
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"The perimeter of the room is {perimeter}");
                Console.WriteLine($"The area of the room is {area}");
                Console.WriteLine($"The volume of the room is {volume}\n\n");

                // More fun measuring rooms?
                ContinueEntry = "";
                while ((ContinueEntry != "y") && (ContinueEntry != "n"))
                {
                    // Preventing the world from user error
                    Console.WriteLine("Would you like to continue measuring rooms?");
                    ContinueEntry = Console.ReadLine().ToLower();
                }
                
            }
            // Kill 'em with kindness
            Console.WriteLine("Thank you for calculating rooms with us! :) ");
        }
    }
}
