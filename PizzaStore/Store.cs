using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Store
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
            //Creating three different toppings with associated prices.
            Topping cheese = new Topping("cheese", 5);
            Topping mushrooms = new Topping("mushrooms", 10);
            Topping anchovies = new Topping("anchovies", 15);

            //Creating three different pizza´s each with an extra topping. 
            Pizza pizza1 = new Pizza("Vegetarian", 80, cheese);
            Pizza pizza2 = new Pizza("Gorgonzola", 85, mushrooms);
            Pizza pizza3 = new Pizza("Contadina", 75, anchovies);

            //Creating three different customers each with a given name.
            Customer customer1 = new Customer("David Larsen");
            Customer customer2 = new Customer("John Larsen");
            Customer customer3 = new Customer("Tom Larsen");

            //Creating three different orders.
            Order order1 = new Order(pizza1, customer1);
            Order order2 = new Order(pizza2, customer2);
            Order order3 = new Order(pizza3, customer3);
            
            //The three different orders are printed out on the console using the ToString method.
            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);
                
             
        }
    }
}
