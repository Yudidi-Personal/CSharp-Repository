using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithm
{
    public class AlgorithmOne
    {
        public AlgorithmOne()
        {
            Console.WriteLine("百鸡问题：100元钱买100只鸡，如何买？已知条件：鸡母每只3元，鸡公每只1元，鸡仔每3只1元。");
            int slnCount = 0;
            for (int i = 0; i <= (int)(100 / 3); i++)
            {
                for (int j = 0; j <= (int)(100); j++)
                {
                    for (int k = 0; k <= (int)(100 * 3); k = k + 3)
                    {
                        if ((i + j + k == 100) && ((i * 3 + j * 1 + k / 3) == 100))
                        {
                            Console.WriteLine(string.Format("{0}: Hen:{1} Cock:{2} Chickens:{3}", ++slnCount, i, j, k));
                        }
                    }
                }
            }
            Console.WriteLine(string.Format("Solution Count:{0}", slnCount));
        }

        public AlgorithmOne(string three)
        {
            int slnCount = 0;
            for (int i = 0; i <= (int)(100 / 3); i++)
            {
                for (int j = 0; j <= 100; j++)
                {
                    for (int k = 0; k <= 100; k = k + 3)//The number of chickens won't overnumber 100.
                    {
                        if ((i + j + k == 100) && ((i * 3 + j * 1 + k / 3) == 100))
                        {
                            Console.WriteLine(string.Format("{0}: Hen:{1} Cock:{2} Chickens:{3}", ++slnCount, i, j, k));
                        }
                    }
                }
            }
            Console.WriteLine(string.Format("Solution Count:{0}", slnCount));
        }

        public AlgorithmOne(int two)
        {
            int count = 1;
            for (int nm = 0; nm <= 100 / 3; nm++)
                for (int ng = 0; ng <= 100; ng++)
                    for (int nz = 0; nz <= 100; nz++)
                    {
                        if ((100 == 3 * nm + ng + nz / 3) && (100 == nm + ng + nz))
                        {
                            Console.WriteLine("方案{0}：鸡公{1}只，鸡母{2}只，鸡仔{3}只", count, ng, nm, nz);
                            count++;
                        }
                    }
            Console.ReadLine();
        }
    }

}
