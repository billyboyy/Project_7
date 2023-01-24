using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Items
    {
        public Items(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        
        public Items AddComponent(ItemComponent component)
        {
            _components.Add(component);
            return this;
        }

        public T GetComponent<T>() 
        {
            return (T)_components.OfType<T>().FirstOrDefault();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            _components.ForEach(c => sb.AppendLine(c.ToString()));
            return sb.ToString();
        }
        private List<ItemComponent> _components = new List<ItemComponent>();
    }
}
