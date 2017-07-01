using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaikuGen
{
    public class Output
    {
        public List<Word> Words { get; set; }

        public Output()
        {
            Words = new List<IGenerate>();
        }

        public void Add(Word w)
        {
            Words.Add(w);
        }

        public void Clear()
        {
            Words.Clear();
        }

        public int Count
        {
            get { return Words.Count;  }
        }

        public int Syllables
        {
            get
            {
                int sylls = 0;
                foreach (Word w in Words)
                {
                    sylls += w.Sylls;
                }
                return sylls;
            }
        }

        public override string ToString()
        {
            StringBuilder line = new StringBuilder();
            line.Append(Words[0].FirstUpper);
            for (int i = 1; i < Words.Count; i++)
            {
                line.Append(" ");
                line.Append(Words[i].Text);
            }
            return line.ToString();
        }

        public Word this[int i]
        {
            get { return Words[i]; }
            set { Words[i] = value; }
        }
    }
}
