using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Sequence : IGenerate
    {
        private List<IGenerate> _items;
        private string _separator;

        public Sequence(List<IGenerate> items, string separator = " ")
        {
            _items = items;
            _separator = separator;
        }

        public string Generate()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_items[0].Generate());
            for (int i = 1; i < _items.Count; i++)
            {
                sb.Append(_separator);
                sb.Append(_items[i].Generate());
            }
            return sb.ToString();
        }

        public static Sequence operator +(Sequence a, Sequence b)
        {
            List<IGenerate> newlist = new List<IGenerate>(a._items);
            newlist.Concat(b._items);
            return new Sequence(newlist, a._separator);
        }

        public static Sequence operator +(Sequence a, IGenerate b)
        {
            List<IGenerate> newlist = new List<IGenerate>(a._items);
            newlist.Add(b);
            return new Sequence(newlist, a._separator);
        }
    }
}
