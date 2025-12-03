using System.Collections.Generic;

namespace Composite
{
    public class Box : IComponent
    {
        private string _name;
        private decimal _boxPrice;
        private List<IComponent> _components;

        public Box(string name, decimal boxPrice = 0)
        {
            _name = name;
            _boxPrice = boxPrice;
            _components = new List<IComponent>();
        }
        public void Add(IComponent component)
        {
            _components.Add(component);
        }
        public void Remove(IComponent component)
        {
            _components.Remove(component);
        }
        public List<IComponent> GetComponents()
        {
            return new List<IComponent>(_components);
        }

        public decimal GetPrice()
        {
            decimal totalPrice = _boxPrice;
            foreach (var component in _components)
            {
                totalPrice += component.GetPrice();
            }

            return totalPrice;
        }

        public string GetName()
        {
            return _name;
        }
    }
}

