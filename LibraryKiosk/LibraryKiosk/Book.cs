using System;
using System.Xml.Linq;

namespace LibraryKiosk
{
    public class Book: IComparable<Book>

    {

   
        public string Title { get; set; }

        public string Author { get; set; }

        public int Pages { get; set; }

        public string Publisher { get; set; }

        public void Print()
        {
            Console.WriteLine();
        }

        public int CompareTo(Book? other)
        {
            throw new NotImplementedException();
        }
    }

}

