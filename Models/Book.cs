using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Book
    {
        public string name { get; set; }
        public bool isAvalible { get; set; }
        public string genre { get; set; }
        public string author { get; set; }
        public Book()
        {
            isAvalible = true;
        }
        public Book(string name, string genre, string author) : this()
        {
            this.name = name;
            this.author = author;
            this.genre = genre;
        }
    }
}
