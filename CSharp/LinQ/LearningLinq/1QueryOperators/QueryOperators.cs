using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningLinq.QueryOperators
{
    class QueryOperators
    {
        public QueryOperators()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var result = numbers.Where(a=> { return a > 3; });
            IEnumerable
        }
    }
}
