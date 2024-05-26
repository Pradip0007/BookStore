using System;
using BookStore.Models.Domain;

namespace BookStore.Repositories.Abstract
{
	public interface IGenreService
	{
		bool Add(Genre Model);
        bool Update(Genre Model);
        bool Delete(int id);
        Genre FindById(int id);
        IEnumerable<Genre> GetAll();
    }
}

