using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemGenericDelegate
{
    public class MyGeneric<MyGene>
    {
        private MyGene GetBiggerOne(MyGene x,MyGene y,bool want)
        {
            if (want)
            {
                return x;
            }
            return default(MyGene);
        }
    }
}
