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

            //Scope_Of_Variables sov = new Scope_Of_Variables();
            //sov.RunExercise();

            //Array_Of_Ints aoi = new Array_Of_Ints();
            //aoi.RunExercise();

            //Object_Composition_Circle circ = new Object_Composition_Circle();
            //circ.RunExercise();
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
        // Instance variables = defined within the class but outside the method. Defined without static.
        // Lasts as long as the class is executing.
        // Local variables = Defined within the method, lasts as long as the method.
        // Parameter = Defined in a method declaration, lasts as long as the method.
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
            // Quick test for your Point class:
            Point pt1 = new Point(10, 20);
            // Pt1 is located at (10,20)
            Point pt2 = new Point(0, 0);
            // Pt2 is at the origin

            pt1.Print(); // Prints out something like (10, 20)
            pt2.Print(); // Prints out something like (0, 0)
            pt1.SetX(-10);
            pt1.Print(); // Now prints out (-10, 20)
            pt2.SetY(10);
            pt2.Print(); // Prints out something like (0, 10)
            Console.WriteLine("pt1 is at {0} and {1}", pt1.GetX(), pt1.GetY());
            // prints out: pt1 is at -10 and 20

            // Note that even though c1 & c2 are using Point
            // objects to store the location, we're still passing
            // in the x & y values separately 
            Circle c1 = new Circle(10, 20, 3);
            // c1 is located at (10,20), with radius = 3
            Circle c2 = new Circle(0, 0, 4);
            // c2 is at the origin, radius is 4

            c1.Print(); // Prints out something like (10, 20) radius=3
            c2.Print(); // Prints out something like (0, 0) radius=4
            c1.SetX(-10);
            c1.Print(); // Now prints out (-10, 20) radius=3
            c2.SetY(10);
            c2.SetRadius(10);
            c2.Print(); // Prints out something like (0, 10) radius=10
            Console.WriteLine("c1 is at {0} and {1}, with radius of {2}",
                c1.GetX(), c1.GetY(), c1.GetRadius());
            // prints out c1 is at -10 and 20, with radius of 3
        }
    }
    // this is a good place to put your Point and Circle classes

    class Point
    {
        // Instance variables
        private double x;
        private double y;

        // Constructor
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        ////////////////////////////////////////////////////////////////////////////
        // Getters and Setters //
        public double GetX()
        {
            return x;
        }
        public void SetX(double setVal)
        {
            x = setVal;
        }
        public double GetY()
        {
            return y;
        }
        public void SetY(double setVal)
        {
            y = setVal;
        }
        ////////////////////////////////////////////////////////////////////////////
        
        public void Print()
        {
            Console.WriteLine("({0}, {1})", x, y);
        }
    }

    // Create a circle class
    class Circle
    {
        private double radius;
        private double x;
        private double y;

        //private Point circlePoint;
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double rad)
        {
            this.radius = rad;
        }

        public double GetX()
        {
            return x;
        }
        public void SetX(double setVal)
        {
            this.x = setVal;
        }
        public double GetY()
        {
            return y;
        }
        public void SetY(double setVal)
        {
            this.y = setVal;
        }
        
        public Circle(double xPoint, double yPoint, double rad)
        {
            //Point circ = new Point(xPoint, yPoint);
            //this.circlePoint = circ;
            this.radius = rad;
            this.x = xPoint;
            this.y = yPoint;
        }

        public void Print()
        {
            Console.WriteLine();
            //circlePoint.Print();
            //({0}, {1})
            Console.WriteLine("({0}, {1}) radius={2} \n", x, y, radius);
        }
    }

    class Array_Of_Ints
    {
        public void RunExercise()
        {
            int userCheck = 10;
            int select = 0;
                        
            while (userCheck != 1000)
            {
                Console.WriteLine("Please enter the size of the array: ");
                try
                {
                    userCheck = Convert.ToInt32(Console.ReadLine());
                
                    int[] ray = new int[userCheck];
                
                for (int i = 0; i < ray.Length; i++)
                {
                    if (!(i % 2 == 0))
                    {
                        ray[i] = i;
                        Console.WriteLine(ray[i]);
                    }
                }
                Console.WriteLine("\nWhat space in the array would you like to examine?");
                select = Convert.ToInt32(Console.ReadLine());
                
                if (select > ray.Length || select < 0)
                {
                    Console.WriteLine("You did an oopsy");
                }
                else
                {
                    Console.WriteLine(ray[select]);
                }

                }
                catch
                {
                    Console.WriteLine("The value was incorrect for int32");
                }
            }
        }
    }
}