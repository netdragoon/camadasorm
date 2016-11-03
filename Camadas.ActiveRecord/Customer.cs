using Castle.ActiveRecord;

namespace Camadas.ActiveRecord
{
    [ActiveRecord(Table = "customer")]
    public class Customer: ActiveRecordBase<Customer>
    {
        public Customer()
        {
           
        }
        [PrimaryKey("id", Generator = PrimaryKeyType.Identity)]
        public long Id { get; set; }

        [Property("name", Length = 45, NotNull = true)]
        public string Name { get; set; }

        //[OneToOne(PropertyRef = "Id", MapType = typeof(Address))]
        [OneToOne(ForeignKey = "id", MapType = typeof(Address), Fetch = FetchEnum.Join, Cascade = CascadeEnum.SaveUpdate)]
        public virtual Address Address { get; set; } 


    }
}
