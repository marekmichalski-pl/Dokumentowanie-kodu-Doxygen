using System;

namespace Shapes
{
    class Program
    {
        /// <summary>
        /// Main function.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            while (true)
            {
                PrintMenu();

                var key = Console.ReadLine();

                switch (key)
                {
                    case "0":
                        CloseApplication();
                        break;
                    case "1":
                        DefineCircle();
                        break;
                    case "2":
                        DefineTriangle();
                        break;
                    case "3":
                        DefineRectangle();
                        break;
                    default:
                        break;
                }
            }
        }


        /// <summary>
        /// Clear screen and show main menu.
        /// </summary>
        private static void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine("======= SHAPES ========");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("");
            Console.WriteLine("0. Exit");
            Console.WriteLine("=======================");
            Console.Write("Your choose: ");
        }

        /// <summary>
        /// Terminate application.
        /// </summary>
        private static void CloseApplication()
        {
            Console.WriteLine("Exiting...");
            Environment.Exit(0);
            return;
        }

        /// <summary>
        /// Calculations for circle.
        /// </summary>
        private static void DefineCircle()
        {
            double r;

            Console.WriteLine("");
            Console.WriteLine("Define circle:");
            try
            {
                r = GetValue("r = ");

                Circle shape = new Circle(r);

                PrintResult(shape.Info());
            }
            catch (FormatException)
            {
                PrintError("is not a number");
            }
            finally
            {
                Console.WriteLine("Press any kay to continue....");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Calculations for triangle.
        /// </summary>
        private static void DefineRectangle()
        {
            double a, b;

            Console.WriteLine("");
            Console.WriteLine("Define rectangle:");
            try
            {
                a = GetValue("a = ");
                b = GetValue("b = ");

                Rectangle shape = new Rectangle(a, b);

                PrintResult(shape.Info());
            }
            catch (FormatException)
            {
                PrintError("is not a number");
            }
            finally
            {
                Console.WriteLine("Press any kay to continue....");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// Calculations for triangle.
        /// </summary>
        private static void DefineTriangle()
        {
            double a, b, c;

            Console.WriteLine("");
            Console.WriteLine("Define triangle:");
            try
            {
                a = GetValue("a = ");
                b = GetValue("b = ");
                c = GetValue("c = ");

                Triangle shape = new Triangle(a, b, c);

                PrintResult(shape.Info());
            }
            catch (FormatException)
            {
                PrintError("is not a number");
            }
            catch (ArgumentException)
            {
                PrintError("Creating a triangle is not possible with defined a, b, c.");
            }
            finally
            {
                Console.WriteLine("Press any kay to continue....");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Get number from console. 
        /// </summary>
        /// <param name="s">Number (text format).</param>
        /// <returns>Number as double.</returns>
        private static double GetValue(string s)
        {
            /// \bug Decimal separator dependsof culture context. Need to change for both ("." and ","). 
            
            Console.Write(s);
            s = Console.ReadLine();
           
            return Convert.ToDouble(s);
        }

        /// <summary>
        /// Print info about error (red color) and write info in logger file.
        /// </summary>
        /// <param name="s">Text to show (error description).</param>
        private static void PrintError(string s)
        {
            var c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: " + s);
            Console.ForegroundColor = c;

            Logger.Error("is not a number");
        }

        /// <summary>
        /// Print result (yellow color).
        /// </summary>
        /// <param name="s">Text to show.</param>
        private static void PrintResult(string s)
        {
            var c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(s);
            Console.ForegroundColor = c;
        }
    }
}
