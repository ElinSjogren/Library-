using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theLibrary
{
    //a class for the individual book propeties
    internal class Book
    {
        public string title { get; set; }
        public int isbn { get; set; }
        public string author { get; set; }
        public bool lended { get; set; }

        public Book(string title, int isbn, string author, bool lended) 
        {
            this.title = title.ToUpper();
            this.isbn = isbn;
            this.author = author;
            this.lended = lended;
        }

    }
}
