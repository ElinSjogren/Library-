using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theLibrary
{
    //class to handle the books
    internal class Library
    {
        public List<Book> books;
        public Library() 
        {
            books = new List<Book>();
        }

        //methods?

        //add to the list
        public void addABook(Book b)
        {
            books.Add(b);
        }
        //remove from the list
        public void removeABook(string bookName)
        {
            foreach (Book b in books)
            {
                if(b.title == bookName)
                {
                    books.Remove(b);
                    Console.WriteLine("you have delated " + b.title);
                }

            }
        }
        //borrow book
        public void borrowBook(string bookName)
        { //when borrowing a book, go trough the list to find the rigth book
            //then check if its already lended or not.
            int controllVal = 0;
            bookName = bookName.ToUpper();
            foreach (Book bo in books)
            {
                if (bookName == bo.title && bo.lended == false)
                {
                    //in the list put that book lended value to true
                    
                        bo.lended = true;
                        Console.WriteLine("You have now borrowed " + bo.title);
                        controllVal++;
                }
            }
            if(controllVal==0)Console.WriteLine("No book found or avalible");

        }

        //return a book
        public void returnBook(string bookName)
        {
            //controllVal gets changes if book is found
            int controllVal = 0;
            bookName = bookName.ToUpper();
            foreach (Book bo in books)
            {
                if (bookName == bo.title && bo.lended == true)
                {
                    bo.lended = false;
                    Console.WriteLine("You have now returned: " + bo.title);
                    controllVal++;
                }
            }
           if(controllVal==0) Console.WriteLine("No book with that name to return");
        }

        //get status of books-list
        public void getBooks() 
        {
            foreach (Book b in books) 
            {
                Console.WriteLine(b.title + ". Lended: " + b.lended);
            }
        }
    }
}
