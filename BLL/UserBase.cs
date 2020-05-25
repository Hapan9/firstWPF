using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBase
    {
        public static readonly List<Models.User> allUsers = new List<Models.User>();

        /// <summary>
        /// загружает изначальный список пользователей из xml
        /// </summary>
        static UserBase()
        {
            allUsers = DAL.WorkWithXML<List<Models.User>>.InfoFromXml(@"xml/allUsers.xml");
        }

        /// <summary>
        /// Добавляет нового пользователя (дальнейшая доработка)
        /// </summary>
        /// <param name="name">Имя пользователя</param>
        /// <param name="surname">Фамилия пользователя</param>
        /// <param name="futhername">Отчество пользователя</param>
        /// <param name="booksID">ЛИСТ (ид) книг которые взял пользователь</param>
        public static void AddUser(string name, string surname, string futhername)
        {
            allUsers.Add(new Models.User(name, surname, futhername));
        }
    }
}
