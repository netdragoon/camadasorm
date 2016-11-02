using System.Collections.Generic;  
namespace Camadas.FluentNhibernate
{
    public class Book
    {
        public Book()
        {
            Authors = new HashSet<Author>();
        }
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
