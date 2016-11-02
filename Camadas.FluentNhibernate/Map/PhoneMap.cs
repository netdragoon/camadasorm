using FluentNHibernate.Mapping; 
namespace Camadas.FluentNhibernate.Map
{
    public class PhoneMap: ClassMap<Phone>
    {
        public PhoneMap()
        {
            Table("phone");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.Identity()
                .Not.Nullable();

            Map(x => x.Ddd)
                .Column("ddd")
                .Length(3)
                .Not.Nullable();

            Map(x => x.Number)
                .Column("number")
                .Length(14)
                .Not.Nullable();

            References(c => c.User)
                .Column("userid")
                .Cascade.SaveUpdate();                
        }
    }
}
