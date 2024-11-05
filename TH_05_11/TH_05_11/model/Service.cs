
namespace TH_05_11.model
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Service(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }

}
