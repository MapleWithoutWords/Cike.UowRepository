using Microsoft.Extensions.Options;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected IDictionary<string, IUnitOfWorkTranscationApi> _uowTranscationApis;
        protected UnitOfWorkOptions _unitOfWorkOptions;

        public UnitOfWork(IOptions<UnitOfWorkOptions> options)
        {
            _uowTranscationApis = new ConcurrentDictionary<string, IUnitOfWorkTranscationApi>();
            _unitOfWorkOptions = options.Value;
        }

        public void AddDatabaseApi(string key, IUnitOfWorkTranscationApi api)
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public IUnitOfWorkTranscationApi FindDatabaseApi(string key)
        {
            throw new NotImplementedException();
        }

        public IUnitOfWorkTranscationApi GetOrAddDatabaseApi(string key, Func<IUnitOfWorkTranscationApi> factory)
        {
            throw new NotImplementedException();
        }

        public Task RollbackAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
