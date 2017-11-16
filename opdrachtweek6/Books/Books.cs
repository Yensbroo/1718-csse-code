namespace Book
{

    public class Book : Author {
        public string bookName;
        public double price;
        public int qtyInStock;



        public Book (string bookName, double price, int qtyInStock)
        {
            this.bookName = bookName;
            this.price = price;
            this.qtyInStock = qtyInStock;
        }

        public Book () {

            qtyInStock = 1;

        }



        public string Name { get => bookName; set => bookName = value; }


        public double Price { get => price; set => price = value;}

        public int QtyInStock { get => qtyInStock; set => qtyInStock = value;}

        public void GetAuthor (string authorName) {
           this.authorName = authorName ;
       }

       public void GetEmail (string email) {
           this.email = email;
       }

       public void GetGender (char gender) {
           this.gender = gender;
       }

    }
}