﻿using System.Collections.Generic;
using BooksSampleWithMVVM.Models;

namespace BooksSampleWithMVVM.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);

        int NextId();
    }
}