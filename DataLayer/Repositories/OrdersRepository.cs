using DataLayer.Entitys;


namespace DataLayer.Repositories
{
    public class OrdersRepository : IRepository<Order>
    {
        private List<Order> _orders;
        public void Add(Order entity)
        {
            _orders.Add(entity);
        }

        public Order? FindById(int id)
        {
            return _orders.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _orders;
        }

        public bool Remove(Order entity)
        {
            return _orders.Remove(entity);
        }
    }
}
