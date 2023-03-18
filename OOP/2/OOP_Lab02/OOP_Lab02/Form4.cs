using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static OOP_Lab02.findBook;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_Lab02
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        public int counter = 0;

        public void CreateBook(int i) 
        {
            List<Book> listbook = dataBase();
            List<Book> books = new List<Book>();
            books.Add(listbook[i]);
            Book book = listbook[i];
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Book>));
            using (var file = new FileStream("buf.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(file, books);
            }
            textBox2.Text += $"№{i+1}\r\n" +
                $"[+] Автор - {book.author} " +
                $"Название - {book.name} ( {book.year} {book.amountOfPages} страниц), " +
                $" Издатель - {book.publisher}, УДК - {book.udk}\n";


        }
        public void Crunch(int sight) 
        {
            try 
            {
                if (textBox2.Text.Length != 0)
                {
                    textBox2.Clear();
                }
                List<Book> listbook = dataBase();
                List<Book> books = new List<Book>();
                counter = counter + sight;
               switch (counter)
                {
                    case 1:
                        {
                            CreateBook(0);
                            break;
                        }
                    case 2:
                        {
                            CreateBook(1);
                            break;
                        }
                    case 3:
                        {
                            CreateBook(2);
                            break;
                        }
                    case 4:
                        {
                            CreateBook(3);
                            break;
                        }
                    case 5:
                        {
                            CreateBook(4);
                            break;
                        }
                    case 6:
                        {
                            CreateBook(5);
                            break;
                        }
                    case 7:
                        {
                            CreateBook(6);
                            break;
                        }
                    case 8:
                        {
                            CreateBook(7);
                            break;
                        }
                    case 9:
                    case 10:
                        {
                            CreateBook(8);
                            counter = 0;
                            break;
                        }
                    
                    case 0:
                    case -1:
                        {
                            counter = listbook.Count;
                            CreateBook(8);
                            break;
                        }
                        default:
                        {
                            MessageBox.Show("Упс!");
                            break;
                        }
                }

            }
            catch 
            { }


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void CheckText(Regex aver)
        {
            MatchCollection matches = aver.Matches(textBox1.Text);
            List<Book> listbook = dataBase();
            List<Book> str = new List<Book>();
            if (matches.Count > 0)
            {
                foreach (var book in listbook)
                {
                    foreach (Match match in matches)
                    {
                        if (aver.IsMatch(book.publisher)) { 
                            textBox2.Text += $"\r\n" +
                                $"[+] Автор - {book.author}\n " +
                                $"Название - {book.name} ( {book.year} {book.amountOfPages} страниц), " +
                                $" Издатель - {book.publisher}, УДК - {book.udk}\n";
                                str.Add(book);
                        }
                    }

                }
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Book>));
                        using (var file = new FileStream("buf.json", FileMode.Create))
                        {
                            jsonFormatter.WriteObject(file, str);
                        }
            }
            else
                textBox2.Text += "Результат не найден!";
        }

        private void PublishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelLast.Text = "Последнее выполненое действие: поиск";

            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле ввода не заполнено!");
            }
            try
            {
                if(textBox2.Text.Length != 0)
                {
                    textBox2.Clear();
                }
                

                switch (textBox1.Text[0])
                {
                    case 'А':
                        case 'а':
                        {
                            Regex aver = new Regex(@"Ав[е, э]рс[е, э]в");
                            CheckText(aver);
                            break;
                        }
                    case 'М':
                    case 'Х':
                    case 'м':
                    case 'х':
                        {
                            Regex liter = new Regex(@"[Мастацкая, Художественная] л[і, и ]т[а, е]ратура");
                            CheckText(liter);
                            break;
                        }
                    case 'Б':
                    case 'б':
                        {
                            switch (textBox1.Text[3])
                            {
                                case 'о':
                                    { 
                            
                                        Regex bel = new Regex(@"Белорус?ская энциклопедия?");
                                        CheckText(bel);
                                        break;
                                    }
                                case 'ы':
                                    {
                                        Regex wh = new Regex(@"Белый ветер?");
                                        CheckText(wh);
                                        break;
                                    }
                            }
                            break;
                        }



                }

            }
            catch (Exception) { }
        }
        private void YearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelLast.Text = "Последнее выполненое действие: поиск";

            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле ввода не заполнено!");
            }
            try
            {
                if (textBox2.Text.Length != 0)
                {
                    textBox2.Clear();
                }
                List<Book> listbook = dataBase();
                int co = 0;
                var result = from book in listbook
                             where book.year == Int32.Parse(textBox1.Text)
                             select book;
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Book>));
                using (var file = new FileStream("buf.json", FileMode.Create))
                {
                    jsonFormatter.WriteObject(file, result);
                }
                foreach (var book in result)
                {
                    textBox2.Text += $"\r\n[+] Автор - {book.author}\r\n Название - {book.name} ( {book.year}, {book.amountOfPages} страниц),  Издатель - {book.publisher}, УДК - {book.udk}";
                    co++;
                   
                }
                if (co == 0)
                    textBox2.Text += "Результат не найден!";

            }
            catch (Exception) { }
        }        
        private void PagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelLast.Text = "Последнее выполненое действие: поиск";

            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле ввода не заполнено!");
            }
            try
            {
                if (textBox2.Text.Length != 0)
                {
                    textBox2.Clear();
                }
                List<Book> listbook = dataBase();
                var result = from book in listbook
                             where book.amountOfPages > Int32.Parse(textBox1.Text.Split(',')[0]) && book.amountOfPages < Int32.Parse(textBox1.Text.Split(',')[1])
                             select book;
                int co = 0;

                foreach (var book in result)
                {
                        textBox2.Text += $"\r\n[+] Автор - {book.author}\n Название - {book.name} ( {book.year}, {book.amountOfPages} страниц),  Издатель - {book.publisher}, УДК - {book.udk}\r\n";
                        co++;
                }
                if (co == 0)
                    textBox2.Text += "Результат не найден!";

            }
            catch (Exception) { }
        }

        protected static bool needToReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }
        private void NameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelLast.Text = "Последнее выполненое действие: сортировка";

            if (textBox2.Text.Length != 0)
            {
                textBox2.Clear();
            }
            List<Book> listbook = dataBase();
            for (int i = 0; i < listbook.Count; i++)
            {
                for (int j = 0; j < listbook.Count - 1; j++)
                    {
                    if (needToReOrder(listbook[j].name, listbook[j + 1].name))
                    {
                        Book s = listbook[j];
                        listbook[j] = listbook[j + 1];
                        listbook[j + 1] = s;
                    }
                }
            }
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Book>));
            using (var file = new FileStream("buf.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(file, listbook);
            }
            foreach (var book in listbook)
            {
                textBox2.Text += $"\r\n[+] Автор - {book.author}\n Название - {book.name} ( {book.year}, {book.amountOfPages} страниц),  Издатель - {book.publisher}, УДК - {book.udk}\r\n";
            }
        }
        private void DateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelLast.Text = "Последнее выполненое действие: сортировка";

            if (textBox2.Text.Length != 0)
            {
                textBox2.Clear();
            }
            List<Book> listbook = dataBase();
            var result = from book in listbook
                         orderby book.year
                            select book;

             var jsonFormatter = new DataContractJsonSerializer(typeof(List<Book>));
             using (var file = new FileStream("buf.json", FileMode.Create))
             {
                  jsonFormatter.WriteObject(file, result);
             }
            
            foreach (var book in result)
            {
                textBox2.Text += $"\r\n[+] Автор - {book.author}\n Название - {book.name} ( {book.year}, {book.amountOfPages} страниц),  Издатель - {book.publisher}, УДК - {book.udk}\r\n";
            }

            
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            try
            {
                int counter = 0;
                List<Book> newstr = new List<Book>();
                var jsonListFormatter = new DataContractJsonSerializer(typeof(List<Book>));
                using (var file = new FileStream("save.json", FileMode.Open))
                {
                    List<Book> str = (List<Book>)jsonListFormatter.ReadObject(file);
                    if (str != null)
                        foreach (var book in str) { 
                            newstr.Add(book);
                        }
                }
                using (var file = new FileStream("buf.json", FileMode.Open))
                {
                    List<Book> str = (List<Book>)jsonListFormatter.ReadObject(file);
                    if (str != null)
                        foreach (var book in str)
                        {
                            newstr.Add(book);
                            counter++;
                        }
                }
                objectsLoadedIndicator.Text = "Обьектов загружено: ";
                objectsLoadedIndicator.Text += counter.ToString();
                if (textBox2.Text.Length != 0)
                {

                    var jsonFormatter = new DataContractJsonSerializer(typeof(List<Book>));
                    using (var file = new FileStream("save.json", FileMode.Create))
                    {
                        jsonFormatter.WriteObject(file, newstr);
                    }
                }
                else
                    MessageBox.Show("Нет данных для сохранения!");

                    toolStripStatusLabelLast.Text = "Последнее выполненое действие: сохранение объектов";


            }
            catch (Exception)
            {

            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия проекта 2.0\r\nРазработчик - Жук Анна Михайловна");
        }

        private void SortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }





        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void toolStripStatusLabelPanelShow_Click(object sender, EventArgs e)
        {
            if (!menuStrip1.Visible)
            {
                menuStrip1.Show();
                toolStripStatusLabelLast.Text = "Последнее выполненое действие: вывод панели инструментов.";
            }
        }

        private void toolStripStatusLabelPanelHide_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Visible)
            {
                menuStrip1.Hide();
                toolStripStatusLabelLast.Text = "Последнее выполненое действие: скрытие панели инструментов.";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = $"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()} ";

        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crunch(1);
        }

        private void backwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crunch(-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void objectsLoadedIndicator_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabelLast_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
