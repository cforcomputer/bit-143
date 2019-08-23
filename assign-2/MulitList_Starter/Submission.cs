using System;
using System.Collections.Generic;


public class Program
{
	public Main(string[] args)
    {
        char choice = 'i';
        do
        {
            Console.WriteLine("A. End the program");
            Console.WriteLine("B. Add a book");
            Console.WriteLine("C. Print all books");
            Console.WriteLine("D. Remove a book");
            Console.WriteLine("C. Run tests");

            choice = Console.ReadLine().ToLower;

            // call Action class to perform action based on user choice
            Action act = new Action();
            act.ExecuteAction(choice);
        } while (choice != 'q'); // check for option A (user quits program)
	}
}

////////////////////////////////////////////////////////////
//_____ _               _ _           _      
//   __ \              | |       | \ | |        | |     
//| /  \/_  __ ___ __ _| |_ ___  |  \| |  ___ __| | ___ 
//| |   | '__/ _ \/ _` | __/ _ \ | . ` |/ _ \ / _` |/ _ \
//| \__/| | |  __| (_| | ||  __/ | |\  | (_) | (_| |  __/
// \____|_|  \___|\__,_|\__\___| \_| \_/\___/ \__,_|\___|
/////////////////////////////////////////////////////////////
private Node head;
private Node current;

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

    public Node(Object bookList)
    {
        this.data = bookList;
        this.Next = null;
    }
}

///////////////////////////////////////////////////////////////////////////////

public class Action
{
    public void ExecuteAction(char c)
    {
        string bookName_input;
        int pubYear_input, noOfCopies_input, result = 0;
        // char libName_input;

        // switch calls the action that the user selected
        switch (c)
        {                
            case 'a':
                // quit
                break;
            case 'b':
                // Add a book
                // input details from user
                Console.WriteLine("Please enter a book name: ");
                bookName_input = Console.ReadLine();
            case 'c':
                // Print all books (display list)

            case 'd':
                // Remove a book
            case 'e':
                // Run test cases
        }
    }

    public void AddNode(char bookName_input, int pubYear_input)
    {
        // work on copy of list
        Node tempList = new Node();

        while (tempList)
        {
            if (bookName_input == 0 || pubYear_input == 0)
            {
                return;
            }
            if (tempList.Next != null)
            {
                tempList = tempList.Next;
            }
            else
            {
                break;
            }
        }
    }

    public void DisplayLists()
    {
        Node tempList = new Node();

        while (tempList != null)
        {
            Console.WriteLine("Author: {0}", );
            Console.WriteLine("Title: {0}");
            Console.WriteLine("Price: {0}");
        }
    }
}
