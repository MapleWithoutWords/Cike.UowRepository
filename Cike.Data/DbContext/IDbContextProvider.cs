using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.Data.DbContext
{
    public interface IDbContextProvider<TDbContext> where TDbContext : class
    {
        Task<TDbContext> GetDbContextAsync();
    }
}
