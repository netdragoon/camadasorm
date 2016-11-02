using FluentNHibernate.Mapping;

namespace Camadas.FluentNhibernate.Map
{
    public class AddressMap: ClassMap<Address>
    {
        public AddressMap()
        {
            Table("address");

            Id(x => x.Id)
                .Column("id")
                .Not.Nullable();

            Map(x => x.Street)
                .Column("street")
                .Not.Nullable()
                .Length(45);

            Map(x => x.Number)
                .Column("number")
                .Not.Nullable()
                .Length(20);

            HasOne(c => c.Customer)
                .ForeignKey("id")
                .Cascade.All();
        }
    }
}
