using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.IoC
{
    public interface IUOW
    {
        public IUnitOfWork GetContextBL();
    }
}
