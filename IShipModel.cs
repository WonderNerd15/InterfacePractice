namespace InterfacePractice{
    public interface IShipModel
    {
         string Title { get; set; }
         
         void Ship(CustomerModel customer);
    }
}