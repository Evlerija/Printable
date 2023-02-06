using System;

namespace ConsoleApp18
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Dota");
            Book book2 = new Book("CS");
            Magazine magazine1 = new Magazine("Tarkov");
            Magazine magazine2 = new Magazine("Warface");
            Printable[] printables = { book1, book2, magazine1, magazine2 };
            for (int i = 0; i < printables.Length; i++)
            {
                printables[i].Print();
                
            }
            
        }
    }
    public interface Printable
    {
        public void Print()
        {
        }
        
    }
    public class Book : Printable
    {
        public string book;
        
        static void PrintBooks(Printable[] printables)
        {
            
        }
        public string getBook()
        {
            return book;
        }
        public void setBook1(string book)
        {
            this.book = book;
        }
        public Book(string Book)
        {
            book = Book;
        }
        public void Print()
        {

        }
        override
        public string ToString()
        {
            return "Book{" + "name='" + book + " " + "}";
        }


    }
    public class Magazine : Printable
    {
        private string magazine;
        static void printMagazines(Printable[] printables)
        {

        }
        public string getMagazine1()
        {
            return magazine;
        }
        public void setBook1(string magazine)
        {
            this.magazine = magazine;
        }
        public Magazine(string magazine)
        {
            this.magazine = magazine;
        }
        public void Print()
        {
           
        }
        override
        public string ToString()
        {
            return "Magazine{" + "name='" + magazine + " " + "}";
        }

    }
}

