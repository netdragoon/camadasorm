using System.Data;

namespace Camadas.DapperSqlServer
{
    public abstract class RepositoryPhoneContract : Repository<Phone>, IRepository<Phone>
    {
        public RepositoryPhoneContract(IDbConnection connection) : base(connection)
        {
        }
    }
    public class RepositoryPhone : RepositoryPhoneContract
    {
        public RepositoryPhone(IDbConnection connection) : base(connection)
        {
        }
    }
}
