using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Choice : IGenerate, IPluralize
    {
        private List<IGenerate> _items { get; set; }

        public Choice(List<IGenerate> words)
        {
            _items = words;
        }

        public string Generate()
        {
            int i = RandomizerFactory.Random.GetNext(_items.Count);
            string s = _items[i].Generate();
            return s;
        }

        public string Pluralize()
        {
            bool canPluralize = false;
            foreach (IGenerate item in _items)
            {
                if (item is IPluralize)
                {
                    canPluralize = true;
                    break;
                }
            }
            if (!canPluralize)
            {
                throw new NotImplementedException();
            }
            IGenerate chosenItem = null;
            do
            {
                int i = RandomizerFactory.Random.GetNext(_items.Count);
                chosenItem = _items[i];
            } while (!(chosenItem is IPluralize));
            string s = (chosenItem as IPluralize).Pluralize();
            return s;
        }

        public static Choice operator +(Choice a, Choice b)
        {
            List<IGenerate> newlist = new List<IGenerate>(a._items.Concat(b._items));
            return new Choice(newlist);
        }
    }
}
