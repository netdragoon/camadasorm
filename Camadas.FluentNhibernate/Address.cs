using System;
namespace Camadas.FluentNhibernate
{
    public class Address
    {
        public virtual long Id { get; set; }
        public virtual string Number { get; set; }
        public virtual string Street { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
