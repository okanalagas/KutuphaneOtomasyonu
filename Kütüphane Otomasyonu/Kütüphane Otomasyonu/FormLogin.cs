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
    public partial class FormLogin : Form
    {
        List<User> Users = new List<User>();
        List<Book> Books = new List<Book>();
        public FormLogin()
        {
            InitializeComponent();
        }   

        private void button_login_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (User user in Users)
            {
                if (textBox_username.Text.ToLower() == user.Username && textBox_password.Text == user.Password && user.Authority == "admin")
                {
                    AdminPanel adminPanel = new AdminPanel(Users,Books);
                    adminPanel.Show();
                    this.Hide();
                    check= true;
                    break;
                }
                else if (textBox_username.Text.ToLower() == user.Username && textBox_password.Text == user.Password && user.Authority == "member")
                {
                    MemberPanel memberPanel = new MemberPanel(Books);
                    memberPanel.Show();
                    this.Hide();
                    check= true;
                    break;
                }                             
            }
            if (!check)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Users.Add(new User(1, "Mehmet", "Yılmaz", DateTime.Now, "mehmetyilmaz", "1234", "admin"));
            Users.Add(new User(2, "Ali", "Yıldız", DateTime.Now, "aliyildiz", "123", "member"));
            Users.Add(new User(3, "Necla", "Korkmaz", DateTime.Now, "neclakorkmaz", "123", "member"));
            Users.Add(new User(4, "Ceyda", "Kuşçu", DateTime.Now, "ceydakuscu", "123", "member"));

            Books.Add(new Book(1, "Kitap1", "Yazar1", "Dil1", "YayınEvi1", "Tür1", 100, 250, 2000));
            Books.Add(new Book(2, "Kitap2", "Yazar2", "Dil1", "YayınEvi2", "Tür2", 150, 1200, 2010));
            Books.Add(new Book(3, "Kitap3", "Yazar3", "Dil1", "YayınEvi3", "Tür3", 1250, 175, 1999));
            Books.Add(new Book(4, "Kitap4", "Yazar4", "Dil1", "YayınEvi2", "Tür1", 4100, 97, 1995));
            Books.Add(new Book(5, "Kitap5", "Yazar3", "Dil1", "YayınEvi3", "Tür5", 52100, 55, 2011));
            Books.Add(new Book(6, "Kitap6", "Yazar5", "Dil1", "YayınEvi4", "Tür4", 1090, 21, 2007));
        }
    }
}
