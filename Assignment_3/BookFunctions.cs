﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class BookFunctions
    {  
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            return string.Join(", ", B.Author);
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }
}
