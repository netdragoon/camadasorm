using FluentNHibernate.Mapping;

namespace Camadas.FluentNhibernate.Map
{
    public class CustomerMap: ClassMap<Customer>
    {
        public CustomerMap()
        {
            Table("customer");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.Identity()
                .Not.Nullable();

            Map(x => x.Name)
                .Column("name")
                .Not.Nullable()
                .Length(45);   

            HasOne(c => c.Address)
                .ForeignKey("id")                
                .Cascade.All();
                            
        }
    }
}
