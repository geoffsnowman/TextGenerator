using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Noun : Word, IPluralize
    {
        private string _plural;

        public Noun(string text, string plural = "") : base(text)
        {
            if (plural == "")
            {
                _plural = text + "s";
            }
            else
            {
                _plural = plural;
            }
        }

        public string Pluralize()
        {
            return _plural;
        }

    }
}
