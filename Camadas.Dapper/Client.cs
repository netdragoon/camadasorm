using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;

namespace Camadas.DapperSqlServer
{
    [Table("Client")]
    public class Client
    {
        public Client()
        {
            Phones = new HashSet<Phone>();
        }

        [Key()]
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }

        public ICollection<Phone> Phones { get; set; }
    }
}
