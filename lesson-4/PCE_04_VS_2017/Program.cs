
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
    public class UnderflowException : Exception
    { public UnderflowException(string s) : base(s) { } }
    public class OverflowException : Exception
    { public OverflowException(string s) : base(s) { } }


    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            // Test for adding to front of list //
            MyIntList cc = new MyIntList();
            cc.AddToFront(50);

            for (int i = 0; i < 3; i++)
            {
                cc.AddToFront(3);
            }

            cc.PrintAll();
        }
    }

    // Is this where the IntListNode should go?
    public class IntListNode // should this class be marked public?
    {                           // HINT: private is NOT the correct access for this class

        public int Data; // should be public (which makes sense, once you've moved it & changed it to not be public)
        public IntListNode Next; // should also be public
    }

    public class MyIntList
    {
        // instance variables, if any
        protected IntListNode first; // protected so that the LinkedList_Verifier can get to it


        // constructor(s), if any


        ////////////////////////// Nested classes: basics assignment //////////////////////////////
        protected class IntListNode
        {

            public int m_data;
            public IntListNode m_next;

            // Add a constructor which takes as an argument an int that it will store
            public IntListNode(int data)
            {
                m_data = data;
                // m_next = null; // automatically done by CLR, so I don't have to
            }

            public IntListNode(int data, IntListNode next)
                : this(data)
            {
                m_next = next;
            }
        }

        // From this point down, it’s just normal MyIntList stuff
        private IntListNode m_first; // first item in the list
                                     // automtically given the value null 

        ///////////////////////////////////////////////////////////////////////////////////////////

        // Implement this!
        public void AddToFront(int numToAdd)
        {
            if (m_first == null) // list is empty
            {
                // create new node
                IntListNode l = new IntListNode(numToAdd);
                // Set front to new node
                m_first = l;
            }
            else
            {
                // create new node
                IntListNode nn = new IntListNode(numToAdd);
                // new node.next = front
                nn.m_next = m_first;
                // front points to a new node
                m_first = nn;
            }
        }

        public void PrintAll()
        {
            // cur assigned m_first item
            IntListNode cur = m_first;
            // while m_first/cur is not empty
            while (cur != null)
            {
                // Print the object in the list
                Console.WriteLine(cur.m_data);
                // then move to the next object in the list
                cur = cur.m_next;
            }
        }
        public int RemoveFromFront() // changed to return int value
        {
            // If the list is empty, return early
            if (m_first == null)
            {
                return Int32.MinValue;
            }
            else
            {
                // Assign the first node's int value to x
                int x = m_first.m_data;
                // make m_first point towards the next node in the list
                m_first = m_first.m_next;
                // Return the integer value that was retrieved
                return x;
            }
        }
        public void PrintNode(uint i)
        {
            int count = 0;
            // Assign cur to the first node
            IntListNode cur = m_first;

            // If the first node is not empty AND count is less than the input total length
            while (cur != null && count < i)
            {
                // Cur next node
                cur = cur.m_next;
                count++;
            }
            // Check to make sure we are still within bounds of the list
            if (cur != null)
            {
                Console.WriteLine(cur.m_data);
            }
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////////
    
    public class SmartArrayAOD
    {
        int[] rgNums;
        private const int MINIMUM_STARTING_SIZE = 5;

        public SmartArrayAOD()
        {
        }

        public SmartArrayAOD(int startingSize)
        {
            rgNums = new int[startingSize];
        }
        // RUNNING TIME: O(1) Because the steps are constant time, we're performing a check 
        // then we allocate an array, and assign a value.
        public void SetAtIndex(int idx, int val)
        {
            // Resizing the array to make room for idx if not
            if (idx < rgNums.Length || idx > rgNums.Length || rgNums == null)
            {
                rgNums = new int[idx + 1];
                rgNums[idx] = val;
            }
            rgNums[idx] = val;
        }
        // RUNNING TIME: O(1) Because the x number of steps is constant, there are no loops or 
        // complex operations.
        public int GetAtIndex(int idx)
        {
            if (idx < rgNums.Length)
            {
                throw new UnderflowException("The index is too low!");
            }
            else if (idx > rgNums.Length || rgNums == null)
            {
                throw new OverflowException("The index is too high or the array is not allocated!");
            }
            else
            {
                return rgNums[idx];
            }
        }

        public void PrintAllElements()
        {
            if (rgNums == null)
            {
                Console.WriteLine("ARRAY NOT YET ALLOCATED");
            }
            for (int i = 0; i < rgNums.Length; i++)
            {
                Console.WriteLine("Element {0}: {1}", i, rgNums[i]);
            }
        }

        public int getSize()
        {
            if (rgNums == null)
            {
                return 0;
            }
            return rgNums.Length;
        }
        // RUNNING TIME: O(N) Because the array is a linear search, the duration of time it takes to run it 
        // scales 1:1 with the size of the array.
        public bool Find(int val)
        {
            // Check to see if array is allocated
            if (rgNums == null)
            {
                return false;
            }
            // Search for the value in the array (linear search)
            for (int i = 0; i < rgNums.Length; i++)
            {
                if (rgNums[i] == val)
                {
                    return true;
                }
            }
            // If the value not found, return false
            return false;
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////
    
    public class MyLinkedList
    {
        // Added to the constructor so that methods would work inside MyLinkedList
        public class LinkedListNode
        {
            public int m_data;
            public LinkedListNode m_next;
                       

            // Add a constructor which takes as an argument an int that it will store
            public LinkedListNode(int data)
            {
                m_data = data;
                // m_next = null; // automatically done by CLR, so I don't have to
            }

            public LinkedListNode(int data, LinkedListNode next)
                : this(data)
            {
                m_next = next;
            }

        }

        // first item in the list, automtically given the value null
        protected LinkedListNode m_first;
        private int value;

        public MyLinkedList(int value)
        {
            this.value = value;
        }


        // First, in your own words, summarize the important parts of the
        // "linked list traversal" schema/plan/pattern/strategy, as discussed
        // in class:
        //
        // YOUR ANSWER HERE
        // --Setup-- means to implement the first steps of navigating a linked list. This typically means
        // assigning a the first thing in the list to a new object that you have defined.
        // --Iteration Logic-- is the logic involved with the important checks involved with navigating the 
        // linked list. Any loops, anything being moved. Ex: while (cur != null) --> checking whether the 
        // end of the linked list, or whether it is empty or not.
        // --Work-- is everything that should be repeated for each node in the list. Also if you need to do something
        // after you do the work for the node
        // --Teardown-- anything that comes after you visit all the nodes. EX: Printing the node count after running through
        // all the nodes.


        public void Print()
        {
            // Quickly summarize what this code does in each of
            // the important steps of the 'list traversal' schema, 
            // in order to implement this method

            /// Summary: The code first assigns the first value to the value of cur. Int the list transversal schema
            /// this is the setup.
            /// Then it checks if the list is empty or not with the while loop, this is the iteration logic.
            /// Then it performs the work for each node, which is printing the contents and moving to the next node.
            /// There isn't really a teardown in the case of this method.
            LinkedListNode cur = m_first;
            while (null != cur)
            {
                Console.WriteLine(cur.m_data);
                cur = cur.m_next;
            }
        }

        // Try to find a given BY VALUE

        public bool Find(int target)
        {
            // Quickly summarize what your code does in each of
            // the important steps of the 'list traversal' schema, 
            // in order to implement this method

            /// Summary: The code first assigns the first value to the value of cur. This is the setup.
            /// Then, it checks to see if the list is empty in a while loop, running through the list during the 
            /// iteration logic.
            /// After that, it does the work for each node, moving to the next, checking to see if the data in the node
            /// is equal to the target parameter. 
            /// The teardown is returning false if the target value is not present after searching the list.

            LinkedListNode cur = m_first;
            while (cur.m_next != null)
            {
                cur = cur.m_next;
                if (cur.m_data == target)
                {
                    return true;
                }
            }
            return false;
        }


        // Try to find a given BY VALUE
        public bool PrintAllMatching(int target)
        {
            // Quickly summarize what your code does in each of
            // the important steps of the 'list traversal' schema, 
            // in order to implement this method

            /// Summary: The code first assigns the first value to the value of cur. This is the setup.
            /// Then, it checks to see if the list is empty in a while loop, running through the list during the 
            /// iteration logic.
            /// After that, it does the work for each node, moving to the next, checking to see if the data in the node
            /// is equal to the target parameter. If it is, it prints the value and returns true.
            /// The teardown is returning false if the target value is not present after searching the list.

            // YOUR CODE GOES HERE!!!

            LinkedListNode cur = m_first;
            while (cur.m_next != null)
            {
                cur = cur.m_next;
                if (cur.m_data == target)
                {
                    Console.WriteLine(target);
                    return true;
                }
            }
            return false;

        }
        //////////////////////////////////////////////////////////////////////////////////////

        // from previous ICEs:
        public void InsertAtFront(int value)
        {
            // YOUR CODE GOES HERE!!
            // You are allowed to copy-and-paste your prior work into here
            // HOWEVER
            // it's great practice to re-code this; you should be able to code
            // this up in ~5 minutes or so, including testing.  So re-typing
            // this is actually a good thing to do.

            if (m_first == null)
            {
                m_first = new LinkedListNode(value);
            }
            else
            {
                LinkedListNode n = new LinkedListNode(value);
                n.m_next = m_first;
                m_first = n;
            }

        }

        // RUN TIME: O(N) Linear search through a linked list results in a run time that is directly proportional to the 
        // size of the linked list.
        // Add, BY INDEX
        public void InsertAt(int newData, uint index)
        {
            LinkedListNode ln = new LinkedListNode(newData);

            if (m_first == null || index == 0)
            {
                ln.m_next = m_first;
                m_first = ln;
                return;
            }

            LinkedListNode cur = m_first;
            int counter = 0;

            while (cur.m_next != null && counter < index - 1)
            {
                cur = cur.m_next;
                counter++;
            }
            ln.m_next = cur.m_next;
            cur.m_next = ln;
        }

        // Remove, BY INDEX

        // RUN TIME: O(N) given that the while loop has to incrememnt through the entire linked list, assuming that it does not
        // find the required value. Therefore the method big O can be considered completing in linear time.
        public void RemoveAt(uint index)
        {
            if (m_first == null) return;

            if (index == 0)
            {
                m_first = m_first.m_next;
                return;
            }

            LinkedListNode cur = m_first;

            int counter = 0;
            while (cur.m_next != null && counter < index - 1)
            {
                cur = cur.m_next;
                counter++;
            }

            if (counter == index - 1 && cur.m_next != null)
            {
                cur.m_next = cur.m_next.m_next;
            }
            
        }

        // Add newData, so that it's in the proper sorted order (lowest to highest)
        // Note that this method assumes that the list is already properly sorted
        // (i.e., you start from an empty list,and ONLY call this method to add things
        // to the list)

        // RUN TIME: O(N) given that the while loop has to incrememnt through the entire linked list, assuming that it does not
        // find the required value. Therefore the method big O can be considered completing in linear time.
        public void InsertInOrder(int newData)
        {
            LinkedListNode data = new LinkedListNode(newData);

            if (m_first == null)
            {
                data.m_next = m_first;
                m_first = data;
                return;
            }

            LinkedListNode cur = m_first;
            int counter = 0;

            while (cur.m_next != null && data.m_next.m_data < newData)
            {
                cur = cur.m_next;
                counter++;
            }

            if (cur.m_next == null)
            {
                data.m_next = null;
                cur.m_next = data;
            }
            else
            {
                data.m_next = cur.m_next;
                cur.m_next = data;
            }
            throw new OverflowException("Overflow, woopsy");
        }

        // RUN TIME: O(N) given that the while loop has to incrememnt through the entire linked list, assuming that it does not
        // find the required value. Therefore the method big O can be considered completing in linear time.
        public void RemoveByValue(int value)
        {
            int counter = 0;
            // Find the value in the array
            LinkedListNode cur = m_first;
            while (cur.m_next != null)
            {
                cur = cur.m_next;
                counter++;
                
                // If the current value is the value to be removed
                if (cur.m_data == value)
                {
                    cur = cur.m_next;
                    return;
                }

                // Find previous node of the node to be deleted
                for (int i = 0; cur != null && i < counter -1; i++)
                {
                    cur = cur.m_next;
                }

                // Store the pointer to the next of the nodes to be deleted
                LinkedListNode next = cur.m_next.m_next;
                cur.m_next = next; // unlink the deleted node from the list
                                    
            }
                throw new Exception("The value was not found.");
            
        }

        public MyLinkedList Clone()
        {
            // Think about what your code does in each of
            // the three important steps of the 'list traversal' schema, 
            // in order to implement this method.
            // You are not required to write this down, but it's recommended that you
            // do so.

            // YOUR CODE GOES HERE!!!
            return null;

            throw new Exception("YOU NEED TO IMPLEMENT THIS!");

        }


        // Not really used in this week's PCE
        public void PrintAtLocation(int index)
        {
            // Remember that '0' is the very first item in the list
            // Assuming that there are any items in the list
            // YOUR CODE GOES HERE!!!

        }
    }
}
