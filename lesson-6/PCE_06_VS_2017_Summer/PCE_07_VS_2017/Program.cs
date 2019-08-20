#define TESTING
using System;
using System.Collections.Generic;

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
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(15);
            
        }
    }

    public class BinarySearchTree
    {
        // Protected so that the BST_Verifier subclass can get at it
        // and verify that the tree looks right (for NUnit tests)
        // Normally this should be private.
        protected BSTNode root; // also (semi-)traditional to name this 'root', instead of 'top'

        // You should make the BSTNode class a nested class
        // Normally should be private; it's protected for the reasons explained above
        protected class BSTNode
        {
            public BSTNode Left;
            public BSTNode Right;
            public int key; // key was not defined in original, added so that key is defined?
            public int Data;
            public BSTNode(int val)
            {
                Data = val;
            }
        }

        public void Add(int key)
        {
            if (root == null)
            {
                root = new BSTNode(key);
                return;
            }
            BSTNode cur = root;

            while (true)
            {
                if (key < cur.key) //.key doesn't exist in the current context... .data?
                {
                    if (cur.Left == null)
                    {
                        cur.Left = new BSTNode(key);
                        break;
                    }
                    else
                    {
                        cur = cur.Left;
                    }
                }
                else if (key > cur.key) //.key does not exist
                {

                }
                else // cur.key == key
                {
                    throw new Exception("No duplicates allowed in tree!");
                }
            }
        }

        public bool Find(int target)
        {
            if (root == null)
                return false;
            BSTNode cur = root;
            
            while (cur != null)
            {
                if (target == cur.key) // .key does not exist
                {
                    return true;
                }
                else if (target > cur.key) //.key does not exist
                {
                    cur = cur.Right;
                }
                else
                {
                    cur = cur.Left;
                }
            }
            return false;
        }

        public void Print()
        {
            if (root == null)
            {
                return;
            }
            Print(root);
        }
        private void Print(BSTNode cur)
        {
            if (cur.Left != null)
            {
                Print(cur.Left);
            }
            Console.WriteLine(cur.Data);
            if(cur.Right != null)
            {
                Print(cur.Right);
            }
        }

        public void PrintIterative()
        {
            // Not mentioned by project
            Stack<BSTNode> s = new Stack<BSTNode>();
            Console.WriteLine("PRINT IS NOT YET IMPLEMENTED!!!!\nYou need to implement this method, iteratively (using a loop)!");
        }

        public bool FindR(int target)
        {
            // non-working:
            if (root == null)
                return false;

            if (target < this.key)
            {
                if (this.Left == null)
                {
                    return false;
                }
                else
                {
                    return FindR(target, this.Left);
                }
            }
            else if (target > this.key)
            {
                if (this.Right == null)
                {
                    return false;
                }
                else
                {
                    return FindR(target, this.Right);
                }
            }
            else
            {
                return true;
            }
        }
        private bool FindR(int target, BSTNode cur)
        {
            if (target < cur.key)
            {
                if (cur.Left == null)
                {
                    return false;
                }
                else
                {
                    return FindR(target, cur.Left); // recursive call
                }
            }
            else if (target > cur.key)
            {
                if (cur.Right == null)
                {
                    return false;
                }
                else
                {
                    return FindR(target, cur.Right);
                }

            }
            else
            {
                return true;
            }
        }

        public void AddR(int key)
        {
            if (root == null)
            {
                root = new BSTNode(key);
                return;
            }
          AddR(BSTNode, root);    // what to add for nodeToAdd     
           
        }

        private void AddR(BSTNode cur, BSTNode nodeToAdd)
        {
            if (nodeToAdd.key < cur.Data)
            {
                if (cur.Left == null)
                {
                    nodeToAdd.Left = new BSTNode(nodeToAdd.key);
                    return;
                }
                else
                {
                    cur.Left.AddR(nodeToAdd.key);
                    return;
                }

                // val == data --> duplicate!
            }
        }
        
        public void PrintBeneathNode(int target)
        {
            Console.WriteLine("NOT YET IMPLEMENTED");
            return;

        }
    }
}
