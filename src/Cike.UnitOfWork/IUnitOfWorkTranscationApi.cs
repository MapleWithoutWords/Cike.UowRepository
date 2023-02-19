using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.UnitOfWork
{
    public interface IUnitOfWorkTranscationApi
    {
        public Task SaveChangesAsync(CancellationToken cancellationToken = default);
        public Task CommitAsync();
        public Task RollbackAsync(CancellationToken cancellationToken = default);
    }
}
