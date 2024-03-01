using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Store
    {
        #region Instance field


        #endregion

        #region constroctor 

        public Store() 
        { 

        }

        #endregion


        #region properties 

        #endregion


        public void Start()
        {

            Topping topping1 = new Topping("cheese", 5);
            Topping topping2 = new Topping("mushrooms", 10);
            Topping topping3 = new Topping("anchovies", 15);

            Pizza pizza1 = new Pizza("Vegetarian", 80);
            Pizza pizza2 = new Pizza("Gorgonzola", 85);
            Pizza pizza3 = new Pizza("Contadina", 75);

            Customer customer1 = new Customer("Lars Larsen");
            Customer customer2 = new Customer("Kim Larsen");
            Customer customer3 = new Customer("Tom Larsen");

            Order order1 = new Order(pizza1, topping1, customer1);
            Order order2 = new Order(pizza2, topping2, customer2);
            Order order3 = new Order(pizza3, topping3, customer3);
            

            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);
                
             
        }
    }
}
