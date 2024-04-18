
namespace WebApplication1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        internal static void Add(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}