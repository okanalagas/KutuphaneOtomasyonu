using Kütüphane_Otomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class MemberPanel : Form
    {
        List<Book> Books;
        public MemberPanel(List<Book> books)
        {
            InitializeComponent();
            Books = books;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void MemberPanel_Load(object sender, EventArgs e)
        {
            foreach (Book book in Books)
            {
                dataGridView1.Rows.Add(book.Id, book.Name, book.Author, book.Language, book.Publisher, book.Genre, book.Count, book.Page, book.PublicationYear);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Book searchedBook=null;
            foreach (Book book in Books)
            {
                if(textBox_search.Text.ToLower()==book.Name.ToLower())
                {
                    searchedBook= book;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(searchedBook.Id, searchedBook.Name, searchedBook.Author, searchedBook.Language, searchedBook.Publisher, searchedBook.Genre, searchedBook.Count, searchedBook.Page, searchedBook.PublicationYear);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Book book in Books)
            {
                dataGridView1.Rows.Add(book.Id, book.Name, book.Author, book.Language, book.Publisher, book.Genre, book.Count, book.Page, book.PublicationYear);
            }
        }
    }
}
