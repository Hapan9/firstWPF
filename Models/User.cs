using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class User
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string futhername { get; set; }
        //public readonly List<int> usedBooks = new List<int>();
        public readonly List<Book> usedBooks = new List<Book>();
        public User()
        {
            for (int i = 0; i < usedBooks.Count; i++)
            {
                usedBooks[i].isAvalible = false;
            }
        }
        public User(string name, string surname, string futhername) : this()
        {
            this.name = name;
            this.surname = surname;
            this.futhername = futhername;
        }

        /// <summary>
        /// Добавляет ссылку на объект класса book с листа
        /// </summary>
        /// <param name="usedBook"></param>
        public void AddUsedBook(Book usedBook)
        {
            if (usedBook.isAvalible)
            {
                usedBooks.Add(usedBook);
                usedBooks[usedBooks.Count - 1].isAvalible = false;
            }
        }
        public string AllInfo()
        {
            string res = "Ім'я: " + name + "\nФамилия: " + surname + "\nОтчество: " + futhername + "\n";
            if (usedBooks.Count != 0)
            {
                for (int i = 0; i < usedBooks.Count; i++)
                {
                    res += "\n" + (i+1) + " Книга\nНазва: " + usedBooks[i].name + "\nАвтор: " + usedBooks[i].author + "\nЖанр: " + usedBooks[i].genre;
                }
            }
            return res;
        }
    }
}
