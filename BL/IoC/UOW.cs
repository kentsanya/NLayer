using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.IoC
{
    public class UOW : IUOW
    {
        private IUnitOfWork _unitOfWork;
        public UOW(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }
        public IUnitOfWork GetContextBL()
        {
            return _unitOfWork;
        }
    }
}
