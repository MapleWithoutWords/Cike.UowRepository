using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.Data.Domain
{
    public interface IModifierObject : IModificationTime, IModifierUserId
    {
    }
    public interface IModifierObject<TUserId> : IModificationTime, IModifierUserId<TUserId>
    {
    }
}
