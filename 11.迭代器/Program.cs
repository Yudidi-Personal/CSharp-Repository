using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.迭代器
{
    /// <summary>
    /// Iterator就是一个方法,需要满足2个条件
    /// 1. 返回类型是IEnumerable
    /// 2. 必须用yield修饰return语句
    /// </summary>
    public class PowersOf2
    {
        static void Main()
        {
            // Display powers of 2 up to the exponent of 8:
            foreach (int i in Power(2, 8))
            {
                Console.Write("{0} ", i);
            }
        }

        public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }

        // Output: 2 4 8 16 32 64 128 256
    }

}
