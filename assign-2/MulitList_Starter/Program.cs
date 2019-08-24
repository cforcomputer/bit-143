using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

// comment, located at the top of the Program.cs file, 
// that explains what the compile-time problem was and how you worked
// around it AND how you'd react to this situation in a real-life/professional work environment.
/// Answer: The program will not compile because:
///   case MenuOptions.RUN_TESTS:
///   AllTests tester = new AllTests();
///   tester.RunTests();
///   break;
///   Is not implemented correctly. For this particular problem I merely commented it out
///   and left a note for when it would be necessary for later implementing tests. In a professional 
///   environment I would likely be using some kind of version control system and code review.
///   I could submit an issue inquiring to the purpose of the code. If I was working with a team, I could
///   also ask someone nearby for assistance. 


namespace MulitList_Starter
{
    class Node
    {
        public book data;
        public Node previous;
        public Node next;
        public Node() //default
        {

        }

        public Node(book data, Node previous, Node next) // constructor creates list
        {
            this.data = data;
            this.previous = previous;
            this.next = next;
        }
    }
    
    class book
    {
        public string author;
        public string book_title;
        public double price;
        public book() // default
        {

        }

        public book(string author, string book_title, double price) //constructor creates book object
        {
            this.author = author;
            this.book_title = book_title;
            this.price = price;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Or, you could go with the more traditional:
            UserInterface ui = new UserInterface();
            ui.RunProgram();
        }
    }

    // Bit of a hack, but still an interesting idea....
    enum MenuOptions
    {
        QUIT = 1,
        ADD_BOOK,
        PRINT,
        REMOVE_BOOK,
        RUN_TESTS
    }

    class UserInterface
    {
        MultiLinkedListOfBooks theList;
        // new node
        public Node head = null;
        public void RunProgram()
        {
            
            int nChoice;
            theList = new MultiLinkedListOfBooks();

            do // main loop
            {
                Console.WriteLine("Your options:");
                Console.WriteLine("1 : End the program");
                Console.WriteLine("2 : Add a book");
                Console.WriteLine("3 : Remove a book");
                Console.WriteLine("4 : Print all books");
                Console.WriteLine("5 : RUN TESTS");

                if (!Int32.TryParse(Console.ReadLine(), out nChoice))
                {
                    Console.WriteLine("You need to type in a valid, whole number!");
                    continue;
                }
                switch (nChoice)
                {
                    case 1: //quit
                        Console.WriteLine("Thank you for using the multi-list program!");
                        break;
                    case 2: // add a book
                        AddBook();
                        break;
                    case 3: // Remove a book
                        Console.WriteLine("Remove a book: \n");
                        RemoveBook();
                        break;
                    case 4: // Print all books                  
                        Console.WriteLine("Print books: \n");
                        break;
                    default:
                        Console.WriteLine("I'm sorry, but that wasn't a valid menu option");
                        break;
                }
            } while (nChoice != 1);
        }

        public void AddBook()
        {
            // Node node = new Node();
            book nn = new book();
            MultiLinkedListOfBooks ll = new MultiLinkedListOfBooks();

            Console.WriteLine("ADD A BOOK!");

            Console.WriteLine("Author name?");
            string book_author = Console.ReadLine();
            nn.author = book_author;

            Console.WriteLine("Title?");
            string book_name = Console.ReadLine();
            nn.book_title = book_name;

            double price = -1;
            while (price < 0)
            {
                Console.WriteLine("Price?");
                if (!Double.TryParse(Console.ReadLine(), out price))
                {
                    Console.WriteLine("I'm sorry, but that's not a number!");
                    price = -1;
                }
                else if (price < 0)
                {
                    Console.WriteLine("I'm sorry, but the number must be zero, or greater!!");
                }
            }
            nn.price = price;

            // STUDENTS: YOUR ERROR-CHECKING CODE SHOULD GO HERE!
            if (book_author != null && book_name != null)
            {
                Console.WriteLine(ErrorCode.OK);
            }            
        } // end AddBook

        public void RemoveBook()
        {
            
            Console.WriteLine("REMOVE A BOOK!");

            Console.WriteLine("Author name?");
            string author = Console.ReadLine();

            Console.WriteLine("Title?");
            string title = Console.ReadLine();

            ErrorCode ec = theList.Remove(author, title);

            // STUDENTS: YOUR ERROR-CHECKING CODE SHOULD GO HERE!
            if (author != null && title != null)
            {
                theList.Remove(author, title);
                Console.WriteLine(ErrorCode.OK);
                return;
            }
            Console.WriteLine(ErrorCode.BookNotFound);
        }        
    }

    enum ErrorCode
    {
        OK,
        DuplicateBook,
        BookNotFound
    }



    // perform all operations related to book
    class MultiLinkedListOfBooks
    {
        private Node head;

        public MultiLinkedListOfBooks() // default constructor
        {
            this.head = null;            
        }

        public MultiLinkedListOfBooks(Node new_node)
        {
            this.head = new_node;
        }

        // method to add a new book node
        public Node InsertNode(Node new_book)
        {
            Console.WriteLine("Running insert...");
            if (this.head == null)
            {
                Console.Write("*");
                this.head = new_book;
            }

            Node temp = this.head;
            while (temp != null)
            {
                Console.Write("*");
                new_book.previous = temp;
                temp = temp.next;
            }
            temp = new_book;

            SortingLinkedList();
            return this.head;
        }

        // sorting the linked list by title - alphabetical order
        public Node SortingLinkedList() // returns head
        {
            Node temp1 = this.head, temp2 = this.head;

            while (temp1 != null)
            {
                Console.WriteLine("Running sort");
                temp2 = head;
                
                while (temp2 != null)
                {
                    Node tem_next = temp2.next;

                    if (temp2.next != null && temp2.data.author.CompareTo(temp2.next.data.author) > 0 )
                    {
                        Console.Write("*");
                        Node tmp1 = temp2.next;
                        temp2.next = temp2.next.next;
                        tmp1.previous = temp2.previous;
                        temp2.previous = tmp1;
                        tmp1.next = temp2;
                    }
                    else if (temp2.next != null && temp2.data.author.CompareTo(temp2.next.data.book_title) == 0)
                    {
                        Console.Write("*");
                        if (temp2.data.book_title.CompareTo(temp2.next.data.book_title) > 0)
                        {
                            Console.Write("*");
                            Node tmp1 = temp2.next;
                            temp2.next = temp2.next.next;
                            tmp1.previous = temp2.previous;
                            temp2.previous = tmp1;
                            tmp1.next = temp2;
                        }
                    }
                    temp2 = tem_next;
                }
                temp1 = temp1.next;
            }
            return this.head;
        }


        public void Print()
        {
            // if there are no books, then print out a message saying that the list is empty
            Node temp = head;
            
            if (head == null)
            {
                Console.WriteLine(ErrorCode.BookNotFound);
                return;
            }

            Node node = head;
            while (node != node.previous)
            {
                
                    Console.WriteLine(temp.data.author);
                    Console.WriteLine(temp.data.book_title);
                    Console.WriteLine(temp.data.price);
                    head = temp.next;
                
                node = node.next;
            }
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }

        public ErrorCode Remove(string author, string title)
        {
            Node temp = head;
            if (head == null)
            {
                return ErrorCode.BookNotFound;
            }
            
            if (head.data.author == author && head.data.book_title == title)
            {
                head = temp.next;                
            }
            if (temp == null || temp.next == null)
                return ErrorCode.BookNotFound;
            Node next = temp.next.next;
            temp.next = next;

            return ErrorCode.OK;
        }
    }
}
