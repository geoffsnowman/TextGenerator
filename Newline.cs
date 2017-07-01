using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Newline : IGenerate
    {
        public string Generate()
        {
            return "\r\n";
        }
    }
}
