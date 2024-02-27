using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Order
    {

        #region Instance field
       private double _tax;
       private int _deliveryFee;
       private Customer _customer;
       private Pizza _pizza;

        #endregion

        #region constroctor 
        public Order(Pizza pizza, Customer customer) 
        {
            Pizza = pizza;
            Customer = customer;
            Tax = 0.25;
            DeliveryFee = 40;
              
        }
        #endregion

        #region properties 


        public Pizza Pizza
        {
            get { return _pizza; }
            private set { _pizza = value; }
        }

        public Customer Customer
        {
            get { return _customer; }
            private set { _customer = value; }
        }


        public double Tax 
        { 
            get { return _tax; } 
            private set { _tax = value; } 
        }
        
        public int DeliveryFee
        {
            get { return _deliveryFee; }
            private set { _deliveryFee = value; }
        }

        public double CalculateTotalPrice()
        {
            return Pizza.Price + (Pizza.Price * Tax) + DeliveryFee;
        
        }
        #endregion

        public override string ToString()
        {
            return $"{Customer.ToString()}, {Pizza.ToString()}, Total Price: {CalculateTotalPrice()} kr.";
        }
    }
}
