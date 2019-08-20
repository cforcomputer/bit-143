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
        }
    }

    class DuplicateValueException : Exception
    { public DuplicateValueException(string msg) : base(msg) { } }

    public class BST
    {
        private BSTNode m_top;

        private class BSTNode
        {
            private int m_data;
            private BSTNode m_left;
            private BSTNode m_right;

            public int Data
            {
                get { return m_data; }
                set { m_data = value; }
            }
            public BSTNode Left
            {
                get { return m_left; }
                set { m_left = value; }
            }
            public BSTNode Right
            {
                get { return m_right; }
                set { m_right = value; }
            }

            public BSTNode(int data)
            {
                m_data = data;
            }
        }

        public void AddValue(int v)
        {
            if (m_top == null)
            {
                m_top = new BSTNode(v);
            }
            else
            {
                BSTNode cur = m_top;
                while (true)
                {
                    if (v < cur.Data)
                    {
                        if (cur.Left == null)
                        {
                            cur.Left = new BSTNode(v);
                            return;
                        }
                        else
                            cur = cur.Left;
                    }
                    else if (v > cur.Data)
                    {
                        if (cur.Right == null)
                        {
                            cur.Right = new BSTNode(v);
                            return;
                        }
                        else
                            cur = cur.Right;
                    }
                    else
                        throw new DuplicateValueException("Value " + v + " is already in the tree!");
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("=== Printing the tree ===");
            if (m_top == null)
                Console.WriteLine("Empty tree!");
            else
                PrintInternal(m_top);
        }
        private void PrintInternal(BSTNode cur)
        {
            if (cur.Left != null)
                PrintInternal(cur.Left);

            Console.WriteLine(cur.Data);

            if (cur.Right != null)
                PrintInternal(cur.Right);
        }

        public bool Find(int target)
        {
            return FindNode(target) != null;
        }

        private BSTNode FindNode(int target)
        {
            BSTNode cur = m_top;
            while (cur != null)
            {
                if (cur.Data == target)
                    return cur;
                else if (target < cur.Data)
                    cur = cur.Left;
                else if (target > cur.Data)
                    cur = cur.Right;
            }

            return null;
        }


        public void Remove(int target)
        {
            // if the tree is empty:
            if (m_top == null)
                return;
            //else
            //    throw new DuplicateValueException("Value " + target + " is already in the tree!");

            if (m_top.Data == target)
            {
                RemoveRootNode(target);
            }
            else
            {
                RemoveNonrootNode(target);
            }
        }

        private void RemoveNonrootNode(int target)
        {
            BSTNode cur = m_top;
            BSTNode parent = null;

            //First, find the target node that we need to remove
            // we'll have the 'parent' reference trail the cur pointer down the tree
            // so when we stop, cur is the node to remove, and parent is one above it.
            while (false)
            {

            }

            // Next, we figure out which of the cases we're in

            // Case 1: The target node has no children
            if (cur.Left == null && cur.Right == null)
            {


                return;
            }
            // Case 2: The target node has 1 child
            // (You may want to split out the left vs. right child thing)


            // Case 3: The target node has 1 child





        }

        private void RemoveRootNode(int target)
        {
            // If we're here, it's because we're removing the top-most node (the 'root' node)

            // Case 1: Root has no children
            if (m_top.Left == null && m_top.Right == null)
            {
                m_top = null;            // Therefore, the tree is now empty
                return;
            }
            // Case 2: Root has 1 child
            else if (m_top.Left == null)
            {
                // 1 (right) child, OR zero children (right may also be null)
                m_top = m_top.Right; // Right is null or another node - either way is correct
                return;
            }
            else if (m_top.Right == null)
            {
                // If we're here, Left is not null, so there MUST be one (Left) Child
                m_top = m_top.Left;
                return;
            }
            // Case 3: Root has two children - this is where it gets interesting :)
            else
            {
                // 2 children - find (and remove) next smaller value
                // use that data to overwrite the current data.
                BSTNode removee = FindAndRemoveNextSmallerValue(target, m_top);
                m_top.Data = removee.Data;
                return;
            }
        }

        /// <summary>
        /// This method takes 1 step to the left, then walks as far to the right
        /// as possible.  Once that right-most node is found, it's removed & returned.
        /// Note that the node MAY be immediately to the left of the <B>startHere</B> 
        /// parameter, if startHere.Left.Right == null
        /// </summary>
        /// <param name="smallerThanThis"></param>
        /// <param name="startHere"></param>
        /// <returns></returns>
        private BSTNode FindAndRemoveNextSmallerValue(int smallerThanThis, BSTNode startHere)
        {
            BSTNode parent = startHere;
            BSTNode child = startHere.Left;

            return null;
        }

        // Given the value of a node, find (and remove) the predessor node in the tree
        // returns the value of the predecessor node, or Int32.MinValue if no such value was found
        public int TestFindAndRemoveNextSmallest(int sourceNode)
        {
            BSTNode startAt = this.FindNode(sourceNode);
            // sourceNode should == startAt.Data, unless startAt is null)
            BSTNode removed = FindAndRemoveNextSmallerValue(sourceNode, startAt);
            if (removed != null)
                return removed.Data;
            else
                return Int32.MinValue;
        }
    }


    public class SearchingAndSorting
    {
        public int Partition(int[] nums, int left, int right)
        {
            return -1;
        }
        public void QuickSort(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
                A[i] = Int32.MinValue;
        }
    }
}
