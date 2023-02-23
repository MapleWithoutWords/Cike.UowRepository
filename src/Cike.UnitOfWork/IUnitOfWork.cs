using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        /// <summary>
        /// 重新初始化配置
        /// </summary>
        /// <param name="options"></param>
        void SetOptions(UnitOfWorkOptions options);
        UnitOfWorkOptions Options { get; }

        public Task SaveChangesAsync();
        public Task CommitAsync();
        public Task RollbackAsync();

        IUnitOfWorkTranscationApi FindUowTranscationApi( string key);

        void AddUowTranscationApi( string key, IUnitOfWorkTranscationApi api);

        IUnitOfWorkTranscationApi GetOrAddUowTranscationApi(string key, Func<IUnitOfWorkTranscationApi> factory);
    }
}
