namespace InterfacePractice
{

    public class DigitalProduct : IShipModel
    {
        public required string Title { get; set; }

        public void Ship(CustomerModel customer)
        {
           Console.WriteLine($"{Title} has been emailed to {customer.Name} at {customer.Email}");
        }
    }


}