using Camadas.FluentNhibernate;
namespace Camadas.Test.CslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IConnection conn = new Connection())
            {
                //User usr = new User()
                //{
                //    Name = "test",
                //    Email = "test1@test.com",
                //    Password = "bade$53",
                //    Active = true
                //};

                //usr.Phones.Add(new Phone
                //{
                //   User = usr,
                //   Ddd = "001",
                //   Number = "9898-9696"
                //});

                //conn.Add(usr);           
                //long id = 1;
                //User usr = conn.Find<User>(id);

                //Author au = new Author
                //{
                //    Name = "José de Oliveira"
                //};
                //Book bo1 = new Book
                //{
                //    Title = "A Pantera Corderosa"
                //};
                //Book bo2 = new Book
                //{
                //    Title = "O Esquadrão Noturno"
                //};

                //conn.Add(bo1);
                //conn.Add(bo2);

                //au.Books.Add(bo1);
                //au.Books.Add(bo2);

                //conn.Add(au);

                int id = 1;
                Author aut = conn.Find<Author>(id);

            }
        }
    }
}
