using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context
{
    internal class DataBaseContext: DbContext
    {
       
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
          : base(options)
        {
           
        }
       
    }
}
