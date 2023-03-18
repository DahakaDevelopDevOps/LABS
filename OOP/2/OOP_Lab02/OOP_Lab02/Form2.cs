using System.Runtime.Serialization.Json;
using static OOP_Lab02.findBook;

namespace OOP_Lab02
{

    public partial class Form2 : Form
    {
        public Author GetAuthor()
        {
            try
            {
                var jsonListFormatter = new DataContractJsonSerializer(typeof(List<Book>));
                using (var file = new FileStream("book.json", FileMode.Open))
                {
                    Book book = (Book)jsonListFormatter.ReadObject(file);
                    List<Book> books = new List<Book>();
                    books.Add(book);
                    return new Author(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), books);
                }

            }
            catch
            {
                MessageBox.Show("Упс. Что-то пошло не так. Проверьте json-файл");
                return new Author(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text));
            }
        }

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string author)
        {
            InitializeComponent();
            string[] str = author.Split(' ');
            switch (str[0])
            {
                case "Пушкин":
                    textBox1.Text = "Пушкин Александ Сергеевич";
                    textBox3.Text = "111111111";
                    textBox2.Text = "Россия";
                    pictureBox1.Image = Image.FromFile("D:\\BSTU\\Лабы\\2 год\\4семестр\\ООП\\2\\P.jpg");
                    break;
                case "Мураками":
                    textBox1.Text = "Харуки Мураками";
                    textBox3.Text = "222222222";
                    textBox2.Text = "Япония";
                    pictureBox1.Image = Image.FromFile("D:\\BSTU\\Лабы\\2 год\\4семестр\\ООП\\2\\M.jpg");
                    break;
                case "Ремарк":
                    textBox1.Text = "Эрих Пауль Ремарк";
                    textBox3.Text = "333333333";
                    textBox2.Text = "Германия";
                    pictureBox1.Image = Image.FromFile("D:\\BSTU\\Лабы\\2 год\\4семестр\\ООП\\2\\Re.jpg");
                    break;
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var jsonListFormatter = new DataContractJsonSerializer(typeof(List<Author>));
                Author author = GetAuthor();
                using (var file = new FileStream("author.json", FileMode.Create))
                {
                    jsonListFormatter.WriteObject(file, author);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Упс. Что-то пошло не так, перезапустите программу или проверьте json-файл");
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
