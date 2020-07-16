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
        public Author Author { get; set; }
        public Genre Genre { get; set; }

    }

    public enum Genre
    {
        SciFi,
        History,
        Mystery,
        Politics
    }
}
