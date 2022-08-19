using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            mainMenu();
        }

        static void mainMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("    Welcome to the Shape Calculator");
            Console.WriteLine("---------------------------------------");
            
            Console.WriteLine("\n");
            Console.WriteLine("\tIndex");
            Console.WriteLine("---------------------");

            Console.WriteLine("   -   Circle       |");
            Console.WriteLine("   -   Triangle     |");
            Console.WriteLine("   -   Square       |");
            Console.WriteLine("   -   Rectangle    |");
            Console.WriteLine("                    |");
            Console.WriteLine("   -  Shortcuts:    |");
            Console.WriteLine("   -   Quit = Q     |");
            Console.WriteLine("   -   Menu = M     |");
            Console.WriteLine("---------------------\n");

            Console.WriteLine(" Enter the desired calculation: ");
            string tast = Console.ReadKey().Key.ToString();



            Console.ReadKey();
        }
    }
}
