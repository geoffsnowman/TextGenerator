using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Word : IGenerate
    {
        private string _text;

        public Word (string text)
        {
            _text = text;
        }

        public string Generate()
        {
            return _text;
        }
    }
}
