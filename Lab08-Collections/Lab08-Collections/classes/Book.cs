using System;
using Lab08_Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab08_Collections
{/// <summary>
/// below is a class of Book with three properties
/// </summary>
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        
    }

    enum Genre
    {
        SciFi,
        History,
        Mystery,
        Politics
    }
}
