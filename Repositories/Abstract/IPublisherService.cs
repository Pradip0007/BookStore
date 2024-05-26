using System;
using BookStore.Models.Domain;

namespace BookStore.Repositories.Abstract
{
	public interface IPublisherService
	{
        bool Add(Publisher Model);
        bool Update(Publisher Model);
        bool Delete(int id);
        Publisher FindById(int id);
        IEnumerable<Publisher> GetAll();
    }
}

