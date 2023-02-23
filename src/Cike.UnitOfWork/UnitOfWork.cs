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

        public UnitOfWork(IOptions<UnitOfWorkOptions> options)
        {
            _uowTranscationApis = new ConcurrentDictionary<string, IUnitOfWorkTranscationApi>();
            Options = options.Value;
        }

        public UnitOfWorkOptions Options { get; set; }
        public void SetOptions(UnitOfWorkOptions options)
        {
            if (options == null)
            {
                return;
            }
            Options?.Normalize(options);
        }

        public void AddUowTranscationApi(string key, IUnitOfWorkTranscationApi api)
        {
            if (FindUowTranscationApi(key) != null)
            {
                throw new ArgumentException($"There are key = '{key}' IUnitOfWorkTranscationApi object.");
            }
            _uowTranscationApis[key] = api;
        }

        public async Task CommitAsync()
        {
            await SaveChangesAsync();

            //publish event

            foreach (var item in _uowTranscationApis)
            {
                await item.Value.CommitAsync();
            }
        }

        public void Dispose()
        {
            foreach (var item in _uowTranscationApis)
            {
                item.Value?.Dispose();
            }
        }

        public IUnitOfWorkTranscationApi FindUowTranscationApi(string key)
        {
            if (_uowTranscationApis.ContainsKey(key))
            {
                return _uowTranscationApis[key];
            }
            return null;
        }

        public IUnitOfWorkTranscationApi GetOrAddUowTranscationApi(string key, Func<IUnitOfWorkTranscationApi> factory)
        {
            var result = FindUowTranscationApi(key);
            if (result == null)
            {
                result = factory.Invoke();
                AddUowTranscationApi(key, result);
            }
            return result;
        }


        public async Task RollbackAsync()
        {
            foreach (var item in _uowTranscationApis)
            {
                await item.Value.RollbackAsync();
            }
        }

        public async Task SaveChangesAsync()
        {
            foreach (var item in _uowTranscationApis)
            {
                await item.Value.SaveChangesAsync();
            }
        }
    }
}
