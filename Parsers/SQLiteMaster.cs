using SQLite;
using System;


namespace Parsers
{
    [Table("sqlite_master")]
    class SqliteMaster
    {
        public string Name { get; set; }
    }
}
