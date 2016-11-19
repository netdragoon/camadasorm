using Passive;
using System;
namespace Camadas.Passive
{              
    public class Client  : DynamicModel
    {   
        public Client(string connectionStringName = "ConnTest", string tableName = "Client", string primaryKeyField = "Id") 
            : base(connectionStringName, tableName, primaryKeyField)
        {               
        }   
        public long Id { get; set; }        
        public string Name { get; set; }        
        public DateTime Created { get; set; }        
        public bool Active { get; set; } 
    }
}
