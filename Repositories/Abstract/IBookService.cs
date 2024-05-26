using System;
using BookStore.Models.Domain;

namespace BookStore.Repositories.Abstract
{
	public interface IBookService
	{
        bool Add(Book Model);
        bool Update(Book Model);
        bool Delete(int id);
        Book FindById(int id);
        IEnumerable<Book> GetAll();
    }
}

