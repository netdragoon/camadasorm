using Dapper.Contrib.Extensions;

namespace Camadas.DapperSqlServer
{
    [Table("Phone")]
    public class Phone
    {
        [Key()]        
        public long Id { get; set; }
        public long ClientId { get; set; }
        public Client Client { get; set; }
        public string Ddd { get; set; }
        public string Number { get; set; }
    }
}
