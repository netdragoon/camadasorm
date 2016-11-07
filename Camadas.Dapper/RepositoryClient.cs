using Dapper;
using System.Linq;

namespace Camadas.DapperSqlServer
{
    public abstract class RepositoryClientContract : Connection<Client>, IConnection<Client>
    {
        public abstract Client FindWithPhone<Tkey>(Tkey id);
    }
    public class RepositoryClient : RepositoryClientContract
    {
        public override Client FindWithPhone<Tkey>(Tkey id)
        {
            Client cl = Find(id);
            cl.Phones = Connect.Query<Phone>("SELECT * FROM Phone WHERE ClientId=@ClientId", new { ClientId = cl.Id }).ToList();
            return cl;
        }  
    }
}
