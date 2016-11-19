using PetaPoco;
namespace Camadas.PetaPoco
{
    public class Connection
    {
        protected IDatabase database;        
        public IDatabase Database()
        {
            return database;
        }
        private const string StrConn = "Server=.\\SqlExpress;Database=Db;User Id=sa;Password=senha;MultipleActiveResultSets=true;";       
        public Connection()
        {
            database = new Database(StrConn, nameof(System.Data.SqlClient));
        }

        public static Connection Create()
        {
            return new Connection();
        }
    }
}
