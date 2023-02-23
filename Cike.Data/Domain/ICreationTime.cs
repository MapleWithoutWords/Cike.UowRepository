using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.Data.Domain
{
    public interface ICreationTime
    {
        /// <summary>
        /// Creation time.
        /// </summary>
        DateTime CreationTime { get; }
    }
}
