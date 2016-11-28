using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //凡是返回IEnumerable<T>接口都可以使用foreach();
            //1.
            new MyIteratorCode().Call();
            //2.
            foreach (var item in MyIterator())
            {
                Console.WriteLine(item);
            }

            //一个实际场景；
            //。。。
            Console.ReadLine();
        }

        static IEnumerable<int> MyIterator()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

        class MyIteratorCode
        {
            public void Call()
            {
                foreach (var item in MyIterator())
                {
                    Console.WriteLine(item);
                }
            }

            IEnumerable<int> MyIterator()
            {
                yield return 1;
                yield return 2;
                yield return 3;
            }
        }

    }
}
