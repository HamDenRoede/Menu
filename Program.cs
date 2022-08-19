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
            Console.WriteLine("-------------------------");

            Console.WriteLine("   -   Circle    (C)     |");
            Console.WriteLine("   -   Triangle  (T)     |");
            Console.WriteLine("   -   Square    (S)     |");
            Console.WriteLine("   -   Rectangle (R)     |");
            Console.WriteLine("                         |");
            Console.WriteLine("   -   Shortcuts:        |");
            Console.WriteLine("   -   Quit =    (Q)     |");
            Console.WriteLine("   -   Menu =    (M)     |");
            Console.WriteLine("-------------------------\n");

            Console.WriteLine(" Enter the desired calculation: ");
            string tast = Console.ReadKey().Key.ToString();

            switch(tast)
            {
                case "c":
                    //udregn cirle
                    break;
                case "t":
                    //udregn triangle
                    break;
                case "s":
                    //udregn square
                    break;
                case "r":
                    //udregn rect
                    break;


                case "q":
                    //sluk program
                    break;
                case "m":
                    mainMenu();
                    break;
            }



            //Console.ReadKey();
        }
    }
}
