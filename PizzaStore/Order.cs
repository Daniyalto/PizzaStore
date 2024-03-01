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
        private Topping _topping;

        #endregion

        #region constroctor 
        public Order(Pizza pizza, Topping topping, Customer customer) 
        {
            _pizza = pizza;
            _customer = customer;
            _topping = topping;
            _tax = 0.25;
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

        public Topping Topping
        {
            get { return _topping; }
            private set { _topping = value; }
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
            return Pizza.Price + Topping.Price + ((Pizza.Price + Topping.Price) * Tax) + DeliveryFee;
        
        }
        #endregion

        public override string ToString()
        {
            return $"{Customer.ToString()}, {Pizza.ToString()}, {Topping.ToString()} Total Price: {CalculateTotalPrice()} kr.";
        }
    }
}
