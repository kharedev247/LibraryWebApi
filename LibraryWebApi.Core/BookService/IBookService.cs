﻿using LibraryWebApi.Common.Models;

namespace LibraryWebApi.Core.BookService
{
  public interface IBookService
  {
    Task<IEnumerable<Book>> GetAllBooksAsync();
    Task<Book> GetBookByIdAsync(int id);
    Task AddBookAsync(Book book);
    Task UpdateBookAsync(Book book);
    Task DeleteBookAsync(int id);
  }
}
