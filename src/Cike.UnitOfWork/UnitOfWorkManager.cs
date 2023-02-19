using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.UnitOfWork
{
    public class UnitOfWorkManager : IUnitOfWorkManager
    {
        public IUnitOfWork CurrentUnitOfWork { get; }

        public IUnitOfWork Create()
        {
            throw new NotImplementedException();
        }

        public IUnitOfWork Create(UnitOfWorkOptions unitOfWorkOptions)
        {
            throw new NotImplementedException();
        }
    }
}
