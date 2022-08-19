using System;
using System.Threading;

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
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("    Welcome to the Shape Calculator");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("\n");
            Console.WriteLine("\tIndex");
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   -   Circle    (C)     |");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("   -   Triangle  (T)     |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   -   Square    (S)     |");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   -   Rectangle (R)     |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                         |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   -   Shortcuts:        |");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("   -   Quit =    (Q)     |");
            Console.WriteLine("   -   Menu =    (M)     |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------\n");

            Console.WriteLine("Enter the desired calculation: ");
            string input = Console.ReadLine();

        

            /*
            const string c = "Please enter the radius of the circle: ";
            const string m = "Redirecting to Main Menu"; 
            */



            switch (input.ToLower())
            {
                /*
                case "test":
                    Console.WriteLine("Testing testing, attention please.");
                    Console.WriteLine("Taking you back to the main menu now.");
                    Thread.Sleep(4000);
                    mainMenu();
                    break;
                */

                case "c":
                    calcCircle();
                    Console.WriteLine("Press 'M' to return to return to main manu. ");
                    Console.WriteLine("Press 'Q' to return to return to main manu. ");
                    string userInputCircle = Console.ReadLine();
                    if (userInputCircle == "m")
                    {
                        mainMenu();
                    }
                    if (userInputCircle == "q")
                    {
                        Environment.Exit(0);
                    } else if (userInputCircle != "m")
                    {
                        Console.WriteLine("Try again");
                    }
                    else if (userInputCircle != "q")
                    {
                        Console.WriteLine("Try again");
                    }
                    break;

                case "t":
                    calcTriangle();
                    Console.WriteLine("Press 'M' to return to return to main manu. ");
                    Console.WriteLine("Press 'Q' to return to return to main manu. ");
                    string userInputTriangle = Console.ReadLine();
                    if (userInputTriangle == "m")
                    {
                        mainMenu();
                    }
                    if (userInputTriangle == "q")
                    {
                        Environment.Exit(0);
                    }
                    else if (userInputTriangle != "m")
                    {
                        Console.WriteLine("Try again");
                    }
                    else if (userInputTriangle != "q")
                    {
                        Console.WriteLine("Try again");
                    }
                    break;

                case "s":
                    calcSquare();
                    Console.WriteLine("Press 'M' to return to return to main manu. ");
                    Console.WriteLine("Press 'Q' to return to return to main manu. ");
                    string userInputSquare = Console.ReadLine();
                    if (userInputSquare == "m")
                    {
                        mainMenu();
                    }
                    if (userInputSquare == "q")
                    {
                        Environment.Exit(0);
                    }
                    else if (userInputSquare != "m")
                    {
                        Console.WriteLine("Try again");
                    }
                    else if (userInputSquare != "q")
                    {
                        Console.WriteLine("Try again");
                    }
                    break;
                case "r":
                    calcRect();
                    Console.WriteLine("Press 'M' to return to return to main manu. ");
                    Console.WriteLine("Press 'Q' to return to return to main manu. ");
                    string userInputRect = Console.ReadLine();
                    if (userInputRect == "m")
                    {
                        mainMenu();
                    }
                    if (userInputRect == "q")
                    {
                        Environment.Exit(0);
                    }
                    else if (userInputRect != "m")
                    {
                        Console.WriteLine("Try again");
                    }
                    else if (userInputRect != "q")
                    {
                        Console.WriteLine("Try again");
                    }
                    break;

                    
                case "q":
                    Environment.Exit(0);
                    break;
                case "m":                    
                    Console.WriteLine("Main Menu placeholder");
                    mainMenu();
                    break;
                    
                default:
                    Console.WriteLine("Incorrect command. Please try again.");
                    Thread.Sleep(3000);
                    mainMenu();
                    break;
            }
            //Console.ReadKey();
        }

        static void calcCircle()
        {
            Console.WriteLine("Please enter the radius of the circle");
            double radius = Convert.ToDouble(Console.ReadLine());
            double pi = 3.141;
            double circleCircumference = 2 * (pi * radius);
            double circleArea = (2 * pi) * (2 * radius);

            Console.WriteLine("The circumference is: {0}  --  The area is: {1}", circleCircumference, circleArea);
            Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.Clear();
            Console.WriteLine("  ******  ");
            Console.WriteLine("****  ****");
            Console.WriteLine("**      **");
            Console.WriteLine("****  ****");
            Console.WriteLine("  ******  ");
            Console.ForegroundColor = ConsoleColor.White;


        }

        static void calcTriangle ()
        {
            Console.WriteLine("Please enter the first side of the triangle");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second side of the triangle");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the third side of the triangle");
            double c = Convert.ToDouble(Console.ReadLine());

            double triangleCircumference = a + b + c;

            Console.WriteLine("The circumference is: {0}", triangleCircumference);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("   ©   ");
            Console.WriteLine("  © ©  ");
            Console.WriteLine(" ©   © ");
            Console.WriteLine("© © © ©");

            Console.ForegroundColor = ConsoleColor.White;

        }

        static void calcSquare ()
        {
            Console.WriteLine("Please enter the length of one side of the square");
            double a = Convert.ToDouble(Console.ReadLine());

            double squareCircumference = 4 * a;
            double squareArea = 2 * a;

            Console.WriteLine("The circumference is: {0}", squareCircumference);
            Console.WriteLine("The area is: {0}", squareArea);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ______");
            Console.WriteLine("|      |");
            Console.WriteLine("|      | {0}", a);
            Console.WriteLine("|______|");
            Console.WriteLine("   {0}  ", a);

            Console.ForegroundColor = ConsoleColor.White;
        }

        static void calcRect()
        {
            Console.WriteLine("Please enter the length of the first side of the square");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the length of the second side of the square");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the length of the third side of the square");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the length of the fourth side of the square");
            double d = Convert.ToDouble(Console.ReadLine());
            double rectCircumference = a + b + c + d;

            Console.WriteLine("The circumference is: {0}", rectCircumference);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" __________");
            Console.WriteLine("|          |");
            Console.WriteLine("|          |");
            Console.WriteLine("|__________|");

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
