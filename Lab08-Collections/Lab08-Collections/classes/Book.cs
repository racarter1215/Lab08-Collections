using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08_Collections
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string BookGenre { get; set; }
        public string BookLength { get; set; }
    }

    enum BookGenre
    {
        SciFi,
        History,
        Mystery,
        Politics
    }
}
