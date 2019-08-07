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

        private Node head;

        // Print all elements in the linked list
        public void PrintAll()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data + " \n");
                current = current.Next;
            }
        }

        // Move backwards in the linked list
        public void MoveBackwards()
        {
            Node previous = null, current = head, next;
            while (current !=null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            head = previous;
        }

        // Move forwards in the LinkedList
        public void MoveForwards()
        {
            if (head == null) // list is empty
            {
                throw new Exception("You're at the end of the list!");
            }
            // at least one page in the next node of the list, remove it and then add it to the previously
            // visited section of the list (behind it)
            else
            {
                Node current = head, next = null;
                // next = current.Next;
                current.Next = current;
                // current = next;                
            }
        }

        // This method adds a new element to the last visited node of the linked list
        public void VisitPage(string pageName) // string is the text description of what the page is
        {
            //Node dat = null, current = head, next = null;
            // adds a node with the visited page information to the linked list
            if (head == null)
            {
                head = new Node(pageName);
            }
            else
            {
                //Node prior = head;
                //while (prior.Next != null)
                //{
                //    prior = prior.Next;
                //}
                //prior.Next = new Node(pageName);

                Node empty = new Node(pageName);
                empty.Next = head;
                head = empty;
            }
        }
    }
}
