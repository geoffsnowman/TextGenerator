using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class RepeatExactly : IGenerate
    {
        private int _count;
        private IGenerate _item;
        private string _separator;

        public RepeatExactly(int count, int max, IGenerate item, string separator = " ")
        {
            _count = count;
            _item = item;
            _separator = separator;
        }

        public string Generate()
        {
            StringBuilder sb = new StringBuilder();
            if (_count > 0)
            {
                sb.Append(_item.Generate());
                for (int i = 1; i < _count; i++)
                {
                    sb.Append(_separator);
                    sb.Append(_item.Generate());
                }
            }
            return sb.ToString();
        }
    
    }
}
