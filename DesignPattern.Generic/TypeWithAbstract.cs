using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Generic
{
    public class TypeWithAbstract
    {
        private List<Item> _item;
        public TypeWithAbstract()
        {
            _item = new List<Item>();
            _item.Add(new Item<string>() { Name = "12" });
            _item.Add(new Item<int>() { Name = 12 });

            foreach (var it in _item)
            {
                Console.Write(it.GetType().GetProperty("Name").GetValue(it).GetType().Name);
                Console.Write(Environment.NewLine);
            }
           
        }

    }
    public class Item<T> : Item
    {
        public T Name { get; set; }
    }

    public class Item
    {

    }

}
