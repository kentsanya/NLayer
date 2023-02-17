using DataLayer.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
       public IRepository<Order> OrderRepository { get; }
       public IRepository<Flower> FlowerRepository { get; }
       void Save();
    }
}
