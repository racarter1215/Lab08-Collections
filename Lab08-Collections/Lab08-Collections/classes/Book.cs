﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08_Collections
{
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
