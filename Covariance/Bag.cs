using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    public class Bag<T>: IBag<T>
    {
        private List<T> _items = new List<T>();

        public T Get(int id) => _items[id]; 
        public void Add(T item) => _items.Add(item);    
    }
}
