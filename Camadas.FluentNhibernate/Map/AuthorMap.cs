using FluentNHibernate.Mapping;
namespace Camadas.FluentNhibernate.Map
{
    public class AuthorMap: ClassMap<Author>
    {
        public AuthorMap()
        {
            Table("author");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.Identity()
                .Not.Nullable();

            Map(x => x.Name)
                .Column("name")
                .Not.Nullable()
                .Length(45);

            HasManyToMany(c => c.Books)
                .ParentKeyColumn("authorid")
                .ChildKeyColumn("bookid")
                .Table("authorbook")                
                .LazyLoad();             
        }
    }
}
