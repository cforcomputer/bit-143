using System;
using System.Collections;
using System.Collections.Generic;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using_DotNets_Stack uds = new Using_DotNets_Stack();
            //uds.RunExercise();

            Reversing_User_Input rui = new Reversing_User_Input();
            rui.RunExercise();

            //Basic_Generic_Test_Code bgtc = new Basic_Generic_Test_Code();
            //bgtc.RunExercise();

            //Basic_AbsValComparer_Test_Code bavctc = new Basic_AbsValComparer_Test_Code();
            //bavctc.RunExercise();

            // add more here, as you need
        }
    }

    class What_Is_A_Stack 
    {
        // Put your answer here (in comments)
        /// A stack is a container of objects that are inserted and removed according to the last-in first-out
        /// LIFO principle. In the pushdown stacks, only two operations are allowed: push the item into the stack,
        /// and pop the item out of the stack. 
        /// A stack is a limited access data structure - elements can be removed and added only from the top. 
        /// push = adds an item to the top of the stack
        /// pop = removes an item from the top
        /// A stack is a recursive data structure 
        /// it is either empty, or consists of a top, and the rest is a stack.
        /// 
        /// Applications:
        /// Reversing a word
        /// The undo mechanism in text editors
        /// Backtracking -- The process when you access the most recent element in a series of elements. 
        /// Therefore at each point you on a stack all possible choice. Backtracking means popping a next 
        /// choice from the stack.
        /// Language processing -- space for parameters and local variables is created internally using a stack.
        /// Compiler's syntax check for matching braces is implemented using a stack.
        /// Support for recursion.
        /// 
        /// Implementations
        /// Array based, Linked List
        /// 
        // Answer to 2. 
        /// Push 1, 2, and 3 onto a stack.
        /// 1-2-3
        /// Pop the stack twice.
        /// 1
        /// Then push 4 and 5
        /// 1-4-5
        /// The top end is the 5, since it was the last number (presumptively) to be added to the stack.
        /// Each new number placed on the stack ends up on top of the last number to be added.
    }


    class Car
    {
    }

    class Using_DotNets_Stack 
    {
        // Your comment explaining the running time of
        // Push goes here
        /// When talking about the O(1) operation and O(N) operations:
        /// What does O(1) operation apply to in a stack?
        /// A: Peek, push, and pop
        /// There is not much processing involved in these cases, and they are merely returning a singular primitive.
        /// What does N refer to in the context of Push?
        /// A: N refers to the number of items in the stack. This would apply if we are using (ex: loop)
        /// to pass through the stack to find a specific number.

		// Make sure that "using System.Collections;" is at the top of this file
        public void RunExercise()
        {
            // Create a stack
            // Push numbers 1, 2 and 3
            // Pop off the values and print them as you do so
            // Make sure to use push, pop, and peek methods in code
            // Less than 25 lines

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            // 1, 2, 3
            
            for (int i = 0; i < stack.Count; i++)
            {
                // Print the stack and then pop that value in the stack.
                Console.WriteLine("Pop\t\t{0}", stack.Pop());
            }
            Console.WriteLine("Peek\t\t{0}", stack.Peek());
        }
    }

    class Reversing_User_Input
    {
        public void RunExercise()
        {
            // Create generic stack object
            Stack<int> stack = new Stack<int>();
            int readLine = 0;

            while (readLine > -1)
            {
                Console.WriteLine("Please type a number");
                Console.WriteLine("Please type a negative number to stop");
                readLine = Convert.ToInt32(Console.ReadLine());
                // Check to see if negative or not
                if (readLine > -1)
                {
                    stack.Push(readLine);
                }
            }
            Console.WriteLine("Here's what you typed, backwards:");

            // Print contents of array backwards
            for (int i = 0; i < stack.Count; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine(stack.Peek());
        }
    }

    class Basic_Generic_Test_Code
    {
        //public void RunExercise()
        //{
        //    //These lines of code have been commented out.
        //    // They won't compile until you implement the generic
        //    // BasicGeneric class.

        //    // Note that you should NOT modify this code at all:

        //    //////////////// ints /////////////////////////////////////////////
        //    Console.WriteLine("=============================");
        //    Console.WriteLine("Test for INT");
        //    Console.WriteLine("=============================\n");

        //    BasicGeneric<int> basic_int = new BasicGeneric<int>();
        //    int intValueToStore = 100;
        //    basic_int.SetItem(intValueToStore);

        //    Console.WriteLine("Stored {0}, Print() tells us:", intValueToStore );
        //    basic_int.Print();

        //    double intCheckVal = basic_int.GetItem();
        //    Console.WriteLine("Using Get, got back: {0}", intCheckVal);
        //    if (intCheckVal != intValueToStore )
        //        Console.WriteLine("\tERROR: checkVal is not {0}", intValueToStore );
        //    else
        //        Console.WriteLine("\tGetItem appeared to work!");

        //    //////////////// doubles //////////////////////////////////////////
        //    Console.WriteLine("\n=============================");
        //    Console.WriteLine("Test for DOUBLE");
        //    Console.WriteLine("=============================\n");
        //    BasicGeneric<double> basic_double = new BasicGeneric<double>();
        //    double doubleValueToStore = 3.14159;
        //    basic_double.SetItem(doubleValueToStore);

        //    Console.WriteLine("Stored {0}, Print() tells us:", doubleValueToStore);
        //    basic_double.Print();

        //    double doubleCheckVal = basic_double.GetItem();
        //    Console.WriteLine("Using Get, got back: {0}", doubleCheckVal);
        //    if (doubleCheckVal != doubleValueToStore)
        //        Console.WriteLine("\tERROR: checkVal is not {0}", doubleValueToStore);
        //    else
        //        Console.WriteLine("\tGetItem appeared to work!");

        //    //////////////// strings //////////////////////////////////////////
        //    Console.WriteLine("\n=============================");
        //    Console.WriteLine("Test for STRING");
        //    Console.WriteLine("=============================\n");

        //    BasicGeneric<string> basic_string = new BasicGeneric<string>();
        //    string stringValueToStore  = "fun  text here";
        //    basic_string.SetItem(stringValueToStore );

        //    Console.WriteLine("Stored {0}, Print() tells us:", stringValueToStore );
        //    basic_string.Print();

        //    string stringCheckVal = basic_string.GetItem();
        //    Console.WriteLine("Using Get, got back: {0}", stringCheckVal);

        //    // != is ok for strings in C#, but not in Java
        //    if (stringCheckVal != stringValueToStore ) 
        //        Console.WriteLine("\tERROR: checkVal is not {0}", stringValueToStore );
        //    else
        //        Console.WriteLine("\tGetItem appeared to work!");
        //}
    }

    // please put your 'BasicGeneric' class here

    class Basic_AbsValComparer_Test_Code
    {
        public void RunExercise()
        {
            //AbsValComparer absolute_val_comp = new AbsValComparer();

            //List<double> nums = new List<double>();

            //nums.Add(20.4);
            //nums.Add(-20.4);
            //nums.Add(-10.3);
            //nums.Add(3.1);
            //nums.Add(-4.2);

            //Console.WriteLine("Before sorting:\n");
            //foreach( double num in nums)
            //{
            //    Console.WriteLine(num);
            //}

            //nums.Sort(absolute_val_comp);

            //Console.WriteLine("\nAfter sorting\n");

            //foreach (double num in nums)
            //{
            //    Console.WriteLine(num);
            //}

            //double[] nums_to_find = { 3.1, -4.2, -20.4, 999 };
            //foreach( double targetNum in nums_to_find)
            //{
            //    int loc = nums.BinarySearch(targetNum, absolute_val_comp);
            //    if (loc >= 0)
            //        Console.WriteLine("Found {0} at location {1}", targetNum, loc);
            //    else
            //        Console.WriteLine("Did not find {0}", targetNum);
            //}
        }
    }

    // please put your 'AbsValComparer' class here


    class What_Is_An_Enum
    {
        // What is an enum? Why would you want to use one?
        /// An enum (short for enumeration) in C#, is a keyword that represents a value type for declaring a set of
        /// named integer constants. It can be defined using the enum keywork directly inside a namespace, class, or structure
        /// The enum is used to give a name to each constant so that the constant integer can be referred using its name.
 
               
        // Why is an enum better than a public const int? (or a public static readonly int)?
        /// Because, unlike the int, it makes code more readable by giving related constants meaningful names.
        /// it also simultaneously improves maintainability by giving developers a simple reference for constants.
    }
}

