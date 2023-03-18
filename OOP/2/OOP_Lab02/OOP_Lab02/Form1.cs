using System.Runtime.Serialization.Json;
using System.Text.RegularExpressions;
using static OOP_Lab02.findBook;

namespace OOP_Lab02
{
    public partial class Form1 : Form
    {
        public Book GetBook()
        {
            List<string> strName = new List<string>();
            var result = findBook.findAt(textBox1.Text);
            foreach (var item in result)
            {
                strName.Add(item.ToString().Split('-')[0]);
            }

            string[] str = textBox1.Text.Split(' ');
            if (radioButton1.Checked)
            {
                return new Book(radioButton1.Text, (textBox2.Text), listBox1.Text, textBox3.Text, Int32.Parse(textBox4.Text), listBox2.Text, Int32.Parse(maskedTextBox1.Text), strName, dateTimePicker1.Text);
            }
            else if (radioButton3.Checked)
            {
                return new Book(radioButton3.Text, (textBox2.Text), listBox1.Text, textBox3.Text, Int32.Parse(textBox4.Text), listBox2.Text, Int32.Parse(maskedTextBox1.Text), strName, dateTimePicker1.Text);
            }
            else if (radioButton4.Checked)
            {
                return new Book(radioButton4.Text, (textBox2.Text), listBox1.Text, textBox3.Text, Int32.Parse(textBox4.Text), listBox2.Text, Int32.Parse(maskedTextBox1.Text), strName, dateTimePicker1.Text);
            }
            else
            {
                return new Book(radioButton5.Text, (textBox2.Text), listBox1.Text, textBox3.Text, Int32.Parse(textBox4.Text), listBox2.Text, Int32.Parse(maskedTextBox1.Text), strName, dateTimePicker1.Text);
            }
        }


        public bool IsValidStr()
        {
            Regex regex = new Regex(@"[0-9]");//@"^[0-9]{1,3}\.[0-9]{1,3}(\/[0-9]{1,2})?$"
            MatchCollection matches = regex.Matches(textBox3.Text);
            if (matches.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += button3_Click;
            listBox1.SelectedIndexChanged += button3_Click;
            listBox2.SelectedIndexChanged += button3_Click;
            checkBox1.CheckedChanged += button3_Click;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {   
                List<string> strName = new List<string>();
                List<string> strDate = new List<string>();
                List<string> strPages = new List<string>();
                List<string> strSize = new List<string>();
                if (textBox1.Text.Length != 0 && listBox2.Text != "")
                {
                    checkBox1.Enabled = true;
                }
                if (checkBox1.Checked)
                {
                    Form2 form2 = new Form2(textBox1.Text);
                    form2.Show();
                    Form3 form3 = new Form3(listBox2.Text);
                    form3.Show();
                    checkBox1.Checked = false;
                }
                else if (listBox1.Items.Count == 0)
                {
                    var result = findBook.findAt(textBox1.Text);
                    foreach (var item in result)
                    {
                        string[] strings = item.ToString().Split('-');
                        listBox1.Items.Add(strings[0]);
                    }
                }
                else
                {
                    var result = findBook.findAt(textBox1.Text);

                    foreach (var item in result)
                    {
                        string[] str = item.ToString().Split('-');
                        strName.Add(str[0]);
                        strDate.Add(str[1]);
                        strPages.Add(str[2]);
                        strSize.Add(str[3]);
                    }

                    var indexOfText = strName.IndexOf(listBox1.Text);
                    maskedTextBox1.Text = strDate[indexOfText];
                    textBox4.Text = strPages[indexOfText];
                    textBox2.Text = strSize[indexOfText];
                }
                if (Int32.Parse(maskedTextBox1.Text) < 1900)
                {
                    textBox3.Text = "621.3.06";

                }
                else if (Int32.Parse(maskedTextBox1.Text) > 1900 && Int32.Parse(maskedTextBox1.Text) < 1960)
                {
                    textBox3.Text = "81.23.1";
                }
                else
                {
                    textBox3.Text = "311.2.3";
                }
                Book book = new Book(textBox3.Text);
                Book.CreateUDK(book.udk);


            }
            catch (Exception)
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.Items.RemoveAt(i);
                }
                listBox1.Items.RemoveAt(0);
                textBox1.Clear();
                maskedTextBox1.Text = "";
                textBox3.Clear();
                textBox4.Clear();
                textBox2.Clear();
                textBox5.Clear();
                checkBox1.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Проблема с отчисткой!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox1.Text == " " || textBox3.Text.Length == 0
                    || textBox1.Text.Length == 0 || (radioButton5.Checked && radioButton1.Checked
                    && radioButton3.Checked && radioButton4.Checked))
                {
                    MessageBox.Show("Не все поля заполнены!!!");
                }
                else
                {
                    var jsonListFormatter = new DataContractJsonSerializer(typeof(List<Book>));
                    Book book = GetBook();
                    List<string> listbook = new List<string>();
                    using (var file = new FileStream("book.json", FileMode.Create))
                    {
                        jsonListFormatter.WriteObject(file, book);
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Упс. Что-то пошло не так, перезапустите программу или проверьте json-файл");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var jsonListFormatter = new DataContractJsonSerializer(typeof(List<Book>));
                using (var file = new FileStream("book.json", FileMode.Open))
                {
                    Book book = (Book)jsonListFormatter.ReadObject(file);
                    textBox5.Text = $"[+] Формат - {book.format}\n[+] Размер - {book.size}\n[+] Наименование - {book.name}\n[+] УДК - {book.udk}\n[+] Кол-во страниц - {book.amountOfPages}\n[+] Издатель - {book.publisher}\n[+] Год создания - {book.year}\n[+] Дата загрузки - {book.dateOfLoad}\n";
                }
            }
            catch (Exception)
            {

            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


    }
}