using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonu.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreationDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }        

        public User()
        {

        }

        public User(int id, string name, string surname, DateTime creationDate, string username, string password, string authority)
        {
            Id = id;
            Name = name;
            Surname = surname;
            CreationDate = creationDate;
            Username = username;
            Password = password;
            Authority = authority;
        }
    }
}
