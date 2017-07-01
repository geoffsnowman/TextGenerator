using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Capitalize : IGenerate
    {
        private IGenerate _item;

        public Capitalize(IGenerate item)
        {
            _item = item;
        }

        public string Generate()
        {
            string lower = _item.Generate();
            string upper = Char.ToUpperInvariant(lower[0]) + lower.Substring(1);
            return upper;
        }
    }
}

