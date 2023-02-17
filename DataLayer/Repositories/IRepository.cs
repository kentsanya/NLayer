using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IRepository<T> where T : class
    {
      public  void Add(T entity);
       public  bool Remove (T entity);

        public IEnumerable<T> GetAll();

        public T? FindById(int id);

    }
}
