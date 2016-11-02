using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camadas.FluentNhibernate
{
    public class Phone
    {
        public virtual int Id { get; set; }        
        public virtual User User { get; set; }
        public virtual string Ddd { get; set; }
        public virtual string Number { get; set; }
    }
}
