using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book books = new Book();
            books.bookName = "Yens";
            books.price = 20;
            books.qtyInStock = 70;
            books.authorName = "Yens";
            books.email = "yensbroothaers@student.arteveldehs.be";
            books.gender = 'M';
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", books.bookName, books.price, books.qtyInStock, books.authorName, books.email, books.gender);
        }
    }
}
