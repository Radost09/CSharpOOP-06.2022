using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        Random random = new Random();

        public string RandomString()
        {
            int elementIndex = random.Next(0, base.Count);
            string element = base[elementIndex];
            base.RemoveAt(elementIndex);
            return element;
        }
    }
}
