using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code is used by the first exercise
            // It is left here, uncommented, so that it's easy for you to run
            // Once you complete it, feel free to comment these lines out
            // That way, you won't have every single exercise being run, each and
            // every time :)
            //IO_Operators ioo = new IO_Operators();
            //ioo.RunExercise();

            //Fibonnaci_With_Array fwa = new Fibonnaci_With_Array();
            //fwa.RunExercise();

            Scope_Of_Variables sov = new Scope_Of_Variables();
            sov.RunExercise();

            //Array_Of_Ints aoi = new Array_Of_Ints();
            //aoi.RunExercise();
        }
    }

    class IO_Operators
    {
        public void RunExercise()
        {
            Console.WriteLine("Please enter two integers");

            int intOne = Convert.ToInt32(Console.ReadLine());
            int intTwo = Convert.ToInt32(Console.ReadLine());

            int result = intOne - intTwo;

            // Find the absolute value difference
            if (result < 0)
            {
                result *= -1;
            }

            // If the absolute value is <= 5 then print
            if (result <= 5)
            {
                Console.WriteLine("{0} and {1} are within 5 integers of each other.", intOne, intTwo);
            }
            else
            {
                Console.WriteLine("{0} and {1} are NOT within 5 integers of each other.", intOne, intTwo);
            }
        }
    }

    class Fibonnaci_With_Array
    {
        public void RunExercise()
        {
            // Create a new array with 20 slots
            int[] fib = new int[20];

            // Assign the first two slots to 0 and 1
            fib[0] = 0;
            fib[1] = 1;

            // Print the first two slots before the loop
            Console.WriteLine(fib[0] + "\n" + fib[1]);

            // Starting from slot 3, fill the loop with fibonacci sequence
            for (int c = 2; c <= fib.Length; c++)
            { 
                try
                {
                    // Array out of bounds because ?
                    fib[c] = fib[c - 1] + fib[c - 2];
                }
                catch
                {
                    break;
                }

                Console.WriteLine(fib[c]);
            }            
        }
    }

    class Scope_Of_Variables
    {
        // Put your comment here:

        public void RunExercise()
        {
            NumberPrinter np = new NumberPrinter();
            np.SetLowest(3.14159);
            np.SetHighest(12);
            np.Print(true);
            np.SetHighest(17.1);
            np.Print(false);
        }
    }

    // New class called NumberPrinter
    class NumberPrinter
    {
        private int highest;
        private int lowest;

        // Constructor that sets the lowest and the highest to be 0
        public NumberPrinter()
        {
            highest = 0;
            lowest = 0;
        }

        public void SetHighest(double high)
        {
            highest = Convert.ToInt32(high);
        }

        public void SetLowest(double low)
        {
            lowest = Convert.ToInt32(low);
        }
        public void Print(bool even)
        {
            if (!even)
            {
                for (int i = lowest; i <= highest; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = lowest; i <= highest; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
                   
        }
    }

    class Object_Composition_Circle
    {
        public void RunExercise()
        {
            //// Quick test for your Point class:
            //Point pt1 = new Point(10, 20);
            //// Pt1 is located at (10,20)
            //Point pt2 = new Point(0, 0);
            //// Pt2 is at the origin

            //pt1.Print(); // Prints out something like (10, 20)
            //pt2.Print(); // Prints out something like (0, 0)
            //pt1.setX(-10);
            //pt1.Print(); // Now prints out (-10, 20)
            //pt2.setY(10);
            //pt2.Print(); // Prints out something like (0, 10)
            //Console.WriteLine("pt1 is at {0} and {1}", pt1.getX(), pt1.getY());
            //// prints out: pt1 is at -10 and 20

            //// Note that even though c1 & c2 are using Point
            //// objects to store the location, we're still passing
            //// in the x & y values separately 
            //Circle c1 = new Circle(10, 20, 3);
            //// c1 is located at (10,20), with radius = 3
            //Circle c2 = new Circle(0, 0, 4);
            //// c2 is at the origin, radius is 4

            //c1.Print(); // Prints out something like (10, 20) radius=3
            //c2.Print(); // Prints out something like (0, 0) radius=4
            //c1.setX(-10);
            //c1.Print(); // Now prints out (-10, 20) radius=3
            //c2.setY(10);
            //c2.setRadius(10);
            //c2.Print(); // Prints out something like (0, 10) radius=10
            //Console.WriteLine("c1 is at {0} and {1}, with radius of {2}",
            //    c1.getX(), c1.getY(), c1.getRadius());
            //// prints out c1 is at -10 and 20, with radius of 3
        }
    }
    // this is a good place to put your Point and Circle classes


    class Array_Of_Ints
    {
        public void RunExercise()
        {
        }
    }
}