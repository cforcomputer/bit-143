﻿#define TESTING
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
            // put into main, and run as a stand-alone console application
        }
    }

    public class StackOfInts : SmartArray // this must inherit from the SmartArray class
                                          // ORIG: public class StackOfInts // this must inherit from the SmartArray class
    {
        /// topOfStack will be the index of the NEXT space that will be used
        /// So it therefore starts out at 0, meaning that 0 is UNoccupied.
        /// 
        // Question: Is 0 then the identifier for all unoccupied slots?
        protected int topOfStack { get; set; }

        // Allocates the array that the StackOfInts will use to store the integers
        public StackOfInts()
        {
            // note: not sure what size to allocate to the array, constructor starts at 0 - increases based on 
            // value of topOfStack when new items added to the stack?
            this.rgNums = new int[5];
        }

        // TRUE if the stack currently contains NO elements.
        // FALSE otherwise
        public bool isEmpty()
        {
            // testing
            if (rgNums.Length == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // returns nothing
        // throws an OverflowException if the stack runs out of space space in the underlying array
        // Parameters: an integer that is the value to be added to the top of the stack
        // This method will take the value given by the parameter, and add it to the top of the stack.

        // HINT: In order for this to work, you must adjust topOfStack, an objective of this exercise 
        // is to figure out how.
        public void Push(int item)
        {
            // if the array is full
            if (topOfStack == rgNums.Length - 1)
            {
                throw new OverflowException("The stack is full!");
            }
            else
            {
                rgNums[topOfStack] = item;
                Console.WriteLine("Added {0} to the top of the stack", item);
            }
        }
        public int Peek()
        {
            // check to see if the stack is empty
            if (isEmpty())
            {
                throw new UnderflowException("The stack is empty!");
            }

            return topOfStack;
        }

        public int Pop()
        {
            // check to see if the stack is empty or full
            if (isEmpty())
            {
                throw new UnderflowException("The stack is empty!");
            }
            // if the array is not empty, return the top-most item on the stack AND remove it
            int stackVal = rgNums[topOfStack - 1];
            rgNums[topOfStack - 1] = 0;
            return stackVal;
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
            SmartArray test1 = new SmartArray();
            test1.SetAtIndex(5, 12);
            test1.SetAtIndex(10, 11);
            test1.GetAtIndex(5);
            test1.PrintAllElements();
        }

        public void SetAtIndex(int idx, int val)
        {
            //////////////////REUSED CODE/////////////////
            // set the value at the index
            if (idx < 0)
            {
                throw new UnderflowException("The index is less than zero!");
            }

            else if (idx > rgNums.Length || rgNums.Length == idx)
            {
                throw new OverflowException("The array is out of bounds!");
            }
            // check to make sure the index is set
            // set rgNums[idx] out as val
            rgNums[idx] = val;
        }
        public int GetAtIndex(int idx)
        {
            //////////////////REUSED CODE/////////////////
            // Checks to see if the slot can be accessed
            if (idx < 0)
            {
                throw new UnderflowException("The index is less than zero!");
            }
            else if (idx > rgNums.Length || rgNums.Length == idx)
            {
                throw new OverflowException("The array is out of bounds!");
            }
            else
            {
            //    val = rgNums[idx];
                Console.WriteLine(rgNums[idx]);
                return rgNums[idx];
            }
        }
        public void PrintAllElements()
        {
            //////////////////REUSED CODE/////////////////
            for (int i = 0; i < rgNums.Length; i++)
            {
                Console.WriteLine(rgNums[i]);
            }
        }
        public bool Find(int val)
        {
            //////////////////REUSED CODE/////////////////
            // search the entire length of the array for the value val
            for (int i = 0; i < rgNums.Length; i++)
            {
                if (rgNums[i] == val)
                {
                    return true;
                }
            }
            return false;
        }
        /// An integer – the size, in number of elements, that the SmartArray currently has the capacity to hold.
        public int getSize()
        {
            return rgNums.Length;
        }
    }

    public class QueueOfInts : SmartArray
    {
        protected int count = 0;
        protected int frontOfQueue = 0;
        protected int outVar;

        // backOfQueue will be the index of the NEXT space that will be used
        // So it therefore starts out at 0, meaning that 0 is UNoccupied.
        protected int backOfQueue = 0;

        // default constructor
        // allocates the array that the QueueOfInts will use to store the integers
        public QueueOfInts()
            : base()
        {
            this.rgNums = new int[5];
        }

        public bool isEmpty()
        {
            // needs to inherit from StackOfInts isEmpty?
            // testing
            if (rgNums.Length == -1)
            {
                PrintQState("isEmpty()");
                return true;                
            }
            else
            {
                return false;
            }
        }
        public void Enqueue(int item)
        {
            // needs to reuse code from SmartArray
            // item = an integer that is the value to be added to the front of the queue
            // required to implement a circular queue even though smart array already handles extra space.
            // PrintQState("isEmpty()");

            // if full, throw an overflow exception
            // 11:00-Queue API Impl
            if (count >= rgNums.Length)
            {
                throw new OverflowException("The queue is full!");
            }
            count++;
            // If A is true, if not, then use C --> Adjusting backOfQueue
            // Expression, not a statement
            // the value of backOfQueue is 
            backOfQueue = ((backOfQueue + 1) == rgNums.Length) ? 0 : (backOfQueue + 1);

            // add the new item to the queue
            rgNums[backOfQueue] = item;
        }
        public int Peek()
        {
            // check to see if the stack is empty
            if (this.isEmpty())
            {
                throw new UnderflowException("The queue is empty!");
            }

            return frontOfQueue;
        }

        // NO PARAMETERS
        // Copies the front-most item into the out parameter (yo what?)
        // Then removes the front-most item from the queue
        public int Dequeue()
        {
            if (rgNums == null)
            {
                throw new UnderflowException("The queue is empty!");
            }

            // If there is an item at the front of the queue, copy it and then remove that item.
            if (frontOfQueue != -1)
            {
                outVar = rgNums[frontOfQueue];
                rgNums[frontOfQueue] = 0;
            }
            
            return rgNums[frontOfQueue];
        }

        // While not required, you may find this useful for your own debugging 
        public void PrintQState(string fnx)
        {
            Console.WriteLine(" QUEUE STATE: =======================");
            Console.WriteLine(" Calling {0}", fnx);
            Console.WriteLine("count:{0}", count);
            Console.WriteLine("this.getSize:{0}", this.getSize());
            Console.WriteLine("frontOfQueue:{0}", frontOfQueue);
            Console.WriteLine("backOfQueue:{0}", backOfQueue);

            int val;
            for (int i = 0; i < this.getSize(); i++)
            {
                // this.GetAtIndex(i, out val);
                // Console.WriteLine("\tIndex: {0}\tValue:{1}", i, val);
            }
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
