namespace PizzaStore
{
    public class Pizza
    {
        #region Instance field
        string _name;
        int _price;

        #endregion

        #region constroctor 
        public Pizza(string name, int price) 
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

        public override string ToString() 
        {
            return $"Pizza: {Name}, Price: {Price} kr.";
        }
    }
}
