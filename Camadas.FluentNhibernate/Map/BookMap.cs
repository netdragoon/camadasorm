using FluentNHibernate.Mapping;
namespace Camadas.FluentNhibernate.Map
{
    public class BookMap  : ClassMap<Book>
    {
        public BookMap()
        {
            Table("book");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.Identity()
                .Not.Nullable();

            Map(x => x.Title)
                .Column("title")
                .Not.Nullable()
                .Length(45);

            HasManyToMany(c => c.Authors)
                .ParentKeyColumn("bookid")
                .ChildKeyColumn("authorid")
                .Table("authorbook")                
                .LazyLoad();
        }
    }
}
