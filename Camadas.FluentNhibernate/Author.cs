using System.Collections.Generic; 
namespace Camadas.FluentNhibernate
{
    public class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
