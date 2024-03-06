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
            _pizza = pizza;
            _customer = customer;
            _tax = 0.25; // Based on 25% moms/tax in Denmark. 
            _deliveryFee = 40; 
              
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
            double pizzaAndToppingPrice = Pizza.Price + Pizza.Topping.Price;
            double totalPrice = pizzaAndToppingPrice + (pizzaAndToppingPrice * Tax) + DeliveryFee;
            return totalPrice;

        }
        #endregion

        public override string ToString()
        {
            return $"{Customer.ToString()}, {Pizza.ToString()}, Total Price: {CalculateTotalPrice()} kr";
        }
    }
}
