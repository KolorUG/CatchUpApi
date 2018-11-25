using CatchUppApi.Models;
using System.Collections.Generic;

namespace CatchUppApi.ReposInterfaces
{
    public interface IRepository<T> where T :  BaseEntity
    {
         T GetById(int id);
         IEnumerable<T> GetAll();
         T Add(T entity);
         void Update(T entity);
         void Delete(T entity);
    }
}