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
        }
        private Node head;

        // Print all elements in the linked list
        public void PrintAll()
        {
            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.Next;
            }
        }

        // Move backwards in the linked list
        public void MoveBackwards()
        {
           
        }

        // Move forwards in the LinkedList
        public void MoveForwards()
        {
            if (head == null) // list is empty
            {
                return;
            }
            // at least one page in the next node of the list, remove it and then add it to the previously
            // visited section of the list (behind it)
            else
            {
                
            }
        }

        // This method adds a new element to the front of the linked list
        public void VisitPage(string name) // string is the text description of what the page is
        {
            // adds a node with the visited page information to the linked list

        }
    }
}
