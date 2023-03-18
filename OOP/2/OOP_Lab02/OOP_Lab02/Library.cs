using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization.Json;

namespace OOP_Lab02
{
    public class findBook
    {
        public static List<Book> dataBase()
        {
            var jsonListFormatter = new DataContractJsonSerializer(typeof(List<Book>));
            using (var filelist = new FileStream("mybd.json", FileMode.Open))
            {
                List<Book> listbook = ((List<Book>)jsonListFormatter.ReadObject(filelist));
                return listbook;
            }
        }
            public static List<string> findAt(string str)
        {
            string[] sourse = str.Split(' ');
            switch (sourse[0])
            {
                case "Пушкин":
                    return new List<string>() { "О рыбаке и рыбке -1833-25-1Мб", "Цыганы -1824-36-2Мб", "Борис Годунов -1831-100-3Мб" };
                case "Мураками":
                    return new List<string>() { "Охота на овец -1982-350-1Мб", "Убийство Командора -2017-1500-2Мб", "К югу от границы, на запад от солца -1992-125-3Мб" }; ;
                case "Ремарк":
                    return new List<string>() { "Три товарища -1936-241-1Мб", "Черный обелиск -1956-365-2Мб", "Триумфальная арка -1945-127-3Мб" };
                default:
                    throw new InvalidCastException();
            }
        }
        public class Book
        {
            [StringLength(20, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
            public string author { get;set; }
            public string format;
            public string size;
            public string name;
            [Validators.UDKValidation(ErrorMessage = "Неправильный УДК!")]
            [RegularExpression(@"[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}")]
            public string udk { get; set; }
            public int amountOfPages;
            public string publisher;
            public List<int> listOfYears;
            public List<int> Pages;
            public List<string> publishers;
            public int year;
            public List<string> listOfPublisher;
            public string dateOfLoad;

            public Book( List<string> listOfPublisher, string author, List<int> listOfYears, List<int> Pages, List<string> publishers, string udk) 
            {
                this.author = author;
                this.listOfPublisher = listOfPublisher;
                this.listOfYears = listOfYears;
                this.Pages = Pages;
                this.publishers = publishers;
                this.udk = udk;
            }
            public Book(string udk) { this.udk = udk; }
            //Валидация УДК
            public static void CreateUDK(string udk)
            {
                Book book = new Book(udk);
                var results = new List<ValidationResult>();
                var context = new ValidationContext(book);
                if (Validator.TryValidateObject(book, context, results, true))
                    MessageBox.Show("Проходит валидацию!");
                else
                    MessageBox.Show("Неверный УДК!");
            }
            //----------------
            public Book() { }
            public Book(string author, string name) 
            {
                this.author = author;
                this.name = name;

            }
            public Book(string format, string size, string name,
                        string udk, int amountOfPages, string publisher,
                        int year, List<string> listOfPublisher, string dateOfLoad)
            {
                this.format = format;
                this.size = size;
                this.name = name;
                this.udk = udk;
                this.amountOfPages = amountOfPages;
                this.publisher = publisher;
                this.year = year;
                this.listOfPublisher = listOfPublisher;
                this.dateOfLoad = dateOfLoad;

            }



            
        }

        public class Author
        {

            List<Book> ownBooks = new List<Book>();

            public string FIO;
            public string country;
            private int ID;
            public Author() { }
            public Author(string FIO, string country, int ID, List<Book> ownBooks)
            {
                this.FIO = FIO;
                this.country = country;
                this.ID = ID;
                this.ownBooks = ownBooks;
            }
            public Author(string FIO, string country, int ID)
            {
                this.FIO = FIO;
                this.country = country;
                this.ID = ID;
            }

        }

        public class Publisher
        {
            List<Author> authors = new List<Author>();
            public string name;
            public string country;
            public string town;
            public int yearOfFoundation;
            public string status;
            public Publisher() { }
            public Publisher(string name, string country, int yearOfFoundation, string town, string status, List<Author> authors)
            {
                this.name = name;
                this.country = country;
                this.yearOfFoundation = yearOfFoundation;
                this.status = status;
                this.authors = authors;
                this.town = town;
            }
            public Publisher(string name, string country, int yearOfFoundation, string town, string status)
            {
                this.name = name;
                this.country = country;
                this.yearOfFoundation = yearOfFoundation;
                this.status = status;
                this.town = town;
            }

        }



    }
}
