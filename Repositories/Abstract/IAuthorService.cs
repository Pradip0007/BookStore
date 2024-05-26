using System;
using BookStore.Models.Domain;

namespace BookStore.Repositories.Abstract
{
	public interface IAuthorService
	{
        bool Add(Author Model);
        bool Update(Author Model);
        bool Delete(int id);
        Author FindById(int id);
        IEnumerable<Author> GetAll();
    }
}

