using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1__Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Continue = true;
            Console.Clear();

            do
            {
                Console.WriteLine("                             Welcome to Williams Calculator");
                Console.WriteLine("What would you wish to do ? + press 1, - press 2, * press 3, / press 4 . If you wish to quit press q");
                string answer = null;
                answer = Console.ReadLine();
                const string ADDITION = ("1");
                const string SUBTRACTION = ("2");
                const string MULTIPLICATION = ("3");
                const string DIVISION = ("4");
                const string QUIT = ("0");
            if (answer != QUIT && ( answer == ADDITION || answer == SUBTRACTION || answer == MULTIPLICATION || answer == DIVISION))
                {
                    double x = NubX();
                    double y = NubY();

                    if (answer == ADDITION)
                    {
                        Add(x, y);
                    }
                    else if (answer == SUBTRACTION)
                    {
                        Sub(x, y);
                    }
                    else if (answer == MULTIPLICATION)
                    {
                        Multi(x, y);
                    }
                    else if (answer == DIVISION)
                    {
                        Console.WriteLine("Remeber that in Division you cant divide by 0");
                        Div(x, y);                         
                    }
                }
                else
                {
                    if (answer == QUIT)
                    {
                      Console.WriteLine("Goodbye, come again at any time");
                    Console.ReadKey();
                    break;
                    }
                    else
                    {
                        Console.WriteLine("invalid charcter");
                        Console.ReadKey();
                        Console.Clear();
                        
                    }
                    
                }               
            } while (Continue);     
        }
        static void Add(double x, double y)
        {
            Console.WriteLine(x + " + " + y + " = " + (x + y));
            Console.ReadKey(); Console.Clear();
        }
        static void Sub(double x, double y)
        {
            Console.WriteLine(x + " - " + y + " = " + (x - y));
            Console.ReadKey(); Console.Clear();
        }
        static void Multi(double x, double y)
        {
            Console.WriteLine(x + " * " + y + " = " + (x * y));
            Console.ReadKey(); Console.Clear();
        }
        static void Div(double x, double y)
        {
            Console.WriteLine(x + " / " + y + " = " + (x / y));
            Console.ReadKey(); Console.Clear();
        }
        static double NubX()
        {
            double x = 0;
            bool alive = true;

            while (alive)
            {
                Console.Write("x = ");
                try
                {
                    x = Double.Parse(Console.ReadLine());
                    alive = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Charecter, try again");
                }
               
            }
            return x;
        }
        static double NubY()
        {
            double y = 0;
            bool alive = true;
         while (alive)
            {
                Console.Write("y = ");
                try
                {
                    y = Double.Parse(Console.ReadLine());
                    alive = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Character, try again");
                }
            }
            return y;
        }
    }
}