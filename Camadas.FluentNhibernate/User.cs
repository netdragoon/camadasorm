using System.Collections.Generic;   
namespace Camadas.FluentNhibernate
{
    public class User
    {
        public User()
        {
            Phones = new HashSet<Phone>();
        }
        public virtual long Id { get; set; }                       
        public virtual string Name { get; set; }                    
        public virtual string Email { get; set; }           
        public virtual string Password { get; set; }        
        public virtual bool Active { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
    }
}
