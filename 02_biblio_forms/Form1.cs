using _1_biblio_system;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_biblio_forms
{
    public partial class Form1 : Form
    {
        string filename = "data_asd";

        List<Book> books;
        List<BookReader> readers;
        public Form1()
        {
            InitializeComponent();

            books = new List<Book>();
            readers = new List<BookReader>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Заполните необходимые поля.");
                return;
            }

            int id;
            if(!int.TryParse(textBox3.Text, out id))
            {
                MessageBox.Show("id - должно быть число.");
                return;
            }
            string author = textBox4.Text;
            string title = textBox5.Text;

            foreach(Book b in books)
            {
                if(b.id == id)
                {
                    MessageBox.Show("Книга с таким id уже существует: " + author + " - " + title);
                    return;
                }
            }

            Book bk = new Book(id, author, title);
            books.Add(bk);

            listBox1.Items.Add(bk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show("Заполните необходимые поля.");
                return;
            }

            int year;
            if (!int.TryParse(textBox2.Text, out year))
            {
                MessageBox.Show("Год - должно быть число.");
                return;
            }
            string name = textBox1.Text;

            BookReader rdr = new BookReader(name, year);
            readers.Add(rdr);

            listBox2.Items.Add(rdr);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
                return;

            textBox1.Text = readers[listBox2.SelectedIndex].name;
            textBox2.Text = readers[listBox2.SelectedIndex].birthyear.ToString();

            update_reader_books_listbox();
        }

        private void update_reader_books_listbox()
        {
            listBox3.Items.Clear();
            foreach (Book b in readers[listBox2.SelectedIndex].GetList())
            {
                listBox3.Items.Add(b);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите книгу");
                return;
            }
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите читателя");
                return;
            }

            foreach(BookReader r in readers)
            {
                foreach(Book b in r.GetList())
                {
                    if(b.id == books[listBox1.SelectedIndex].id)
                    {
                        MessageBox.Show("Данная книга принадлежит - " + r);
                        return;
                    }
                }
            }

            readers[listBox2.SelectedIndex].TakeBook(books[listBox1.SelectedIndex]);
            update_reader_books_listbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите читателя");
                return;
            }
            if (listBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите книгу");
                return;
            }

            readers[listBox2.SelectedIndex].BookBack(books[listBox3.SelectedIndex].id);
            update_reader_books_listbox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите читателя");
                return;
            }

            readers[listBox2.SelectedIndex].BackAll();
            update_reader_books_listbox();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы хотите сохранить состояние программы в файл?", "Да?", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;

            ProgramState ps = new ProgramState(books, readers);

            FileStream f = File.Create(filename);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, ps);
            f.Close();

            MessageBox.Show("Данные сохранены в файл " + filename);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists(filename))
            {
                DialogResult dialogResult = MessageBox.Show("Обнаружен файл с сохранёнными данными предыдущей работы программы. Вы хотите восстановить их?", "Да?", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    Stream f = File.OpenRead(filename);

                    ProgramState ps = bf.Deserialize(f) as ProgramState;
                    f.Close();

                    this.books = ps.books;
                    this.readers = ps.readers;

                    foreach(Book b in books)
                    {
                        listBox1.Items.Add(b);
                    }
                    foreach(BookReader r in readers)
                    {
                        listBox2.Items.Add(r);
                    }
                }
            }
        }
    }
}

[Serializable]
class ProgramState
{
    public List<Book> books;
    public List<BookReader> readers;
    public ProgramState(List<Book> books, List<BookReader> readers)
    {
        this.books = books;
        this.readers = readers;
    }
}