using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    class ThreeWaysToForeachListObject
    {
        public ThreeWaysToForeachListObject()
        {
            IList<int> list = new List<int>() { 100,200,300};

            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            IEnumerator<int> ienumerator = list.GetEnumerator();
            while (ienumerator.MoveNext())
            {
                Console.WriteLine(ienumerator.Current);
            }
        }
    }
}
