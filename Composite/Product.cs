namespace Composite
{
    public class Product : IComponent
    {
        private string _name;
        private decimal _price;

        public Product(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public string GetName()
        {
            return _name;
        }
    }
}

