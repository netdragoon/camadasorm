using PetaPoco;
using System; 
namespace Camadas.PetaPoco
{

    [TableName("Client")]
    [PrimaryKey("Id")]
    [ExplicitColumns]
    public class Client
    {
        public Client()
        {                     
        }

        
        [Column("Id")]
        public long Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Created")]
        public DateTime Created { get; set; }

        [Column("Active")]
        public bool Active { get; set; }    
        //public ICollection<Phone> Phones { get; set; }
    }
}
