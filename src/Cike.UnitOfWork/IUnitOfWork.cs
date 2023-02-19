using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.UnitOfWork
{
    public interface IUnitOfWork
    {
        public Task SaveChangesAsync();
        public Task CommitAsync();
        public Task RollbackAsync();

        IUnitOfWorkTranscationApi FindDatabaseApi( string key);

        void AddDatabaseApi( string key, IUnitOfWorkTranscationApi api);

        IUnitOfWorkTranscationApi GetOrAddDatabaseApi(string key, Func<IUnitOfWorkTranscationApi> factory);
    }
}
