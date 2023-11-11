using System.Collections.Generic;
using System.ComponentModel;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerModel customer = GetCustomerModel();
            
            List<IShipModel> cart = new List<IShipModel>();
            cart.Add(new PhysicalProduct {Title = "Hard Drive"});
            cart.Add(new DigitalProduct {Title = "Video Game"});

            foreach (var product in cart)
            {
                product.Ship(customer);
            }
        }

         static CustomerModel GetCustomerModel()
        {
            CustomerModel customer = new CustomerModel{Name = "Gaby", 
                                                       Address = "3539 SW 5th St",
                                                       Email = "GabyBHolland@gmail.com"};

            return customer;
        }
    }

}