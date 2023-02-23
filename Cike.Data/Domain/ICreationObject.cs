using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.Data.Domain
{
    public interface ICreationObject : ICreationTime, ICreatorUserId
    {
    }
    public interface ICreationObject<TUserId> : ICreationTime, ICreatorUserId<TUserId>
    {
    }
}
