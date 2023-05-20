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
    public partial class AdminPanel : Form
    {
        List<User> Users;
        List<Book> Books;
        public AdminPanel(List<User> users, List<Book> books)
        {
            InitializeComponent();
            this.Users = users;
            Books = books;  
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            foreach (User user in Users)
            {
                dataGridView1.Rows.Add(user.Id, user.Name, user.Surname, user.CreationDate, user.Username, user.Password, user.Authority);
            }
            foreach (Book book in Books)
            {
                dataGridView2.Rows.Add(book.Id, book.Name, book.Author, book.Language, book.Publisher, book.Genre, book.Count, book.Page, book.PublicationYear);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox_id.Text, textBox_name.Text, textBox_surname.Text, textBox_creationDate.Text, textBox_username.Text, textBox_password.Text, textBox_authority.Text);
            ClearText();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            ClearText();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridFill();
        }
       

        private void button_update_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells[0].Value=textBox_id.Text;
            dataGridView1.CurrentRow.Cells[1].Value=textBox_name.Text;
            dataGridView1.CurrentRow.Cells[2].Value=textBox_surname.Text;
            dataGridView1.CurrentRow.Cells[3].Value=textBox_creationDate.Text;
            dataGridView1.CurrentRow.Cells[4].Value=textBox_username.Text;
            dataGridView1.CurrentRow.Cells[5].Value=textBox_password.Text;
            dataGridView1.CurrentRow.Cells[6].Value=textBox_authority.Text;
            ClearText();
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        public void GridFill()
        {
            textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_surname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_creationDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_username.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_password.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_authority.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        public void ClearText()
        {
            for (int i = 0; i < groupBox_memberProcess.Controls.Count; i++)
            {
                if (groupBox_memberProcess.Controls[i] is TextBox)
                {
                    groupBox_memberProcess.Controls[i].Text=string.Empty;
                }
            }
        }
        public void ClearText2()
        {
            for (int i = 0; i < groupBox_bookProcess.Controls.Count; i++)
            {
                if (groupBox_bookProcess.Controls[i] is TextBox)
                {
                    groupBox_bookProcess.Controls[i].Text = string.Empty;
                }
            }
        }

        private void button_bookAdd_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(textBox_bookId.Text, textBox_bookName.Text, textBox_author.Text, textBox_language.Text, textBox_publisher.Text, textBox_genre.Text, textBox_count.Text, textBox_page.Text, textBox_publicationYear.Text);
            ClearText2();
        }

        private void button_bookDelete_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void button_bookUpdate_Click(object sender, EventArgs e)
        {
            dataGridView2.CurrentRow.Cells[0].Value=textBox_bookId.Text;
            dataGridView2.CurrentRow.Cells[1].Value=textBox_bookName.Text;
            dataGridView2.CurrentRow.Cells[2].Value=textBox_author.Text;
            dataGridView2.CurrentRow.Cells[3].Value=textBox_language.Text;
            dataGridView2.CurrentRow.Cells[4].Value=textBox_publisher.Text;
            dataGridView2.CurrentRow.Cells[5].Value=textBox_genre.Text;
            dataGridView2.CurrentRow.Cells[6].Value=textBox_count.Text;
            dataGridView2.CurrentRow.Cells[7].Value=textBox_page.Text;
            dataGridView2.CurrentRow.Cells[8].Value=textBox_publicationYear.Text;
            ClearText2();
        }

        private void button_bookClear_Click(object sender, EventArgs e)
        {
            ClearText2();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_bookId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox_bookName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox_author.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox_language.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox_publisher.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox_genre.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox_count.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            textBox_page.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            textBox_publicationYear.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }       
    }
}
