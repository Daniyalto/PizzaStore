using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Topping
    {
        #region Instance field

        private string _name;
        private int _price;

        #endregion

        #region constroctor 
        public Topping(string name, int price)
        {
           _name = name;
           _price = price;
        }

        #endregion

        #region properties 

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            private set { _price = value; }
        }

        

        #endregion

      
    }



}

