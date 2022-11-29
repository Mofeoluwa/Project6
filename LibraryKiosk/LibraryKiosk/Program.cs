using System;
using System.Xml.Linq;

namespace LibraryKiosk;

class Program
{

public static void Main(string[] args)
    {
        string path = @"books.csv";

        //string lineFromCSV:= "";
       

        using (StreamReader sr = new StreamReader(path))
        {
            AvlTree tree = new AvlTree();
            int i = 1;
            string line;
            List<string> lines;
            Node node = new Node();
            while ((line = sr.ReadLine()) != null)
            {
                lines = ProcessCSVLine(line);
                Book book = new Book();
                book.Title = lines[0];
                book.Author = lines[1];
                book.Pages = Int32.Parse(lines[2]);
                book.Publisher = lines[3];
                i++;

                //Console.WriteLine(book.Title);
                //Console.WriteLine(book.Author);
                //Console.WriteLine(book.Pages);
                //Console.WriteLine(book.Publisher);

                book.Print();
                node.book = book;
                node.Title = lines[0];



            }


        };



        List<string> ProcessCSVLine(string lineFromCSV)
        {

            string[] rawBookParts = lineFromCSV.Split(",");
            List<string> sanitizedBookParts = new List<string>();
            string cleanString = string.Empty;
            for (int i = 0; i < rawBookParts.Length; i++)
            {
                cleanString += rawBookParts[i];
                if (cleanString.StartsWith("\"") && !cleanString.EndsWith("\""))
                {
                    continue;
                }
                sanitizedBookParts.Add(cleanString.Replace("\"", String.Empty));
                cleanString = String.Empty;

            }

            return sanitizedBookParts;


        }



        //tree.Add(5);
        //tree.DisplayTree();


    } // End Main``` }
}

