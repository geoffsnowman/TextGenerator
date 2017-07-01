using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Repeat : IGenerate
    {
        private int _min;
        private int _max;
        private IGenerate _item;
        private string _separator;

        public Repeat(int min, int max, IGenerate item, string separator = " ")
        {
            _min = min;
            _max = max;
            _item = item;
            _separator = separator;
        }

        public string Generate()
        {
            int repeat = _min + RandomizerFactory.Random.GetNext(_max - _min);
            StringBuilder sb = new StringBuilder();
            if (repeat > 0)
            {
                sb.Append(_item.Generate());
                for (int i = 1; i < repeat; i++)
                {
                    sb.Append(_separator);
                    sb.Append(_item.Generate());
                }
            }
            return sb.ToString();
        }
    
    }
}
