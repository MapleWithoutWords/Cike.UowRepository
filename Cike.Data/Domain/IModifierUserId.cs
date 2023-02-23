using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.Data.Domain
{
    public interface IModifierUserId<TUserId>
    {
        TUserId ModifierUserId { get; set; }
    }
    public interface IModifierUserId : IModifierUserId<Guid>
    {
    }
}
