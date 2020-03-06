using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public string Autor { get; set; }
        public string Title { get; set; }
        public Book (string autor, string title)
        {
            this.Autor = autor;
            this.Title = title;
        }
        public Book ()
        {
        }
    }
}
