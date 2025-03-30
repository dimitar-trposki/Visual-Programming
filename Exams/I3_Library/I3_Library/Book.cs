using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3_Library
{
    public class Book
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumOfAvailableCopies { get; set; }

        public Book(string iD, string title, string author, int numOfAvailableCopies)
        {
            ID = iD;
            Title = title;
            Author = author;
            NumOfAvailableCopies = numOfAvailableCopies;
        }

        public void decrementCopies()
        {
            --NumOfAvailableCopies;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} ({2}) (x{3})", ID, Title, Author, NumOfAvailableCopies);
        }
    }
}
