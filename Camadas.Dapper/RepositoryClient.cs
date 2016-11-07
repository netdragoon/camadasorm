using Dapper;
using System.Linq;
using System.Data;

namespace Camadas.DapperSqlServer
{
    public abstract class RepositoryClientContract : Repository<Client>, IRepository<Client>
    {
        public RepositoryClientContract(IDbConnection connection) : base(connection)
        {   
        }

        public abstract Client FindWithPhone<Tkey>(Tkey id);
    }
    public class RepositoryClient : RepositoryClientContract
    {
        public RepositoryClient(IDbConnection connection) : base(connection)
        {

        }   
        public override Client FindWithPhone<Tkey>(Tkey id)
        {
            Client cl = Find(id);
            cl.Phones = _connection.Query<Phone>("SELECT * FROM Phone WHERE ClientId=@ClientId", new { ClientId = cl.Id }).ToList();
            return cl;
        }  
    }
}
