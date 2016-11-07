using Camadas.ActiveRecord;
using Camadas.DapperSqlServer;
using System;

namespace Camadas.Test.CslApp
{
    class Program
    {
        static void Main(string[] args)
        {    
            TestDapper();
            System.Console.WriteLine("Pressione <Enter>");
            System.Console.ReadKey();

        } 
        static void TestDapper()
        {
            RepositoryClient repClient = new RepositoryClient(DapperSqlServer.Connection.Instance);
            RepositoryPhone repPhone = new RepositoryPhone(DapperSqlServer.Connection.Instance);

            //var clients = repClient.All();
            //var phones = repPhone.All();
            ////Client cl = new Client();
            ////cl.Name = "Cliente 2";
            ////cl.Created = DateTime.Now.AddDays(-1);
            ////cl.Active = true;

            var result = repClient.FindWithPhone(1);

            
            //Phone p1 = new Phone();
            //p1.ClientId = 1;
            //p1.Ddd = "023";
            //p1.Number = "9988-9890";            
            //Phone p2 = new Phone();
            //p2.ClientId = 1;
            //p2.Ddd = "022";
            //p2.Number = "9977-6676";
            //rep.Insert(p1);
            //rep.Insert(p2);
        }
        static void TestActiveRecords()
        {
            try
            {      //TestFluentNhibernate();
                ActiveRecord.Connection.Load();
                long id = 3;
                Customer cu = Customer.Find(id);
                //cu.Name = "João Paulo";
                //cu.Address = new Address()
                //{
                //    Id = cu.Id,
                //    Number = "456",
                //    Street = "Jovem Pan, Site Lameda"
                //};
                //cu.UpdateAndFlush();

            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        static void TestFluentNhibernate()
        {
            //using (IConnection conn = new Connection())
            //{
            //    //User usr = new User()
            //    //{
            //    //    Name = "test",
            //    //    Email = "test1@test.com",
            //    //    Password = "bade$53",
            //    //    Active = true
            //    //};

            //    //usr.Phones.Add(new Phone
            //    //{
            //    //   User = usr,
            //    //   Ddd = "001",
            //    //   Number = "9898-9696"
            //    //});

            //    //conn.Add(usr);           
            //    //long id = 1;
            //    //User usr = conn.Find<User>(id);

            //    //Author au = new Author
            //    //{
            //    //    Name = "José de Oliveira"
            //    //};
            //    //Book bo1 = new Book
            //    //{
            //    //    Title = "A Pantera Corderosa"
            //    //};
            //    //Book bo2 = new Book
            //    //{
            //    //    Title = "O Esquadrão Noturno"
            //    //};

            //    //conn.Add(bo1);
            //    //conn.Add(bo2);

            //    //au.Books.Add(bo1);
            //    //au.Books.Add(bo2);

            //    //conn.Add(au);

            //    //int id = 1;
            //    //Author aut = conn.Find<Author>(id);

            //    //Customer cust = new Customer();
            //    //cust.Name = "Limeira";
            //    //cust.Address = new Address();
            //    //cust.Address.Number = "136";
            //    //cust.Address.Street = "Street North";

            //    //conn.Add(cust);
            //    long id = 1;
            //    Customer cust = conn.Find<Customer>(id);
            //    Address addr = conn.Find<Address>(id);

            //}
        }
    }
}
