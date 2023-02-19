using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.UnitOfWork
{
    public class UnitOfWorkOptions
    {
        public bool IsTranscation { get; set; }
        public IsolationLevel IsolationLevel { get; set; }
    }
}
