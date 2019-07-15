using System;
using SmartArray_Test;

// 400_enum_ErrorCode Project

namespace SmartArray_Test
{

   // Your enum goes here:
    enum ErrorCode
    {
        NoError,
        Underflow,
        Overflow
    }

    
    class SmartArray
    {
        int[] rgNums;

        //// Running time for this method: 
        /// O(1) - Constant time
        //// Explanation (Why did you choose that running time?):
        /// I chose this running time because there is only one element that remains
        /// the same, there will always be the single step of creating the array that is size 5. 
        public SmartArray()
        {
           rgNums = new int[5];
        }

        //// Running time for this method:
        /// O(N) - Linear Time
        //// Explanation (Why did you choose that running time?):
        /// Instead of an unchanging int like the default SmartArray constructor, the howMany parameter can be
        /// any size. For this reason the time is linear instead of constant. 
        /// Because memory allocation takes longer time for larger arrays.
        /// ex:
        /// around 10 ns for an array of size 1
        /// around 400 ns for an array of size 10,000
        /// around 300,000 ns for an array of size 1,000,000
        
        public SmartArray(int howMany)
        {
            // Second overloaded constructor
            // An integer that specifies what the size of the array should be
            // Allocates an array given by the param

            rgNums = new int[howMany];
        }

        // Running time for this method:
        /// O(1) - Constant time
        // Explanation (Why did you choose that running time?):
        /// Given that each are conditional statements, where only one can be met, this method is constant time.
        /// It can be an Underflow, but not an Overflow, and it can have no error, but then it would be neither
        /// an Underflow or an Overflow.
        
        public ErrorCode SetAtIndex(int idx, int val)
        {
            // set the value at the index
            if (idx < 0)
            {
                return ErrorCode.Underflow;
            }           

            else if (idx > rgNums.Length || rgNums.Length == idx)
            {
                return ErrorCode.Overflow;
            }
            // check to make sure the index is set
            // set rgNums[idx] out as val
            rgNums[idx] = val;

            if (rgNums[idx] == val)
            {
                // if it is, return no error
                return ErrorCode.NoError;
            }
            
            return ErrorCode.Underflow;
        }

        // Running time for this method:
        ///  O(1) - Constant time
        // Explanation (Why did you choose that running time?):
        /// There is always a single step to take, the number of steps for this method does not change when the 
        /// size of the array changes. 
        /// It will be one of the statements, not more than one. Either it will be:
        /// (idx < 0) --> Underflow
        /// or
        /// (idx > rgNums.Length || rgNums.Length == idx)
        /// or the val = rgNums[idx]

        public ErrorCode GetAtIndex(int idx, out int val)
        {
            // Checks to see if the slot can be accessed
            if (idx < 0)
            {
                val = Int32.MinValue;
                return ErrorCode.Underflow;
            }
            else if (idx > rgNums.Length || rgNums.Length == idx)
            {
                val = Int32.MinValue;
                return ErrorCode.Overflow;
            }
            else
            { 
                val = rgNums[idx];

                return ErrorCode.NoError;
            }
             // return ErrorCode.Overflow;
        }

        // Running time for this method: 
        /// O(N) Linear time
        // Explanation (Why did you choose that running time?):
        /// We have access to every single element in the array, and we are printing them one at a time.
        /// There is no special process, so the time is directly correlated to the overall size of the array
        /// O * N
        public void PrintAllElements()
        {
            for (int i = 0; i < rgNums.Length; i++)
            {
                Console.WriteLine(rgNums[i]);
            }
        }


        // Running time for this method:
        /// O(N^2) - BubbleSort
        // Explanation (Why did you choose that running time?):
        /// This is BubbleSort, we previously discussed that BubbleSort is a linear search algorithm.
        /// It's a linear search algorithm because we are taking an array, and then searching through it
        /// one by one until we reach the correct integer. If you look at it on a graph, it appears as a
        /// linear pattern.
        /// We increment through the array by one each time, until rgNums[i] == val, and then we end it if 
        /// it is true, otherwise we return false if the value is not present.
        public bool Find(int val)
        {
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
    }
    }

    class Program
    {
        // Tests for SmartArrayTests
        static void Main(string[] args)
        {
            SmartArray sa = new SmartArray();
            const int SMART_ARRAY_SIZE = 5;
            bool testPassed = false;
            ErrorCode ec;

            Console.WriteLine("CHECK THIS: SmartArray starts with all zeros");
            sa.PrintAllElements();
            Console.WriteLine("\n*******************\n");


            Console.WriteLine("================= SetAtIndex =================");
            Console.WriteLine("AutoChecked: Can add at slot 0?");
            if ((ec = sa.SetAtIndex(0, 10)) != ErrorCode.NoError)
                Console.WriteLine("TEST FAILED: UNABLE TO SET ELEMENT 0! (ErrorCode: {0})", ec);
            else
                Console.WriteLine("Test Passed: Able to set element 0!");
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Can add at slots 0-4?");
            testPassed = true;
            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            {
                if ((ec = sa.SetAtIndex(i, 10 * i)) != ErrorCode.NoError)
                {
                    Console.WriteLine("TEST FAILED: UNABLE TO SET ELEMENT {0}! (ErrorCode: {1})", i, ec);
                    testPassed = false;
                    break; // out of the loop
                }
            }
            if (testPassed)
                Console.WriteLine("Test Passed: Able to set all elements!");
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Should NOT be able to add at slot {0}?", SMART_ARRAY_SIZE);

            if ((ec = sa.SetAtIndex(SMART_ARRAY_SIZE, 10)) != ErrorCode.Overflow)
                Console.WriteLine("TEST FAILED: SET ELEMENT {0} DIDN'T OVERFLOW (ErrorCode: {1})", SMART_ARRAY_SIZE, ec);
            else
                Console.WriteLine("Test Passed: Unable to set element {0}!", SMART_ARRAY_SIZE);
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Should NOT be able to add at slot {0}?", SMART_ARRAY_SIZE + 10);
            if ((ec = sa.SetAtIndex(SMART_ARRAY_SIZE + 10, 10)) != ErrorCode.Overflow)
                Console.WriteLine("TEST FAILED: SET ELEMENT {0} DIDN'T OVERFLOW (ErrorCode: {1})", SMART_ARRAY_SIZE + 10, ec);
            else
                Console.WriteLine("Test Passed: Unable to set element {0}!", SMART_ARRAY_SIZE + 10);
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Should NOT be able to add at slot -1?");
            if ((ec = sa.SetAtIndex(-1, 10)) != ErrorCode.Underflow)
                Console.WriteLine("TEST FAILED: SET ELEMENT -1 DIDN'T UNDERFLOW! ErrorCode: {0})", ec);
            else
                Console.WriteLine("Test Passed: Unable to set element -1!");
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Should NOT be able to add at slot -10?");
            if ((ec = sa.SetAtIndex(-10, 10)) != ErrorCode.Underflow)
                Console.WriteLine("TEST FAILED: SET ELEMENT -10 DIDN'T UNDERFLOW! ErrorCode: {0})", ec);
            else
                Console.WriteLine("Test Passed: Unable to set element -1!");
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("CHECK THIS: Should see 0, 10, 20, 30, 40");
            sa.PrintAllElements();
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("================= GetAtIndex =================");
            int valueGotten;
            Console.WriteLine("AutoChecked: Can get from slot 0?");
            ec = sa.GetAtIndex(0, out valueGotten);
            if (ec != ErrorCode.NoError)
            {
                Console.WriteLine("TEST FAILED: UNABLE TO GET FROM SLOT 0 (ErrorCode: {0})", ec);
            }
            else if (valueGotten != 0)
            {
                Console.WriteLine("TEST FAILED: UNEXPECTED VALUE FROM SLOT 0: (EXPECTED 0, GOT {0})", valueGotten);
            }
            else
                Console.WriteLine("Test Passed: Able to get expected value from slot 0!");
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Can get from slots 0-4?");
            testPassed = true;
            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            {
                ec = sa.GetAtIndex(i, out valueGotten);
                if (ec != ErrorCode.NoError)
                {
                    Console.WriteLine("TEST FAILED: UNABLE TO GET FROM SLOT {0} (ErrorCode: {1})", i, ec);
                }
                else if (valueGotten != 10 * i)
                {
                    Console.WriteLine("TEST FAILED:  UNEXPECTED VALUE AT SLOT {0} (EXPECTED {1}, GOT {2})", i, i * 10, valueGotten);
                    testPassed = false;
                    break; // out of the loop
                }
            }
            if (testPassed)
                Console.WriteLine("Test Passed: Able to get expected values!");
            Console.WriteLine("\n*******************\n");


            Console.WriteLine("AutoChecked: Should NOT be able to get from slot {0}?", SMART_ARRAY_SIZE);
            if ((ec = sa.GetAtIndex(SMART_ARRAY_SIZE, out valueGotten)) != ErrorCode.Overflow)
                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T OVERFLOW (ErrorCode: {1})?", SMART_ARRAY_SIZE, ec);
            else if (valueGotten != Int32.MinValue)
                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T PRODUCE Int32.MinValue", SMART_ARRAY_SIZE);
            else
                Console.WriteLine("Test Passed: Unable to get from slot {0}!", SMART_ARRAY_SIZE);
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Should NOT be able to get from slot {0}?", SMART_ARRAY_SIZE + 10);
            if ((ec = sa.GetAtIndex(SMART_ARRAY_SIZE + 10, out valueGotten)) != ErrorCode.Overflow)
                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T OVERFLOW (ErrorCode: {1})?", SMART_ARRAY_SIZE + 10, ec);
            else if (valueGotten != Int32.MinValue)
                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T PRODUCE Int32.MinValue", SMART_ARRAY_SIZE + 10);
            else
                Console.WriteLine("Test Passed: Unable to get from slot {0}!", SMART_ARRAY_SIZE + 10);
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Should NOT be able to get from slot -1?");
            if ((ec = sa.GetAtIndex(-1, out valueGotten)) != ErrorCode.Underflow)
                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T UNDERFLOW(ErrorCode: {1})", -1, ec);
            else if (valueGotten != Int32.MinValue)
                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T PRODUCE Int32.MinValue", -1);
            else
                Console.WriteLine("Test Passed: Unable to get from slot {0}!", SMART_ARRAY_SIZE);

            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Should NOT be able to get from slot -10?");
            if ((ec = sa.GetAtIndex(-10, out valueGotten)) != ErrorCode.Underflow)
                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T UNDERFLOW(ErrorCode:{1})", -10, ec);
            else if (valueGotten != Int32.MinValue)
                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T PRODUCE Int32.MinValue", -10);
            else
                Console.WriteLine("Test Passed: Unable to get from slot {0}!", SMART_ARRAY_SIZE);
            Console.WriteLine("\n*******************\n");


            Console.WriteLine("================= Find =================");
            Console.WriteLine("AutoChecked: Can find 0?");
            if (!sa.Find(0))
                Console.WriteLine("TEST FAILED: UNABLE TO FIND VALUE 0!");
            else
                Console.WriteLine("Test Passed: Able to find value 0!");
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Can find the values in slots 0-4?");
            testPassed = true;
            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            {
                ec = sa.GetAtIndex(i, out valueGotten);
                if (ec != ErrorCode.NoError)
                {
                    Console.WriteLine("TEST FAILED:UNABLE TO GET ELEMENT AT SLOT {0} (ErrorCode: {1})!", i, ec);
                    testPassed = false;
                    break;
                }  // technically don't need the 'else'....
                else if (!sa.Find(valueGotten)) // test by getting from array
                {
                    Console.WriteLine("TEST FAILED: UNABLE TO FIND {0}!", valueGotten);
                    testPassed = false;
                    break; // out of the loop
                }
            }
            if (testPassed)
                Console.WriteLine("Test Passed: Able to find values that are already in the array!");
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Can find the values calculated to be in slots 0-4?");
            testPassed = true;
            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            {
                if (!sa.Find(i * 10)) // test by re-calculating the result
                {
                    Console.WriteLine("TEST FAILED: UNABLE TO FIND {0}!", i * 10);
                    testPassed = false;
                    break; // out of the loop
                }
            }
            if (testPassed)
                Console.WriteLine("Test Passed: Able to find values calculated to be in the array!");
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Should NOT be able to find -1?");
            if (sa.Find(-1))
                Console.WriteLine("TEST FAILED: ABLE TO FIND -1, WHICH SHOULD NOT BE PRESENT");
            else
                Console.WriteLine("Test Passed: Unable to find nonexistent value -1!");
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Should NOT be able to find -10?");
            if (sa.Find(-10))
                Console.WriteLine("TEST FAILED: ABLE TO FIND -10, WHICH SHOULD NOT BE PRESENT");
            else
                Console.WriteLine("Test Passed: Unable to find nonexistent value -10!");
            Console.WriteLine("\n*******************\n");

            Console.WriteLine("AutoChecked: Should NOT be able to find 11?");
            if (sa.Find(11))
                Console.WriteLine("TEST FAILED: ABLE TO FIND 11, WHICH SHOULD NOT BE PRESENT");
            else
                Console.WriteLine("Test Passed: Unable to find nonexistent value 11!");
            Console.WriteLine("\n*******************\n");
        }
    }
//}
