using Camadas.ActiveRecord;
using Castle.ActiveRecord;

namespace Camadas.ActiveRecord
{
    [ActiveRecord(Table = "address")]
    public class Address : ActiveRecordBase<Address>
    {

        public Address()
        {
           
        }

        [PrimaryKey(Column = "id", Generator = PrimaryKeyType.Assigned)]
        public long Id { get; set; }

        [Property("number", Length = 20, NotNull = true)]
        public string Number { get; set; }

        [Property("street", Length = 45, NotNull = true)]
        public string Street { get; set; }

        [OneToOne(ForeignKey = "id", MapType = typeof(Customer), Fetch = FetchEnum.Join, Cascade = CascadeEnum.SaveUpdate)]
        public virtual Customer Customer { get; set; }
    }
}
