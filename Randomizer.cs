using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Randomizer : IRandomize
    {
        static Random rand = new Random();

        public int GetNext(int max)
        {
            return rand.Next(max);
        }
    }
}
