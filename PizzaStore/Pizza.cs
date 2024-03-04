namespace PizzaStore
{
    public class Pizza
    {
        #region Instance field
        private string _name;
        private int _price;
        private Topping _topping;
     

        #endregion

        #region constroctor 
        public Pizza(string name, int price, Topping topping) 
        {
            _name = name;
            _price = price;
            _topping = topping;
            
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

        public Topping Topping
        {
            get { return _topping; }
            private set { _topping = value; }
        }

        #endregion

        public override string ToString()
        {
            return $"Pizza: {Name}, Price: {Price} kr., Extra topping: {Topping.Name}, Price: {Topping.Price} kr.";
        }
    }
}
