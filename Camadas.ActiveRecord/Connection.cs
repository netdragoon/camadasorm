using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using System.Collections.Generic;
using System.Reflection;

namespace Camadas.ActiveRecord
{
    public class Connection
    {
        public Connection()
        {
        }
        static Connection()
        {

        }
        public static void Load()
        {
            InPlaceConfigurationSource source = new InPlaceConfigurationSource();

            Dictionary<string, string> properties = new Dictionary<string, string>();

            
            properties.Add("connection.driver_class", "NHibernate.Driver.MySqlDataDriver");
            properties.Add("dialect", "NHibernate.Dialect.MySQLDialect");
            properties.Add("connection.provider", "NHibernate.Connection.DriverConnectionProvider");
            properties.Add("connection.connection_string", "Server=localhost;Database=camadas;Uid=root;Pwd=senha;");
            properties.Add("proxyfactory.factory_class", "NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle");

            source.Add(typeof(ActiveRecordBase), properties);

            Assembly asm = Assembly.Load("Camadas.ActiveRecord");

            ActiveRecordStarter.Initialize(asm, source);
        }
    }
}
