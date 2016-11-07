namespace Camadas.DapperSqlServer
{
    public abstract class RepositoryPhoneContract : Connection<Phone>, IConnection<Phone>
    {
    }
    public class RepositoryPhone : RepositoryPhoneContract
    {
    }
}
