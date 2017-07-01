using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    //This whole file is a hack to make the generator testable. I would like to use DI. DI has issues with 
    //Azure functions. I have seen the service locatior pattern recommeded as a workaround. This class is a kind of
    //mini service locator for just one interface. In the normal course of events, the first time we ask for a
    //random number generator, we'll make one and hand it back to the user.
    //
    //In a unit test, before we call Generate(), we will sneak a NON-RANDOM randomizer into the Random property
    //so that we can get consistent results from a unit test. I don't really like this but it will make the code
    //testable.
    //
    public static class RandomizerFactory
    {
        static IRandomize _rand = null;
        public static IRandomize Random
        {
            get
            {
                if (_rand == null)
                {
                    _rand = new Randomizer();
                }
                return _rand;
            }
            set
            {
                _rand = value;
            }
        }
    }
}
