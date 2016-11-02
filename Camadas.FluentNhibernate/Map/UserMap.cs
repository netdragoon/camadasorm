using FluentNHibernate.Mapping;
namespace Camadas.FluentNhibernate.Map
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("user");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.Identity()
                .Not.Nullable();

            Map(x => x.Name)
                .Column("name")
                .Length(45)
                .Not.Nullable();

            Map(x => x.Email)
                .Column("email")
                .Length(100)
                .Not.Nullable();

            Map(x => x.Password)
                .Column("password")
                .Length(60)
                .Not.Nullable();

            Map(x => x.Active)
                .Column("active")
                .Not.Nullable();

            HasMany(c => c.Phones)
                .KeyColumn("userid")                
                .LazyLoad()
                .Cascade.SaveUpdate();           
        }
    }
}
