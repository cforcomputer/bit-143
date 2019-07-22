#define TESTING
using System;

/*
 * STUDENTS: Your answers (your code) goes into this file!!!!
 * 
 * NOTE: In addition to your answers, this file also contains a 'main' method, 
 *      in case you want to run a normal console application.
 *  
 */

namespace PCE_StarterProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Use this for any code that you want to
            // put into main, and run as a stand-alone console applicatiion
        }
    }

    public class StackOfInts : SmartArray // this must inherit from the SmartArray class
                                          // ORIG: public class StackOfInts // this must inherit from the SmartArray class
    {
        /// <summary>
        /// topOfStack will be the index of the NEXT space that will be used
        /// So it therefore starts out at 0, meaning that 0 is UNoccupied.
        /// </summary>
        protected int topOfStack = 0;
        public StackOfInts()
        {
        }

        public bool isEmpty()
        {
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");
        }
        public void Push(int item)
        {
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");
        }
        public int Peek()
        {
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");
        }

        public int Pop()
        {
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");
        }
    }

    public class UnderflowException : Exception
    { public UnderflowException(string s) : base(s) { } }
    public class OverflowException : Exception
    { public OverflowException(string s) : base(s) { } }

    // You should replace this with your (working) SmartArray
    // Note that you'll have to implement getSize in order for the
    // rest of the code to compile & run :)
    public class SmartArray
    {
        protected int[] rgNums = new int[5];

        public SmartArray()
        {

        }

        public void SetAtIndex(int idx, int val)
        {
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");
        }
        public int GetAtIndex(int idx)
        {
            throw new OverflowException("Index out of bounds");
        }
        public void PrintAllElements()
        {
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");
        }
        public bool Find(int val)
        {
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");
        }
        public int getSize()
        {
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");
        }
    }

    public class QueueOfInts : SmartArray
    {
        protected int count = 0;
        protected int frontOfQueue = 0;

        // backOfQueue will be the index of the NEXT space that will be used
        // So it therefore starts out at 0, meaning that 0 is UNoccupied.
        protected int backOfQueue = 0;

        public QueueOfInts()
            : base()
        {
        }

        public bool isEmpty()
        {
            PrintQState("isEmpty()");
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");
        }
        public void Enqueue(int item)
        {
            PrintQState("isEmpty()");
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");
        }
        public int Peek()
        {
            PrintQState("isEmpty()");
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");
        }

        public int Dequeue()
        {
            PrintQState("isEmpty()");
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");

        }

        // While not required, you may find this useful for your own debugging 
        public void PrintQState(string fnx)
        {
            //Console.WriteLine(" QUEUE STATE: =======================");
            //Console.WriteLine(" Calling {0}", fnx);
            //Console.WriteLine("count:{0}", count);
            //Console.WriteLine("this.getSize:{0}", this.getSize());
            //Console.WriteLine("frontOfQueue:{0}", frontOfQueue);
            //Console.WriteLine("backOfQueue:{0}", backOfQueue);

            //int val;
            //for (int i = 0; i < this.getSize(); i++)
            //{
            //    this.GetAtIndex(i, out val);
            //    Console.WriteLine("\tIndex: {0}\tValue:{1}", i, val);
            //}
        }

    }

    public class SmartArrayResizable : SmartArray
    {
        public SmartArrayResizable()
        {

        }

        public void Resize(int newSize)
        {
            throw new Exception("YOU NEED TO IMPLEMENT THIS!");
        }
    }

    class What_Is_A_Generic
    {
        // Put your comment here
    }

    // Your job is to finish this class, by implementing the three missing methods:
    class BasicGeneric<T>
    {
        // T storedItem;

        // You'll need to add a
        // SetItem method

        // You'll need to add a
        // GetItem method

        // You'll need to add a
        // Print method


        // And that's it!
    }

    class ProgramLogic
    {
        private int theData;
        public ProgramLogic()
        {
            theData = 0;
        }

        public void PrintData()
        {
            Console.WriteLine(theData);
        }

        // Method is defined to be virtual in the base class
        public override string ToString()
        {
            return "ProgramLogic object containing: " + theData.ToString();
        }

        public int Data
        {
            get
            {
                return theData;
            }
            set
            {
                theData = value;
            }
        }
    }
}
