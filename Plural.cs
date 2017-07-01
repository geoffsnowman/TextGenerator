using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Plural : IGenerate
    {
        private IPluralize _item;
        public Plural(IPluralize item)
        {
            _item = item;
        }

        public string Generate()
        {
            return _item.Pluralize();
        }
    }
}
