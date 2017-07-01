using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class CurrentTime : IGenerate
    {
        public string Generate()
        {
            return System.DateTime.Now.ToLongTimeString();
        }
    }
}
