﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public double Price { get; set; }

        public Book(string isbn, string title, string[] author, DateTime publicationDate, double price)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            Price = price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {string.Join(", ", Author)}, Publication Date: {PublicationDate}, Price: {Price}";
        }
    }
}
