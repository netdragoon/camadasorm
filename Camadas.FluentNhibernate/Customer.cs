namespace Camadas.FluentNhibernate
{
    public class Customer
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }   
        public virtual Address Address { get; set; }
    }
}
