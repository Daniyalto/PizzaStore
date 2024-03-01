using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {
        #region Instance field

        private string _name;

        #endregion

        #region constroctor 
        public Customer(string name) 
        {
            _name = name;
        }

        #endregion

        #region properties 

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        #endregion

        public override string ToString()
        {
            return $"Customer: {Name}";
        }
    }
}
