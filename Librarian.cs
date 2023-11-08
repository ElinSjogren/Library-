using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theLibrary
{
    internal class Librarian
    {

        public int count = 0;
        public string questionToAsk = $"What do ya wanna do? {Environment.NewLine} Press A for See books "  +
            $"in the library, {Environment.NewLine} Press B for Borrow a specific book-title,{Environment.NewLine} Press C for deleteing a" +
            $" book {Environment.NewLine} Press D for adding a new book to the Library {Environment.NewLine} Press E for return a book";
        public string? result;
        public void askWhatToDo()
        {
            Console.WriteLine(questionToAsk);
        }

        public string getAnswer()
        {
            result = Console.ReadLine();
            if(result == null)
            {
                Console.WriteLine("Wrong!");
                askWhatToDo();
                return"";
            }else return Console.ReadLine();
        }
        public void deteremenWhatToDoo(Library lib, string whatToDoInput)
        {


            whatToDoInput = whatToDoInput.ToUpper();
            switch (whatToDoInput)
            {
                case "A":
                    //se books
                    lib.getBooks();
                    break;
                case "B":
                    //borrow books
                    Console.WriteLine("what book do you wanna borrow? ");
                    string bookName =Console.ReadLine();
                    lib.borrowBook(bookName);
                    break;
                case "C":
                    //destroy books
                    Console.WriteLine("what book do you wanna delete? ");
                    string bookN = Console.ReadLine();
                    bookN=bookN.ToUpper();
                    lib.removeABook(bookN);
                    break;
                case "D":
                    //add books
                    Console.WriteLine("what book do you want to add? ");
                    //take them inputs, lended default value is false
                    string bookTitle;
                    do
                    {
                        Console.WriteLine("Input title:");
                        bookTitle = Console.ReadLine();

                    } while (bookTitle.Length==0);
                    Console.WriteLine("Input ISBN-number:");
                    string bookIsbn = Console.ReadLine();
                    int bookIsbnNr = 0;
                    do
                    {
                        try
                        {
                            Int32.TryParse(bookIsbn, out bookIsbnNr);
                            
                            count++;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Try again, isbn in numbers");
                        }

                    } while (count == 0);
                    Console.WriteLine("Input author:");
                    string bookAuthor = Console.ReadLine();
                    Book addingBook = new Book(bookTitle, bookIsbnNr, bookAuthor, false);
                    lib.addABook(addingBook);
                    break;
                case "E":
                    Console.WriteLine("what book do you wanna return? ");
                    string bookNa = Console.ReadLine();
                    lib.returnBook(bookNa);
                    break;
                default:
                    //not a good input
                    Console.WriteLine("Choose better");
                    break;
            }

            
        }

    }
}
