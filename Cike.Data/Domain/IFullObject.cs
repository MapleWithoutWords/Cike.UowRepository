using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.Data.Domain
{
    public interface IFullObject : ICreationObject, IModifierObject, ISoftDelete
    {
    }
    public interface IFullObject<TUserId> : ICreationObject<TUserId>, IModifierObject<TUserId>, ISoftDelete
    {
    }
}
