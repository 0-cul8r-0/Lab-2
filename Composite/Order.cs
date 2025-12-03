using System.Collections.Generic;

namespace Composite
{
    public class Order
    {
        private string _orderNumber;
        private List<IComponent> _items;

        public Order(string orderNumber)
        {
            _orderNumber = orderNumber;
            _items = new List<IComponent>();
        }
        public void AddItem(IComponent item)
        {
            _items.Add(item);
        }
        public void RemoveItem(IComponent item)
        {
            _items.Remove(item);
        }
        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var item in _items)
            {
                totalPrice += item.GetPrice();
            }

            return totalPrice;
        }
        public string GetOrderNumber()
        {
            return _orderNumber;
        }
        public List<IComponent> GetItems()
        {
            return new List<IComponent>(_items);
        }
    }
}

