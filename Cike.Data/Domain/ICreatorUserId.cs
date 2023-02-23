using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.Data.Domain
{
    public interface ICreatorUserId<TUserId>
    {
        TUserId CreatorUserId { get; }
    }
    public interface ICreatorUserId : ICreatorUserId<Guid>
    {
    }
}
