using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.UnitOfWork
{
    public class UnitOfWorkManager : IUnitOfWorkManager
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public UnitOfWorkManager(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }
        public IUnitOfWork CurrentUnitOfWork { get; }


        public IUnitOfWork Create(UnitOfWorkOptions unitOfWorkOptions = null)
        {
            if (CurrentUnitOfWork != null)
            {
                return CurrentUnitOfWork;
            }
            var unitOfWork = CreateNewUnitOfWork();
            if (unitOfWorkOptions != null)
            {
                unitOfWork.SetOptions(unitOfWorkOptions);
            }

            return unitOfWork;
        }


        private IUnitOfWork CreateNewUnitOfWork()
        {
            using var scope = _serviceScopeFactory.CreateScope();
            var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
            return unitOfWork;
        }
    }
}
