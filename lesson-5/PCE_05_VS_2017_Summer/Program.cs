#define TESTING
using System;

/*
 * STUDENTS: Your answers (your code) goes into this file!!!!
 * 
  * NOTE: In addition to your answers, this file also contains a 'main' method, 
 *      in case you want to run a normal console application.
 * 
 * If you want to / have to put something into 'Main' for these PCEs, then put that 
 * into the Program.Main method that is located below, 
 * then select this project as startup object 
 * (Right-click on the project, then select 'Set As Startup Object'), then run it 
 * just like any other normal, console app: use the menu item Debug->Start Debugging, or 
 * Debug->Start Without Debugging
 * 
 */

namespace PCE_StarterProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            RecursiveMethods recur = new RecursiveMethods();
            // recur.Print_Numbers_Recursively();
            // recur.PrintEvenNumbers_Iteratively(16);
            // recur.PrintEvenNumbers_Recursively(16);
            // recur.PowR(2, 3);
            recur.MultR(6, 2);
        }
    }

    class What_Does_This_Code_Print
    {
        // There is no code to write for this exercise
        // Put your answer, in comments, here:
        //
        //
        //
    }

    class Warmup
    {
        // There is no code to write for this exercise
        // Put your answer, in comments, here:
        //
        //
        //
    }

    class Warmup_Number2
    {
        // There is no code to write for this exercise
        // Put your answer, in comments, here:
        //
        //
        //
    }

    class Warmup_Number3
    {
        // There is no code to write for this exercise
        // Put your answer, in comments, here:
        //
        //
        //
    }

    class Warmup_MoreComplicated
    {
        // There is no code to write for this exercise
        // Put your answer, in comments, here:
        //
        //
        //
    }


    /////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////

    class Recursively_Printing_Even_Numbers
    {
        public void RunExercise()
        {
            // RecursiveMethods rm = new RecursiveMethods();
            // rm.PrintEvenNumbers_Recursively(3);
        }
    }

    public class RecursiveMethods
    {
        int baseNum = 1;
        // recursively print the numbers 1 - 10
        public void Print_Numbers_Recursively()
        {           
            
            if (baseNum <= 10)
            {
                Console.WriteLine(baseNum);
                baseNum++;

                Print_Numbers_Recursively();
            }
        }

        // counts down from N to baseNum with a standard loop
        public void PrintEvenNumbers_Iteratively(int N)
        {
            for (int baseNum2 = -1; N != baseNum2; N--)
            {
                if (N % 2 == 0) // if even
                {
                    Console.WriteLine("Argument: {0}", N);
                }
            }
        }

        int baseNum3 = -1;
        virtual public void PrintEvenNumbers_Recursively(int N)
        {
            if (N > baseNum3)
            {
                if (N % 2 == 0)
                {
                    Console.WriteLine("Argument: {0}", N);
                }
                PrintEvenNumbers_Recursively(N - 1);
            }            
        }


        // The method should take two integer parameters named B and E, and will return the value of B^E.  (for example, PowR(2,3) = 8, PowR(3,2) = 9, etc) 4
        // You're not allowed to simply call the built-in Math.Pow method, and return the value, though – you need to find a way, by adjusting the values that
        // you pass to the successive recursive calls, to get this to happen.  You only need to make this work for non-negative, whole numbers. 

        // Make sure that your code does the right thing for positive numbers, zero, and negative numbers for both the base and the exponent.If a particular
        // value(such as a negative exponent) doesn’t make sense(or is outside the scope of this exercise), your PowR method should catch that error, and then return 0. 
        public int PowR(int b, int exp)
        {
            // ex: b = 2 exp = 3
            // 2 ^ 3 == 8
            if (exp < 1)
            {
                return 1;
            }
            else
            {
                int tester = PowR(b, exp - 1); // 1 * 
                Console.WriteLine(tester + " --> call PowR \n");
                tester *=  b;
                Console.WriteLine(tester + " --> multiply by base value  b \n");
                return tester;
            }
        }

        // handles one-time initialization-type work
        public int MultR(int a, int b)
        {
            // int baseNum;
            int val = __MultR(a, b);
            Console.WriteLine("The value of {0} * {1} = {2}", a, b, val);
            return val;
           
        }
        // private method handles the recursion
        private int __MultR(int a, int b)
        {
            // check to see if a is less than b, then if it is, swap them and check to make sure 
            // b is not equal to 0.
            if (a < b)
            {
                return __MultR(b, a);
            }
            else if (b != 0)
            {
                return (a + __MultR(a, b - 1));
            }
            else
                return 0;

        }

        public int Factorial(int n)
        {
            return -1;
        }

        public void Fibonacci_Array(int[] array)
        {
            throw new Exception("YOU NEED TO REMOVE THIS LINE OF CODE, AND IMPLEMENT THIS METHOD");
        }
    }

    public class MyLinkedList
    {
        protected class LinkedListNode
        {
            public int m_data;
            public LinkedListNode m_next;
        }

        // first item in the list, automtically given the value null
        protected LinkedListNode m_first;

        // from previous ICEs:
        public void InsertAtFront(int value)
        {
            // YOUR CODE GOES HERE!!
            // You are allowed to copy-and-paste your prior work into here
            // HOWEVER
            // it's great practice to re-code this; you should be able to code
            // this up in ~5 minutes or so, including testing.  So re-typing
            // this is actually a good thing to do.
            // return;
        }

        public void Print()
        {
            RecursivelyPrintForward();
        }

        public void RecursivelyPrintForward()
        {
            Console.WriteLine("YOU NEED TO IMPLEMENT THIS!");
            return;
        }

        public void RecursivelyPrintBackward()
        {
            Console.WriteLine("YOU NEED TO IMPLEMENT THIS!");
            return;
        }

        public void RecursivelyPrint(bool fwd)
        {
            Console.WriteLine("YOU NEED TO IMPLEMENT THIS!");
            return;
        }
    }

}
