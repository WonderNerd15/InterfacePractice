namespace InterfacePractice
{

    public class PhysicalProduct : IShipModel
    {
        public required string Title { get; set; }

        public void Ship(CustomerModel customer)
        {
           Console.WriteLine($"{Title} has been mailed to {customer.Name} at {customer.Address}");
        }
    }


}