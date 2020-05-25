using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Library
    {
        public static readonly List<Models.Book> allBooks = new List<Models.Book>();

        /// <summary>
        /// Чтение из xml файла
        /// 
        /// </summary>
        static Library()
        {
            allBooks = DAL.WorkWithXML<List<Models.Book>>.InfoFromXml(@"xml/allBooks.xml");
        }

        /// <summary>
        /// Добавление книги
        /// </summary>
        /// <param name="name">Имя книги</param>
        /// <param name="genre">Жанр книги</param>
        /// <param name="author">Автор книги</param>
        public static void AddBook(string name, string genre, string author)
        {
            allBooks.Add(new Models.Book(name, genre, author));
        }
    }
}
