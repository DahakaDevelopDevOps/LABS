using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using static OOP_Lab02.findBook;

namespace OOP_Lab02
{
    public partial class Form3 : Form
    {

        public Publisher GetPublisher()
        {
            try
            {
                var jsonListFormatter = new DataContractJsonSerializer(typeof(List<Author>));
                using (var file = new FileStream("author.json", FileMode.Open))
                {
                    Author author = (Author)jsonListFormatter.ReadObject(file);
                    List<Author> authors = new List<Author>();
                    authors.Add(author);
                    if (checkBox1.Checked)
                        return new Publisher(textBox3.Text, textBox2.Text, Int32.Parse(maskedTextBox1.Text), textBox1.Text ,checkBox1.Text, authors);
                    else
                        return new Publisher(textBox3.Text, textBox2.Text, Int32.Parse(maskedTextBox1.Text), textBox1.Text, checkBox2.Text, authors);
                }

            }
            catch
            {
                MessageBox.Show("Упс. Что-то пошло не так. Проверьте json-файл");
                if (checkBox1.Checked)
                    return new Publisher(textBox3.Text, textBox2.Text, Int32.Parse(maskedTextBox1.Text), textBox1.Text, checkBox1.Text);
                else
                    return new Publisher(textBox3.Text, textBox2.Text, Int32.Parse(maskedTextBox1.Text), textBox1.Text, checkBox2.Text);
            }
        }
        public Form3()
        {
            InitializeComponent();
            label2.Click += label2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;

        }
        public Form3(string publisher)
        {
            InitializeComponent();
            switch (publisher)
            {
                case "Аверсэв":
                    textBox2.Text = "Беларусь";
                    textBox3.Text = "Аверсэв";
                    textBox1.Text = "Минск";
                    maskedTextBox1.Text = "2000";
                    checkBox2.Checked = true;
                    checkBox1.Checked = false;
                    break;
                case "Белорусская энциклопедия им. П. Бровки":
                    textBox2.Text = "Беларусь";
                    textBox3.Text = "Белорусская энциклопедия им. П. Бровки";
                    textBox1.Text = "Гомель";
                    maskedTextBox1.Text = "1978";
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                    break;
                case "Белый ветер":
                    textBox2.Text = "Беларусь";
                    textBox3.Text = "Белый ветер";
                    textBox1.Text = "Гродно";
                    maskedTextBox1.Text = "2006";
                    checkBox2.Checked = true;
                    checkBox1.Checked = false;
                    break;
                case "Мастацкая літаратура":
                    textBox2.Text = "Беларусь";
                    textBox3.Text = "Мастацкая літаратура";
                    textBox1.Text = "Витебск";
                    maskedTextBox1.Text = "1991";
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                    break;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var jsonListFormatter = new DataContractJsonSerializer(typeof(List<Publisher>));
                Publisher publisher = GetPublisher();
                using (var file = new FileStream("publisher.json", FileMode.Create))
                {
                    jsonListFormatter.WriteObject(file, publisher);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Упс. Что-то пошло не так, перезапустите программу или проверьте json-файл");
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
