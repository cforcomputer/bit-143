// Patrick O'Brien
// BIT 143
// Summer 2019
// Assignment 1
// Revision 0

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


/// <summary>
/// Implement the linked list in the methods below.
/// </summary>
namespace Helpdesk
{
    class History //LinkedList
    {

        private Node head;

        public class Node
        {
            public Object data { get; set; }
            public Node Next { get; set; }

            // Constructor that takes a single input 
            public Node(string input)
            {
                this.data = input;
                this.Next = null;
            }
        }

        public void PrintAll()
        {
            //Node current = head;
            //while (current != null)
            //{
            //    Console.WriteLine(current.data + " \n");
            //    current = current.Next;
            //}

            // CORRECTION: FIRST PRINT THE HISTORY, THEN PRINT THE FUTURE
            // PRINT FROM THE [MOST RECENT ITEM] AND WORK BACK [TOWARDS THE OLDEST ITEM]

            // A SEPARATE CASE IS NOT REQUIRED FOR ADDING TO THE FRONT OF THE LIST WHEN IT'S
            // EMPTY, AND THEN ADDING TO THE LIST WHEN IT'S NOT EMPTY. 
            // YOU CAN ADD TO EITHER LIST IN ABOUT 4 - 5 LINES OF CODE
            if (head == null)
            {
                Console.WriteLine("The list is empty!");
                return;
            }

            Console.WriteLine("\nHistory:\n{0}", head.data);
            Console.WriteLine("Previously visited pages:\n");
            Console.WriteLine("Pages in your 'future':\n");
        }

        // Move backwards in the linked list
        public void MoveBackwards()
        {
            //Node previous = null, current = head, next;
            //while (current !=null)
            //{
            //    next = current.Next;
            //    current.Next = previous;
            //    previous = current;
            //    current = next;
            //}
            //head = previous;

            // DOES NOT WORK, SHOULD NOT REVERSE THE LIST

            // DOES NOT CHECK TO SEE IF THE LIST IS EMPTY - WILL CRASH

            // SHOULD REMOVE THE ITEM FROM THE FRONT OF THE LIST, THEN 
            // ADD IT TO THE "FUTURE" LIST. CURRENTLY NOT ADDING TO FUTURE LIST.

            // SHOULD REMOVE THE CURRENT NODE, TAKE STRING OUT, THEN CREATE A BRAND NEW NODE
            // TO STORE THE STRING THAT YOU ADD TO THE FUTURE LIST, INSTEAD OF CREATING A NEW ONE.
            // FIX SIMILAR PROBLEMS

            // MOVEFORWARDS/BACKWARDS: IF YOU'RE ALREADY AT THE END OF THE FUTURE/HISTORY LIST AND
            // YOU CALL THESE, THEN YOU'LL ADD A "NULL" STRING TO THE OTHER LIST.
            if (head == null)
            {
                return;
            }
            else
            {

            }
        }



        // Move forwards in the LinkedList
        public void MoveForwards()
        {
            //if (head == null) // list is empty
            //{
            //    throw new Exception("You're at the end of the list!");
            //}
            //// at least one page in the next node of the list, remove it and then add it to the previously
            //// visited section of the list (behind it)
            //else
            //{
            //    Node current = head; 
            //    current.Next = current;                               
            //}

            // DOES NOT WORK - IT CURRENTLY ALWAYS RESETS THE HISTORY TO BEING THE SECOND ITEM ON THE LIST

            if (head == null)
            {
                return;
            }
            else
            {
                head = head.Next;
            }
        }



        // This method adds a new element to the last visited node of the linked list
        public void VisitPage(string pageName) // string is the text description of what the page is
        {
            // MUST ALSO REMOVE ALL ENTRIES IN THE "FUTURE" LIST
            // PUT IN A COMMENT STATING THE RUNNING TIME OF THE CURRENT SOLUTION
            // THEN IMPLEMENT CODE THAT TAKES A CONSTANT TIME O(1) TO IMPLEMENT THE LIST

            // Running time of the current solutin is O(N) because currently VisitPage checks
            // every node in the list, no no good!

            // adds a node with the visited page information to the linked list
            //if (head == null)
            //{
            //    head = new Node(pageName);
            //}
            //else
            //{
            //    Node empty = new Node(pageName);
            //    empty.Next = head;
            //    head = empty;
            //}
            

            if (head == null)
            {
                head = new Node(pageName);
            }
            else
            {                
                Node empty = new Node(pageName);
                empty.Next = head;
                head = empty;
            }
        }
    }
}
