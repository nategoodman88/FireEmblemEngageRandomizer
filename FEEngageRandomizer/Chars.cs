using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEEngageRandomizer
{
    //Creates a dictionary and maps specific strings to those for use in other classes
    public class Chars : Dictionary<string, string>
    {

        public new void Add(string Character, string Class)
        {
            base.Add(Character, Class);
        }

        public new string this[string Character]
        {
            get { return base[Character]; }
            set { base[Character] = value; }
        }

    }
}
