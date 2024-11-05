namespace TH_05_11.model
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<Service> Services { get; set; }

        public Invoice(int id, int customerId)
        {
            Id = id;
            CustomerId = customerId;
            Services = new List<Service>();
        }

        public void AddService(Service service)
        {
            Services.Add(service);
        }

        public decimal TotalAmount()
        {
            decimal total = 0;
            foreach (var service in Services)
            {
                total += service.Price;
            }
            return total;
        }
    }

}
