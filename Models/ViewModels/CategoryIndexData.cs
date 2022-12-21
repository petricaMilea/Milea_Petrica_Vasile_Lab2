﻿using Milea_Petrica_Vasile_Lab2.Models;


namespace Milea_Petrica_Vasile_Lab2.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
        public IEnumerable<Book> Books { get; set; }

    }
}