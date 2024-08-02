using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MileStone1_Assessment
{
    class Books
    {
        public string bookId;
        public string bookName;
        public string isbnNumber;
        public double price;
        public string publisher;
        public int noOfPages;
        public string language;
        public string lot;
        public string summary;
        //constructor to set default values fro LOT and Language
        public Books()
        {
            this.lot = "Technical";
            this.language = "English";
        }
        //method to capture book details from user
        public void acceptBook()
        {
            Console.WriteLine("Enter Book Details ");
            Console.Write("Book ID : ");
            this.bookId = Console.ReadLine();
            Console.Write("Book Name : ");
            this.bookName = Console.ReadLine();
            Console.Write("ISBN Number : ");
            this.isbnNumber = Console.ReadLine();
            Console.Write("Price : ");
            bool isPriceValid = double.TryParse(Console.ReadLine(),out this.price);
            Console.Write("Publisher : ");
            this.publisher = Console.ReadLine();
            Console.Write("Total number of Pages : ");
            this.noOfPages = int.Parse(Console.ReadLine());
            Console.Write("Language : ");
            string tempLang = Console.ReadLine();
            this.language= (tempLang.Length>0)?tempLang:this.language;
            Console.Write("LOT : ");
            string tempLoT = Console.ReadLine();
            this.lot = (tempLoT.Length > 0) ? tempLoT : this.lot;
            Console.Write("Summary : ");
            this.summary = Console.ReadLine();
        }
        public void printBookDetails()
        {
            Console.WriteLine("Book ID : " + this.bookId);            
            Console.WriteLine("Book Name : "+this.bookName);
            Console.WriteLine("ISBN Number : "+this.isbnNumber);
            Console.WriteLine("Price : "+this.price);
            Console.WriteLine("Publisher : "+this.publisher);
            Console.WriteLine("Total number of Pages : "+this.noOfPages);
            Console.WriteLine("Language : "+this.language);
            Console.WriteLine("LOT : "+this.lot);
            Console.WriteLine("Summary : "+this.summary);
        }
        
    }
    internal class Library
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t******************Library******************");

            //predefined LoT 
            string[] LoTList = { ".NET", "JAVA", "IMS", "V&V", "BI", "RDBMS", "TECHNICAL" };
            int option = 0, subOption;
            Dictionary<string,Books> bookDictionary = new Dictionary<string,Books>();
            //looping until exit is pressed
            do{
                //display menu items and get selection from user
                Console.Write("\nMenu\n----\n\n1. Display books\n2. Add new book\n3. Delete book\n4. Exit\nEnter your Option : ");
                option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        display();
                        break;
                    case 2:
                        addBook();
                        break;
                    case 3:
                        removeBook();
                        break;
                    case 4:
                        Console.WriteLine("Exiting Menu.....");
                        break;
                    default: Console.WriteLine("Invalid selection!");
                        break;
                }

            }while(option!= 4);

            //Code for displaying book details
            void display()
            {
                Console.Write("\nEnter Book ID to display specific book.Press any key for displaying all book:");
                String displayBookID = Console.ReadLine();
                if (bookDictionary.Keys.Contains(displayBookID))
                {
                    Console.WriteLine("\nBook Details\n-------------");
                    bookDictionary[displayBookID].printBookDetails();

                }
                else
                {
                    for (int i = 0; i < bookDictionary.Count; i++)
                    {
                        bookDictionary[bookDictionary.Keys.ElementAt(i)].printBookDetails();
                    }
                }
            }

            //code to add book. validations will be done once data is entered by user
            void addBook()
            {
                Console.WriteLine("\nAdding new book\n----------------");
                Books newBook = new Books();
                newBook.acceptBook();
                if (bookDictionary.Keys.Contains(newBook.bookId))
                {
                    Console.WriteLine("Book ID " + newBook.bookId + " already exist in library \n");
                    
                }
                else
                {
                    bool isBookDetailsValid = validate(newBook);
                    if (isBookDetailsValid)
                    {
                        bookDictionary.Add(newBook.bookId, newBook);
                    }
                }
            }

            //code to remove book based on book id
            void removeBook()
            {
                Console.Write("\nDeleting existing book\n\nEnter Book ID to be removed : ");
                string displayBookID = Console.ReadLine();
                if (bookDictionary.Keys.Contains(displayBookID))
                {
                    bookDictionary.Remove(displayBookID);
                }
                else
                {
                    Console.WriteLine("\nInvalid Book ID!");
                }
                
            }

            //validate details entered by user
            Boolean validate(Books book)
            {   bool validBook=true;
                if (book.bookId.Length == 4)
                {
                    Console.WriteLine("Book ID should have 5 digits!");
                    validBook= false;
                }
                if(book.bookId.Length == 0 || book.bookName.Length == 0)
                {
                    Console.WriteLine("Book ID and Book Name cannot be blank");
                    validBook = false;
                }
                if (!(LoTList.Contains(book.lot.ToUpper())))
                {
                    Console.WriteLine("LoT value should be selected either of below LoT\n .NET, JAVA, IMS, V&V, BI, RDBMS");
                    validBook = false;
                }
                return validBook;
                
            }
        }
    }
}