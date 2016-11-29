using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代器_yield以及流的延迟计算
{
    /// <summary>
    /// 从0遍历到20(不包括20)，输出遍历到的每个元素，并将大于2的所有数字放到一个IEnumerable<int>中返回
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //FirstCallMethod();
            SecondCallMethod();
            Console.ReadLine();
        }

        static void FirstCallMethod()
        {
            WithNoYield();
            WithYield();
        }

        static void SecondCallMethod()
        {
            //WithNoYield()只被调用一次,一次返回全部枚举对象
            foreach (int i in WithNoYield())
            {
                Console.WriteLine(i.ToString());
            }

            //WithYield()被调用多次，每次返回一个枚举对象
            foreach (int i in WithYield())
            {
                Console.WriteLine(i.ToString());
            }
        }


        /// <summary>
        /// C# 1.0
        /// </summary>
        /// <returns></returns>
        static IEnumerable<int> WithNoYield()
        {
            IList<int> list = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                if (i > 2)
                    list.Add(i);
            }
            return list;
        }

        /// <summary>
        /// C# 2.0
        /// </summary>
        /// <returns></returns>
        static IEnumerable<int> WithYield()
        {
            for (int i = 0; i < 20; i++)
            {
                if (i > 2)
                    yield return i;
            }
        }
    }
}
