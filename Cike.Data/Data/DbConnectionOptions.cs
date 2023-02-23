using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.Data.Data
{
    /// <summary>
    /// database connection string setting
    /// </summary>
    public class DbConnectionOptions
    {
        public DbConnectionStrings DbConnectionStrings { get; set; }
    }

    public class DbConnectionStrings : Dictionary<string, string>
    {
        private const string DefaultConnectionStringName = "Default";

        public string DefaultConnectionString { get => this.GetOrDefault(DefaultConnectionStringName); set => this[DefaultConnectionStringName] = value; }
    }
}
