using BL.DTOModels;


namespace DataLayer.Repositories
{
    public class FlouwersRepository : IRepository<Flower>
    {
        private List<Flower> _flouwers;
        public void Add(Flower entity)
        {
            _flouwers.Add(entity);
        }

        public Flower? FindById(int id)
        {
            if (id > 0) 
            {
                Flower? flower = _flouwers.Find((f) => f.Id == id);
                if (flower != null)
                    return flower;
                else return null;
            }
            else return null;
        }

        public IEnumerable<Flower> GetAll()
        {
            return _flouwers;
        }

        public bool Remove(Flower entity)
        {
            if (entity!=null)
            {
                return _flouwers.Remove(entity);
            }
            else return false;
        }
    }
}
